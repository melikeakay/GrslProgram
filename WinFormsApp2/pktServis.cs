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
    public partial class pktServis : Form
    {
        public pktServis()
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

        private void RaporBtn_Click(object sender, EventArgs e)
        {
            Raporlar rapor = new Raporlar();
            rapor.Show();
            this.Hide();

        }

        private void LockBtn_Click(object sender, EventArgs e)
        {
            EmployeeLogin empLogin = new EmployeeLogin();
            empLogin.Show();
            this.Hide();

        }

        private void ÇıkışBtn_Click(object sender, EventArgs e)
        {
            DialogResult exit;
            exit = MessageBox.Show("Çıkış yapmak istediğinden emin misiniz?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (exit == DialogResult.Yes)
            {
                Close();
            }

        }

        private void OnlinePktBtn_Click(object sender, EventArgs e)
        {
            verileriGoster("Select * from PaketSiparis");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void eklebutton_Click(object sender, EventArgs e)
        {
            
                Baglanti.Open();
                SqlCommand komut = new SqlCommand("INSERT INTO PaketServis (Name,Mail,TelNo,Adres,Siparis,SiparisDurumu,TeslimatSaglayan,OdemeTuru,İndirimKuponu,Aciklama) VALUES (@Name,@Mail,@TelNo,@Adres,@Siparis,@SiparisDurumu,@TeslimatSaglayan,@OdemeTuru,@İndirimKuponu,@Aciklama)", Baglanti);

            komut.Parameters.AddWithValue("@Name", İsimtextBox.Text);
            komut.Parameters.AddWithValue("@Mail", MailTxtbx.Text);
            komut.Parameters.AddWithValue("@TelNo",TelNumtextBox.Text);
            komut.Parameters.AddWithValue("@Adres", AdrestextBox.Text);
            komut.Parameters.AddWithValue("@Siparis",UruntextBox.Text);
            komut.Parameters.AddWithValue("@siparisDurumu",durumcombobx.Text);
            komut.Parameters.AddWithValue("@TeslimatSaglayan",teslimtextBox.Text);
            komut.Parameters.AddWithValue("@OdemeTuru",odemeCmbbx.Text);
            komut.Parameters.AddWithValue("@İndirimKuponu",indirimcmbbx.Text);  
            komut.Parameters.AddWithValue("@Aciklama",nottxtbx.Text);

            komut.ExecuteReader();


                

                verileriGoster("Select * from PaketServis");

                Baglanti.Close();



            
           
         

                
        }

        private void Gcllbutton_Click(object sender, EventArgs e)
        {
            try
            {
                Baglanti.Open();
                SqlCommand komut = new SqlCommand("update PaketServis set Name =' " + İsimtextBox.Text + "',TelNo ='" +TelNumtextBox.Text  + "',Siparis='" + UruntextBox.Text+"',SiparisDurumu='"+durumcombobx.Text+"',OdemeTuru='"+odemeCmbbx.Text, Baglanti);
                komut.ExecuteNonQuery();
                verileriGoster("select * from PaketServis");
                Baglanti.Close();

            }
            catch (Exception)
            {

                MessageBox.Show("Sipariş güncelleme işlemi yapılamadı...", "Hata");
            }
        }

        private void SilBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from PaketServis where Name=@Name", Baglanti);
                komut.Parameters.AddWithValue("@Name",İsimtextBox.Text);
                komut.ExecuteNonQuery();
                verileriGoster("Select * from PaketServis");
                Baglanti.Close();
                İsimtextBox.Clear();
                MessageBox.Show("Sipariş başarıyla silindi...","Onaylandı");
            }
            catch (Exception)
            {
                MessageBox.Show("Sipariş silme işlemi yapılmadı...", "Hata");

            }
        }
    }
}
