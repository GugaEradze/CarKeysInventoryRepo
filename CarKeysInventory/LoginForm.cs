using System.Data;
using System.Data.SqlClient;

namespace CarKeysInventory
{
    public partial class LoginForm : Form
    {
        User user = new User();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void showCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (showCheckBox.Checked == false)
            {
                passwordTextBox.UseSystemPasswordChar = true;
            }
            else
            {
                passwordTextBox.UseSystemPasswordChar = false;
            }
        }

        private void registrationButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            OpenForm(new UserRegistrationForm());
            CloseForm(this);
        }

        public static void OpenForm(Form formToOpen)
        {
            formToOpen.ShowDialog();
        }

        public static void CloseForm(Form formToClose)
        {
            formToClose.Close();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (usernameTextBox.Text == "" || passwordTextBox.Text == "")
            {
                MessageBox.Show("Need Login Data", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string userName = usernameTextBox.Text;
                string password = passwordTextBox.Text;
                DataTable dataTable = user.GetUsersList(new SqlCommand("SELECT * FROM [CarKeysManagement].[dbo].[Users] WHERE UserName = '" + usernameTextBox.Text + "' AND Password = '" + passwordTextBox.Text + "'"));
                if (dataTable.Rows.Count > 0)
                {
                    EnteranceForm enteranceForm = new EnteranceForm();
                    this.Hide();
                    OpenForm(new EnteranceForm());
                    CloseForm(this);
                }
                else
                {
                    MessageBox.Show("Your Username Or Password Doesn't Exist", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void passwordTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                loginButton.Focus();
                loginButton.PerformClick();
            }
        }
    }
}