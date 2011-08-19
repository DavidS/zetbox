using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kistl.Client.Presentables
{
    public interface IContextViewModel
    {
        ICommandViewModel AbortCommand { get; }
        ICommandViewModel DeleteCommand { get; }
        ICommandViewModel SaveCommand { get; }
        ICommandViewModel VerifyCommand { get; }

        bool CanSave();
        void Save();
        void Abort();
        void Verify();
        void Delete(IEnumerable<DataObjectViewModel> items);

        bool IsContextModified { get; }
    }
}
