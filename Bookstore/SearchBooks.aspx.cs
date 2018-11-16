using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections.Specialized;
using System.Data.SqlClient;
using System.Configuration;

namespace Bookstore
{
    public partial class WebForm2 : System.Web.UI.Page
    {
       
        protected void Page_Load(object sender, EventArgs e)
        {
           NameValueCollection queryString = Request.QueryString;
           lblCategory.Text = queryString["category"];
        }

        protected void btnAllBooks_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string showBook = Server.UrlEncode(button.Text);
            Response.Redirect("~/ShowBooks.aspx?category=" + lblCategory.Text+"&showBook="+showBook);

        }

        protected void btnShow_Click(object sender, EventArgs e)
        {
            if (ddlbname.SelectedValue == "-1" && ddlaname.SelectedValue =="-1" && ddlrating.SelectedValue=="-1")
            {
                lblvalBname.Visible = true;
                lblvalidateAname.Visible = true;
                lblvalidateRating.Visible = true;
            }
            else if(ddlbname.SelectedValue == "-1" && ddlaname.SelectedValue != "-1" && ddlrating.SelectedValue == "-1")
            {
                Button button = (Button)sender;
                string showBook = Server.UrlEncode(button.Text);
                Response.Redirect("~/ShowBooks.aspx?category=" + lblCategory.Text + "&showBook=" + showBook+"&aname="+ddlaname.SelectedItem.Text+"&bookname=null&rating=null");
            }
            else if(ddlbname.SelectedValue == "-1" && ddlaname.SelectedValue != "-1" && ddlrating.SelectedValue != "-1")
            {
                Button button = (Button)sender;
                string showBook = Server.UrlEncode(button.Text);
                Response.Redirect("~/ShowBooks.aspx?category=" + lblCategory.Text + "&showBook=" + showBook + "&aname=" + ddlaname.SelectedItem.Text + "&bookname=null&rating=" + ddlrating.SelectedItem.Text);
            }
            else if(ddlbname.SelectedValue == "-1" && ddlaname.SelectedValue == "-1" && ddlrating.SelectedValue != "-1")
            {
                Button button = (Button)sender;
                string showBook = Server.UrlEncode(button.Text);
                Response.Redirect("~/ShowBooks.aspx?category=" + lblCategory.Text + "&showBook=" + showBook + "&aname=null&bookname=null&rating="+ddlrating.SelectedItem.Text);
            }
            else if(ddlbname.SelectedValue != "-1" && ddlaname.SelectedValue == "-1" && ddlrating.SelectedValue == "-1")
            {
                Button button = (Button)sender;
                string showBook = Server.UrlEncode(button.Text);
                Response.Redirect("~/ShowBooks.aspx?category=" + lblCategory.Text + "&showBook=" + showBook + "&aname=null&rating=null&bookname=" + ddlbname.SelectedItem.Text);
            }
            else if(ddlbname.SelectedValue != "-1" && ddlaname.SelectedValue == "-1" && ddlrating.SelectedValue != "-1")
            {
                Button button = (Button)sender;
                string showBook = Server.UrlEncode(button.Text);
                Response.Redirect("~/ShowBooks.aspx?category=" + lblCategory.Text + "&showBook=" + showBook + "&aname=null&bookname=" + ddlbname.SelectedItem.Text+"&rating="+ddlrating.SelectedItem.Text);
            }
            else if(ddlbname.SelectedValue != "-1" && ddlaname.SelectedValue != "-1" && ddlrating.SelectedValue != "-1")
            {
                Button button = (Button)sender;
                string showBook = Server.UrlEncode(button.Text);
                Response.Redirect("~/ShowBooks.aspx?category=" + lblCategory.Text + "&showBook=" + showBook + "&aname="+ddlaname.SelectedItem.Text+"&bookname=" + ddlbname.SelectedItem.Text + "&rating=" + ddlrating.SelectedItem.Text);
            }
            else
            {
                Button button = (Button)sender;
                string showBook = Server.UrlEncode(button.Text);
                Response.Redirect("~/ShowBooks.aspx?category=" + lblCategory.Text + "&showBook=" + showBook + "&aname="+ddlaname.SelectedItem.Text+"&bookname=" + ddlbname.SelectedItem.Text + "&rating=null");
            }
            
        }
    }
}