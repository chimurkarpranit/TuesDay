using System;
using System.Web.UI;

namespace Day6
{
    public partial class WelCome : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Session["LoginID"] != null)
                {
                    if (Session["Language"].ToString() == "サブミット")
                    {
                        LblLoginID.Text = "Unikaihatsuへようこそ、" + " <font color=blue>" + Session["LoginID"] + "</font>";
                    }
                    else if (Session["Language"].ToString() == "Submit")
                    {
                        LblLoginID.Text = "Welcome To Unikaihatsu ," + " <font color=blue>" + Session["LoginID"] + "</font>";
                    }
                }
                else
                {
                    Response.Redirect("Login.aspx", false);
                }
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }
    }
}