using Microsoft.VisualBasic.Devices;
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

namespace CarKeysInventory
{
    public partial class ProductAdd : Form
    {
        Product product = new Product();
        Category category = new Category();

        public ProductAdd()
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

        private void addButton_Click(object sender, EventArgs e)
        {
            if (productTextBox.Text == "" || categoryComboBox.Text == "" || priceTextBox.Text == "" || quantityTextBox.Text == "")
            {
                MessageBox.Show("Need Products's Data", "Field Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string productName = productTextBox.Text;
                string categoryName = categoryComboBox.Text;
                decimal price = Convert.ToDecimal(priceTextBox.Text);
                int quantity = Convert.ToInt32(quantityTextBox.Text);
                string description = descriptionTextBox.Text;

                if (!product.CheckProduct(productName))
                {
                    if (product.InsertProduct(productName, price, quantity, categoryName, description))
                    {
                        productTextBox.Clear();
                        priceTextBox.Clear();
                        quantityTextBox.Clear();
                        descriptionTextBox.Clear();
                        MessageBox.Show("Product Is Added", "Add Product", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Product Do Not Add", "Add Product", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("The Product Is Already Exists", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void ProductAdd_Load(object sender, EventArgs e)
        {
            categoryComboBox.DataSource = category.GetCategoryList();
            categoryComboBox.DisplayMember = "CategoryName";
            categoryComboBox.ValueMember = "CategoryName";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
