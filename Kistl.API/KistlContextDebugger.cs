using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kistl.API
{

    public static class KistlContextDebugger
    {
        private readonly static object _lock = new object();

        private static IKistlContextDebugger _Current;

        public static void SetDebugger(IKistlContextDebugger debugger)
        {
            lock (_lock)
            {
                if (_Current != null)
                {
                    _Current.Dispose();
                }
                _Current = debugger;
            }
        }

        // TODO: Replace by central ServiceDiscoveryService
        public static IKistlContextDebugger GetDebugger()
        {
            return _Current;
        }

        public static void Created(IKistlContext ctx)
        {
            lock (_lock)
            {
                if (_Current != null)
                {
                    _Current.Created(ctx);
                }
            }
        }

        public static void Disposed(IKistlContext ctx)
        {
            lock (_lock)
            {
                if (_Current != null)
                {
                    _Current.Disposed(ctx);
                }
            }
        }

        public static void Changed(IKistlContext ctx)
        {
            lock (_lock)
            {
                if (_Current != null)
                {
                    _Current.Changed(ctx);
                }
            }
        }
    }

}
