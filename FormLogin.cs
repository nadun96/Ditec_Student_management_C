namespace DITEC
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            var DialogResult = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string user = textBoxUsername.Text;
            string pass = textBoxPassword.Text;

            if (user == "Admin" && pass == "Skills@123")
            {
                MessageBox.Show("Login Success  !");
                this.Hide();
                FormRegister obj = new FormRegister();
                obj.Show();
            }
            else
            {
                MessageBox.Show("Login Not Success Please Check User and Password ?");
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            textBoxUsername.Clear();
            textBoxPassword.Clear();
        }
    }
}