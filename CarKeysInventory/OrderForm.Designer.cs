namespace CarKeysInventory
{
    partial class OrderForm
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderForm));
            customersDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            productsDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            label1 = new Label();
            label2 = new Label();
            customerSearchButton = new Button();
            customerSearchTextBox = new TextBox();
            productSearchButton = new Button();
            productSearchTextBox = new TextBox();
            label3 = new Label();
            customerIdTextBox = new TextBox();
            customerNameTextBox = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            productIdTextBox = new TextBox();
            label7 = new Label();
            priceTextBox = new TextBox();
            label8 = new Label();
            label9 = new Label();
            totalTextBox = new TextBox();
            label10 = new Label();
            productNameTextBox = new TextBox();
            label11 = new Label();
            dateTimePicker1 = new DateTimePicker();
            backButton = new Button();
            insertButton = new Button();
            numericUpDown = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)customersDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productsDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown).BeginInit();
            SuspendLayout();
            // 
            // customersDataGridView
            // 
            customersDataGridView.AllowUserToAddRows = false;
            customersDataGridView.AllowUserToDeleteRows = false;
            customersDataGridView.AllowUserToResizeColumns = false;
            customersDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            customersDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Red;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.Crimson;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            customersDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            customersDataGridView.ColumnHeadersHeight = 28;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            customersDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            customersDataGridView.GridColor = Color.Silver;
            customersDataGridView.Location = new Point(0, 0);
            customersDataGridView.Name = "customersDataGridView";
            customersDataGridView.RowHeadersVisible = false;
            customersDataGridView.RowHeadersWidth = 51;
            customersDataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            customersDataGridView.RowTemplate.Height = 29;
            customersDataGridView.Size = new Size(422, 298);
            customersDataGridView.TabIndex = 4;
            customersDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            customersDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            customersDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            customersDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            customersDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            customersDataGridView.ThemeStyle.BackColor = Color.White;
            customersDataGridView.ThemeStyle.GridColor = Color.Silver;
            customersDataGridView.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            customersDataGridView.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            customersDataGridView.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            customersDataGridView.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            customersDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            customersDataGridView.ThemeStyle.HeaderStyle.Height = 28;
            customersDataGridView.ThemeStyle.ReadOnly = false;
            customersDataGridView.ThemeStyle.RowsStyle.BackColor = Color.White;
            customersDataGridView.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            customersDataGridView.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            customersDataGridView.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            customersDataGridView.ThemeStyle.RowsStyle.Height = 29;
            customersDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            customersDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            customersDataGridView.Click += customersDataGridView_Click;
            // 
            // productsDataGridView
            // 
            productsDataGridView.AllowUserToAddRows = false;
            productsDataGridView.AllowUserToDeleteRows = false;
            productsDataGridView.AllowUserToResizeColumns = false;
            productsDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = Color.White;
            productsDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.Red;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.Crimson;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            productsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            productsDataGridView.ColumnHeadersHeight = 28;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            productsDataGridView.DefaultCellStyle = dataGridViewCellStyle6;
            productsDataGridView.GridColor = Color.Silver;
            productsDataGridView.Location = new Point(447, 0);
            productsDataGridView.Name = "productsDataGridView";
            productsDataGridView.RowHeadersVisible = false;
            productsDataGridView.RowHeadersWidth = 51;
            productsDataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            productsDataGridView.RowTemplate.Height = 29;
            productsDataGridView.Size = new Size(736, 298);
            productsDataGridView.TabIndex = 5;
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
            productsDataGridView.ThemeStyle.ReadOnly = false;
            productsDataGridView.ThemeStyle.RowsStyle.BackColor = Color.White;
            productsDataGridView.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            productsDataGridView.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            productsDataGridView.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            productsDataGridView.ThemeStyle.RowsStyle.Height = 29;
            productsDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            productsDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            productsDataGridView.Click += productsDataGridView_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.Red;
            label1.Location = new Point(422, 0);
            label1.Name = "label1";
            label1.Size = new Size(25, 655);
            label1.TabIndex = 6;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(12, 337);
            label2.Name = "label2";
            label2.Size = new Size(131, 31);
            label2.TabIndex = 7;
            label2.Text = "CUSTOMER";
            // 
            // customerSearchButton
            // 
            customerSearchButton.BackColor = Color.White;
            customerSearchButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            customerSearchButton.ForeColor = Color.Red;
            customerSearchButton.Location = new Point(249, 304);
            customerSearchButton.Name = "customerSearchButton";
            customerSearchButton.Size = new Size(105, 29);
            customerSearchButton.TabIndex = 29;
            customerSearchButton.Text = "Search";
            customerSearchButton.UseVisualStyleBackColor = false;
            customerSearchButton.Click += customerSearchButton_Click;
            // 
            // customerSearchTextBox
            // 
            customerSearchTextBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            customerSearchTextBox.ForeColor = Color.Red;
            customerSearchTextBox.Location = new Point(12, 304);
            customerSearchTextBox.Name = "customerSearchTextBox";
            customerSearchTextBox.Size = new Size(231, 30);
            customerSearchTextBox.TabIndex = 28;
            customerSearchTextBox.KeyPress += customerSearchTextBox_KeyPress;
            // 
            // productSearchButton
            // 
            productSearchButton.BackColor = Color.White;
            productSearchButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            productSearchButton.ForeColor = Color.Red;
            productSearchButton.Location = new Point(729, 304);
            productSearchButton.Name = "productSearchButton";
            productSearchButton.Size = new Size(105, 29);
            productSearchButton.TabIndex = 32;
            productSearchButton.Text = "Search";
            productSearchButton.UseVisualStyleBackColor = false;
            productSearchButton.Click += productSearchButton_Click;
            // 
            // productSearchTextBox
            // 
            productSearchTextBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            productSearchTextBox.ForeColor = Color.Red;
            productSearchTextBox.Location = new Point(453, 304);
            productSearchTextBox.Name = "productSearchTextBox";
            productSearchTextBox.Size = new Size(270, 30);
            productSearchTextBox.TabIndex = 31;
            productSearchTextBox.KeyPress += productSearchTextBox_KeyPress;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(453, 337);
            label3.Name = "label3";
            label3.Size = new Size(131, 31);
            label3.TabIndex = 30;
            label3.Text = "PRODUCT";
            // 
            // customerIdTextBox
            // 
            customerIdTextBox.BackColor = Color.White;
            customerIdTextBox.Enabled = false;
            customerIdTextBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            customerIdTextBox.ForeColor = Color.Red;
            customerIdTextBox.Location = new Point(12, 401);
            customerIdTextBox.Name = "customerIdTextBox";
            customerIdTextBox.ReadOnly = true;
            customerIdTextBox.Size = new Size(231, 30);
            customerIdTextBox.TabIndex = 33;
            // 
            // customerNameTextBox
            // 
            customerNameTextBox.BackColor = Color.White;
            customerNameTextBox.Enabled = false;
            customerNameTextBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            customerNameTextBox.ForeColor = Color.Red;
            customerNameTextBox.Location = new Point(12, 467);
            customerNameTextBox.Name = "customerNameTextBox";
            customerNameTextBox.ReadOnly = true;
            customerNameTextBox.Size = new Size(231, 30);
            customerNameTextBox.TabIndex = 34;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(12, 368);
            label4.Name = "label4";
            label4.Size = new Size(231, 30);
            label4.TabIndex = 35;
            label4.Text = "Customer ID :";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(12, 434);
            label5.Name = "label5";
            label5.Size = new Size(231, 30);
            label5.TabIndex = 36;
            label5.Text = "Customer Name :";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(453, 368);
            label6.Name = "label6";
            label6.Size = new Size(231, 30);
            label6.TabIndex = 38;
            label6.Text = "Product ID :";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // productIdTextBox
            // 
            productIdTextBox.BackColor = Color.White;
            productIdTextBox.Enabled = false;
            productIdTextBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            productIdTextBox.ForeColor = Color.Red;
            productIdTextBox.Location = new Point(453, 401);
            productIdTextBox.Name = "productIdTextBox";
            productIdTextBox.ReadOnly = true;
            productIdTextBox.Size = new Size(301, 30);
            productIdTextBox.TabIndex = 37;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Red;
            label7.Location = new Point(791, 368);
            label7.Name = "label7";
            label7.Size = new Size(231, 30);
            label7.TabIndex = 40;
            label7.Text = "Price :";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // priceTextBox
            // 
            priceTextBox.BackColor = Color.White;
            priceTextBox.Enabled = false;
            priceTextBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            priceTextBox.ForeColor = Color.Red;
            priceTextBox.Location = new Point(791, 401);
            priceTextBox.Name = "priceTextBox";
            priceTextBox.ReadOnly = true;
            priceTextBox.Size = new Size(292, 30);
            priceTextBox.TabIndex = 39;
            priceTextBox.Text = "0";
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Red;
            label8.Location = new Point(791, 434);
            label8.Name = "label8";
            label8.Size = new Size(231, 30);
            label8.TabIndex = 42;
            label8.Text = "Quantity :";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            label9.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.Red;
            label9.Location = new Point(791, 500);
            label9.Name = "label9";
            label9.Size = new Size(231, 30);
            label9.TabIndex = 44;
            label9.Text = "Total :";
            label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // totalTextBox
            // 
            totalTextBox.BackColor = Color.White;
            totalTextBox.Enabled = false;
            totalTextBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            totalTextBox.ForeColor = Color.Red;
            totalTextBox.Location = new Point(791, 533);
            totalTextBox.Name = "totalTextBox";
            totalTextBox.ReadOnly = true;
            totalTextBox.Size = new Size(292, 30);
            totalTextBox.TabIndex = 43;
            // 
            // label10
            // 
            label10.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.Red;
            label10.Location = new Point(453, 434);
            label10.Name = "label10";
            label10.Size = new Size(231, 30);
            label10.TabIndex = 46;
            label10.Text = "Product Name :";
            label10.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // productNameTextBox
            // 
            productNameTextBox.BackColor = Color.White;
            productNameTextBox.Enabled = false;
            productNameTextBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            productNameTextBox.ForeColor = Color.Red;
            productNameTextBox.Location = new Point(453, 467);
            productNameTextBox.Name = "productNameTextBox";
            productNameTextBox.ReadOnly = true;
            productNameTextBox.Size = new Size(301, 30);
            productNameTextBox.TabIndex = 45;
            // 
            // label11
            // 
            label11.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.Red;
            label11.Location = new Point(453, 500);
            label11.Name = "label11";
            label11.Size = new Size(231, 30);
            label11.TabIndex = 47;
            label11.Text = "Order Date :";
            label11.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarForeColor = Color.Red;
            dateTimePicker1.CalendarTitleForeColor = Color.Red;
            dateTimePicker1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(453, 533);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(301, 30);
            dateTimePicker1.TabIndex = 48;
            // 
            // backButton
            // 
            backButton.BackColor = Color.White;
            backButton.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            backButton.ForeColor = Color.Red;
            backButton.Location = new Point(1065, 602);
            backButton.Name = "backButton";
            backButton.Size = new Size(105, 39);
            backButton.TabIndex = 50;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = false;
            backButton.Click += backButton_Click;
            // 
            // insertButton
            // 
            insertButton.BackColor = Color.Red;
            insertButton.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            insertButton.ForeColor = Color.White;
            insertButton.Location = new Point(954, 602);
            insertButton.Name = "insertButton";
            insertButton.Size = new Size(105, 39);
            insertButton.TabIndex = 52;
            insertButton.Text = "Insert";
            insertButton.UseVisualStyleBackColor = false;
            insertButton.Click += insertButton_Click;
            // 
            // numericUpDown
            // 
            numericUpDown.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            numericUpDown.ForeColor = Color.Red;
            numericUpDown.Location = new Point(791, 468);
            numericUpDown.Name = "numericUpDown";
            numericUpDown.Size = new Size(292, 30);
            numericUpDown.TabIndex = 53;
            numericUpDown.ValueChanged += numericUpDown_ValueChanged;
            // 
            // OrderForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 653);
            Controls.Add(numericUpDown);
            Controls.Add(insertButton);
            Controls.Add(backButton);
            Controls.Add(dateTimePicker1);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(productNameTextBox);
            Controls.Add(label9);
            Controls.Add(totalTextBox);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(priceTextBox);
            Controls.Add(label6);
            Controls.Add(productIdTextBox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(customerNameTextBox);
            Controls.Add(customerIdTextBox);
            Controls.Add(productSearchButton);
            Controls.Add(productSearchTextBox);
            Controls.Add(label3);
            Controls.Add(customerSearchButton);
            Controls.Add(customerSearchTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(productsDataGridView);
            Controls.Add(customersDataGridView);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(1200, 700);
            MinimumSize = new Size(1200, 700);
            Name = "OrderForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OrderForm";
            Load += OrderForm_Load;
            ((System.ComponentModel.ISupportInitialize)customersDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)productsDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView customersDataGridView;
        private Guna.UI2.WinForms.Guna2DataGridView productsDataGridView;
        private Label label1;
        private Label label2;
        private Button customerSearchButton;
        private TextBox customerSearchTextBox;
        private Button productSearchButton;
        private TextBox productSearchTextBox;
        private Label label3;
        private TextBox customerIdTextBox;
        private TextBox customerNameTextBox;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox productIdTextBox;
        private Label label7;
        private TextBox priceTextBox;
        private Label label8;
        private Label label9;
        private TextBox totalTextBox;
        private Label label10;
        private TextBox productNameTextBox;
        private Label label11;
        private DateTimePicker dateTimePicker1;
        private Button backButton;
        private Button insertButton;
        private NumericUpDown numericUpDown;
    }
}