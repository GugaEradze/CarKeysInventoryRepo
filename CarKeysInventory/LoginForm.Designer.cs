namespace CarKeysInventory
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            label1 = new Label();
            usernameTextBox = new TextBox();
            passwordTextBox = new TextBox();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            loginButton = new Button();
            registrationButton = new Button();
            showCheckBox = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.Red;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, -2);
            label1.Name = "label1";
            label1.Size = new Size(716, 70);
            label1.TabIndex = 0;
            label1.Text = "Car Keys Inventory";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // usernameTextBox
            // 
            usernameTextBox.Font = new Font("Microsoft JhengHei UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            usernameTextBox.ForeColor = Color.Red;
            usernameTextBox.Location = new Point(217, 206);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(288, 29);
            usernameTextBox.TabIndex = 1;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Font = new Font("Microsoft JhengHei UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            passwordTextBox.ForeColor = Color.Red;
            passwordTextBox.Location = new Point(217, 278);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(288, 29);
            passwordTextBox.TabIndex = 2;
            passwordTextBox.UseSystemPasswordChar = true;
            passwordTextBox.KeyPress += passwordTextBox_KeyPress;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(294, 80);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 76);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.Font = new Font("Microsoft JhengHei UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(217, 172);
            label2.Name = "label2";
            label2.Size = new Size(288, 31);
            label2.TabIndex = 4;
            label2.Text = "Username :";
            // 
            // label3
            // 
            label3.Font = new Font("Microsoft JhengHei UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(217, 244);
            label3.Name = "label3";
            label3.Size = new Size(288, 31);
            label3.TabIndex = 5;
            label3.Text = "Paasword :";
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.Red;
            loginButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            loginButton.ForeColor = Color.White;
            loginButton.Location = new Point(217, 330);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(140, 40);
            loginButton.TabIndex = 6;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // registrationButton
            // 
            registrationButton.BackColor = Color.Red;
            registrationButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            registrationButton.ForeColor = Color.White;
            registrationButton.Location = new Point(365, 330);
            registrationButton.Name = "registrationButton";
            registrationButton.Size = new Size(140, 40);
            registrationButton.TabIndex = 7;
            registrationButton.Text = "Registration";
            registrationButton.UseVisualStyleBackColor = false;
            registrationButton.Click += registrationButton_Click;
            // 
            // showCheckBox
            // 
            showCheckBox.ForeColor = Color.Red;
            showCheckBox.Location = new Point(511, 278);
            showCheckBox.Name = "showCheckBox";
            showCheckBox.Size = new Size(70, 30);
            showCheckBox.TabIndex = 8;
            showCheckBox.Text = "Show";
            showCheckBox.UseVisualStyleBackColor = true;
            showCheckBox.CheckedChanged += showCheckBox_CheckedChanged;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(713, 440);
            Controls.Add(showCheckBox);
            Controls.Add(registrationButton);
            Controls.Add(loginButton);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(passwordTextBox);
            Controls.Add(usernameTextBox);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(731, 487);
            MinimumSize = new Size(731, 487);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox usernameTextBox;
        private TextBox passwordTextBox;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private Button loginButton;
        private Button registrationButton;
        private CheckBox showCheckBox;
    }
}