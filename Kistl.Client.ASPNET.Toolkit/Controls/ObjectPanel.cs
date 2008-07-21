using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using Kistl.Client.ASPNET.Toolkit;
using Kistl.GUI;
using Kistl.API;

namespace Kistl.Client.ASPNET.Toolkit.Controls
{
    public abstract class ObjectPanelControl : System.Web.UI.UserControl, IContainerLoader, IObjectControl
    {
        public abstract HtmlGenericControl divChildrenControl { get; }
        public abstract IButtonControl btnSaveControl { get; }

        public ObjectPanelControl()
        {
            this.Init += new EventHandler(ObjectPanelControl_Init);
        }

        void ObjectPanelControl_Init(object sender, EventArgs e)
        {
            btnSaveControl.Click += new EventHandler(btnSave_Click);
        }

        void btnSave_Click(object sender, EventArgs e)
        {
            if (UserSaveRequest != null)
            {
                UserSaveRequest(this, EventArgs.Empty);
            }
        }

        public void AddChild(IControlLoader child)
        {
            divChildrenControl.Controls.Add((Control)child);
        }

        #region IBasicControl Members
        IKistlContext IBasicControl.Context { get; set; }

        public string ShortLabel
        {
            get;
            set;
        }

        public string Description
        {
            get;
            set;
        }

        public FieldSize Size
        {
            get;
            set;
        }

        #endregion

        #region IObjectControl Members

        public Kistl.API.IDataObject Value
        {
            get;
            set;
        }

        public event EventHandler UserInput;
        public event EventHandler UserSaveRequest;
        public event EventHandler UserDeleteRequest;

        #endregion
    }
}
