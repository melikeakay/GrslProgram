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
    public partial class RaporW : Form
    {
        public RaporW()
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
            MasalarW masa = new MasalarW();
            masa.Show();
            this.Hide();

        }

        private void MenuBtn_Click(object sender, EventArgs e)
        {

        }

        private void raporBtn_Click(object sender, EventArgs e)
        {
            RaporW rapor = new RaporW();
            rapor.Show();
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
        SqlConnection Baglanti = new SqlConnection("Data Source=DESKTOP-0J0SBS6;Initial Catalog=Restaurant;Integrated Security=True");
        private void İzinTalepBtn_Click(object sender, EventArgs e)
        {
            Baglanti.Open();
            SqlCommand komut = new SqlCommand("INSERT INTO personelHareketleri (PersonelId,Islem,Tarih,Durum) VALUES (@PersonelId ,@Islem,@Tarih,@Durum)", Baglanti);
            komut.Parameters.AddWithValue("@PersonelId", CalısanIdtxtbx.Text);
            komut.Parameters.AddWithValue("@Islem", BasdateTimePicker1.Value);
            komut.Parameters.AddWithValue("@Tarih", BitdateTimePicker2.Value);
            komut.Parameters.AddWithValue("@Durum", comboBox1.Text);

            komut.ExecuteNonQuery();

            verileriGoster("Select * from personelHareketleri");

            Baglanti.Close();
        }
    }
}
