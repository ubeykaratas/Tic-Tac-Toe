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
    public partial class DifficultyLevel : Form {
        public DifficultyLevel() {
            InitializeComponent();
        }

        private void btEasy_Click(object sender, EventArgs e) {
            this.Hide();
            Game gameForm = new Game();
            gameForm.ShowDialog();
            this.Close();
        }

        private void btMed_Click(object sender, EventArgs e) {
            this.Hide();
            MidGame midGameForm = new MidGame();
            midGameForm.ShowDialog();
            this.Close();
        }

        private void btHard_Click(object sender, EventArgs e) {
            this.Hide();
            HardGame hardGameForm = new HardGame();
            hardGameForm.ShowDialog();
            this.Close();
        }
    }
}
