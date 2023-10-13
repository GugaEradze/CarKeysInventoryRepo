namespace CarKeysInventory
{
    partial class UserRegistrationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserRegistrationForm));
            panel1 = new Panel();
            label1 = new Label();
            backButton = new Button();
            label2 = new Label();
            userNameTextBox = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            fullNameTextBox = new TextBox();
            passwordTextBox = new TextBox();
            phoneTextBox = new TextBox();
            registrationButton = new Button();
            clearButton = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Red;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(766, 67);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(247, 45);
            label1.TabIndex = 0;
            label1.Text = "User Registration";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // backButton
            // 
            backButton.BackColor = Color.White;
            backButton.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            backButton.ForeColor = Color.Red;
            backButton.Location = new Point(654, 420);
            backButton.Name = "backButton";
            backButton.Size = new Size(100, 35);
            backButton.TabIndex = 1;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = false;
            backButton.Click += backButton_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(131, 142);
            label2.Name = "label2";
            label2.Size = new Size(116, 27);
            label2.TabIndex = 1;
            label2.Text = "User Name :";
            // 
            // userNameTextBox
            // 
            userNameTextBox.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            userNameTextBox.ForeColor = Color.Red;
            userNameTextBox.Location = new Point(266, 139);
            userNameTextBox.Name = "userNameTextBox";
            userNameTextBox.Size = new Size(355, 31);
            userNameTextBox.TabIndex = 2;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(131, 192);
            label3.Name = "label3";
            label3.Size = new Size(116, 27);
            label3.TabIndex = 3;
            label3.Text = "Full Name :";
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(131, 242);
            label4.Name = "label4";
            label4.Size = new Size(116, 27);
            label4.TabIndex = 4;
            label4.Text = "Password :";
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(131, 292);
            label5.Name = "label5";
            label5.Size = new Size(116, 27);
            label5.TabIndex = 5;
            label5.Text = "Phone :";
            // 
            // fullNameTextBox
            // 
            fullNameTextBox.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            fullNameTextBox.ForeColor = Color.Red;
            fullNameTextBox.Location = new Point(266, 189);
            fullNameTextBox.Name = "fullNameTextBox";
            fullNameTextBox.Size = new Size(355, 31);
            fullNameTextBox.TabIndex = 6;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            passwordTextBox.ForeColor = Color.Red;
            passwordTextBox.Location = new Point(266, 239);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(355, 31);
            passwordTextBox.TabIndex = 7;
            // 
            // phoneTextBox
            // 
            phoneTextBox.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            phoneTextBox.ForeColor = Color.Red;
            phoneTextBox.Location = new Point(266, 289);
            phoneTextBox.Name = "phoneTextBox";
            phoneTextBox.Size = new Size(355, 31);
            phoneTextBox.TabIndex = 8;
            // 
            // registrationButton
            // 
            registrationButton.BackColor = Color.Red;
            registrationButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            registrationButton.ForeColor = Color.White;
            registrationButton.Location = new Point(423, 421);
            registrationButton.Name = "registrationButton";
            registrationButton.Size = new Size(119, 35);
            registrationButton.TabIndex = 9;
            registrationButton.Text = "Registrate";
            registrationButton.UseVisualStyleBackColor = false;
            registrationButton.Click += registrationButton_Click;
            // 
            // clearButton
            // 
            clearButton.BackColor = Color.White;
            clearButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            clearButton.ForeColor = Color.Red;
            clearButton.Location = new Point(548, 421);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(100, 35);
            clearButton.TabIndex = 11;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = false;
            clearButton.Click += clearButton_Click;
            // 
            // UserRegistrationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(766, 466);
            Controls.Add(backButton);
            Controls.Add(clearButton);
            Controls.Add(registrationButton);
            Controls.Add(phoneTextBox);
            Controls.Add(passwordTextBox);
            Controls.Add(fullNameTextBox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(userNameTextBox);
            Controls.Add(label2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(784, 513);
            MinimizeBox = false;
            MinimumSize = new Size(784, 513);
            Name = "UserRegistrationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserModuleForm";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private TextBox userNameTextBox;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox fullNameTextBox;
        private TextBox passwordTextBox;
        private TextBox phoneTextBox;
        private Button registrationButton;
        private Button clearButton;
        private Button backButton;
    }
}