using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;

namespace CarKeysInventory
{
    public partial class UserRegistrationForm : Form
    {
        User user = new User();

        public UserRegistrationForm()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            OpenForm(new LoginForm());
            CloseForm(this);
        }

        private void registrationButton_Click(object sender, EventArgs e)
        {
            if (userNameTextBox.Text == "" || passwordTextBox.Text == "" || fullNameTextBox.Text == "" || phoneTextBox.Text == "")
            {
                MessageBox.Show("Need User's Data", "Field Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string userName = userNameTextBox.Text;
                string password = passwordTextBox.Text;
                string fullName = fullNameTextBox.Text;
                string phone = phoneTextBox.Text;

                if (!user.CheckUser(userName, phone))
                {
                    if (user.InsertUser(userName, fullName, password, phone))
                    {
                        userNameTextBox.Clear();
                        passwordTextBox.Clear();
                        fullNameTextBox.Clear();
                        phoneTextBox.Clear();
                        MessageBox.Show("User Is Registered", "Registration", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("User Do Not Add", "Registration", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("The Username Or Password Is Already Exists", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            userNameTextBox.Clear();
            passwordTextBox.Clear();
            fullNameTextBox.Clear();
            phoneTextBox.Clear();
        }

        public static void OpenForm(Form formToOpen)
        {
            formToOpen.ShowDialog();
        }

        public static void CloseForm(Form formToClose)
        {
            formToClose.Close();
        }
    }
}

