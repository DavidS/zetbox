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
using Kistl.GUI;
using Kistl.API;

public partial class Controls_DoublePropertyControl : Kistl.Client.ASPNET.Toolkit.Controls.DoublePropertyControl
{
    protected override TextBox txtDoubleControl
    {
        get { return txtDouble; }
    }
}
