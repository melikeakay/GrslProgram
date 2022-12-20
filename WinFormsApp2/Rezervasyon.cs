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
    public partial class Rezervasyon : Form
    {
        public Rezervasyon()
        {
            InitializeComponent();
        }


        SqlConnection Baglanti = new SqlConnection("Data Source=DESKTOP-0J0SBS6;Initial Catalog=Restaurant;Integrated Security=True");

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

        private void RezervasyonBtn_Click(object sender, EventArgs e)
        {
            Rezervasyon rezervasyon = new Rezervasyon();
            rezervasyon.Show();
            this.Hide();


        }

        private void PaketBtn_Click(object sender, EventArgs e)
        {
            pktServis paketservis = new pktServis();
            paketservis.Show();
            this.Hide();
        }

        private void RaporBtn_Click(object sender, EventArgs e)
        {
            Raporlar rapor = new Raporlar();
            rapor.Show();
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
            DialogResult exit;
            exit = MessageBox.Show("Çıkış yapmak istediğinizden emin misiniz?", "soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (exit == DialogResult.Yes)
            {
                Close();
            }
        }

        private void EkleBtn_Click(object sender, EventArgs e)
        {
            Baglanti.Open();
            SqlCommand komut = new SqlCommand("INSERT INTO rezervasyon (Name,Mail,TelNo,Tarih,KisiSayısı,MasaId,Aciklama) VALUES (@Name,@Mail,@TelNo,@Tarih,@KisiSayısı,@MasaId,@Aciklama)", Baglanti);

            komut.Parameters.AddWithValue("@Name", İsimtextBox.Text);
            komut.Parameters.AddWithValue("@Mail", MailtextBox.Text);
            komut.Parameters.AddWithValue("@TelNo", TelNotextBox.Text);
            komut.Parameters.AddWithValue("@Tarih", dateTimePicker1.Value);
            komut.Parameters.AddWithValue("@KisiSayısı", KisiSayitextBox.Text);
            komut.Parameters.AddWithValue("@MasaId", masacomboBox.Text);
            komut.Parameters.AddWithValue("@Aciklama", AcıklamatextBox.Text);




            komut.ExecuteNonQuery();

            verileriGoster("Select * from rezervasyon");

            Baglanti.Close();
            İsimtextBox.Clear();
            MailtextBox.Clear();
            TelNotextBox.Clear();


            AcıklamatextBox.Clear();

        }

        private void GnclBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Baglanti.Open();
                SqlCommand komut = new SqlCommand("update rezervasyon set Name =' " + İsimtextBox.Text + "',Mail ='" + MailtextBox.Text + "',TelNo='" + TelNotextBox.Text, Baglanti);
                komut.ExecuteNonQuery();
                verileriGoster("select * from rezervasyon");
                Baglanti.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("Güncelleme Yapılamadı", "Hata");
            }


        }
        
        private void silBtn_Click(object sender, EventArgs e)
        {
            /*  Baglanti.Open();
              SqlCommand komut = new SqlCommand("delete from rezervasyon where TelNo=@TelNo", Baglanti);
              komut.Parameters.AddWithValue("@TelNo", TelNotextBox.Text);
              komut.ExecuteNonQuery();
              verileriGoster("Select * from rezervasyon");
              Baglanti.Close();
              TelNotextBox.Clear();*/
            Baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from rezervasyon where TelNo=@TelNo" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'", Baglanti);
            komut.Parameters.AddWithValue("@TelNo", TelNotextBox.Text);
            komut.ExecuteNonQuery();
            verileriGoster("Select * from rezervasyon");
            Baglanti.Close();
            TelNotextBox.Clear();


        }

        private void eskiBtn_Click(object sender, EventArgs e)
        {
            verileriGoster("Select * from rezervasyon");

        }
    }
}
