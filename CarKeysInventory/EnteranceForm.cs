using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarKeysInventory
{
    public partial class EnteranceForm : Form
    {
        public EnteranceForm()
        {
            InitializeComponent();
        }

        private void userButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            OpenForm(new UserForm());
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

        private void customerButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            OpenForm(new CustomerForm());
            CloseForm(this);
        }

        private void categoryButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            OpenForm(new CategoryForm());
            CloseForm(this);
        }

        private void productButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            OpenForm(new ProductForm());
            CloseForm(this);
        }

        private void shoppingButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            OpenForm(new OrderForm());
            CloseForm(this);
        }

        private void orderButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            OpenForm(new OrderListForm());
            CloseForm(this);
        }
    }
}
