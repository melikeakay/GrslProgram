using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;
using System.Net.Mail;

namespace WinFormsApp2
{
    public partial class PasswordForget : Form
    {
        public PasswordForget()
        {
            InitializeComponent();
        }
       
        private void MailButton_Click(object sender, EventArgs e)
        {
            SqlConnection Baglanti = new SqlConnection(@"Data Source=DESKTOP-0J0SBS6;Initial Catalog=Restaurant;Integrated Security=True");
            SqlCommand komut = new SqlCommand("Select * from WaiterLogin Where Name =" + KullanıcıTextBox.Text.ToString() +
                            "and mail=" + MailTextBox.Text.ToString() );
            SqlDataReader oku =komut.ExecuteReader();

            while (oku.Read())
            {
                try
                {
                    if(Baglanti.State== ConnectionState.Closed)
                    {
                        MailMessage ePosta = new MailMessage();
                        ePosta.From = new MailAddress("Mail Adresiniz.");
                        ePosta.To.Add(MailTextBox.Text); //göndereceğimiz mail adresi

                        Random rnd = new Random();
                      

                        ePosta.Subject = "Şifre Sıfırlama"; //mail konusu
                        ePosta.Body = $@"{DateTime.Now.ToLongDateString}
                         tarihinde şifre sıfırlama talebinde bulundunuz. Yeni Şifreniz:"; //mail içeriği 

                        SmtpClient client = new SmtpClient();
                        client.Credentials = new System.Net.NetworkCredential("Mail Adresiniz.", "Mail Şifreniz.");
                        client.Port = 587;
                        client.Host = "smtp.outlook.com";
                        client.EnableSsl = true;
                        client.Send(ePosta);
                        object userState = true;
                        bool kontrol = true;

                    }

                }
                catch (Exception)
                {

                    throw;
                } 

            }

        }

        private void MailTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
