namespace CarKeysInventory
{
    partial class OrderListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderListForm));
            ordersDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            panel1 = new Panel();
            productIdTextBox = new Label();
            searchButton = new Button();
            orderSearchTextBox = new TextBox();
            completeButton = new Button();
            label4 = new Label();
            deleteButton = new Button();
            backButton = new Button();
            orderIdTextBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)ordersDataGridView).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // ordersDataGridView
            // 
            ordersDataGridView.AllowUserToAddRows = false;
            ordersDataGridView.AllowUserToDeleteRows = false;
            ordersDataGridView.AllowUserToResizeColumns = false;
            ordersDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            ordersDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Red;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.Crimson;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            ordersDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            ordersDataGridView.ColumnHeadersHeight = 28;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            ordersDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            ordersDataGridView.Dock = DockStyle.Fill;
            ordersDataGridView.GridColor = Color.Silver;
            ordersDataGridView.Location = new Point(0, 0);
            ordersDataGridView.Name = "ordersDataGridView";
            ordersDataGridView.RowHeadersVisible = false;
            ordersDataGridView.RowHeadersWidth = 51;
            ordersDataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            ordersDataGridView.RowTemplate.Height = 29;
            ordersDataGridView.Size = new Size(1182, 653);
            ordersDataGridView.TabIndex = 6;
            ordersDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            ordersDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            ordersDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            ordersDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            ordersDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            ordersDataGridView.ThemeStyle.BackColor = Color.White;
            ordersDataGridView.ThemeStyle.GridColor = Color.Silver;
            ordersDataGridView.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            ordersDataGridView.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            ordersDataGridView.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ordersDataGridView.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            ordersDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            ordersDataGridView.ThemeStyle.HeaderStyle.Height = 28;
            ordersDataGridView.ThemeStyle.ReadOnly = false;
            ordersDataGridView.ThemeStyle.RowsStyle.BackColor = Color.White;
            ordersDataGridView.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            ordersDataGridView.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ordersDataGridView.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            ordersDataGridView.ThemeStyle.RowsStyle.Height = 29;
            ordersDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            ordersDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            ordersDataGridView.Click += ordersDataGridView_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Red;
            panel1.Controls.Add(productIdTextBox);
            panel1.Controls.Add(searchButton);
            panel1.Controls.Add(orderSearchTextBox);
            panel1.Controls.Add(completeButton);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(deleteButton);
            panel1.Controls.Add(backButton);
            panel1.Controls.Add(orderIdTextBox);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 549);
            panel1.Name = "panel1";
            panel1.Size = new Size(1182, 104);
            panel1.TabIndex = 7;
            // 
            // productIdTextBox
            // 
            productIdTextBox.AutoSize = true;
            productIdTextBox.ForeColor = Color.Red;
            productIdTextBox.Location = new Point(287, 68);
            productIdTextBox.Name = "productIdTextBox";
            productIdTextBox.Size = new Size(50, 20);
            productIdTextBox.TabIndex = 64;
            productIdTextBox.Text = "label1";
            // 
            // searchButton
            // 
            searchButton.BackColor = Color.White;
            searchButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            searchButton.ForeColor = Color.Red;
            searchButton.Location = new Point(234, 15);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(99, 31);
            searchButton.TabIndex = 63;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = false;
            searchButton.Click += searchButton_Click;
            // 
            // orderSearchTextBox
            // 
            orderSearchTextBox.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            orderSearchTextBox.ForeColor = Color.Red;
            orderSearchTextBox.Location = new Point(12, 15);
            orderSearchTextBox.Name = "orderSearchTextBox";
            orderSearchTextBox.Size = new Size(216, 31);
            orderSearchTextBox.TabIndex = 62;
            // 
            // completeButton
            // 
            completeButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            completeButton.BackColor = Color.DodgerBlue;
            completeButton.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            completeButton.ForeColor = Color.White;
            completeButton.Location = new Point(852, 57);
            completeButton.Name = "completeButton";
            completeButton.Size = new Size(105, 39);
            completeButton.TabIndex = 61;
            completeButton.Text = "Complete";
            completeButton.UseVisualStyleBackColor = false;
            completeButton.Click += completeButton_Click;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(12, 60);
            label4.Name = "label4";
            label4.Size = new Size(105, 35);
            label4.TabIndex = 60;
            label4.Text = "Order ID :";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // deleteButton
            // 
            deleteButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            deleteButton.BackColor = Color.Red;
            deleteButton.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            deleteButton.ForeColor = Color.White;
            deleteButton.Location = new Point(963, 57);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(105, 39);
            deleteButton.TabIndex = 58;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += deleteButton_Click;
            // 
            // backButton
            // 
            backButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            backButton.BackColor = Color.White;
            backButton.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            backButton.ForeColor = Color.Red;
            backButton.Location = new Point(1074, 57);
            backButton.Name = "backButton";
            backButton.Size = new Size(105, 39);
            backButton.TabIndex = 57;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = false;
            backButton.Click += backButton_Click;
            // 
            // orderIdTextBox
            // 
            orderIdTextBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            orderIdTextBox.ForeColor = Color.Red;
            orderIdTextBox.Location = new Point(123, 63);
            orderIdTextBox.Name = "orderIdTextBox";
            orderIdTextBox.Size = new Size(105, 30);
            orderIdTextBox.TabIndex = 59;
            // 
            // OrderListForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 653);
            Controls.Add(panel1);
            Controls.Add(ordersDataGridView);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(700, 300);
            Name = "OrderListForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OrderListForm";
            Load += OrderListForm_Load;
            ((System.ComponentModel.ISupportInitialize)ordersDataGridView).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView ordersDataGridView;
        private Panel panel1;
        private Label label4;
        private Button deleteButton;
        private Button backButton;
        private TextBox orderIdTextBox;
        private Button completeButton;
        private Button searchButton;
        private TextBox orderSearchTextBox;
        private Label productIdTextBox;
    }
}