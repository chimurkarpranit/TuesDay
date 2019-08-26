using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Data;

namespace Day3_4
{
    public partial class CacheEx7 : System.Web.UI.Page
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
                if (Cache["EmployeeName"] == null)
                {
                    LabelCache.Visible = true;
                }
                else
                {
                    DLEmployeeCache.DataSource = Cache["EmployeeName"];
                    DLEmployeeCache.DataValueField = "Name";
                    DLEmployeeCache.DataTextField = "Name";
                    DLEmployeeCache.DataBind();
                }
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
                if (DLEmployeeCache.SelectedValue == "0")
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "msgbox", "alert('Select Employee Name');", true);
                }
                else
                {
                    string cstring = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
                    MySqlConnection con = new MySqlConnection(cstring);
                    MySqlCommand cmd = new MySqlCommand(m.strDL + DLEmployeeCache.SelectedValue + "'", con);
                    MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
                    sda.SelectCommand = cmd;
                    DataSet ds = new DataSet();
                    sda.Fill(ds);
                    GridView1.DataSource = ds;
                    GridView1.DataBind();
                }
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }
    }
}