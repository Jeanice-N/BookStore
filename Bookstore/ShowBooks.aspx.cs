using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections.Specialized;

namespace Bookstore
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        string cs = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        string query;


        SqlDataAdapter adapter;
        DataSet ds;
        SqlCommandBuilder cmdBuilder;

        protected void Page_Load(object sender, EventArgs e)
        {
            NameValueCollection cate = Request.QueryString;
            lblCategory.Text = cate["category"];
            NameValueCollection buttonText = Request.QueryString;
            lblButtonText.Text = buttonText["showBook"];

            NameValueCollection bookName = Request.QueryString;
            string userinputBookName = bookName["bookname"];
            NameValueCollection Brating = Request.QueryString;
            string userinputRating = Brating["rating"];
            NameValueCollection author = Request.QueryString;
            string userinputAuthorName = author["aname"];

            if (lblButtonText.Text == "Show")
            {
                if (userinputBookName != "null" && userinputAuthorName != "null" && userinputRating != "null")
                {
                    query = "Select bname, bimage,bdesc,category,bauthor,price,brating From Book WHERE category='" + lblCategory.Text + "' AND bname='" + userinputBookName + "' AND bauthor='" + userinputAuthorName + "' AND brating=" + Convert.ToInt32(userinputRating) + ";";
                    ConnectionToSql(query);

                }
                else if (userinputBookName == "null" && userinputAuthorName != "null" && userinputRating == "null")
                {
                    query = "Select bname, bimage,bdesc,category,bauthor,price,brating From Book WHERE category='" + lblCategory.Text + "' AND bauthor='" + userinputAuthorName + "';";
                    ConnectionToSql(query);
                }
                else if (userinputBookName == "null" && userinputAuthorName != "null" && userinputRating != "null")
                {
                    query = "Select bname, bimage,bdesc,category,bauthor,price,brating From Book WHERE category='" + lblCategory.Text + "' AND bauthor='" + userinputAuthorName + "' AND brating=" + Convert.ToInt32(userinputRating) + ";";
                    ConnectionToSql(query);
                }
                else if (userinputBookName == "null" && userinputAuthorName == "null" && userinputRating != "null")
                {
                    query = "Select bname, bimage,bdesc,category,bauthor,price,brating From Book WHERE category='" + lblCategory.Text + "' AND brating=" + Convert.ToInt32(userinputRating) + ";";
                    ConnectionToSql(query);
                }
                else if (userinputBookName != "null" && userinputAuthorName == "null" && userinputRating == "null")
                {
                    query = "Select bname, bimage,bdesc,category,bauthor,price,brating From Book WHERE category='" + lblCategory.Text + "' AND bname='" + userinputBookName + "';";
                    ConnectionToSql(query);
                }
                else if (userinputBookName != "null" && userinputAuthorName == "null" && userinputRating != "null")
                {
                    query = "Select bname, bimage,bdesc,category,bauthor,price,brating From Book WHERE category='" + lblCategory.Text + "' AND bname='" + userinputBookName + "' AND brating=" + Convert.ToInt32(userinputRating) + ";";
                    ConnectionToSql(query);
                }
                else
                {
                    query = "Select bname, bimage,bdesc,category,bauthor,price,brating From Book WHERE category='" + lblCategory.Text + "' AND bname='" + userinputBookName + "' AND bauthor='" + userinputAuthorName + "';";
                    ConnectionToSql(query);
                }
            }
            else
            {
                query = "Select bname, bimage,bdesc,category,bauthor,price,brating From Book WHERE category='" + lblCategory.Text + "';";
                ConnectionToSql(query);
            }
        }

        protected void ConnectionToSql(string query)
        {
            using (SqlConnection conn = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                allBooksGridView.DataSource = reader;
                allBooksGridView.DataMember = "bimage";
                allBooksGridView.DataMember = "bdesc";
                allBooksGridView.DataMember = "category";
                allBooksGridView.DataMember = "bauthor";
                allBooksGridView.DataMember = "price";
                allBooksGridView.DataMember = "brating";
                allBooksGridView.DataBind();

            }
        }

        protected void allBooksGridView_DataBound(object sender, EventArgs e)
        {

           
            foreach (GridViewRow row in allBooksGridView.Rows)
            {
                double rating = Convert.ToDouble(row.Cells[9].Text);
                row.Cells[9].Text = rating.ToString("N1"); ;
            }

        }


        protected void allBooksGridView_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            //Determine the RowIndex of the Row whose Button was clicked.
            int rowIndex = Convert.ToInt32(e.CommandArgument);

            //Reference the GridView Row.
            GridViewRow row = allBooksGridView.Rows[rowIndex];

            DropDownList dropdown = (DropDownList)row.Cells[2].FindControl("ddlQuantity");
            int quantity = Convert.ToInt16(dropdown.SelectedValue);
            Response.Write(quantity);


            //Fetch value of book name
            string bookName = allBooksGridView.Rows[rowIndex].Cells[3].Text;

            //fetch value of book price
            double bookPrice = Convert.ToDouble(allBooksGridView.Rows[rowIndex].Cells[8].Text);

            string query = "INSERT INTO Cart (bname, price, qty) VALUES ('" + bookName + "', '" + bookPrice + "', " + quantity + ");";

            using (SqlConnection conn = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                
                conn.Open();
                cmd.ExecuteNonQuery();
                

            }

            lblMessage.Text = "Book added to cart successfully";
            lblMessage.ForeColor = System.Drawing.Color.Green;
        }


        protected void dropdown_indexChanged(object sender, EventArgs e)
        {

            DropDownList dropdown = (DropDownList)sender;
            int quantity = Convert.ToInt16(dropdown.SelectedIndex);
            //Response.Write(quantity);


        }
    }
}