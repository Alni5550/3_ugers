using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _3_ugers.Admin
{
    public partial class Error : System.Web.UI.Page
    {
        protected void button1_click(object sender, EventArgs e)
        {
            HttpCookie cuid = Request.Cookies["WCOMPA"];
            cuid.Expires = DateTime.Now.AddHours(-1);
            Response.Cookies.Add(cuid);

        }
    }
}