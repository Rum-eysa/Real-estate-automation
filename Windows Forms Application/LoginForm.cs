namespace Windows_Forms_Application
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            bool isAuthenticated = AuthenticateUser(username, password);

            if (isAuthenticated)
            {
                // Giriş başarılı olduğunda ana formu aç
                MainForm mainForm = new MainForm();
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre yanlış.", "Giriş Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool AuthenticateUser(string username, string password)
        {
            try
            {
                string[] lines = File.ReadAllLines("users.txt");

                foreach (string line in lines)
                {
                    string[] parts = line.Split(':');
                    if (parts.Length == 2 && parts[0] == username && parts[1] == password)
                    {
                        return true; // Kullanıcı adı ve şifre doğru
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Giriş kontrolünde hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
    }
}
