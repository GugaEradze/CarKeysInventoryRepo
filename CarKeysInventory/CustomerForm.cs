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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CarKeysInventory
{
    public partial class CustomerForm : Form
    {
        User user = new User();
        Customer customer = new Customer();

        public CustomerForm()
        {
            InitializeComponent();
        }

        public void ShowTable()
        {
            customersDataGridView.DataSource = user.GetUsersList(new SqlCommand("SELECT * FROM [CarKeysManagement].[dbo].[Customers]"));
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            ShowTable();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text == "" || phoneTextBox.Text == "")
            {
                MessageBox.Show("Need Customer's Data", "Field Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string customerName = nameTextBox.Text;
                string phone = phoneTextBox.Text;

                if (!customer.CheckUser(customerName, phone))
                {
                    if (customer.InsertCustomer(customerName, phone))
                    {
                        nameTextBox.Clear();
                        phoneTextBox.Clear();
                        ShowTable();
                        MessageBox.Show("Customer Is Added", "Add Customer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Customer Do Not Add", "Add Customer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("The Customer Name Or Phone Is Already Exists", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void customersDataGridView_Click(object sender, EventArgs e)
        {
            idTextBox.Text = customersDataGridView.CurrentRow.Cells[0].Value.ToString();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (idTextBox.Text.Equals(""))
            {
                MessageBox.Show("Need Customer's ID", "Field Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int id = Convert.ToInt32(idTextBox.Text);
                var result = MessageBox.Show("Are You Sure You Want To Delete Customer?", "Delete Customer", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (customer.DeleteCustomer(id))
                    {
                        ShowTable();
                        idTextBox.Clear();

                        MessageBox.Show("Customer Deleted", "Delete Customer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Customer Can't Be Deleted", "Delete Customer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            OpenForm(new EnteranceForm());
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
    }
}
