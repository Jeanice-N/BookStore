using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bookstore
{
    public partial class WebForm7 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /* NOTES:
             * The Checkout button from CartView.aspx leads to this form
             * When populating Customer table with information from this form please save the cId to a querystring or sessionid
             * The cId is needed when populating the SalesInvoice table later
             */
        }
    }
}