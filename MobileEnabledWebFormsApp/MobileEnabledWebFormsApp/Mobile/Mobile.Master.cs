using System;
using System.Web.UI.WebControls;
using System.Web.UI;
namespace MobileEnabledWebFormsApp.Mobile
{
    public partial class MobileMaster : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.ClientScript.RegisterClientScriptInclude("Jquery", ResolveUrl("Scripts/jquery-1.9.0.js"));
            Page.ClientScript.RegisterClientScriptInclude("Master", ResolveUrl("Scripts/Master.js"));
        }
    }
}
