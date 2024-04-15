namespace _TTT_Game_Ubeydullah_Karatas {
    partial class userInterface {
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
            btLevel = new Button();
            btAdminPanel = new Button();
            btGame = new Button();
            SuspendLayout();
            // 
            // btLevel
            // 
            btLevel.Location = new Point(58, 129);
            btLevel.Name = "btLevel";
            btLevel.Size = new Size(144, 64);
            btLevel.TabIndex = 0;
            btLevel.Text = "Difficulty Level";
            btLevel.UseVisualStyleBackColor = true;
            btLevel.Click += btLevel_Click;
            // 
            // btAdminPanel
            // 
            btAdminPanel.Enabled = false;
            btAdminPanel.Location = new Point(320, 129);
            btAdminPanel.Name = "btAdminPanel";
            btAdminPanel.Size = new Size(144, 64);
            btAdminPanel.TabIndex = 1;
            btAdminPanel.Text = "Admin Panel";
            btAdminPanel.UseVisualStyleBackColor = true;
            btAdminPanel.Visible = false;
            btAdminPanel.Click += btAdminPanel_Click;
            // 
            // btGame
            // 
            btGame.Location = new Point(582, 131);
            btGame.Name = "btGame";
            btGame.Size = new Size(145, 62);
            btGame.TabIndex = 2;
            btGame.Text = "New Game";
            btGame.UseVisualStyleBackColor = true;
            btGame.Click += btGame_Click;
            // 
            // userInterface
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 334);
            Controls.Add(btAdminPanel);
            Controls.Add(btLevel);
            Controls.Add(btGame);
            Name = "userInterface";
            Text = "userInterface";
            Load += userInterface_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btLevel;
        private Button btAdminPanel;
        private Button btGame;
    }
}