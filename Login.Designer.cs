namespace Nguyen_Xuan_Tuan_Linh_BH02990_SE08301_Database_ASM_Final
{
    partial class Login
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
            txtUsername = new Label();
            txtPassword = new Label();
            txtRole = new Label();
            tbUsername = new TextBox();
            tbPassword = new TextBox();
            cbbRole = new ComboBox();
            btnLogin = new Button();
            btnClear = new Button();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.AutoSize = true;
            txtUsername.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold);
            txtUsername.ForeColor = SystemColors.ButtonFace;
            txtUsername.Location = new Point(33, 176);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(99, 23);
            txtUsername.TabIndex = 0;
            txtUsername.Text = "Username: ";
            // 
            // txtPassword
            // 
            txtPassword.AutoSize = true;
            txtPassword.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold);
            txtPassword.ForeColor = SystemColors.ButtonFace;
            txtPassword.Location = new Point(33, 220);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(95, 23);
            txtPassword.TabIndex = 1;
            txtPassword.Text = "Password: ";
            // 
            // txtRole
            // 
            txtRole.AutoSize = true;
            txtRole.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtRole.ForeColor = SystemColors.ButtonFace;
            txtRole.Location = new Point(33, 259);
            txtRole.Name = "txtRole";
            txtRole.Size = new Size(55, 23);
            txtRole.TabIndex = 2;
            txtRole.Text = "Role: ";
            // 
            // tbUsername
            // 
            tbUsername.BackColor = Color.FromArgb(45, 45, 48);
            tbUsername.BorderStyle = BorderStyle.FixedSingle;
            tbUsername.ForeColor = SystemColors.ButtonFace;
            tbUsername.Location = new Point(172, 176);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(100, 23);
            tbUsername.TabIndex = 3;
            // 
            // tbPassword
            // 
            tbPassword.BackColor = Color.FromArgb(45, 45, 48);
            tbPassword.BorderStyle = BorderStyle.FixedSingle;
            tbPassword.ForeColor = SystemColors.ButtonFace;
            tbPassword.Location = new Point(172, 220);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(100, 23);
            tbPassword.TabIndex = 4;
            tbPassword.UseSystemPasswordChar = true;
            // 
            // cbbRole
            // 
            cbbRole.BackColor = Color.FromArgb(45, 45, 48);
            cbbRole.ForeColor = SystemColors.ButtonFace;
            cbbRole.FormattingEnabled = true;
            cbbRole.Location = new Point(172, 259);
            cbbRole.Name = "cbbRole";
            cbbRole.Size = new Size(100, 23);
            cbbRole.TabIndex = 5;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(0, 64, 0);
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.ForeColor = SystemColors.ButtonFace;
            btnLogin.Location = new Point(33, 301);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 34);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(0, 64, 0);
            btnClear.Cursor = Cursors.Hand;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.ForeColor = SystemColors.ButtonFace;
            btnClear.Location = new Point(197, 301);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 34);
            btnClear.TabIndex = 7;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 36, 49);
            ClientSize = new Size(345, 450);
            Controls.Add(btnClear);
            Controls.Add(btnLogin);
            Controls.Add(cbbRole);
            Controls.Add(tbPassword);
            Controls.Add(tbUsername);
            Controls.Add(txtRole);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtUsername;
        private Label txtPassword;
        private Label txtRole;
        private TextBox tbUsername;
        private TextBox tbPassword;
        private ComboBox cbbRole;
        private Button btnLogin;
        private Button btnClear;
    }
}
