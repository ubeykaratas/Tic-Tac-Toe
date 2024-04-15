namespace _TTT_Game_Ubeydullah_Karatas {
    partial class addOrUpdateUser {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btBack = new Button();
            btSave = new Button();
            txtId = new TextBox();
            txtUserType = new TextBox();
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            txtNameSurname = new TextBox();
            txtMail = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(190, 61);
            label1.Name = "label1";
            label1.Size = new Size(24, 20);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(190, 108);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 2;
            label2.Text = "UserType";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(190, 155);
            label3.Name = "label3";
            label3.Size = new Size(78, 20);
            label3.TabIndex = 4;
            label3.Text = "UserName";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(190, 202);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 6;
            label4.Text = "Password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(190, 249);
            label5.Name = "label5";
            label5.Size = new Size(107, 20);
            label5.TabIndex = 8;
            label5.Text = "NameSurname";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(190, 296);
            label6.Name = "label6";
            label6.Size = new Size(38, 20);
            label6.TabIndex = 10;
            label6.Text = "Mail";
            // 
            // btBack
            // 
            btBack.Location = new Point(139, 365);
            btBack.Name = "btBack";
            btBack.Size = new Size(158, 54);
            btBack.TabIndex = 12;
            btBack.Text = "Back";
            btBack.UseVisualStyleBackColor = true;
            btBack.Click += btBack_Click;
            // 
            // btSave
            // 
            btSave.Location = new Point(504, 365);
            btSave.Name = "btSave";
            btSave.Size = new Size(158, 54);
            btSave.TabIndex = 13;
            btSave.Text = "Save";
            btSave.UseVisualStyleBackColor = true;
            btSave.Click += btSave_Click;
            // 
            // txtId
            // 
            txtId.Location = new Point(319, 58);
            txtId.Name = "txtId";
            txtId.Size = new Size(199, 27);
            txtId.TabIndex = 14;
            // 
            // txtUserType
            // 
            txtUserType.Location = new Point(319, 105);
            txtUserType.Name = "txtUserType";
            txtUserType.Size = new Size(199, 27);
            txtUserType.TabIndex = 15;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(319, 152);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(199, 27);
            txtUserName.TabIndex = 16;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(319, 199);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(199, 27);
            txtPassword.TabIndex = 17;
            // 
            // txtNameSurname
            // 
            txtNameSurname.Location = new Point(319, 246);
            txtNameSurname.Name = "txtNameSurname";
            txtNameSurname.Size = new Size(199, 27);
            txtNameSurname.TabIndex = 18;
            // 
            // txtMail
            // 
            txtMail.Location = new Point(319, 293);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(199, 27);
            txtMail.TabIndex = 19;
            // 
            // addOrUpdateUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 475);
            Controls.Add(txtMail);
            Controls.Add(txtNameSurname);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            Controls.Add(txtUserType);
            Controls.Add(txtId);
            Controls.Add(btSave);
            Controls.Add(btBack);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "addOrUpdateUser";
            Text = "addOrUpdateUser";
            Load += addOrUpdateUser_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btBack;
        private Button btSave;
        private TextBox txtId;
        private TextBox txtUserType;
        private TextBox txtUserName;
        private TextBox txtPassword;
        private TextBox txtNameSurname;
        private TextBox txtMail;
    }
}