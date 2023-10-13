namespace CarKeysInventory
{
    partial class CategoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoryForm));
            categoriesDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            idTextBox = new TextBox();
            label4 = new Label();
            nameTextBox = new TextBox();
            label2 = new Label();
            deleteButton = new Button();
            label1 = new Label();
            panel1 = new Panel();
            label5 = new Label();
            addButton = new Button();
            backButton = new Button();
            ((System.ComponentModel.ISupportInitialize)categoriesDataGridView).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // categoriesDataGridView
            // 
            categoriesDataGridView.AllowUserToAddRows = false;
            categoriesDataGridView.AllowUserToDeleteRows = false;
            categoriesDataGridView.AllowUserToResizeColumns = false;
            categoriesDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            categoriesDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Red;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.Crimson;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            categoriesDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            categoriesDataGridView.ColumnHeadersHeight = 28;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            categoriesDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            categoriesDataGridView.Dock = DockStyle.Fill;
            categoriesDataGridView.GridColor = Color.Silver;
            categoriesDataGridView.Location = new Point(0, 0);
            categoriesDataGridView.Name = "categoriesDataGridView";
            categoriesDataGridView.RowHeadersVisible = false;
            categoriesDataGridView.RowHeadersWidth = 51;
            categoriesDataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            categoriesDataGridView.RowTemplate.Height = 29;
            categoriesDataGridView.Size = new Size(959, 466);
            categoriesDataGridView.TabIndex = 5;
            categoriesDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            categoriesDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            categoriesDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            categoriesDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            categoriesDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            categoriesDataGridView.ThemeStyle.BackColor = Color.White;
            categoriesDataGridView.ThemeStyle.GridColor = Color.Silver;
            categoriesDataGridView.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            categoriesDataGridView.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            categoriesDataGridView.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            categoriesDataGridView.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            categoriesDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            categoriesDataGridView.ThemeStyle.HeaderStyle.Height = 28;
            categoriesDataGridView.ThemeStyle.ReadOnly = false;
            categoriesDataGridView.ThemeStyle.RowsStyle.BackColor = Color.White;
            categoriesDataGridView.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            categoriesDataGridView.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            categoriesDataGridView.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            categoriesDataGridView.ThemeStyle.RowsStyle.Height = 29;
            categoriesDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            categoriesDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            categoriesDataGridView.Click += categoriesDataGridView_Click;
            // 
            // idTextBox
            // 
            idTextBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            idTextBox.ForeColor = Color.Red;
            idTextBox.Location = new Point(71, 68);
            idTextBox.Name = "idTextBox";
            idTextBox.Size = new Size(168, 30);
            idTextBox.TabIndex = 9;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(3, 67);
            label4.Name = "label4";
            label4.Size = new Size(62, 29);
            label4.TabIndex = 8;
            label4.Text = "ID :";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // nameTextBox
            // 
            nameTextBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            nameTextBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            nameTextBox.ForeColor = Color.Red;
            nameTextBox.Location = new Point(492, 5);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(455, 30);
            nameTextBox.TabIndex = 4;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(379, 4);
            label2.Name = "label2";
            label2.Size = new Size(107, 29);
            label2.TabIndex = 3;
            label2.Text = "Name :";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // deleteButton
            // 
            deleteButton.BackColor = Color.White;
            deleteButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            deleteButton.ForeColor = Color.Red;
            deleteButton.Location = new Point(245, 69);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(107, 29);
            deleteButton.TabIndex = 2;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += deleteButton_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 3);
            label1.Name = "label1";
            label1.Size = new Size(195, 37);
            label1.TabIndex = 0;
            label1.Text = "Delete Category";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Red;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(idTextBox);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(addButton);
            panel1.Controls.Add(nameTextBox);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(deleteButton);
            panel1.Controls.Add(backButton);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 466);
            panel1.Name = "panel1";
            panel1.Size = new Size(959, 106);
            panel1.TabIndex = 4;
            // 
            // label5
            // 
            label5.BackColor = Color.White;
            label5.Location = new Point(379, 0);
            label5.Name = "label5";
            label5.Size = new Size(15, 105);
            label5.TabIndex = 10;
            // 
            // addButton
            // 
            addButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            addButton.BackColor = Color.White;
            addButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            addButton.ForeColor = Color.Red;
            addButton.Location = new Point(727, 67);
            addButton.Name = "addButton";
            addButton.Size = new Size(107, 29);
            addButton.TabIndex = 7;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += addButton_Click;
            // 
            // backButton
            // 
            backButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            backButton.BackColor = Color.White;
            backButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            backButton.ForeColor = Color.Red;
            backButton.Location = new Point(840, 67);
            backButton.Name = "backButton";
            backButton.Size = new Size(107, 29);
            backButton.TabIndex = 1;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = false;
            backButton.Click += backButton_Click;
            // 
            // CategoryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(959, 572);
            Controls.Add(categoriesDataGridView);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CategoryForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CategoryForm";
            Load += CategoryForm_Load;
            ((System.ComponentModel.ISupportInitialize)categoriesDataGridView).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView categoriesDataGridView;
        private TextBox idTextBox;
        private Label label4;
        private TextBox nameTextBox;
        private Label label2;
        private Button deleteButton;
        private Label label1;
        private Panel panel1;
        private Label label5;
        private Button addButton;
        private Button backButton;
    }
}