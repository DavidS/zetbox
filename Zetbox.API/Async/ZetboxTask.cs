﻿// This file is part of zetbox.
//
// Zetbox is free software: you can redistribute it and/or modify
// it under the terms of the GNU Lesser General Public License as
// published by the Free Software Foundation, either version 3 of
// the License, or (at your option) any later version.
//
// Zetbox is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU Lesser General Public
// License along with zetbox.  If not, see <http://www.gnu.org/licenses/>.

namespace Zetbox.API.Async
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using System.Text;
    using System.Threading;

    public enum ZbTaskState
    {
        /// <summary>
        /// In this state, the task is currently waiting for something (usually another task, or its own initialisation) before starting to run.
        /// </summary>
        Waiting = 0,
        /// <summary>
        /// In this state, the task is currently executing somewhere.
        /// </summary>
        Running,
        /// <summary>
        /// The core task is finished, but some async continuations are still running.
        /// </summary>
        AsyncContinuationsRunning,
        /// <summary>
        /// The core task and continuations are finished, and the result processing was triggered, but has not started yet.
        /// </summary>
        ResultEventsPosted,
        /// <summary>
        /// The core task and continuations are finished, but the result processing still running.
        /// </summary>
        ResultEventRunning,
        /// <summary>
        /// The task has completely finished running and processing results.
        /// </summary>
        Finished,
        /// <summary>
        /// The task has encountered an exception and did not run to completion.
        /// </summary>
        Failed,
        /// <summary>
        /// The task was canceled by a user.
        /// </summary>
        Canceled,
    }

    public class ZbTask
    {
        public static readonly SynchronizationContext Synchron = null;
        public static readonly IEnumerable<ZbTask> NoInnerTasks = null;

        private static bool _debugForceSynchron = false;
        public static bool DebugForceSynchron
        {
            get { return _debugForceSynchron; }
            set { _debugForceSynchron = value; }
        }

        private readonly object _lockObject = new object();
        protected object SyncRoot { get { return _lockObject; } }

        protected readonly List<Action> asyncContinuationActions = new List<Action>();
        protected readonly List<Action> resultActions = new List<Action>();
        protected readonly List<Action<Exception>> errorActions = new List<Action<Exception>>();
        protected readonly List<ZbTask> innerZbTasks;
        protected int numRunningTasks;

        public ZbTaskState State
        {
            get;
            protected set;
        }

        public Exception Exception
        {
            get;
            protected set;
        }

        protected void Fail(Exception ex)
        {
            lock (_lockObject) if (State == ZbTaskState.Canceled) return;

            Exception = ex;
            lock (_lockObject) State = ZbTaskState.Failed;
        }

        protected void RunErrorHandlers()
        {
            foreach (var a in errorActions)
            {
                a(Exception);
            }

            // Error handler should be executed only once
            errorActions.Clear();
        }

        protected void ThrowException()
        {
            RunErrorHandlers();
            throw new TargetInvocationException("An exception occurred while executing a task or one of it's continuation actions: " + Exception.Message, Exception);
        }

        private readonly SynchronizationContext _syncContext;
        public SynchronizationContext SyncContext
        {
            get { return _syncContext; }
        }

        public object GetAwaiter()
        {
            throw new NotImplementedException("Will be implemented when switching to .net 4.5; or replaced by using await directly");
        }

        /// <summary>
        /// This constructor only initializes the internal state of the ZbTask, without starting any execution.
        /// </summary>
        protected ZbTask(SynchronizationContext syncContext, IEnumerable<ZbTask> innerTasks)
        {
            if (innerTasks == null)
                innerTasks = Enumerable.Empty<ZbTask>();

            this.innerZbTasks = innerTasks
                .Where(t => t != null)
                .ToList();

            if (this.innerZbTasks.Count > 0
                && this.innerZbTasks.Any(t => t.SyncContext != this.innerZbTasks[0].SyncContext)) throw new ArgumentOutOfRangeException("innerTasks", "Not all inner Tasks have the same SynchronizationContext");

            if (syncContext != null
                && this.innerZbTasks.Any(t => t.SyncContext != syncContext)) throw new ArgumentOutOfRangeException("syncContext", "SynchronizationContext differs between this and inner Tasks");

            this._syncContext = syncContext ?? (this.innerZbTasks.Count() > 0 ? this.innerZbTasks[0]._syncContext : null);
            this.numRunningTasks = this.innerZbTasks.Count;
        }

        protected void ExecuteOrChainTask(Action task)
        {
            if (innerZbTasks.Count > 0)
            {
                if (task == null)
                {
                    // attach to innerZbTask directly
                    innerZbTasks.ForEach(innerTask =>
                        innerTask
                        .OnError(ex =>
                        {
                            Fail(ex);
                            RunErrorHandlers();
                        })
                        .ContinueWith(t =>
                        {
                            if (Interlocked.Decrement(ref numRunningTasks) == 0)
                            {
                                // Set State to Running for completeness' sake
                                lock (_lockObject) State = ZbTaskState.Running;
                                // but since this task has nothing to do, execute continuations immediately
                                CallAsyncContinuations();
                                lock (_lockObject) State = ZbTaskState.ResultEventsPosted;
                            }
                        })
                        .OnResult(t =>
                        {
                            if (Interlocked.CompareExchange(ref numRunningTasks, 0, 0) == 0)
                            {
                                CallResultActions();
                            }
                        }));
                }
                else
                {
                    // has to be deferred until the innerZbTask has run
                    innerZbTasks.ForEach(innerTask =>
                        innerTask
                        .OnError(ex =>
                        {
                            Fail(ex);
                            RunErrorHandlers();
                        })
                        .OnResult(t =>
                        {
                            if (Interlocked.Decrement(ref numRunningTasks) == 0)
                            {
                                ExecuteTask(task);
                            }
                        }));
                }
            }
            else
            {
                ExecuteTask(task);
            }
        }

        private void ExecuteTask(Action task)
        {
            lock (_lockObject) State = ZbTaskState.Running;
            Void work = () =>
            {
                try
                {
                    if (task != null)
                        task();
                    CallAsyncContinuations();
                }
                catch (Exception ex)
                {
                    // Stop processing
                    Fail(ex);
                }
            };
            if (_syncContext != null && !_debugForceSynchron)
            {
                ThreadPool.QueueUserWorkItem(tpState =>
                {
                    work();
                    lock (_lockObject)
                    {
                        if (State != ZbTaskState.Failed && State != ZbTaskState.Canceled) State = ZbTaskState.ResultEventsPosted;
                        if (IsWaiting > 0)
                        {
                            Monitor.PulseAll(_lockObject);
                        }
                        else
                        {
                            _syncContext.Post(scState => CallResultActions(), null);
                        }
                    }
                });
            }
            else
            {
                work();
                lock (_lockObject)
                {
                    if (State != ZbTaskState.Failed && State != ZbTaskState.Canceled) State = ZbTaskState.ResultEventsPosted;
                    if (IsWaiting > 0)
                    {
                        Monitor.PulseAll(_lockObject);
                    }
                    else
                    {
                        CallResultActions();
                    }
                }
            }
        }

        public ZbTask(Action task)
            : this(SynchronizationContext.Current, NoInnerTasks)
        {
            ExecuteOrChainTask(task);
        }

        public ZbTask(ZbTask innerTask)
            : this(innerTask != null ? innerTask._syncContext : Synchron, new[] { innerTask })
        {
            ExecuteOrChainTask(null);
        }

        public ZbTask(IEnumerable<ZbTask> innerTasks)
            : this(innerTasks != null && innerTasks.Count() > 0 ? innerTasks.First()._syncContext : Synchron, innerTasks)
        {
            ExecuteOrChainTask(null);
        }

        public ZbTask(ZbTask innerTask, Action task)
            : this(innerTask != null ? innerTask._syncContext : Synchron, new[] { innerTask })
        {
            ExecuteOrChainTask(task);
        }

        public ZbTask(IEnumerable<ZbTask> innerTasks, Action task)
            : this(innerTasks != null && innerTasks.Count() > 0 ? innerTasks.First()._syncContext : Synchron, innerTasks)
        {
            ExecuteOrChainTask(task);
        }

        public ZbTask(SynchronizationContext syncContext, Action task)
            : this(syncContext, NoInnerTasks)
        {
            ExecuteOrChainTask(task);
        }

        delegate void Void();

        /// <summary>
        /// Number of threads waiting for the results
        /// </summary>
        public int IsWaiting
        {
            get;
            private set;
        }

        public ZbTask ContinueWith(Action<ZbTask> continuationAction)
        {
            if (continuationAction == null) throw new ArgumentNullException("continuationAction");

            lock (_lockObject)
            {
                switch (State)
                {
                    case ZbTaskState.Waiting:
                    case ZbTaskState.Running:
                        asyncContinuationActions.Add(() => continuationAction(this));
                        break;
                    case ZbTaskState.AsyncContinuationsRunning:
                    case ZbTaskState.ResultEventsPosted:
                    case ZbTaskState.ResultEventRunning:
                    case ZbTaskState.Finished:
                        continuationAction(this);
                        break;
                    case ZbTaskState.Failed:
                        RunErrorHandlers();
                        break;
                    case ZbTaskState.Canceled:
                        break;
                }
            }
            return this;
        }

        public ZbTask OnResult(Action<ZbTask> continuationAction)
        {
            if (continuationAction == null) throw new ArgumentNullException("continuationAction");

            lock (_lockObject)
            {
                switch (State)
                {
                    case ZbTaskState.Waiting:
                    case ZbTaskState.Running:
                    case ZbTaskState.AsyncContinuationsRunning:
                    case ZbTaskState.ResultEventsPosted:
                        resultActions.Add(() => continuationAction(this));
                        break;
                    case ZbTaskState.ResultEventRunning:
                    case ZbTaskState.Finished:
                        continuationAction(this);
                        break;
                    case ZbTaskState.Failed:
                        RunErrorHandlers();
                        break;
                    case ZbTaskState.Canceled:
                        break;
                }
            }
            return this;
        }

        public ZbTask OnError(Action<Exception> errorAction)
        {
            if (errorAction == null) throw new ArgumentNullException("errorAction");

            lock (_lockObject)
            {
                switch (State)
                {
                    case ZbTaskState.Waiting:
                    case ZbTaskState.Running:
                    case ZbTaskState.AsyncContinuationsRunning:
                    case ZbTaskState.ResultEventsPosted:
                    case ZbTaskState.ResultEventRunning:
                    case ZbTaskState.Finished:
                        errorActions.Add(errorAction);
                        break;
                    case ZbTaskState.Failed:
                        errorActions.Add(errorAction);
                        RunErrorHandlers();
                        break;
                    case ZbTaskState.Canceled:
                        break;
                }
            }
            return this;
        }

        /// <summary>
        /// Waits on the finishing of the task or throws an exception on failure.
        /// </summary>
        public void Wait()
        {
            try
            {
                if (innerZbTasks.Count > 0) innerZbTasks.ForEach(it => it.Wait());
            }
            catch (Exception ex)
            {
                Fail(ex);
            }

            CallResultActions();

            lock (_lockObject) if (State == ZbTaskState.Failed) ThrowException();
        }

        /// <summary>
        /// Force State to Canceled, even when the Task failed, we want to ignore it.
        /// </summary>
        public void Cancel()
        {
            // finished Tasks cannot be canceled
            lock (_lockObject) if (State == ZbTaskState.Finished) return;

            // TODO: implement proper cancel support
            try
            {
                foreach (var innerTask in innerZbTasks)
                {
                    innerTask.Cancel();
                }
            }
            catch
            {
                // ignore
            }
            finally
            {
                lock (_lockObject) State = ZbTaskState.Canceled;
            }
        }

        protected void CallAsyncContinuations()
        {
            lock (_lockObject)
            {
                if (State == ZbTaskState.Canceled) return;

                State = ZbTaskState.AsyncContinuationsRunning;
            }
            foreach (var action in asyncContinuationActions)
            {
                action();
            }
        }

        protected void CallResultActions()
        {
            lock (_lockObject)
            {
            RECHECK:
                switch (State)
                {
                    case ZbTaskState.Waiting:
                    case ZbTaskState.Running:
                    case ZbTaskState.AsyncContinuationsRunning:
                        IsWaiting += 1;
                        Monitor.Wait(_lockObject);
                        IsWaiting -= 1;
                        // something happened: we have to decide whether we are the
                        // "lucky" thread to continue execution or whether someone else
                        // already did the work for us
                        goto RECHECK;
                    case ZbTaskState.ResultEventsPosted:
                        State = ZbTaskState.ResultEventRunning;
                        break;
                    case ZbTaskState.ResultEventRunning:
                    case ZbTaskState.Finished:
                        return;
                    case ZbTaskState.Failed:
                        RunErrorHandlers();
                        return;
                    case ZbTaskState.Canceled:
                        return;
                }
            }

            try
            {
                foreach (var action in resultActions)
                {
                    action();
                }
                lock (_lockObject) State = ZbTaskState.Finished;
            }
            catch (Exception ex)
            {
                // Stop processing
                Fail(ex);
            }
        }
    }

    public class ZbTask<TResult> : ZbTask
    {
        protected void ExecuteOrChainTask(Func<TResult> task)
        {
            ExecuteOrChainTask(() =>
            {
                if (task != null)
                    this._result = task();
            });
        }

        /// <summary>
        /// This constructor only initializes the internal state of the ZbTask, without starting any execution.
        /// </summary>
        protected ZbTask(SynchronizationContext syncContext, IEnumerable<ZbTask> innerTasks)
            : base(syncContext, innerTasks)
        {
        }

        public ZbTask(Func<TResult> task)
            : base(SynchronizationContext.Current, NoInnerTasks)
        {
            ExecuteOrChainTask(task);
        }

        public ZbTask(ZbTask innerTask)
            : base(innerTask)
        {
            // ExecuteOrChainTask is called by base constructor
        }

        public ZbTask(IEnumerable<ZbTask> innerTasks)
            : base(innerTasks)
        {
            // ExecuteOrChainTask is called by base constructor
        }

        public ZbTask(ZbTask innerTask, Func<TResult> task)
            : base(innerTask != null ? innerTask.SyncContext : Synchron, new[] { innerTask })
        {
            ExecuteOrChainTask(task);
        }

        public ZbTask(IEnumerable<ZbTask> innerTasks, Func<TResult> task)
            : this(innerTasks != null && innerTasks.Count() > 0 ? innerTasks.First().SyncContext : Synchron, innerTasks)
        {
            ExecuteOrChainTask(task);
        }

        public ZbTask(SynchronizationContext syncContext, Func<TResult> task)
            : base(syncContext, NoInnerTasks)
        {
            ExecuteOrChainTask(task);
        }

        public ZbTask(TResult result)
            : base(ZbTask.Synchron, NoInnerTasks)
        {
            _result = result;
            State = ZbTaskState.Finished;
        }

        public ZbTask<TResult> ContinueWith(Action<ZbTask<TResult>> continuationAction)
        {
            if (continuationAction == null) throw new ArgumentNullException("continuationAction");

            ContinueWith((ZbTask _) => continuationAction(this));
            return this;
        }

        public ZbTask<TResult> OnResult(Action<ZbTask<TResult>> continuationAction)
        {
            if (continuationAction == null) throw new ArgumentNullException("continuationAction");

            OnResult((ZbTask _) => continuationAction(this));
            return this;
        }

        private TResult _result;
        public TResult Result
        {
            get
            {
                Wait(); // will throw on failure
                lock (SyncRoot) if (State == ZbTaskState.Canceled) throw new InvalidOperationException("Task is already canceled.");
                return _result;
            }
            set
            {
                _result = value;
            }
        }
    }

    /// <summary>
    /// This class executes after a Task that can be only created in the future. Then it proceeds as normal.
    /// </summary>
    /// <typeparam name="TIntermediate">The result type of the future task</typeparam>
    /// <typeparam name="TResult">The final result type</typeparam>
    public sealed class ZbFutureTask<TIntermediate, TResult> : ZbTask<TResult>
    {
        /// <summary>
        /// Initialize the future task.
        /// </summary>
        /// <param name="innerTaskFactory">The task which will create the task we'll be acting on.</param>
        /// <param name="task">the transformation we have to do.</param>
        public ZbFutureTask(ZbTask<ZbTask<TIntermediate>> innerTaskFactory, Func<TIntermediate, TResult> task = null)
            : base(innerTaskFactory != null ? innerTaskFactory.SyncContext : Synchron, new[] { innerTaskFactory })
        {
            if (innerTaskFactory == null) throw new ArgumentNullException("innerTaskFactory");

            innerTaskFactory
                .OnResult(
                    (ZbTask<ZbTask<TIntermediate>> factory) =>
                    {
                        var intermediateTask = factory.Result;
                        intermediateTask.OnResult(
                        t =>
                        {
                            ExecuteOrChainTask(() =>
                                {
                                    if (task != null)
                                        this.Result = task(t.Result);
                                });
                        });
                        intermediateTask.Wait();
                    });
        }
    }
}
