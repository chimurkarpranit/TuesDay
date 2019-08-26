using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Data;
using System.Resources;
using System.Text;
using System.Web.UI;

namespace Day6
{
    public partial class Login : Page
    {
        ResourceManager EnStrings;
        ResourceManager JaStrings;
        StringBuilder sb;
        public string SqlQuery { get; set; }
        string conString = ConfigurationManager.ConnectionStrings["DBConnection"].ToString();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string sLang, sLang1;
                //Get The Culture Info
                sLang = System.Threading.Thread.CurrentThread.CurrentCulture.EnglishName;
                sLang1 = sLang.Substring(0, 2);
                if (sLang1 == "En")
                {
                    ButtonLanguage.Text = "日本語";
                    GetEnglish();//Mehod Call
                }
                else if (sLang1 == "Ja")
                {
                    ButtonLanguage.Text = "English";
                    GetJapanese();//Method Call
                }
                else
                {
                    ButtonLanguage.Text = "日本語";
                    GetEnglish();//Mehod Call
                }
            }
        }
        protected void BtnLanguage_Click(object sender, EventArgs e)
        {
            LabelInvalid.Visible = false;
            if (ButtonLanguage.Text == "日本語")
            {
                GetJapanese();
            }
            else if (ButtonLanguage.Text == "English")
            {
                GetEnglish();
            }
        }
        public void GetEnglish()
        {
            EnStrings = new ResourceManager("Day6.JapToEng", typeof(JapToEng).Assembly);
            try
            {
                LabelLogin.Text = EnStrings.GetString("LabelLogin");
                LabelInvalid.Text = EnStrings.GetString("LabelInvalid");
                LabelLoginID.Text = EnStrings.GetString("LabelLoginID");
                LabelPassword.Text = EnStrings.GetString("LabelPassword");
                ReqLoginID.ErrorMessage = EnStrings.GetString("ReqLoginID");
                ReqPassword.ErrorMessage = EnStrings.GetString("ReqPassword");
                ButtonSubmit.Text = EnStrings.GetString("ButtonSubmit");
                ButtonCancel.Text = EnStrings.GetString("ButtonCancel");
                ButtonLanguage.Text = EnStrings.GetString("ButtonLanguage");
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }
        public void GetJapanese()
        {
            JaStrings = new ResourceManager("Day6.EngToJap", typeof(EngToJap).Assembly);
            try
            {
                LabelLogin.Text = JaStrings.GetString("LabelLogin");
                LabelInvalid.Text = JaStrings.GetString("LabelInvalid");
                LabelLoginID.Text = JaStrings.GetString("LabelLoginID");
                LabelPassword.Text = JaStrings.GetString("LabelPassword");
                ReqLoginID.ErrorMessage = JaStrings.GetString("ReqLoginID");
                ReqPassword.ErrorMessage = JaStrings.GetString("ReqPassword");
                ButtonSubmit.Text = JaStrings.GetString("ButtonSubmit");
                ButtonCancel.Text = JaStrings.GetString("ButtonCancel");
                ButtonLanguage.Text = JaStrings.GetString("ButtonLanguage");
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }
        protected void BtnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection con = new MySqlConnection(conString);
                sb = new StringBuilder("select FirstName, LastName from employees where Firstname = '" + textLoginID.Text + "' and LastName = '" + textPassword.Text + "'");
                SqlQuery = sb.ToString();
                MySqlDataAdapter sda = new MySqlDataAdapter(SqlQuery, conString);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    Session["LoginID"] = textLoginID.Text;
                    Session["Language"] = ButtonSubmit.Text;
                    Response.Redirect("WelCome.aspx", false);//redirection
                }
                else
                {
                    LabelInvalid.Visible = true;
                }
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }
        //Cause Validation False Remove text From Control
        protected void BtnCancel_Click(object sender, EventArgs e)
        {
            textLoginID.Text = "";
            textPassword.Text = "";
            LabelInvalid.Visible = false;
        }
    }
}