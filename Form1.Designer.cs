namespace _TTT_Game_Ubeydullah_Karatas {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            label1 = new Label();
            txtUsername = new TextBox();
            label2 = new Label();
            txtPassword = new TextBox();
            btLogin = new Button();
            lbWarning = new Label();
            btRegister = new Button();
            chRemember = new CheckBox();
            chShowPassword = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(117, 64);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 0;
            label1.Text = "Username:";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(117, 87);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(223, 27);
            txtUsername.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(117, 159);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 2;
            label2.Text = "Password:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(117, 182);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(223, 27);
            txtPassword.TabIndex = 3;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btLogin
            // 
            btLogin.Location = new Point(89, 336);
            btLogin.Name = "btLogin";
            btLogin.Size = new Size(131, 47);
            btLogin.TabIndex = 4;
            btLogin.Text = "Log In";
            btLogin.UseVisualStyleBackColor = true;
            btLogin.Click += btLogin_Click;
            // 
            // lbWarning
            // 
            lbWarning.AutoSize = true;
            lbWarning.Location = new Point(117, 422);
            lbWarning.Name = "lbWarning";
            lbWarning.Size = new Size(50, 20);
            lbWarning.TabIndex = 5;
            lbWarning.Text = "label3";
            lbWarning.Visible = false;
            // 
            // btRegister
            // 
            btRegister.Location = new Point(239, 336);
            btRegister.Name = "btRegister";
            btRegister.Size = new Size(131, 47);
            btRegister.TabIndex = 6;
            btRegister.Text = "Register";
            btRegister.UseVisualStyleBackColor = true;
            btRegister.Click += btRegister_Click;
            // 
            // chRemember
            // 
            chRemember.AutoSize = true;
            chRemember.Location = new Point(122, 275);
            chRemember.Name = "chRemember";
            chRemember.Size = new Size(129, 24);
            chRemember.TabIndex = 8;
            chRemember.Text = "Remember me";
            chRemember.UseVisualStyleBackColor = true;
            // 
            // chShowPassword
            // 
            chShowPassword.AutoSize = true;
            chShowPassword.Location = new Point(122, 236);
            chShowPassword.Name = "chShowPassword";
            chShowPassword.Size = new Size(132, 24);
            chShowPassword.TabIndex = 9;
            chShowPassword.Text = "Show Password";
            chShowPassword.UseVisualStyleBackColor = true;
            chShowPassword.CheckedChanged += chShowPassword_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(456, 471);
            Controls.Add(chShowPassword);
            Controls.Add(chRemember);
            Controls.Add(btRegister);
            Controls.Add(lbWarning);
            Controls.Add(btLogin);
            Controls.Add(txtPassword);
            Controls.Add(label2);
            Controls.Add(txtUsername);
            Controls.Add(label1);
            Name = "Form1";
            Text = "logInScreen";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtUsername;
        private Label label2;
        private TextBox txtPassword;
        private Button btLogin;
        private Label lbWarning;
        private Button btRegister;
        private CheckBox chRemember;
        private CheckBox chShowPassword;
    }
}