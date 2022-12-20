using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp2.Resources;

namespace WinFormsApp2
{
    public partial class Tables : Form
    {
        public Tables()
        {
            InitializeComponent();
        }

        private void MasaBtn_Click(object sender, EventArgs e)
        {
            Tables masa =new Tables();
            masa.Show();
            this.Hide();
        }

        private void RezervasyonBtn_Click(object sender, EventArgs e)
        {
            Rezervasyon rezervasyon = new Rezervasyon();
            rezervasyon.Show();
            this.Hide();

        }

        private void pktBtn_Click(object sender, EventArgs e)
        {
            pktServis paketServis = new pktServis();
            paketServis.Show();
            this.Hide();

        }

        private void MutfakBtn_Click(object sender, EventArgs e)
        {
            Mutfak mutfak = new Mutfak();
            mutfak.Show();
            this.Hide();
        }

        private void LockBtn_Click(object sender, EventArgs e)
        {
            EmployeeLogin empLogin = new EmployeeLogin();
            empLogin.Show();
            this.Hide();
        }

        private void CıkısBtn_Click(object sender, EventArgs e)
        {
            {
                DialogResult exit;
                exit = MessageBox.Show("Çıkış yapmak istiyor musun?", "soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (exit == DialogResult.Yes)
                {
                    Close();
                }
            }

        }

        private void btnMasa1_Click(object sender, EventArgs e)
        {
            Siparis siparis = new Siparis();

            int uzunluk = btnMasa1.Text.Length;
            Genel.ButtonValue = btnMasa1.Text.Substring(uzunluk - 6, 6);
            Genel.ButtonName = btnMasa1.Name;

            this.Close();
            siparis.ShowDialog();
        }

        private void btnMasa2_Click(object sender, EventArgs e)
        {
            Siparis siparis = new Siparis();

            int uzunluk = btnMasa2.Text.Length;
            Genel.ButtonValue = btnMasa2.Text.Substring(uzunluk - 6, 6);
            Genel.ButtonName = btnMasa2.Name;

            this.Close();
            siparis.ShowDialog();
        }

        private void btnMasa3_Click(object sender, EventArgs e)
        {
            Siparis siparis = new Siparis();

            int uzunluk = btnMasa3.Text.Length;
            Genel.ButtonValue = btnMasa3.Text.Substring(uzunluk - 6, 6);
            Genel.ButtonName = btnMasa3.Name;

            this.Close();
            siparis.ShowDialog();
        }

        private void btnMasa4_Click(object sender, EventArgs e)
        {
            Siparis siparis = new Siparis();

            int uzunluk = btnMasa4.Text.Length;
            Genel.ButtonValue = btnMasa4.Text.Substring(uzunluk - 6, 6);
            Genel.ButtonName = btnMasa4.Name;

            this.Close();
            siparis.ShowDialog();
        }

        private void btnMasa5_Click(object sender, EventArgs e)
        {
            Siparis siparis = new Siparis();

            int uzunluk = btnMasa5.Text.Length;
            Genel.ButtonValue = btnMasa5.Text.Substring(uzunluk - 6, 6);
            Genel.ButtonName = btnMasa5.Name;

            this.Close();
            siparis.ShowDialog();
        }

        private void btnMasa6_Click(object sender, EventArgs e)
        {
            Siparis siparis = new Siparis();

            int uzunluk =btnMasa6.Text.Length;
            Genel.ButtonValue = btnMasa6.Text.Substring(uzunluk - 6, 6);
            Genel.ButtonName = btnMasa6.Name;

            this.Close();
            siparis.ShowDialog();
        }

        private void btnMasa7_Click(object sender, EventArgs e)
        {
            Siparis siparis = new Siparis();

            int uzunluk = btnMasa7.Text.Length;
            Genel.ButtonValue = btnMasa7.Text.Substring(uzunluk - 6, 6);
            Genel.ButtonName = btnMasa7.Name;

            this.Close();
            siparis.ShowDialog();
        }

        private void btnMasa8_Click(object sender, EventArgs e)
        {
            Siparis siparis = new Siparis();

            int uzunluk = btnMasa8.Text.Length;
            Genel.ButtonValue = btnMasa8.Text.Substring(uzunluk - 6, 6);
            Genel.ButtonName = btnMasa8.Name;

            this.Close();
            siparis.ShowDialog();
        }

        private void btnMasa9_Click(object sender, EventArgs e)
        {
            Siparis siparis = new Siparis();

            int uzunluk = btnMasa9.Text.Length;
            Genel.ButtonValue =btnMasa9.Text.Substring(uzunluk - 6, 6);
            Genel.ButtonName = btnMasa9.Name;

            this.Close();
            siparis.ShowDialog();
        }

        private void btnMasa10_Click(object sender, EventArgs e)
        {
            Siparis siparis = new Siparis();

            int uzunluk = btnMasa10.Text.Length;
            Genel.ButtonValue = btnMasa10.Text.Substring(uzunluk - 6, 6);
            Genel.ButtonName = btnMasa10.Name;

            this.Close();
            siparis.ShowDialog();
        }

        private void btnMasaa11_Click(object sender, EventArgs e)
        {
            Siparis siparis = new Siparis();

            int uzunluk = btnMasaa11.Text.Length;
            Genel.ButtonValue = btnMasaa11.Text.Substring(uzunluk - 6, 6);
            Genel.ButtonName = btnMasaa11.Name;

            this.Close();
            siparis.ShowDialog();
        }

        private void btnMasa12_Click(object sender, EventArgs e)
        {
            Siparis siparis = new Siparis();

            int uzunluk = btnMasa12.Text.Length;
            Genel.ButtonValue = btnMasa12.Text.Substring(uzunluk - 6, 6);
            Genel.ButtonName = btnMasa12.Name;

            this.Close();
            siparis.ShowDialog();
        }

        private void btnMasa13_Click(object sender, EventArgs e)
        {
            Siparis siparis = new Siparis();

            int uzunluk = btnMasa13.Text.Length;
            Genel.ButtonValue = btnMasa13.Text.Substring(uzunluk - 6, 6);
            Genel.ButtonName = btnMasa13.Name;

            this.Close();
            siparis.ShowDialog();
        }

        private void btnMasa14_Click(object sender, EventArgs e)
        {
            Siparis siparis = new Siparis();

            int uzunluk = btnMasa14.Text.Length;
            Genel.ButtonValue =btnMasa14.Text.Substring(uzunluk - 6, 6);
            Genel.ButtonName = btnMasa14.Name;

            this.Close();
            siparis.ShowDialog();
        }

        private void btnMasa15_Click(object sender, EventArgs e)
        {
            Siparis siparis = new Siparis();

            int uzunluk = btnMasa15.Text.Length;
            Genel.ButtonValue = btnMasa15.Text.Substring(uzunluk - 6, 6);
            Genel.ButtonName = btnMasa15.Name;

            this.Close();
            siparis.ShowDialog();
        }

        private void btnMasa16_Click(object sender, EventArgs e)
        {
            Siparis siparis = new Siparis();

            int uzunluk = btnMasa16.Text.Length;
            Genel.ButtonValue = btnMasa16.Text.Substring(uzunluk - 6, 6);
            Genel.ButtonName = btnMasa16.Name;

            this.Close();
            siparis.ShowDialog();
        }

        private void btnMasa17_Click(object sender, EventArgs e)
        {
            Siparis siparis = new Siparis();

            int uzunluk = btnMasa17.Text.Length;
            Genel.ButtonValue = btnMasa17.Text.Substring(uzunluk - 6, 6);
            Genel.ButtonName = btnMasa17.Name;

            this.Close();
            
        }

        private void btnMasa18_Click(object sender, EventArgs e)
        {
            Siparis siparis = new Siparis();

            int uzunluk = btnMasa18.Text.Length;
            Genel.ButtonValue = btnMasa18.Text.Substring(uzunluk - 6, 6);
            Genel.ButtonName = btnMasa18.Name;

            this.Close();
            siparis.ShowDialog();
        }

        private void btnMasa19_Click(object sender, EventArgs e)
        {
            Siparis siparis = new Siparis();

            int uzunluk = btnMasa19.Text.Length;
            Genel.ButtonValue = btnMasa19.Text.Substring(uzunluk - 6, 6);
            Genel.ButtonName = btnMasa19.Name;

            this.Close();
            siparis.ShowDialog();
        }

        private void btnMasa20_Click(object sender, EventArgs e)
        {
            Siparis siparis = new Siparis();

            int uzunluk = btnMasa20.Text.Length;
            Genel.ButtonValue = btnMasa20.Text.Substring(uzunluk - 6, 6);
            Genel.ButtonName = btnMasa20.Name;

            this.Close();
            siparis.ShowDialog();
        }
        Genel gnl = new Genel();
        private void Tables_Load(object sender, EventArgs e)
        {
            SqlConnection Baglanti = new SqlConnection(@"Data Source=DESKTOP-0J0SBS6;Initial Catalog=Restaurant;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("Select Durum , Id from Masalar", Baglanti);
            SqlDataReader dr = null;

            if (Baglanti.State == ConnectionState.Closed)
            {
                Baglanti.Open();
            }
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                foreach (Control item in this.Controls)
                {
                    if (item is Button)
                    {
                        if (item.Name == "MasaBtn" + dr["Id"].ToString() && dr["Durum"].ToString() == "1")
                        {
                            item.BackColor = Color.Teal;
                        }
                        else if (item.Name == "MasaBtn" + dr["Id"].ToString() && dr["Durum"].ToString() == "2")
                        {
                            cMasalar ms = new cMasalar();
                            DateTime dt1 = Convert.ToDateTime(ms.SessionSum(2));
                            DateTime dt2 = DateTime.Now;

                            string st1 = Convert.ToDateTime(ms.SessionSum(2)).ToShortTimeString();
                            string st2 = DateTime.Now.ToShortTimeString();

                            DateTime t1 = dt1.AddMinutes(DateTime.Parse(st1).TimeOfDay.TotalMinutes);
                            DateTime t2 = dt2.AddMinutes(DateTime.Parse(st2).TimeOfDay.TotalMinutes);

                            var fark = t2 - t1;

                            item.Text = String.Format("{0}{1}",
                                fark.Hours > 0 ? String.Format("{0} saat", fark.Hours) : "",
                                fark.Minutes > 0 ? string.Format("{0} dakika", fark.Minutes) : "").Trim() + "\n\n\nMasa" + dr["Id"].ToString();

                            item.BackColor = Color.DarkRed;

                        }
                        else if (item.Name == "MasaBtn" + dr["Id"].ToString() && dr["Durum"].ToString() == "3")
                        {
                            item.BackColor = Color.YellowGreen;
                        }
                        else if (item.Name == "MasaBtn" + dr["Id"].ToString() && dr["Durum"].ToString() == "4")
                        {
                            item.BackColor = Color.DarkOrange;

                        }

                    }
                }

            }


        }
        Button btn;
        private void SecileneGore(object sender, MouseEventArgs e)
        {
            btn = sender as Button;
            Siparis sip = new Siparis();
            sip.Show();
        }
    }
}
