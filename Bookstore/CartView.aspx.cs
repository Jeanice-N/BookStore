using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bookstore
{
    public partial class WebForm6 : System.Web.UI.Page
    {
        string cs = Data.GetConnectionString();
        string query = "select sum(price) from Cart;";
        double subTotal = 0;
        double tax = 0;
        double total = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            updateTotals();
            
        }

        protected void GridView1_RowDeleted(object sender, EventArgs e)
        {
            updateTotals();
            
        }

        protected void updateTotals()
        {
            
            using (SqlConnection conn = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();

                object obj = cmd.ExecuteScalar();
                if(obj != null && DBNull.Value != obj)
                {
                    subTotal = Convert.ToDouble(obj);
                } else
                {
                    subTotal = 0;
                }
                               
                lblSubtotal.Text = "$" + subTotal.ToString("N2");

                tax = subTotal * 0.13;
                lblTax.Text = "$" + tax.ToString("N2");

                total = subTotal + tax;
                lblTotal.Text = "$" + total.ToString("N2");


            }
        }
    }
}