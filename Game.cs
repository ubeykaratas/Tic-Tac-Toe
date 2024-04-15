﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _TTT_Game_Ubeydullah_Karatas {
    public partial class Game : Form {
        public Game() {
            InitializeComponent();
        }

        public string signInType = "";

        private string fPath = System.IO.Directory.GetCurrentDirectory() + @"\";
        private const int howManySquare = 9;

        private void bt1_Click(object sender, EventArgs e) {
            userPlay(bt1);
            if (CheckWin()) {
                MessageBox.Show("Player Win!");
                endGame();
                return;
            }
            compPlay();
            if (CheckWin()) {
                MessageBox.Show("Computer Win!");
                endGame();
                return;
            }

        }

        private void bt2_Click(object sender, EventArgs e) {
            userPlay(bt2);
            if (CheckWin()) {
                MessageBox.Show("Player Win!");
                endGame();
                return;
            }
            compPlay();
            if (CheckWin()) {
                MessageBox.Show("Computer Win!");
                endGame();
                return;
            }
        }

        private void bt3_Click(object sender, EventArgs e) {
            userPlay(bt3);
            if (CheckWin()) {
                MessageBox.Show("Player Win!");
                endGame();
                return;
            }
            compPlay();
            if (CheckWin()) {
                MessageBox.Show("Computer Win!");
                endGame();
                return;
            }
        }

        private void bt4_Click(object sender, EventArgs e) {
            userPlay(bt4);
            if (CheckWin()) {
                MessageBox.Show("Player Win!");
                endGame();
                return;
            }
            compPlay();
            if (CheckWin()) {
                MessageBox.Show("Computer Win!");
                endGame();
                return;
            }
        }

        private void bt5_Click(object sender, EventArgs e) {
            userPlay(bt5);
            if (CheckWin()) {
                MessageBox.Show("Player Win!");
                endGame();
                return;
            }
            compPlay();
            if (CheckWin()) {
                MessageBox.Show("Computer Win!");
                endGame();
                return;
            }
        }

        private void bt6_Click(object sender, EventArgs e) {
            userPlay(bt6);
            if (CheckWin()) {
                MessageBox.Show("Player Win!");
                endGame();
                return;
            }
            compPlay();
            if (CheckWin()) {
                MessageBox.Show("Computer Win!");
                endGame();
                return;
            }
        }

        private void bt7_Click(object sender, EventArgs e) {
            userPlay(bt7);
            if (CheckWin()) {
                MessageBox.Show("Player Win!");
                endGame();
                return;
            }
            compPlay();
            if (CheckWin()) {
                MessageBox.Show("Computer Win!");
                endGame();
                return;
            }
        }

        private void bt8_Click(object sender, EventArgs e) {
            userPlay(bt8);
            if (CheckWin()) {
                MessageBox.Show("Player Win!");
                endGame();
                return;
            }
            compPlay();
            if (CheckWin()) {
                MessageBox.Show("Computer Win!");
                endGame();
                return;
            }
        }

        private void bt9_Click(object sender, EventArgs e) {
            userPlay(bt9);
            if (CheckWin()) {
                MessageBox.Show("Player Win!");
                endGame();
                return;
            }
            compPlay();
            if (CheckWin()) {
                MessageBox.Show("Computer Win!");
                endGame();
                return;
            }
        }

        private void userPlay(Button userBt) {
            if (userBt.Enabled) {
                userBt.BackgroundImage = Image.FromFile(fPath + "X.png");
                userBt.Enabled = false;
                userBt.AccessibleName = "x";
            }
        }

        private void compPlay() {
            for (int i = 1; i <= howManySquare; i++) {
                Button currentButton = (Button)Controls["bt" + i];
                if (currentButton.Enabled) {
                    currentButton.BackgroundImage = Image.FromFile(fPath + "O.png");
                    currentButton.AccessibleName = "o";
                    if (CheckWin()) {
                        currentButton.BackgroundImage = Image.FromFile(fPath + "O.png");
                        currentButton.AccessibleName = "o";
                        currentButton.Enabled = false;
                        endGame();
                        return;
                    }
                    currentButton.BackgroundImage = null;
                    currentButton.AccessibleName = null;
                    currentButton.Enabled = true;
                }
            }

            for (int i = 1; i <= howManySquare; i++) {
                Button currentButton = (Button)Controls["bt" + i];
                if (currentButton.Enabled) {
                    currentButton.BackgroundImage = Image.FromFile(fPath + "X.png");
                    currentButton.AccessibleName = "x";
                    if (CheckWin()) {
                        currentButton.BackgroundImage = Image.FromFile(fPath + "O.png");
                        currentButton.AccessibleName = "o";
                        currentButton.Enabled = false;
                        return;
                    }
                    currentButton.BackgroundImage = null;
                    currentButton.AccessibleName = null;
                    currentButton.Enabled = true;
                }
            }

            if (!checkIfAllBoxesFilled()) {
                Random rand = new Random();
                int randomIndex;
                do {
                    randomIndex = rand.Next(1, howManySquare + 1);
                    Button currentButton = (Button)Controls["bt" + randomIndex];
                    if (currentButton.Enabled) {
                        currentButton.BackgroundImage = Image.FromFile(fPath + "O.png");
                        currentButton.AccessibleName = "o";
                        currentButton.Enabled = false;
                        break;
                    }
                } while (true);
            }


        }

        private bool checkIfAllBoxesFilled() {
            for (int i = 1; i <= howManySquare; i++) {
                Button currentButton = (Button)Controls["bt" + i];
                if (currentButton.Enabled) {
                    return false;
                }
            }
            return true;
        }

        private bool CheckWin() {
            // Check horizontal lines
            if ((bt1.AccessibleName == bt2.AccessibleName) && (bt2.AccessibleName == bt3.AccessibleName) && (bt1.AccessibleName != null))
                return true;
            if ((bt4.AccessibleName == bt5.AccessibleName) && (bt5.AccessibleName == bt6.AccessibleName) && (bt4.AccessibleName != null))
                return true;
            if ((bt7.AccessibleName == bt8.AccessibleName) && (bt8.AccessibleName == bt9.AccessibleName) && (bt7.AccessibleName != null))
                return true;

            // Check vertical lines
            if ((bt1.AccessibleName == bt4.AccessibleName) && (bt4.AccessibleName == bt7.AccessibleName) && (bt1.AccessibleName != null))
                return true;
            if ((bt2.AccessibleName == bt5.AccessibleName) && (bt5.AccessibleName == bt8.AccessibleName) && (bt2.AccessibleName != null))
                return true;
            if ((bt3.AccessibleName == bt6.AccessibleName) && (bt6.AccessibleName == bt9.AccessibleName) && (bt3.AccessibleName != null))
                return true;

            // Check diagonal lines
            if ((bt1.AccessibleName == bt5.AccessibleName) && (bt5.AccessibleName == bt9.AccessibleName) && (bt1.AccessibleName != null))
                return true;
            if ((bt3.AccessibleName == bt5.AccessibleName) && (bt5.AccessibleName == bt7.AccessibleName) && (bt3.AccessibleName != null))
                return true;

            return false;
        }

        private void startGame() {
            for (int i = 1; i <= howManySquare; i++) {
                Button currentButton = (Button)Controls["bt" + i];
                currentButton.Enabled = true;
            }
        }

        private void endGame() {
            for (int i = 1; i <= howManySquare; i++) {
                Button currentButton = (Button)Controls["bt" + i];
                currentButton.Enabled = false;
            }
        }

        private void btReset_Click(object sender, EventArgs e) {

            for (int i = 1; i <= howManySquare; i++) {
                Button currentButton = (Button)Controls["bt" + i];
                currentButton.BackgroundImage = null;
                currentButton.AccessibleName = null;
                currentButton.Enabled = true;
            }
        }

        private void txtStudentNumber_TextChanged(object sender, EventArgs e) {
            if (!IsValidStudentNumber(txtStudentNumber.Text)) lbScore.Text = "";
        }

        private bool IsValidStudentNumber(string studentNumber) {
            int stNumber;
            if (txtStudentNumber.Text.Length != 8) {
                lbWarning.Visible = true;
                lbWarning.Text = "Number must be 8 digit";
            }
            else if (!int.TryParse(txtStudentNumber.Text, out stNumber)) {
                lbWarning.Visible = true;
                lbWarning.Text = "Invalid Number";
            }
            else {
                lbWarning.Visible = false;
                return true;
            }

            return false;
        }

        private void btBack_Click(object sender, EventArgs e) {
            if (this.signInType != "") {
                this.Hide();
                userInterface interfaceForm = new userInterface();
                interfaceForm.signInType = this.signInType;
                interfaceForm.ShowDialog();
                this.Close();
            }
            else {
                this.Hide();
                DifficultyLevel diffForm = new DifficultyLevel();
                diffForm.ShowDialog();
                this.Close();
            }
        }
    }
}
