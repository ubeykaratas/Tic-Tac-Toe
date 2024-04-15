using System.Data;
using System.Xml;

namespace _TTT_Game_Ubeydullah_Karatas {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        addOrUpdateUser addUpdateForm = new addOrUpdateUser();
        string fPath = System.IO.Directory.GetCurrentDirectory() + @"\";
        string fileName = "20201055";

        private void Form1_Load(object sender, EventArgs e) {
            if (Properties.Settings.Default.UserName != string.Empty) {
                txtUsername.Text = Properties.Settings.Default.UserName;
                txtPassword.Text = Properties.Settings.Default.Password;
            }

            chRemember.Checked = txtUsername.Text != "" && txtPassword.Text != "" ? true : false;
        }

        private void btLogin_Click(object sender, EventArgs e) {
            string logInType = "";
            bool isLoginSuccess = false;

            XmlDocument xmlDoc = new XmlDocument();
            try {
                xmlDoc.Load(fPath + $"{fileName}.xml");
            }
            catch {
                MessageBox.Show("File not found!");
                return;
            }

            if (xmlDoc.DocumentElement != null) {
                foreach (XmlNode node in xmlDoc.DocumentElement) {

                    logInType = node.ChildNodes[1]?.FirstChild?.Value?.ToString().ToLower() ?? "";
                    if ((txtUsername.Text == (node.ChildNodes[2]?.FirstChild?.Value?.ToString() ?? "")) && (txtPassword.Text == (node.ChildNodes[3]?.FirstChild?.Value?.ToString() ?? ""))) {
                        isLoginSuccess = true;
                        break;
                    }
                }
            }

            if (isLoginSuccess && logInType != null && logInType != "") {
                userInterface userForm = new userInterface();
                userForm.signInType = logInType;

                if (chRemember.Checked && isLoginSuccess) {
                    Properties.Settings.Default.UserName = txtUsername.Text;
                    Properties.Settings.Default.Password = txtPassword.Text;
                }
                else if (isLoginSuccess) {
                    Properties.Settings.Default.UserName = "";
                    Properties.Settings.Default.Password = "";
                }
                Properties.Settings.Default.Save();

                this.Hide();
                userForm.ShowDialog();
                this.Close();
            }
            else {
                lbWarning.Visible = true;
                lbWarning.Text = "Please check your information";
                lbWarning.ForeColor = Color.Red;
            }

        }

        private void btRegister_Click(object sender, EventArgs e) {
            this.Hide();
            addUpdateForm.ShowDialog();
            this.Close();
        }

        private void chShowPassword_CheckedChanged(object sender, EventArgs e) {
            txtPassword.UseSystemPasswordChar = txtPassword.UseSystemPasswordChar ? false : true;
        }


    }
}