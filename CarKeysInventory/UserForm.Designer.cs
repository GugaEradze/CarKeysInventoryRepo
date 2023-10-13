namespace CarKeysInventory
{
    partial class UserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            panel1 = new Panel();
            idTextBox = new TextBox();
            label2 = new Label();
            deleteButton = new Button();
            backButton = new Button();
            label1 = new Label();
            usersDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)usersDataGridView).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Red;
            panel1.Controls.Add(idTextBox);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(deleteButton);
            panel1.Controls.Add(backButton);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 531);
            panel1.Name = "panel1";
            panel1.Size = new Size(959, 41);
            panel1.TabIndex = 0;
            // 
            // idTextBox
            // 
            idTextBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            idTextBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            idTextBox.ForeColor = Color.Red;
            idTextBox.Location = new Point(511, 5);
            idTextBox.Name = "idTextBox";
            idTextBox.Size = new Size(210, 30);
            idTextBox.TabIndex = 4;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(398, 6);
            label2.Name = "label2";
            label2.Size = new Size(107, 29);
            label2.TabIndex = 3;
            label2.Text = "ID :";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // deleteButton
            // 
            deleteButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            deleteButton.BackColor = Color.White;
            deleteButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            deleteButton.ForeColor = Color.Red;
            deleteButton.Location = new Point(727, 5);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(107, 29);
            deleteButton.TabIndex = 2;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += deleteButton_Click;
            // 
            // backButton
            // 
            backButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            backButton.BackColor = Color.White;
            backButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            backButton.ForeColor = Color.Red;
            backButton.Location = new Point(840, 5);
            backButton.Name = "backButton";
            backButton.Size = new Size(107, 30);
            backButton.TabIndex = 1;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = false;
            backButton.Click += backButton_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 3);
            label1.Name = "label1";
            label1.Size = new Size(150, 37);
            label1.TabIndex = 0;
            label1.Text = "Manage Users";
            // 
            // usersDataGridView
            // 
            usersDataGridView.AllowUserToAddRows = false;
            usersDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            usersDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Red;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.Crimson;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            usersDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            usersDataGridView.ColumnHeadersHeight = 28;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            usersDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            usersDataGridView.Dock = DockStyle.Fill;
            usersDataGridView.GridColor = Color.Silver;
            usersDataGridView.Location = new Point(0, 0);
            usersDataGridView.Name = "usersDataGridView";
            usersDataGridView.RowHeadersVisible = false;
            usersDataGridView.RowHeadersWidth = 51;
            usersDataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            usersDataGridView.RowTemplate.Height = 29;
            usersDataGridView.Size = new Size(959, 531);
            usersDataGridView.TabIndex = 1;
            usersDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            usersDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            usersDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            usersDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            usersDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            usersDataGridView.ThemeStyle.BackColor = Color.White;
            usersDataGridView.ThemeStyle.GridColor = Color.Silver;
            usersDataGridView.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            usersDataGridView.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            usersDataGridView.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            usersDataGridView.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            usersDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            usersDataGridView.ThemeStyle.HeaderStyle.Height = 28;
            usersDataGridView.ThemeStyle.ReadOnly = false;
            usersDataGridView.ThemeStyle.RowsStyle.BackColor = Color.White;
            usersDataGridView.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            usersDataGridView.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            usersDataGridView.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            usersDataGridView.ThemeStyle.RowsStyle.Height = 29;
            usersDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            usersDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            usersDataGridView.CellContentClick += usersDataGridView_CellContentClick;
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(959, 572);
            Controls.Add(usersDataGridView);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "UserForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserForm";
            Load += UserForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)usersDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button backButton;
        private Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView usersDataGridView;
        private Button deleteButton;
        private TextBox idTextBox;
        private Label label2;
    }
}