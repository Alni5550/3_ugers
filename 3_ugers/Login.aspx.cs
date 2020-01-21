using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

using System.Security.Cryptography;
using System.Text;

namespace _3_ugers
{
    public partial class WebForm1 : System.Web.UI.Page
    {

        //Vi tildeler Brugernavn og Kodeord en tekstboks på webformen.
        private String cStr = ConfigurationManager.ConnectionStrings["Login"].ConnectionString;
        private String provider = ConfigurationManager.ConnectionStrings["Login"].ProviderName;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string b = TextBox1.Text;
            string k = TextBox3.Text;
            k = ComputeHash(k);

            //string sqlStmt = string.Format("INSERT INTO Login(brugernavn,kodeord) VALUES('{0}', '{1}')", Brugernavn, Kodeord);

            string sqlStmt = string.Format("SELECT * FROM Kunde");

            SqlConnection sc = new SqlConnection(cStr);
            sc.Open();
            SqlCommand sqlcomm = new SqlCommand(sqlStmt, sc);




            SqlDataReader reader = sqlcomm.ExecuteReader();
            while (reader.Read())
            {
                string brugernavn = (string)reader["brugernavn"];
                string kodeord = (string)reader["kodeord"];
                if (b.Equals(brugernavn.Trim()) && k.Equals(kodeord.Trim()))
                {
                    HttpCookie hcid = new HttpCookie("WCOMPA",
                    System.Guid.NewGuid().ToString());
                    hcid.Expires = DateTime.Now.AddHours(1);
                    Response.Cookies.Add(hcid);
                    Server.Transfer("Admin/WebForm1.aspx");
                    break;
                }
            }
            Server.Transfer("Admin/Error.aspx");
            sc.Close();
        }
        private string ComputeHash(string indStreng)
        {
            string outStreng;
            using (SHA256 mySHA256 = SHA256.Create())
            {
                byte[] secBytes = Encoding.ASCII.GetBytes(indStreng);
                byte[] hashValue = mySHA256.ComputeHash(secBytes);
                outStreng = Encoding.ASCII.GetString(hashValue);
            }
            return outStreng;
        }
    }
   

}
        