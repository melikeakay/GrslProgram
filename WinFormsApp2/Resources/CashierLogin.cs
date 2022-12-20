using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2.Resources
{
    public partial class CashierLogin : Form
    {
        public CashierLogin()
        {
            InitializeComponent();
        }

        private void CashierLogin_Load(object sender, EventArgs e)
        {

        }

        private void TableButton_Click(object sender, EventArgs e)
        {
            Tables masa = new Tables();
            masa.Show();
            this.Hide();

        }

        private void reservationButton_Click(object sender, EventArgs e)
        {
            Rezervasyon rezervasyon = new Rezervasyon();
            rezervasyon.Show();
            this.Hide();

        }

        private void KitchenButton_Click(object sender, EventArgs e)
        {
            Mutfak mutfak = new Mutfak();
            mutfak.Show();
            this.Hide();

        }

        private void reportsButton_Click(object sender, EventArgs e)
        {
            Raporlar rapor = new Raporlar();
            rapor.Show();
            this.Hide();

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            DialogResult exit;
            exit = MessageBox.Show("Çıkış yapmak istediğinizden emin misiniz?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (exit == DialogResult.Yes)
            {
                Close();
            }
        }

        private void LockButton_Click(object sender, EventArgs e)
        {
            EmployeeLogin empLogin = new EmployeeLogin();
            empLogin.Show();
            this.Hide();
        }

        private void TakeAwayButton_Click(object sender, EventArgs e)
        {
            pktServis paketservis = new pktServis();
            paketservis.Show();
            this.Hide();
        }
    }
}
