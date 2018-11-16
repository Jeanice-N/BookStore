using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bookstore
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/AboutUs.aspx");
        }

        protected void btnAbout_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/MainPage.aspx");
        }
    }
}