using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace _TTT_Game_Ubeydullah_Karatas {
    public partial class AdminPanel : Form {
        public AdminPanel() {
            InitializeComponent();
        }

        string fPath = System.IO.Directory.GetCurrentDirectory() + @"\";
        string fileName = "20201055";
        addOrUpdateUser addUpdateForm = new addOrUpdateUser();
        bool userSelecetion = false;
        bool isListed = false;

        private void btList_Click(object sender, EventArgs e) {
            isListed = true;
            DataSet dtSet = new DataSet();
            try {
                dtSet.ReadXml(fPath + $"{fileName}.xml");
                dGV.DataSource = dtSet.Tables[0];
            }
            catch {
                MessageBox.Show("File not found!");
            }
        }

        private void btAdd_Click(object sender, EventArgs e) {
            addUpdateForm.isAdmin = true;
            this.Hide();
            addUpdateForm.ShowDialog();
            this.Close();
        }

        private void btUpdate_Click(object sender, EventArgs e) {

            if (userSelecetion) {
                addUpdateForm.IsAdd = false;
                addUpdateForm.isAdmin = true;
                this.Hide();
                addUpdateForm.ShowDialog();
                this.Close();
            }
            else {
                MessageBox.Show("Please make a selection");
            }

        }

        private void dGV_CellClick(object sender, DataGridViewCellEventArgs e) {
            userSelecetion = true;

            int index = e.RowIndex;
            DataGridViewRow selectedRow = dGV.Rows[index];

            for (int i = 0; i < dGV.ColumnCount; i++) {
                if (!DBNull.Value.Equals(dGV.Rows[index].Cells[i].Value)) {
                    addUpdateForm.userDatas[i] = (string) dGV.Rows[index].Cells[i].Value;
                }
            }

        }

        private void btDelete_Click(object sender, EventArgs e) {

            if (txtDelete.Text == "") {
                MessageBox.Show("Please enter a 'User ID' for delete operation!");
                return;
            }
            else if (!isListed) {
                MessageBox.Show("Please list the users first!");
                return;
            }

            XmlDocument docX = new XmlDocument();
            docX.Load(fPath + $"{fileName}.xml");


            var node = docX.SelectSingleNode($"UserDatas/UserData[ID = '{txtDelete.Text}']");
            if (node == null) {
                MessageBox.Show("The user could not been found!");
                return;
            }

            if (node.ParentNode != null) {
                node.ParentNode.RemoveChild(node);
                docX.Save(fPath + $"{fileName}.xml");
            }

            txtDelete.Text = "";
            btList.PerformClick();
            MessageBox.Show("Succesfully deleted");


        }


    }
}
