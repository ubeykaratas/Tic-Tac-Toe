namespace _TTT_Game_Ubeydullah_Karatas {
    partial class AdminPanel {
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
            dGV = new DataGridView();
            btList = new Button();
            btAdd = new Button();
            btUpdate = new Button();
            btDelete = new Button();
            txtDelete = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dGV).BeginInit();
            SuspendLayout();
            // 
            // dGV
            // 
            dGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGV.Location = new Point(12, 12);
            dGV.Name = "dGV";
            dGV.ReadOnly = true;
            dGV.RowHeadersWidth = 51;
            dGV.RowTemplate.Height = 29;
            dGV.Size = new Size(776, 203);
            dGV.TabIndex = 0;
            dGV.CellClick += dGV_CellClick;
            // 
            // btList
            // 
            btList.Location = new Point(59, 275);
            btList.Name = "btList";
            btList.Size = new Size(127, 50);
            btList.TabIndex = 1;
            btList.Text = "List";
            btList.UseVisualStyleBackColor = true;
            btList.Click += btList_Click;
            // 
            // btAdd
            // 
            btAdd.Location = new Point(329, 275);
            btAdd.Name = "btAdd";
            btAdd.Size = new Size(127, 50);
            btAdd.TabIndex = 2;
            btAdd.Text = "Add";
            btAdd.UseVisualStyleBackColor = true;
            btAdd.Click += btAdd_Click;
            // 
            // btUpdate
            // 
            btUpdate.Location = new Point(599, 275);
            btUpdate.Name = "btUpdate";
            btUpdate.Size = new Size(127, 50);
            btUpdate.TabIndex = 3;
            btUpdate.Text = "Update";
            btUpdate.UseVisualStyleBackColor = true;
            btUpdate.Click += btUpdate_Click;
            // 
            // btDelete
            // 
            btDelete.Location = new Point(553, 365);
            btDelete.Name = "btDelete";
            btDelete.Size = new Size(127, 50);
            btDelete.TabIndex = 4;
            btDelete.Text = "Delete";
            btDelete.UseVisualStyleBackColor = true;
            btDelete.Click += btDelete_Click;
            // 
            // txtDelete
            // 
            txtDelete.Location = new Point(352, 377);
            txtDelete.Name = "txtDelete";
            txtDelete.Size = new Size(176, 27);
            txtDelete.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 380);
            label1.Name = "label1";
            label1.Size = new Size(293, 20);
            label1.TabIndex = 6;
            label1.Text = "Silmek istediğiniz kulanıcının id'sini giriniz: ";
            // 
            // AdminPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(txtDelete);
            Controls.Add(btDelete);
            Controls.Add(btUpdate);
            Controls.Add(btAdd);
            Controls.Add(btList);
            Controls.Add(dGV);
            Name = "AdminPanel";
            Text = "AdminPanel";
            ((System.ComponentModel.ISupportInitialize)dGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dGV;
        private Button btList;
        private Button btAdd;
        private Button btUpdate;
        private Button btDelete;
        private TextBox txtDelete;
        private Label label1;
    }
}