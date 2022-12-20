using WinFormsApp2.Resources;

namespace WinFormsApp2
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void EmployeeButton_Click(object sender, EventArgs e)
        {
            //Di�er formumu a�abilmem i�in o formun class�ndan nesne t�retiyorum.
           EmployeeLogin employee = new EmployeeLogin();
            //Show metodu ile nesne olarak t�retti�im ikinci formumu a��yorum.
            employee.Show();
            //Bu mevcut formu kapat�yorum.
            this.Hide();


        }

        private void ManagerButton_Click(object sender, EventArgs e)
        {
           
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            DialogResult exit;
            exit=MessageBox.Show("��k�� yapmak istedi�inizden emin misiniz?","Soru",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (exit == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}