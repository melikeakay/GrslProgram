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
            //Diðer formumu açabilmem için o formun classýndan nesne türetiyorum.
           EmployeeLogin employee = new EmployeeLogin();
            //Show metodu ile nesne olarak türettiðim ikinci formumu açýyorum.
            employee.Show();
            //Bu mevcut formu kapatýyorum.
            this.Hide();


        }

        private void ManagerButton_Click(object sender, EventArgs e)
        {
           
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            DialogResult exit;
            exit=MessageBox.Show("Çýkýþ yapmak istediðinizden emin misiniz?","Soru",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (exit == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}