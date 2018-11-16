using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections;
using System.Collections.Specialized;

namespace Bookstore
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        string cs = Data.GetConnectionString();
        protected void Page_Load(object sender, EventArgs e)
        {
            

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {

            if(ddlRating.SelectedIndex > 0)
            {
                int totalRatings = 0;
                int totalStars = 0;
                double newRating = 0;

                string bookName = Request.QueryString["bname"];
                

                string totalRatingsQuery = "Select totalRatings from Book where bname='" + bookName + "';"; //retrieves total ratings from db
                string totalStarsQuery = "Select totalStars from Book where bname='" + bookName + "';"; //retrieves total starts from db
                                

                using (SqlConnection conn = new SqlConnection(cs))
                {
                    SqlCommand ratingCmd = new SqlCommand(totalRatingsQuery, conn);
                    conn.Open();
                    totalRatings = Convert.ToInt32(ratingCmd.ExecuteScalar());  //assigns book rating to variable
                    totalRatings += 1;

                    SqlCommand starsCmd = new SqlCommand(totalStarsQuery, conn);
                    totalStars = Convert.ToInt32(starsCmd.ExecuteScalar());
                    totalStars += Convert.ToInt32(ddlRating.SelectedValue);
                    
                    newRating = totalStars / Convert.ToDouble(totalRatings);

                    string updateRating = "UPDATE Book SET totalRatings =" + totalRatings + ", totalStars = " + totalStars + ", brating = " + newRating + "WHERE bname = '" + bookName + "';";

                    SqlCommand updateCmd = new SqlCommand(updateRating, conn);
                    updateCmd.ExecuteNonQuery();

                    
                }

                lblMessage.Text = "Rating submitted successfully";
                lblMessage.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                lblMessage.Text = "Please choose a rating";
                lblMessage.ForeColor = System.Drawing.Color.Red;
            }
            

        }
    }
}