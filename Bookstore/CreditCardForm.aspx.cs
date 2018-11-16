using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bookstore
{
    public partial class WebForm8 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /*
             * NOTES:
             * Retrieve the stored cId from CustomerForm.aspx through querystring/sessionid
             * When final submit buttton is clicked:
             *          1. Insert ALL data in Cart table into SalesInvoice table
             *          2. Cart table only has bname, price & qty as fields so you need to grab cId (retrieved earlier) and insert it into 
             *             the SalesInvoice table along with the idate
             *          3. CLEAR ALL data from Cart table
             *          4. Response.redirect to ConfirmationPage.aspx with the cId stored in querystring/sessionid
             *                    
             *          
             */ 

        }
    }
}