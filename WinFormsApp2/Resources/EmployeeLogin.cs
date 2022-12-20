using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp2.Resources
{
    public partial class EmployeeLogin : Form
    {
        public EmployeeLogin()
        {
            InitializeComponent();
        }
        SqlConnection Baglanti = new SqlConnection(@"Data Source=DESKTOP-0J0SBS6;Initial Catalog=Restaurant;Integrated Security=True");

        private void CashierLoginButton_Click(object sender, EventArgs e)
        {

            try
            {
                Baglanti.Open();
                string sql = "Select * from personel where kullanıcıAdı=@kullanıcıAdı AND Parola=@parola";
                SqlParameter prm1 =new SqlParameter("kullanıcıAdı",CashierIdText.Text.Trim());
                SqlParameter prm2 = new SqlParameter("Parola", cashierPasstext.Text.Trim());
                SqlCommand komut = new SqlCommand(sql, Baglanti);
                komut.Parameters.Add(prm1);
                komut.Parameters.Add(prm2);
                DataTable dt =new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(komut);
                da.Fill(dt);

                if(dt.Rows.Count >0){

                    CashierLogin cashierLog = new CashierLogin();
                    cashierLog.Show();
                    this.Hide();

                }

            }
            catch (Exception)
            {

                MessageBox.Show("Hatalı Giriş", "Hata");
            }


            
        }

        private void CashierIdText_TextChanged(object sender, EventArgs e)
        {

        }

        private void cashierPasstext_TextChanged(object sender, EventArgs e)
        {
            cashierPasstext.PasswordChar = '*';

        }

        private void cashierCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (cashierCheckBox.Checked)
            {
                //karakteri göster.
                cashierPasstext.PasswordChar = '\0';
            }
            //değilse karakterlerin yerine * koy.
            else
            {
                cashierPasstext.PasswordChar = '*';
            }
        }

        private void CashierLogingrpBx_Enter(object sender, EventArgs e)
        {

        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {

            DialogResult exit;
            exit = MessageBox.Show("Çıkış yapmak istediğinizden emin misiniz?", "soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (exit == DialogResult.Yes)
            {
                Close();
            }
        }

        private void WaitercheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (WaitercheckBox.Checked)
            {
                //karakteri göster.
                WaiterPassTxtBox.PasswordChar = '\0';
            }
            //değilse karakterlerin yerine * koy.
            else
            {
                WaiterPassTxtBox.PasswordChar = '*';
            }

        }

        private void PasswordForgetLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PasswordForget Pass = new PasswordForget();
            Pass.Show();
            
        }

        private void cashierPasstext_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsNumber(e.KeyChar)|| e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void CashierIdText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

        }

        private void WaiterIdTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void WaiterPassTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void WaiterPassTxtBox_TextChanged(object sender, EventArgs e)
        {
            cashierPasstext.PasswordChar = '*';
        }

        private void EmployeeLogin_Load(object sender, EventArgs e)
        {

        }

        private void waiterLoginButton_Click(object sender, EventArgs e)
        {
            try
            {
                Baglanti.Open();
                string sql = "Select * from personel where kullanıcıAdı=@kullanıcıAdı AND Parola=@parola";
                SqlParameter prm1 = new SqlParameter("kullanıcıAdı", WaiterIdTxtBox.Text.Trim());
                SqlParameter prm2 = new SqlParameter("Parola", WaiterPassTxtBox.Text.Trim());
                SqlCommand komut = new SqlCommand(sql, Baglanti);
                komut.Parameters.Add(prm1);
                komut.Parameters.Add(prm2);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(komut);
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {

                    WaiterLogin waiter=new WaiterLogin();
                    waiter.Show();
                    this.Hide();

                }

            }
            catch (Exception)
            {

                MessageBox.Show("Hatalı Giriş", "Hata");
            }
        }
    }
}
