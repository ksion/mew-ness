using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MobileEnabledWebFormsApp {
    public partial class ProfileSnapShot : System.Web.UI.UserControl {
        protected void Page_Load(object sender, EventArgs e) {
            Page.Header.Controls.Add(new LiteralControl("<link rel=\"stylesheet\" type=\"text/css\" href=\"" + ResolveUrl("~/Styles/Snapshot.css") + "\" />"));
        }
    }
}