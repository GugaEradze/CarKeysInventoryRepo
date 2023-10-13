namespace CarKeysInventory
{
    partial class ProductForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductForm));
            panel1 = new Panel();
            idTextBox = new TextBox();
            label6 = new Label();
            updateButton = new Button();
            backButton = new Button();
            editButton = new Button();
            newButton = new Button();
            categoryComboBox = new ComboBox();
            label5 = new Label();
            descriptionTextBox = new TextBox();
            label3 = new Label();
            priceTextBox = new TextBox();
            label2 = new Label();
            quantityTextBox = new TextBox();
            label1 = new Label();
            productTextBox = new TextBox();
            label4 = new Label();
            productsDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            panel2 = new Panel();
            customerButton1 = new CustomerButton();
            searchButton = new Button();
            textBox1 = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)productsDataGridView).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)customerButton1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Red;
            panel1.Controls.Add(idTextBox);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(updateButton);
            panel1.Controls.Add(backButton);
            panel1.Controls.Add(editButton);
            panel1.Controls.Add(newButton);
            panel1.Controls.Add(categoryComboBox);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(descriptionTextBox);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(priceTextBox);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(quantityTextBox);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(productTextBox);
            panel1.Controls.Add(label4);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 424);
            panel1.Name = "panel1";
            panel1.Size = new Size(959, 148);
            panel1.TabIndex = 5;
            // 
            // idTextBox
            // 
            idTextBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            idTextBox.ForeColor = Color.Red;
            idTextBox.Location = new Point(546, 102);
            idTextBox.Name = "idTextBox";
            idTextBox.Size = new Size(204, 30);
            idTextBox.TabIndex = 25;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(384, 101);
            label6.Name = "label6";
            label6.Size = new Size(156, 29);
            label6.TabIndex = 24;
            label6.Text = "ID :";
            label6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // updateButton
            // 
            updateButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            updateButton.BackColor = Color.White;
            updateButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            updateButton.ForeColor = Color.Red;
            updateButton.Location = new Point(849, 41);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(107, 29);
            updateButton.TabIndex = 23;
            updateButton.Text = "Update";
            updateButton.UseVisualStyleBackColor = false;
            updateButton.Click += updateButton_Click;
            // 
            // backButton
            // 
            backButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            backButton.BackColor = Color.White;
            backButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            backButton.ForeColor = Color.Red;
            backButton.Location = new Point(849, 111);
            backButton.Name = "backButton";
            backButton.Size = new Size(107, 29);
            backButton.TabIndex = 22;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = false;
            backButton.Click += backButton_Click;
            // 
            // editButton
            // 
            editButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            editButton.BackColor = Color.White;
            editButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            editButton.ForeColor = Color.Red;
            editButton.Location = new Point(849, 76);
            editButton.Name = "editButton";
            editButton.Size = new Size(107, 29);
            editButton.TabIndex = 21;
            editButton.Text = "Delete";
            editButton.UseVisualStyleBackColor = false;
            editButton.Click += editButton_Click;
            // 
            // newButton
            // 
            newButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            newButton.BackColor = Color.Red;
            newButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            newButton.ForeColor = Color.White;
            newButton.Location = new Point(849, 6);
            newButton.Name = "newButton";
            newButton.Size = new Size(107, 29);
            newButton.TabIndex = 20;
            newButton.Text = "Create";
            newButton.UseVisualStyleBackColor = false;
            newButton.Click += newButton_Click;
            // 
            // categoryComboBox
            // 
            categoryComboBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            categoryComboBox.ForeColor = Color.Red;
            categoryComboBox.FormattingEnabled = true;
            categoryComboBox.Location = new Point(174, 103);
            categoryComboBox.Name = "categoryComboBox";
            categoryComboBox.Size = new Size(204, 31);
            categoryComboBox.TabIndex = 19;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(12, 102);
            label5.Name = "label5";
            label5.Size = new Size(156, 29);
            label5.TabIndex = 18;
            label5.Text = "Category :";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            descriptionTextBox.ForeColor = Color.Red;
            descriptionTextBox.Location = new Point(546, 60);
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(204, 30);
            descriptionTextBox.TabIndex = 17;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(384, 59);
            label3.Name = "label3";
            label3.Size = new Size(156, 29);
            label3.TabIndex = 16;
            label3.Text = "Description :";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // priceTextBox
            // 
            priceTextBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            priceTextBox.ForeColor = Color.Red;
            priceTextBox.Location = new Point(546, 20);
            priceTextBox.Name = "priceTextBox";
            priceTextBox.Size = new Size(204, 30);
            priceTextBox.TabIndex = 15;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(384, 19);
            label2.Name = "label2";
            label2.Size = new Size(156, 29);
            label2.TabIndex = 14;
            label2.Text = "Price :";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // quantityTextBox
            // 
            quantityTextBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            quantityTextBox.ForeColor = Color.Red;
            quantityTextBox.Location = new Point(174, 60);
            quantityTextBox.Name = "quantityTextBox";
            quantityTextBox.Size = new Size(204, 30);
            quantityTextBox.TabIndex = 13;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 61);
            label1.Name = "label1";
            label1.Size = new Size(156, 29);
            label1.TabIndex = 12;
            label1.Text = "Quantity :";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // productTextBox
            // 
            productTextBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            productTextBox.ForeColor = Color.Red;
            productTextBox.Location = new Point(174, 18);
            productTextBox.Name = "productTextBox";
            productTextBox.Size = new Size(204, 30);
            productTextBox.TabIndex = 11;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(12, 17);
            label4.Name = "label4";
            label4.Size = new Size(156, 29);
            label4.TabIndex = 10;
            label4.Text = "Product Name :";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // productsDataGridView
            // 
            productsDataGridView.AllowUserToAddRows = false;
            productsDataGridView.AllowUserToDeleteRows = false;
            productsDataGridView.AllowUserToResizeColumns = false;
            productsDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            productsDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            productsDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Red;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.Crimson;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            productsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            productsDataGridView.ColumnHeadersHeight = 28;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            productsDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            productsDataGridView.GridColor = Color.Silver;
            productsDataGridView.Location = new Point(0, 38);
            productsDataGridView.Name = "productsDataGridView";
            productsDataGridView.ReadOnly = true;
            productsDataGridView.RowHeadersVisible = false;
            productsDataGridView.RowHeadersWidth = 51;
            productsDataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            productsDataGridView.RowTemplate.Height = 29;
            productsDataGridView.Size = new Size(959, 386);
            productsDataGridView.TabIndex = 6;
            productsDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            productsDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            productsDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            productsDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            productsDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            productsDataGridView.ThemeStyle.BackColor = Color.White;
            productsDataGridView.ThemeStyle.GridColor = Color.Silver;
            productsDataGridView.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            productsDataGridView.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            productsDataGridView.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            productsDataGridView.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            productsDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            productsDataGridView.ThemeStyle.HeaderStyle.Height = 28;
            productsDataGridView.ThemeStyle.ReadOnly = true;
            productsDataGridView.ThemeStyle.RowsStyle.BackColor = Color.White;
            productsDataGridView.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            productsDataGridView.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            productsDataGridView.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            productsDataGridView.ThemeStyle.RowsStyle.Height = 29;
            productsDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            productsDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            productsDataGridView.Click += productsDataGridView_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Red;
            panel2.Controls.Add(customerButton1);
            panel2.Controls.Add(searchButton);
            panel2.Controls.Add(textBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(959, 38);
            panel2.TabIndex = 7;
            // 
            // customerButton1
            // 
            customerButton1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            customerButton1.Image = (Image)resources.GetObject("customerButton1.Image");
            customerButton1.ImageHover = (Image)resources.GetObject("customerButton1.ImageHover");
            customerButton1.ImageNormal = (Image)resources.GetObject("customerButton1.ImageNormal");
            customerButton1.Location = new Point(919, 3);
            customerButton1.Name = "customerButton1";
            customerButton1.Size = new Size(37, 34);
            customerButton1.SizeMode = PictureBoxSizeMode.Zoom;
            customerButton1.TabIndex = 28;
            customerButton1.TabStop = false;
            customerButton1.Click += customerButton1_Click;
            // 
            // searchButton
            // 
            searchButton.BackColor = Color.White;
            searchButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            searchButton.ForeColor = Color.Red;
            searchButton.Location = new Point(213, 4);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(107, 29);
            searchButton.TabIndex = 27;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.ForeColor = Color.Red;
            textBox1.Location = new Point(3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(204, 30);
            textBox1.TabIndex = 26;
            // 
            // ProductForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(959, 572);
            Controls.Add(panel2);
            Controls.Add(productsDataGridView);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ProductForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ProductForm";
            Load += ProductForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)productsDataGridView).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)customerButton1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ComboBox categoryComboBox;
        private Label label5;
        private TextBox descriptionTextBox;
        private Label label3;
        private TextBox priceTextBox;
        private Label label2;
        private TextBox quantityTextBox;
        private Label label1;
        private TextBox productTextBox;
        private Label label4;
        private Button backButton;
        private Button editButton;
        private Button newButton;
        private Guna.UI2.WinForms.Guna2DataGridView productsDataGridView;
        private TextBox idTextBox;
        private Label label6;
        private Button updateButton;
        private Panel panel2;
        private Button searchButton;
        private TextBox textBox1;
        private CustomerButton customerButton1;
    }
}