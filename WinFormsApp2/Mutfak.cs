using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp2.Resources;

namespace WinFormsApp2
{
    public partial class Mutfak : Form
    {
        public Mutfak()
        {
            InitializeComponent();
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

        private void RprBtn_Click(object sender, EventArgs e)
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

        private void cıkısBtn_Click(object sender, EventArgs e)
        {
            DialogResult exit;
            exit = MessageBox.Show("Çıkış yapmak istiyor musunuz?", "soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (exit == DialogResult.Yes)
            {
                Close();
            }

        }

        private void YeniSiparisBtn_Click(object sender, EventArgs e)
        {

        }

        private void EskiSiparis_Click(object sender, EventArgs e)
        {

        }
    }
}
