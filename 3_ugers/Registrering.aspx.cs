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
    public partial class Registrering : System.Web.UI.Page
    {
        private string cStr = ConfigurationManager.ConnectionStrings["Login"].ConnectionString;
        private String provider = ConfigurationManager.ConnectionStrings["Login"].ProviderName;


        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            string Brugernavn = TextBox16.Text;
            string Kodeord = TextBox15.Text;
            Kodeord = ComputeHash(Kodeord);
            string Fornavn = TextBox14.Text;
            string Efternavn = TextBox3.Text;
            string Email = TextBox12.Text;
            int Telefonnummer = int.Parse(TextBox13.Text);
            string Vej = TextBox4.Text;
            string Bynavn = TextBox5.Text;
            int Postnummer = int.Parse(TextBox11.Text);
            string sqlStmt = string.Format("INSERT INTO Kunde(brugernavn,kodeord,fornavn,efternavn,email,telefonnummer,vej,bynavn,postnummer) VALUES( '{0}', '{1}', '{2}', '{3}', '{4}', {5}, '{6}', '{7}', {8} )", Brugernavn, Kodeord, Fornavn, Efternavn, Email, Telefonnummer, Vej, Bynavn, Postnummer);

            try
            {

                SqlConnection sc = new SqlConnection(cStr);
                sc.Open();
                SqlCommand sqlcomm = new SqlCommand(sqlStmt, sc);
                sqlcomm.ExecuteNonQuery();

                sc.Close();

            
 
    }
            catch (Exception ee)
            {
                TextBox3.Text = ee.Message;


            }
        }

        protected void TextBox15_TextChanged(object sender, EventArgs e)
        {

            /*

            Kodeord = ComputeHash(Kodeord);
            string sqlStmt = string.Format("SELECT * FROM Brugernavn");
            SqlDataReader reader = sqlcomm.ExecuteReader();
            while (reader.Read())
            {
                string brugernavn = (string)reader["Brugernavn"];
                string kodeord = (string)reader["Kodeord"];
                if (brugernavn.Equals(brugernavn.Trim()) && kodeord.Equals(kodeord.Trim()))
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
            */
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
      