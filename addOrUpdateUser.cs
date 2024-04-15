using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace _TTT_Game_Ubeydullah_Karatas {
    public partial class addOrUpdateUser : Form {
        public addOrUpdateUser() {
            InitializeComponent();
        }

        public string[] userDatas = new string[6];
        public bool isAdmin = false;
        string fPath = System.IO.Directory.GetCurrentDirectory() + @"\";
        string fileName = "20201055";

        public bool IsAdd = true;

        private void addOrUpdateUser_Load(object sender, EventArgs e) {
            if (!IsAdd) {
                txtId.Text = userDatas[0];
                txtUserType.Text = userDatas[1];
                txtUserName.Text = userDatas[2];
                txtPassword.Text = userDatas[3];
                txtNameSurname.Text = userDatas[4];
                txtMail.Text = userDatas[5];
            }
        }

        private void btSave_Click(object sender, EventArgs e) {
            XDocument doc;
            try {
                doc = XDocument.Load(fPath + $"{fileName}.xml");

            }
            catch {
                doc = new XDocument();
            }

            if (IsAdd) {
                if (doc.Root != null) {
                    doc.Root.Add(
                        new XElement("UserData",
                            new XElement("ID", txtId.Text),
                            new XElement("UserType", txtUserType.Text),
                            new XElement("UserName", txtUserName.Text),
                            new XElement("Password", txtPassword.Text),
                            new XElement("NameSurname", txtNameSurname.Text),
                            new XElement("Mail", txtMail.Text)
                        )
                    );
                }
                else {
                    doc.Add(
                        new XElement("UserDatas",
                            new XElement("UserData",
                                new XElement("ID", txtId.Text),
                                new XElement("UserType", txtUserType.Text),
                                new XElement("UserName", txtUserName.Text),
                                new XElement("Password", txtPassword.Text),
                                new XElement("NameSurname", txtNameSurname.Text),
                                new XElement("Mail", txtMail.Text)
                             )
                        )
                    );
                }
                doc.Save(fPath + $"{fileName}.xml", SaveOptions.None);

            }
            else {
                XmlDocument docX = new XmlDocument();
                docX.Load(fPath + $"{fileName}.xml");

                var node = docX.SelectSingleNode($"UserDatas/UserData[ID = '{userDatas[0]}']");


                if (node != null) {
                    node.RemoveAll();

                    updateElement(docX, node, "ID", txtId.Text);
                    updateElement(docX, node, "UserType", txtUserType.Text);
                    updateElement(docX, node, "UserName", txtUserName.Text);
                    updateElement(docX, node, "Password", txtPassword.Text);
                    updateElement(docX, node, "NameSurname", txtNameSurname.Text);
                    updateElement(docX, node, "Mail", txtMail.Text);

                    docX.Save(fPath + $"{fileName}.xml");
                }

            }

            MessageBox.Show("Succesfully Saved!");
            if (IsAdd) {
                txtId.Text = "";
                txtUserType.Text = "";
                txtUserName.Text = "";
                txtPassword.Text = "";
                txtNameSurname.Text = "";
                txtMail.Text = "";
            }
        }

        private void btBack_Click(object sender, EventArgs e) {

            if (isAdmin) {
                AdminPanel adminPanelForm = new AdminPanel();
                this.Hide();
                adminPanelForm.ShowDialog();
                this.Close();
            }
            else {
                Form1 logInScreen = new Form1();
                this.Hide();
                logInScreen.ShowDialog();
                this.Close();
            }
        }

        private void updateElement(XmlDocument doc, XmlNode node, string str, string data) {
            XmlElement newElement = doc.CreateElement(str);
            newElement.InnerText = data;
            node.AppendChild(newElement);
        }



    }
}
