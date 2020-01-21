using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _3_ugers.Admin
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie cuid = Request.Cookies["WCOMPA"];
            if (cuid == null)
            {
                Response.Redirect("Admin/Error.aspx");

            }

        }
    }
}