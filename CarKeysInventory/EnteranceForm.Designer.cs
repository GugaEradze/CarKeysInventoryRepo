namespace CarKeysInventory
{
    partial class EnteranceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EnteranceForm));
            panel1 = new Panel();
            label1 = new Label();
            label8 = new Label();
            orderButton = new CustomerButton();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            shoppingButton = new CustomerButton();
            userButton = new CustomerButton();
            categoryButton = new CustomerButton();
            customerButton = new CustomerButton();
            label2 = new Label();
            productButton = new CustomerButton();
            panel2 = new Panel();
            panel3 = new Panel();
            customerButton1 = new CustomerButton();
            label9 = new Label();
            label7 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)orderButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)shoppingButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)categoryButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)customerButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productButton).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)customerButton1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(959, 80);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(944, 74);
            label1.TabIndex = 0;
            label1.Text = "Inventory Management System";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Red;
            label8.Location = new Point(822, 152);
            label8.Name = "label8";
            label8.Size = new Size(115, 47);
            label8.TabIndex = 11;
            label8.Text = "SHOPPING";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // orderButton
            // 
            orderButton.Image = (Image)resources.GetObject("orderButton.Image");
            orderButton.ImageHover = (Image)resources.GetObject("orderButton.ImageHover");
            orderButton.ImageNormal = (Image)resources.GetObject("orderButton.ImageNormal");
            orderButton.Location = new Point(50, 222);
            orderButton.Name = "orderButton";
            orderButton.Size = new Size(105, 94);
            orderButton.SizeMode = PictureBoxSizeMode.Zoom;
            orderButton.TabIndex = 10;
            orderButton.TabStop = false;
            orderButton.Click += orderButton_Click;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(45, 319);
            label6.Name = "label6";
            label6.Size = new Size(105, 47);
            label6.TabIndex = 3;
            label6.Text = "ORDERS";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(621, 152);
            label5.Name = "label5";
            label5.Size = new Size(105, 47);
            label5.TabIndex = 9;
            label5.Text = "USERS";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(414, 152);
            label4.Name = "label4";
            label4.Size = new Size(131, 47);
            label4.TabIndex = 8;
            label4.Text = "CATEGORIES";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(218, 152);
            label3.Name = "label3";
            label3.Size = new Size(140, 47);
            label3.TabIndex = 7;
            label3.Text = "CUSTOMERS";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // shoppingButton
            // 
            shoppingButton.Image = (Image)resources.GetObject("shoppingButton.Image");
            shoppingButton.ImageHover = (Image)resources.GetObject("shoppingButton.ImageHover");
            shoppingButton.ImageNormal = (Image)resources.GetObject("shoppingButton.ImageNormal");
            shoppingButton.Location = new Point(822, 55);
            shoppingButton.Name = "shoppingButton";
            shoppingButton.Size = new Size(105, 94);
            shoppingButton.SizeMode = PictureBoxSizeMode.Zoom;
            shoppingButton.TabIndex = 6;
            shoppingButton.TabStop = false;
            shoppingButton.Click += shoppingButton_Click;
            // 
            // userButton
            // 
            userButton.Image = (Image)resources.GetObject("userButton.Image");
            userButton.ImageHover = (Image)resources.GetObject("userButton.ImageHover");
            userButton.ImageNormal = (Image)resources.GetObject("userButton.ImageNormal");
            userButton.Location = new Point(621, 55);
            userButton.Name = "userButton";
            userButton.Size = new Size(105, 94);
            userButton.SizeMode = PictureBoxSizeMode.Zoom;
            userButton.TabIndex = 5;
            userButton.TabStop = false;
            userButton.Click += userButton_Click;
            // 
            // categoryButton
            // 
            categoryButton.Image = (Image)resources.GetObject("categoryButton.Image");
            categoryButton.ImageHover = (Image)resources.GetObject("categoryButton.ImageHover");
            categoryButton.ImageNormal = (Image)resources.GetObject("categoryButton.ImageNormal");
            categoryButton.Location = new Point(427, 55);
            categoryButton.Name = "categoryButton";
            categoryButton.Size = new Size(105, 94);
            categoryButton.SizeMode = PictureBoxSizeMode.Zoom;
            categoryButton.TabIndex = 4;
            categoryButton.TabStop = false;
            categoryButton.Click += categoryButton_Click;
            // 
            // customerButton
            // 
            customerButton.Image = (Image)resources.GetObject("customerButton.Image");
            customerButton.ImageHover = (Image)resources.GetObject("customerButton.ImageHover");
            customerButton.ImageNormal = (Image)resources.GetObject("customerButton.ImageNormal");
            customerButton.Location = new Point(237, 55);
            customerButton.Name = "customerButton";
            customerButton.Size = new Size(105, 94);
            customerButton.SizeMode = PictureBoxSizeMode.Zoom;
            customerButton.TabIndex = 3;
            customerButton.TabStop = false;
            customerButton.Click += customerButton_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(45, 152);
            label2.Name = "label2";
            label2.Size = new Size(114, 47);
            label2.TabIndex = 2;
            label2.Text = "PRODUCTS";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // productButton
            // 
            productButton.Image = (Image)resources.GetObject("productButton.Image");
            productButton.ImageHover = (Image)resources.GetObject("productButton.ImageHover");
            productButton.ImageNormal = (Image)resources.GetObject("productButton.ImageNormal");
            productButton.Location = new Point(50, 55);
            productButton.Name = "productButton";
            productButton.Size = new Size(105, 94);
            productButton.SizeMode = PictureBoxSizeMode.Zoom;
            productButton.TabIndex = 1;
            productButton.TabStop = false;
            productButton.Click += productButton_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Red;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 548);
            panel2.Name = "panel2";
            panel2.Size = new Size(959, 24);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(customerButton1);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(orderButton);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(productButton);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(customerButton);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(categoryButton);
            panel3.Controls.Add(shoppingButton);
            panel3.Controls.Add(userButton);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 80);
            panel3.Name = "panel3";
            panel3.Size = new Size(959, 468);
            panel3.TabIndex = 2;
            // 
            // customerButton1
            // 
            customerButton1.Image = (Image)resources.GetObject("customerButton1.Image");
            customerButton1.ImageHover = (Image)resources.GetObject("customerButton1.ImageHover");
            customerButton1.ImageNormal = (Image)resources.GetObject("customerButton1.ImageNormal");
            customerButton1.Location = new Point(237, 222);
            customerButton1.Name = "customerButton1";
            customerButton1.Size = new Size(105, 94);
            customerButton1.SizeMode = PictureBoxSizeMode.Zoom;
            customerButton1.TabIndex = 12;
            customerButton1.TabStop = false;
            // 
            // label9
            // 
            label9.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.Red;
            label9.Location = new Point(232, 319);
            label9.Name = "label9";
            label9.Size = new Size(114, 47);
            label9.TabIndex = 13;
            label9.Text = "ANALYTICS";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.BackColor = Color.Red;
            label7.Location = new Point(0, 0);
            label7.Name = "label7";
            label7.Size = new Size(1920, 27);
            label7.TabIndex = 0;
            // 
            // EnteranceForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(959, 572);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(977, 619);
            MinimumSize = new Size(977, 619);
            Name = "EnteranceForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EnteranceForm";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)orderButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)shoppingButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)userButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)categoryButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)customerButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)productButton).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)customerButton1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label label1;
        private CustomerButton productButton;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private CustomerButton shoppingButton;
        private CustomerButton userButton;
        private CustomerButton categoryButton;
        private CustomerButton customerButton;
        private Label label2;
        private Label label7;
        private Label label8;
        private CustomerButton orderButton;
        private CustomerButton customerButton1;
        private Label label9;
    }
}