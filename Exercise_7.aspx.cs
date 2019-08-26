using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Data;

namespace Day3_4
{
    public partial class Exercise_7 : System.Web.UI.Page
    {
        AllMessage m = new AllMessage();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindGrid();
            }
        }
        public void BindGrid()
        {
            try
            {
                string cstring = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
                MySqlConnection con = new MySqlConnection(cstring);
                MySqlCommand cmd = new MySqlCommand(m.strEmpDL, con);
                MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                DLEmployee.DataSource = dt;
                DLEmployee.DataTextField = "Name";
                DLEmployee.DataValueField = "Name";
                DLEmployee.DataBind();
                Cache.Insert("EmployeeName", dt, null, DateTime.Now.AddSeconds(40), System.Web.Caching.Cache.NoSlidingExpiration);
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }
        protected void ButtonDetails_Click(object sender, EventArgs e)
        {
            try
            {
                Response.Redirect("CacheEx7.aspx");
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }
    }
}