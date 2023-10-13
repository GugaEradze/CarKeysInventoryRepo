using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class OrderForm : Form
    {
        User user = new User();
        Order order = new Order();
        Customer customer = new Customer();
        Product product = new Product();

        public OrderForm()
        {
            InitializeComponent();
        }

        public static void OpenForm(Form formToOpen)
        {
            formToOpen.ShowDialog();
        }

        public static void CloseForm(Form formToClose)
        {
            formToClose.Close();
        }

        public void ShowCustomerTable()
        {
            customersDataGridView.DataSource = user.GetUsersList(new SqlCommand("SELECT * FROM [CarKeysManagement].[dbo].[Customers]"));
        }

        public void ShowProductTable()
        {
            productsDataGridView.DataSource = user.GetUsersList(new SqlCommand("SELECT * FROM [CarKeysManagement].[dbo].[Products]"));
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            ShowCustomerTable();
            ShowProductTable();
        }

        private void customersDataGridView_Click(object sender, EventArgs e)
        {
            customerIdTextBox.Text = customersDataGridView.CurrentRow.Cells[0].Value.ToString();
            customerNameTextBox.Text = customersDataGridView.CurrentRow.Cells[1].Value.ToString();

        }

        int quantity = 0;

        private void productsDataGridView_Click(object sender, EventArgs e)
        {
            productIdTextBox.Text = productsDataGridView.CurrentRow.Cells[0].Value.ToString();
            productNameTextBox.Text = productsDataGridView.CurrentRow.Cells[1].Value.ToString();
            priceTextBox.Text = productsDataGridView.CurrentRow.Cells[2].Value.ToString();
            decimal total = Convert.ToDecimal(priceTextBox.Text) * Convert.ToInt32(numericUpDown.Value);
            totalTextBox.Text = total.ToString();
            quantity = Convert.ToInt32(productsDataGridView.CurrentRow.Cells[3].Value.ToString());
        }

        private void numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(numericUpDown.Value) > quantity)
            {
                MessageBox.Show("Instock Quantity Is Not Enough", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numericUpDown.Value = numericUpDown.Value - 1;
                return;
            }
            else
            {
                decimal price = Convert.ToDecimal(priceTextBox.Text);
                decimal quantity = Convert.ToDecimal(numericUpDown.Value);
                decimal total = price * quantity;
                totalTextBox.Text = total.ToString();
            }

        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            if (customerIdTextBox.Text == "")
            {
                MessageBox.Show("Please Select Customer", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (productIdTextBox.Text == "")
            {
                MessageBox.Show("Please Select Product", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Are You Sure You Want To Insert This Order", "Insert Order", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DateTime orderDate = dateTimePicker1.Value;
                int productID = Convert.ToInt32(productIdTextBox.Text);
                string productName = productNameTextBox.Text;
                string customerName = customerNameTextBox.Text;
                int customerID = Convert.ToInt32(customerIdTextBox.Text);
                int quantity = Convert.ToInt32(numericUpDown.Value);
                decimal price = Convert.ToDecimal(priceTextBox.Text);
                decimal total = Convert.ToDecimal(totalTextBox.Text);

                if (order.InsertOrder(productID, customerID, productName, customerName, quantity, price, total, orderDate))
                {
                    MessageBox.Show("Order Inserted", "Insert Order", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    numericUpDown.Value = 0;
                }
                else
                {
                    MessageBox.Show("Order Do Not Insert", "Insert Order", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Error", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void customerSearchButton_Click(object sender, EventArgs e)
        {
            customersDataGridView.DataSource = customer.SearchCustomer(customerSearchTextBox.Text);
        }

        private void productSearchButton_Click(object sender, EventArgs e)
        {
            productsDataGridView.DataSource = product.SearchProduct(productSearchTextBox.Text);
        }

        private void customerSearchTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    customerSearchButton.Focus();
                    customerSearchButton.PerformClick();
                }
            }
        }

        private void productSearchTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    productSearchButton.Focus();
                    productSearchButton.PerformClick();
                }
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            OpenForm(new EnteranceForm());
            CloseForm(this);
        }
    }
}
