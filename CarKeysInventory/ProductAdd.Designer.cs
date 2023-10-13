namespace CarKeysInventory
{
    partial class ProductAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductAdd));
            productTextBox = new TextBox();
            label4 = new Label();
            label2 = new Label();
            priceTextBox = new TextBox();
            label3 = new Label();
            quantityTextBox = new TextBox();
            label5 = new Label();
            descriptionTextBox = new TextBox();
            label6 = new Label();
            addButton = new Button();
            button1 = new Button();
            panel1 = new Panel();
            label1 = new Label();
            categoryComboBox = new ComboBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // productTextBox
            // 
            productTextBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            productTextBox.ForeColor = Color.Red;
            productTextBox.Location = new Point(191, 83);
            productTextBox.Name = "productTextBox";
            productTextBox.Size = new Size(204, 30);
            productTextBox.TabIndex = 14;
            // 
            // label4
            // 
            label4.BackColor = Color.White;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(29, 83);
            label4.Name = "label4";
            label4.Size = new Size(156, 29);
            label4.TabIndex = 13;
            label4.Text = "Product Name :";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(29, 125);
            label2.Name = "label2";
            label2.Size = new Size(156, 29);
            label2.TabIndex = 15;
            label2.Text = "Category :";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // priceTextBox
            // 
            priceTextBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            priceTextBox.ForeColor = Color.Red;
            priceTextBox.Location = new Point(191, 167);
            priceTextBox.Name = "priceTextBox";
            priceTextBox.Size = new Size(204, 30);
            priceTextBox.TabIndex = 18;
            // 
            // label3
            // 
            label3.BackColor = Color.White;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(29, 167);
            label3.Name = "label3";
            label3.Size = new Size(156, 29);
            label3.TabIndex = 17;
            label3.Text = "Price :";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // quantityTextBox
            // 
            quantityTextBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            quantityTextBox.ForeColor = Color.Red;
            quantityTextBox.Location = new Point(191, 211);
            quantityTextBox.Name = "quantityTextBox";
            quantityTextBox.Size = new Size(204, 30);
            quantityTextBox.TabIndex = 20;
            // 
            // label5
            // 
            label5.BackColor = Color.White;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(29, 211);
            label5.Name = "label5";
            label5.Size = new Size(156, 29);
            label5.TabIndex = 19;
            label5.Text = "Quantity :";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            descriptionTextBox.ForeColor = Color.Red;
            descriptionTextBox.Location = new Point(191, 254);
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(204, 30);
            descriptionTextBox.TabIndex = 22;
            // 
            // label6
            // 
            label6.BackColor = Color.White;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(29, 254);
            label6.Name = "label6";
            label6.Size = new Size(156, 29);
            label6.TabIndex = 21;
            label6.Text = "Description :";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // addButton
            // 
            addButton.BackColor = Color.Red;
            addButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            addButton.ForeColor = Color.White;
            addButton.Location = new Point(29, 303);
            addButton.Name = "addButton";
            addButton.Size = new Size(253, 34);
            addButton.TabIndex = 23;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += addButton_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Red;
            button1.Location = new Point(288, 303);
            button1.Name = "button1";
            button1.Size = new Size(107, 34);
            button1.TabIndex = 24;
            button1.Text = "Close";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Red;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(426, 63);
            panel1.TabIndex = 25;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(138, 18);
            label1.Name = "label1";
            label1.Size = new Size(169, 25);
            label1.TabIndex = 0;
            label1.Text = "Add Product";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // categoryComboBox
            // 
            categoryComboBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            categoryComboBox.ForeColor = Color.Red;
            categoryComboBox.FormattingEnabled = true;
            categoryComboBox.Location = new Point(191, 123);
            categoryComboBox.Name = "categoryComboBox";
            categoryComboBox.Size = new Size(204, 31);
            categoryComboBox.TabIndex = 26;
            // 
            // ProductAdd
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(426, 371);
            Controls.Add(categoryComboBox);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(addButton);
            Controls.Add(descriptionTextBox);
            Controls.Add(label6);
            Controls.Add(quantityTextBox);
            Controls.Add(label5);
            Controls.Add(priceTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(productTextBox);
            Controls.Add(label4);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ProductAdd";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ProductAdd";
            Load += ProductAdd_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox productTextBox;
        private Label label4;
        private Label label2;
        private TextBox priceTextBox;
        private Label label3;
        private TextBox quantityTextBox;
        private Label label5;
        private TextBox descriptionTextBox;
        private Label label6;
        private Button addButton;
        private Button button1;
        private Panel panel1;
        private Label label1;
        private ComboBox categoryComboBox;
    }
}