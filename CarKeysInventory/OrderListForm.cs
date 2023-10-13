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
    public partial class OrderListForm : Form
    {
        User user = new User();
        Order order = new Order();

        public OrderListForm()
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

        public void ShowOrderTable()
        {
            ordersDataGridView.DataSource = user.GetUsersList(new SqlCommand("SELECT [OrderID], [ProductID], [ProductName], [CustomerName], [Quantity], [Price], [Total], [OrderDate] FROM [CarKeysManagement].[dbo].[Orders]"));
        }

        private void OrderListForm_Load(object sender, EventArgs e)
        {
            ShowOrderTable();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            ordersDataGridView.DataSource = order.SearchOrder(orderSearchTextBox.Text);
        }

        private void ordersDataGridView_Click(object sender, EventArgs e)
        {
            {
                orderIdTextBox.Text = ordersDataGridView.CurrentRow.Cells[0].Value.ToString();
                productIdTextBox.Text = ordersDataGridView.CurrentRow.Cells[1].Value.ToString();
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (orderIdTextBox.Text.Equals(""))
            {
                MessageBox.Show("Need Order's ID", "Field Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    int id = Convert.ToInt32(orderIdTextBox.Text);
                    var result = MessageBox.Show("Are You Sure You Want To Delete Order?", "Delete Order", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        if (order.DeleteOrder(id))
                        {
                            ShowOrderTable();
                            orderIdTextBox.Clear();
                            MessageBox.Show("Order Deleted", "Delete Order", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Delete Order", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void completeButton_Click(object sender, EventArgs e)
        {
            if (orderIdTextBox.Text.Equals(""))
            {
                MessageBox.Show("Need Order's ID", "Field Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    int oid = Convert.ToInt32(orderIdTextBox.Text);
                    int pid = Convert.ToInt32(productIdTextBox.Text);
                    var result = MessageBox.Show("Are You Sure You Want To Complete Order?", "Complete Order", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        if (order.CompleteOrder(oid, pid))
                        {
                            order.DeleteOrder(oid);
                            ShowOrderTable();
                            MessageBox.Show("Order Completed", "Complete Order", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Complete Order", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
