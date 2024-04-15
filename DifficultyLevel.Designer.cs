namespace _TTT_Game_Ubeydullah_Karatas {
    partial class DifficultyLevel {
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
            btEasy = new Button();
            btMed = new Button();
            btHard = new Button();
            SuspendLayout();
            // 
            // btEasy
            // 
            btEasy.Location = new Point(80, 150);
            btEasy.Name = "btEasy";
            btEasy.Size = new Size(150, 60);
            btEasy.TabIndex = 0;
            btEasy.Text = "Easy";
            btEasy.UseVisualStyleBackColor = true;
            btEasy.Click += btEasy_Click;
            // 
            // btMed
            // 
            btMed.Location = new Point(315, 150);
            btMed.Name = "btMed";
            btMed.Size = new Size(150, 60);
            btMed.TabIndex = 1;
            btMed.Text = "Medium";
            btMed.UseVisualStyleBackColor = true;
            btMed.Click += btMed_Click;
            // 
            // btHard
            // 
            btHard.Location = new Point(550, 150);
            btHard.Name = "btHard";
            btHard.Size = new Size(150, 60);
            btHard.TabIndex = 2;
            btHard.Text = "Hard";
            btHard.UseVisualStyleBackColor = true;
            btHard.Click += btHard_Click;
            // 
            // DifficultyLevel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 353);
            Controls.Add(btHard);
            Controls.Add(btMed);
            Controls.Add(btEasy);
            Name = "DifficultyLevel";
            Text = "DifficultyLevel";
            ResumeLayout(false);
        }

        #endregion

        private Button btEasy;
        private Button btMed;
        private Button btHard;
    }
}