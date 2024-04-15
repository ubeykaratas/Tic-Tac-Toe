namespace _TTT_Game_Ubeydullah_Karatas {
    partial class Game {
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
            lbWarning = new Label();
            btReset = new Button();
            bt9 = new Button();
            bt8 = new Button();
            bt7 = new Button();
            bt6 = new Button();
            bt5 = new Button();
            bt4 = new Button();
            bt3 = new Button();
            bt2 = new Button();
            bt1 = new Button();
            lbScore = new Label();
            lbInv = new Label();
            txtStudentNumber = new TextBox();
            btBack = new Button();
            SuspendLayout();
            // 
            // lbWarning
            // 
            lbWarning.AutoSize = true;
            lbWarning.BackColor = SystemColors.Control;
            lbWarning.ForeColor = SystemColors.Desktop;
            lbWarning.Location = new Point(201, 35);
            lbWarning.Name = "lbWarning";
            lbWarning.Size = new Size(0, 20);
            lbWarning.TabIndex = 27;
            // 
            // btReset
            // 
            btReset.Location = new Point(313, 433);
            btReset.Name = "btReset";
            btReset.Size = new Size(94, 29);
            btReset.TabIndex = 26;
            btReset.Text = "Reset";
            btReset.UseVisualStyleBackColor = true;
            btReset.Click += btReset_Click;
            // 
            // bt9
            // 
            bt9.BackgroundImageLayout = ImageLayout.Center;
            bt9.Location = new Point(368, 322);
            bt9.Name = "bt9";
            bt9.Size = new Size(75, 75);
            bt9.TabIndex = 25;
            bt9.UseVisualStyleBackColor = true;
            bt9.Click += bt9_Click;
            // 
            // bt8
            // 
            bt8.BackgroundImageLayout = ImageLayout.Center;
            bt8.Location = new Point(257, 322);
            bt8.Name = "bt8";
            bt8.Size = new Size(75, 75);
            bt8.TabIndex = 24;
            bt8.UseVisualStyleBackColor = true;
            bt8.Click += bt8_Click;
            // 
            // bt7
            // 
            bt7.BackgroundImageLayout = ImageLayout.Center;
            bt7.Location = new Point(148, 322);
            bt7.Name = "bt7";
            bt7.Size = new Size(75, 75);
            bt7.TabIndex = 23;
            bt7.UseVisualStyleBackColor = true;
            bt7.Click += bt7_Click;
            // 
            // bt6
            // 
            bt6.BackgroundImageLayout = ImageLayout.Center;
            bt6.Location = new Point(368, 205);
            bt6.Name = "bt6";
            bt6.Size = new Size(75, 75);
            bt6.TabIndex = 22;
            bt6.UseVisualStyleBackColor = true;
            bt6.Click += bt6_Click;
            // 
            // bt5
            // 
            bt5.AccessibleName = "";
            bt5.BackgroundImageLayout = ImageLayout.Center;
            bt5.Location = new Point(257, 205);
            bt5.Name = "bt5";
            bt5.Size = new Size(75, 75);
            bt5.TabIndex = 21;
            bt5.UseVisualStyleBackColor = true;
            bt5.Click += bt5_Click;
            // 
            // bt4
            // 
            bt4.BackgroundImageLayout = ImageLayout.Center;
            bt4.Location = new Point(148, 205);
            bt4.Name = "bt4";
            bt4.Size = new Size(75, 75);
            bt4.TabIndex = 20;
            bt4.UseVisualStyleBackColor = true;
            bt4.Click += bt4_Click;
            // 
            // bt3
            // 
            bt3.BackgroundImageLayout = ImageLayout.Center;
            bt3.Location = new Point(368, 96);
            bt3.Name = "bt3";
            bt3.Size = new Size(75, 75);
            bt3.TabIndex = 19;
            bt3.UseVisualStyleBackColor = true;
            bt3.Click += bt3_Click;
            // 
            // bt2
            // 
            bt2.BackgroundImageLayout = ImageLayout.Center;
            bt2.Location = new Point(257, 96);
            bt2.Name = "bt2";
            bt2.Size = new Size(75, 75);
            bt2.TabIndex = 18;
            bt2.UseVisualStyleBackColor = true;
            bt2.Click += bt2_Click;
            // 
            // bt1
            // 
            bt1.BackgroundImageLayout = ImageLayout.Center;
            bt1.Location = new Point(148, 96);
            bt1.Name = "bt1";
            bt1.Size = new Size(75, 75);
            bt1.TabIndex = 17;
            bt1.UseVisualStyleBackColor = true;
            bt1.Click += bt1_Click;
            // 
            // lbScore
            // 
            lbScore.AutoSize = true;
            lbScore.Location = new Point(471, 39);
            lbScore.Name = "lbScore";
            lbScore.Size = new Size(0, 20);
            lbScore.TabIndex = 16;
            // 
            // lbInv
            // 
            lbInv.AutoSize = true;
            lbInv.Location = new Point(416, 39);
            lbInv.Name = "lbInv";
            lbInv.Size = new Size(49, 20);
            lbInv.TabIndex = 15;
            lbInv.Text = "Score:";
            // 
            // txtStudentNumber
            // 
            txtStudentNumber.Location = new Point(34, 32);
            txtStudentNumber.Name = "txtStudentNumber";
            txtStudentNumber.Size = new Size(151, 27);
            txtStudentNumber.TabIndex = 14;
            txtStudentNumber.Text = "20201055";
            txtStudentNumber.TextChanged += txtStudentNumber_TextChanged;
            // 
            // btBack
            // 
            btBack.Location = new Point(179, 433);
            btBack.Name = "btBack";
            btBack.Size = new Size(94, 29);
            btBack.TabIndex = 28;
            btBack.Text = "Back";
            btBack.UseVisualStyleBackColor = true;
            btBack.Click += btBack_Click;
            // 
            // Game
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(566, 496);
            Controls.Add(btBack);
            Controls.Add(lbWarning);
            Controls.Add(btReset);
            Controls.Add(bt9);
            Controls.Add(bt8);
            Controls.Add(bt7);
            Controls.Add(bt6);
            Controls.Add(bt5);
            Controls.Add(bt4);
            Controls.Add(bt3);
            Controls.Add(bt2);
            Controls.Add(bt1);
            Controls.Add(lbScore);
            Controls.Add(lbInv);
            Controls.Add(txtStudentNumber);
            Name = "Game";
            Text = "Game";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbWarning;
        private Button btReset;
        private Button bt9;
        private Button bt8;
        private Button bt7;
        private Button bt6;
        private Button bt5;
        private Button bt4;
        private Button bt3;
        private Button bt2;
        private Button bt1;
        private Label lbScore;
        private Label lbInv;
        private TextBox txtStudentNumber;
        private Button btBack;
    }
}