using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CarKeysInventory
{
    public partial class UserForm : Form
    {
        User user = new User();

        public UserForm()
        {
            InitializeComponent();
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            ShowTable();
        }

        public static void OpenForm(Form formToOpen)
        {
            formToOpen.ShowDialog();
        }

        public static void CloseForm(Form formToClose)
        {
            formToClose.Close();
        }

        public void ShowTable()
        {
            usersDataGridView.DataSource = user.GetUsersList(new SqlCommand("SELECT * FROM [CarKeysManagement].[dbo].[Users]"));
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            OpenForm(new EnteranceForm());
            CloseForm(this);
        }

        private void usersDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            idTextBox.Text = usersDataGridView.CurrentRow.Cells[0].Value.ToString();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (idTextBox.Text.Equals(""))
            {
                MessageBox.Show("Need User's ID", "Field Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int id = Convert.ToInt32(idTextBox.Text);
                var result = MessageBox.Show("Are You Sure You Want To Delete Student?", "Delete Student", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (user.DeleteUser(id))
                    {
                        ShowTable();
                        idTextBox.Clear();

                        MessageBox.Show("User Deleted", "Delete User", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("User Can't Be Deleted", "Delete User", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
