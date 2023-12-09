using InventorySystemProject.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventorySystemProject
{
    public partial class mdiMainMenu : Form
    {
        private int childFormNumber = 0;

        public ToolStripStatusLabel StatusStripLabel
        { get { return lblAccessStatusMDI; } set { lblAccessStatusMDI = value; } }

        public mdiMainMenu()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = null;
            object tag = ((ToolStripMenuItem)sender).Tag;
            switch (tag.ToString())
            {
                case "Employees":
                    childForm = new Employees();
                    break;
                case "Products":
                    childForm = new Products();
                    break;
                case "Inventory":
                    childForm = new InventoryLogs();
                    break;
                case "About":
                    childForm = new About();
                    break;
                case "Browse":
                    childForm = new frmDataGridViews();
                    break;
            }

            if (childForm != null)
            {
                foreach (Form f in this.MdiChildren)
                {
                    if (f.GetType() == childForm.GetType())
                    {
                        f.Activate();
                        return;
                    }
                }

                childForm.MdiParent = this;
                childForm.Show();
            }
        }

        #region [Auto-Generated]

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        #endregion

        private void mdiMainMenu_Load(object sender, EventArgs e)
        {
            Login loginForm = new();

            loginForm.StartPosition = FormStartPosition.CenterParent;

            DialogResult result = loginForm.ShowDialog();

            string userAccess = GlobalData.userAccess;
            lblAccessStatusMDI.Text = $"User Logged in as : {userAccess}";

            if (result == DialogResult.OK)
            {
                MessageBox.Show("LOGIN APPROVED!");

            }
            else if (result == DialogResult.Cancel)
            {
                //MessageBox.Show("Canceled");
                this.Close();

            }
            else if (result == DialogResult.Abort)
            {
                MessageBox.Show("ACCESS DENIED!");
                this.Close();
            }
        }

        public void updateLabels(string txtStatus, string? txtStatus2)
        {
            lblRecordStatusMDI.Text = txtStatus;
            lblStockStatusMDI.Text = txtStatus2;
        }
    }
}
