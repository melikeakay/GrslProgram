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
    public partial class MasalarW : Form
    {
        public MasalarW()
        {
            InitializeComponent();
        }

        private void MasaBtn_Click(object sender, EventArgs e)
        {
            MasalarW masa =new MasalarW();
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
    }
}
