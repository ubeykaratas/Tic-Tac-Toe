using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _TTT_Game_Ubeydullah_Karatas {
    public partial class userInterface : Form {

        public string signInType = "";

        public userInterface() {
            InitializeComponent();
        }

        private void userInterface_Load(object sender, EventArgs e) {
            if (signInType == "admin") {
                btAdminPanel.Visible = true;
                btAdminPanel.Enabled = true;
            }
        }

        private void btLevel_Click(object sender, EventArgs e) {
            this.Hide();
            DifficultyLevel diffForm = new DifficultyLevel();
            diffForm.ShowDialog();
            this.Close();
        }

        private void btAdminPanel_Click(object sender, EventArgs e) {
            this.Hide();
            AdminPanel adminForm = new AdminPanel();
            adminForm.ShowDialog();
            this.Close();
        }

        private void btGame_Click(object sender, EventArgs e) {
            this.Hide();
            Game gameForm = new Game();
            gameForm.signInType = this.signInType;
            gameForm.ShowDialog();
            this.Close();
        }

        
    }
}
