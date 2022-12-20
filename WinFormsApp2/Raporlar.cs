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
    public partial class Raporlar : Form
    {
        public Raporlar()
        {
            InitializeComponent();
        }

        public void verileriGoster(string veriler)
        {
            SqlDataAdapter da = new SqlDataAdapter(veriler, Baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
        }

        private void MasaBtn_Click(object sender, EventArgs e)
        {
            Tables masa = new Tables();
            masa.Show();
            this.Hide();


        }

        private void RezerBtn_Click(object sender, EventArgs e)
        {
            Rezervasyon rezervasyon = new Rezervasyon();
            rezervasyon.Show();
            this.Hide();

        }

        private void pktBtn_Click(object sender, EventArgs e)
        {
            pktServis paketservis = new pktServis();
            paketservis.Show();
            this.Hide();

        }

        private void MutfakBtn_Click(object sender, EventArgs e)
        {
            Mutfak mutfak = new Mutfak();
            mutfak.Show();
            this.Hide();

        }

        private void raprBtn_Click(object sender, EventArgs e)
        {
            Raporlar rapor = new Raporlar();
            rapor.Show();
            this.Hide();       

        }

        private void lockBtn_Click(object sender, EventArgs e)
        {
            EmployeeLogin empLogin = new EmployeeLogin();
            empLogin.Show();
            this.Hide();

        }

        private void CıkısBtn_Click(object sender, EventArgs e)
        {
            DialogResult exit;
            exit = MessageBox.Show("Çıkış yapmak istiyor musunuz?", "soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (exit == DialogResult.Yes)
            {
                Close();
            }

        }
        SqlConnection Baglanti = new SqlConnection("Data Source=DESKTOP-0J0SBS6;Initial Catalog=Restaurant;Integrated Security=True");

        private void izinBtn_Click(object sender, EventArgs e)
        {
            Baglanti.Open();
            SqlCommand komut = new SqlCommand("INSERT INTO personelHareketleri (PersonelId,Islem,Tarih,Durum) VALUES (@PersonelId ,@Islem,@Tarih,@Durum)",Baglanti);
            komut.Parameters.AddWithValue("@PersonelId",personelIdTxt.Text);
            komut.Parameters.AddWithValue("@Islem", BasdateTimePicker1.Value);
            komut.Parameters.AddWithValue("@Tarih", dateTimePicker2.Value);
            komut.Parameters.AddWithValue("@Durum", İzincomboBox.Text);

            komut.ExecuteNonQuery();

            verileriGoster("Select * from personelHareketleri");

            Baglanti.Close();
        }
    }
}
