﻿using System;
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

        public mdiMainMenu()
        {
            InitializeComponent();
        }

        public ToolStripStatusLabel StatusStripLabel
        {
            get { return lblStatusMDI; }
            set { lblStatusMDI = value; }
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = null;
            ToolStripMenuItem m = (ToolStripMenuItem)sender;

            switch (m.Tag)
            {
                case "mnuMaintenanceEmployee":
                    lblStatusMDI.Text = "Employee Form Loaded...";
                    childForm = new frmEmployees();
                    break;
                case "mnuMaintenanceProduct":
                    lblStatusMDI.Text = "Product Form Loaded...";
                    childForm = new frmProducts();
                    break;
                case "mnuMaintenanceInventory":
                    lblStatusMDI.Text = "Inventory Form Loaded...";
                    childForm = new frmInventoryLogs();
                    break;
                default:
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
                //childForm.Text = "Window " + childFormNumber++;
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
    }
}
