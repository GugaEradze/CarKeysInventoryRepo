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
using Microsoft.VisualBasic.Devices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CarKeysInventory
{
    public partial class ProductForm : Form
    {
        User user = new User();
        ProductAdd productAdd = new ProductAdd();
        Product product = new Product();
        Category category = new Category();

        public ProductForm()
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

        private void newButton_Click(object sender, EventArgs e)
        {
            OpenForm(new ProductAdd());
        }

        public void ShowTable()
        {
            productsDataGridView.DataSource = user.GetUsersList(new SqlCommand("SELECT * FROM [CarKeysManagement].[dbo].[Products]"));
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            categoryComboBox.DataSource = category.GetCategoryList();
            categoryComboBox.DisplayMember = "CategoryName";
            categoryComboBox.ValueMember = "CategoryName";
            ShowTable();
        }

        private void customerButton1_Click(object sender, EventArgs e)
        {
            ShowTable();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (categoryComboBox.Text == "" || productTextBox.Text == "" || idTextBox.Equals("") || quantityTextBox.Text == "")
            {
                MessageBox.Show("Need Product Data", "Field Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int id = Convert.ToInt32(idTextBox.Text);
                string productName = productTextBox.Text;
                int quantity = Convert.ToInt32(quantityTextBox.Text);
                string category = categoryComboBox.Text;
                decimal price = Convert.ToDecimal(priceTextBox.Text);
                string description = descriptionTextBox.Text;

                if (product.UpdateProduct(id, productName, price, quantity, category, description))
                {
                    ShowTable();
                    idTextBox.Clear();
                    productTextBox.Clear();
                    quantityTextBox.Clear();
                    priceTextBox.Clear();
                    descriptionTextBox.Clear();
                    MessageBox.Show("Product Updated Successfully", "Update Product", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Product Can't Be Updated", "Update Course", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void productsDataGridView_Click(object sender, EventArgs e)
        {
            idTextBox.Text = productsDataGridView.CurrentRow.Cells[0].Value.ToString();
            productTextBox.Text = productsDataGridView.CurrentRow.Cells[1].Value.ToString();
            priceTextBox.Text = productsDataGridView.CurrentRow.Cells[2].Value.ToString();
            quantityTextBox.Text = productsDataGridView.CurrentRow.Cells[3].Value.ToString();
            descriptionTextBox.Text = productsDataGridView.CurrentRow.Cells[5].Value.ToString();
            categoryComboBox.DisplayMember = productsDataGridView.CurrentRow.Cells[4].Value.ToString();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (idTextBox.Text.Equals(""))
            {
                MessageBox.Show("Need Product's ID", "Field Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    int id = Convert.ToInt32(idTextBox.Text);
                    var result = MessageBox.Show("Are You Sure You Want To Delete Product?", "Delete Product", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        if (product.DeleteProduct(id))
                        {
                            ShowTable();
                            idTextBox.Clear();
                            productTextBox.Clear();
                            quantityTextBox.Clear();
                            priceTextBox.Clear();
                            descriptionTextBox.Clear();
                            MessageBox.Show("Product Deleted", "Delete Product", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Delete Product", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
            OpenForm(new EnteranceForm());
        }
    }
}
