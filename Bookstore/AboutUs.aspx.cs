using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bookstore
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtemail.Text == String.Empty)
            {
                lblvalidateEmail.Visible = true;
            }
            else
            {
                btnSubmit.Visible = false;
                txtemail.Visible = false;
                lblComment.Visible = false;
                TxtComment.Visible = false;
                lblLabel.Visible = false;
                thanks.Visible = true;

                string useremail = txtemail.Text;
                MailMessage msg = new MailMessage();
                msg.From = new MailAddress("bookstore775@gmail.com");
                msg.To.Add(new MailAddress(useremail));
                msg.Subject = "JNS Bookstore";
                msg.Body = "Hi," + Environment.NewLine + Environment.NewLine +
                    "Thanks for your comments. Our team is reviewing it!!!" + Environment.NewLine + Environment.NewLine +
                    "Have a nice day." + Environment.NewLine + Environment.NewLine +
                    "Thanks" + Environment.NewLine +
                    "JNL BooKstore";

                SmtpClient mySmtpClient = new SmtpClient();
                System.Net.NetworkCredential myCredential = new System.Net.NetworkCredential("bookstore775@gmail.com", "abc123ABC");
                mySmtpClient.Host = "smtp.gmail.com";
                mySmtpClient.Port = 587;
                mySmtpClient.EnableSsl = true;
                mySmtpClient.UseDefaultCredentials = false;
                mySmtpClient.Credentials = myCredential;

                mySmtpClient.Send(msg);
                msg.Dispose();
            }



        }
    }
}