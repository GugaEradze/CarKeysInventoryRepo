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
using Microsoft.VisualBasic.ApplicationServices;

namespace CarKeysInventory
{
    public partial class CategoryForm : Form
    {
        User user = new User();
        Category category = new Category();

        public CategoryForm()
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

        private void CategoryForm_Load(object sender, EventArgs e)
        {
            ShowTable();
        }

        public void ShowTable()
        {
            categoriesDataGridView.DataSource = user.GetUsersList(new SqlCommand("SELECT * FROM [CarKeysManagement].[dbo].[Categories]"));
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text == "")
            {
                MessageBox.Show("Need Categoty's Data", "Field Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string categoryName = nameTextBox.Text;

                if (!category.CheckCategory(categoryName))
                {
                    if (category.InsertCategory(categoryName))
                    {
                        nameTextBox.Clear();
                        ShowTable();
                        MessageBox.Show("Category Is Added", "Add Category", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Category Do Not Add", "Add Category", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("The Category Is Already Exists", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (idTextBox.Text.Equals(""))
            {
                MessageBox.Show("Need Category's ID", "Field Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int id = Convert.ToInt32(idTextBox.Text);
                var result = MessageBox.Show("Are You Sure You Want To Delete Category?", "Delete Category", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (category.DeleteCategory(id))
                    {
                        ShowTable();
                        idTextBox.Clear();

                        MessageBox.Show("Category Deleted", "Delete Category", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Category Can't Be Deleted", "Delete Category", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            OpenForm(new EnteranceForm());
            CloseForm(this);
        }

        private void categoriesDataGridView_Click(object sender, EventArgs e)
        {
            idTextBox.Text = categoriesDataGridView.CurrentRow.Cells[0].Value.ToString();
        }
    }
}
