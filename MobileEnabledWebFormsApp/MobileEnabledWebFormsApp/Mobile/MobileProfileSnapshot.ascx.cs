using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MobileEnabledWebFormsApp.Mobile {
    public partial class MobileProfileSnapshot : System.Web.UI.UserControl {
        protected void Page_Load(object sender, EventArgs e) {
            Page.ClientScript.RegisterClientScriptInclude("MobileSnapshot", "Scripts/MobileSnapshot.js");
        }
    }
}