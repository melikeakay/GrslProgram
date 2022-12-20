using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2
{
    internal class cMasalar
    {
        private int Id;
        private int Kapasite;
        private int ServisTuru;
        private int Durum;


        public int Id1 { get => Id; set => Id = value; }
        public int Kapasite1 { get => Kapasite; set => Kapasite = value; }
        public int ServisTuru1 { get => ServisTuru; set => ServisTuru = value; }
        public int Durum1 { get => Durum; set => Durum = value; }

        Genel gnl = new Genel();
        public string SessionSum(int a)
        {
            string dt = "";
            SqlConnection Baglanti = new SqlConnection("Data Source=DESKTOP-0J0SBS6;Initial Catalog=Restaurant;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("Select Tarih,MasaId from adisyon Right Join Masalar on adisyon.MasaId=MasalarId where Masalar.Durum=@durum and adisyon.Durum=0", Baglanti);
            SqlDataReader dr = null;
            cmd.Parameters.Add("@durum",SqlDbType.Int).Value = a;

            try
            {
                if (Baglanti.State == ConnectionState.Closed)
                {
                    Baglanti.Open();

                }
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    dt = Convert.ToDateTime(dr["Tarih"]).ToString();
                }
                
            }
            catch(SqlException ex)
            {
                string hata=ex.Message;
            }
            return dt;
        }
    }
}
