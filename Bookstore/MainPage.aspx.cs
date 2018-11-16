using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bookstore
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        public string category { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGeneral_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string category = Server.UrlEncode(btn.Text);
            Response.Redirect("~/SearchBooks.aspx?category=" + category);

        }

        protected void btnFiction_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string category = Server.UrlEncode(btn.Text);
            Response.Redirect("~/SearchBooks.aspx?category=" + category);
        }

        protected void btnDrama_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string category = Server.UrlEncode(btn.Text);
            Response.Redirect("~/SearchBooks.aspx?category=" + category);
        }

        protected void btnMystery_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string category = Server.UrlEncode(btn.Text);
            Response.Redirect("~/SearchBooks.aspx?category=" + category);
        }

        protected void btnHorror_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string category = Server.UrlEncode(btn.Text);
            Response.Redirect("~/SearchBooks.aspx?category=" + category);
        }

        protected void btnAction_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string category = Server.UrlEncode(btn.Text);
            Response.Redirect("~/SearchBooks.aspx?category=" + category);
        }

        protected void btnAcademic_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string category = Server.UrlEncode(btn.Text);
            Response.Redirect("~/SearchBooks.aspx?category=" + category);
        }
    }
}