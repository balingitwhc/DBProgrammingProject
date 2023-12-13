namespace InventorySystemProject.Forms
{
    partial class frmDataGridViews
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvOverview = new DataGridView();
            menuStrip1 = new MenuStrip();
            mnuGridEmployees = new ToolStripMenuItem();
            productsToolStripMenuItem = new ToolStripMenuItem();
            inventoryLogsToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dgvOverview).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvOverview
            // 
            dgvOverview.AllowUserToAddRows = false;
            dgvOverview.AllowUserToDeleteRows = false;
            dgvOverview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOverview.Dock = DockStyle.Fill;
            dgvOverview.Location = new Point(0, 24);
            dgvOverview.Name = "dgvOverview";
            dgvOverview.RowTemplate.Height = 25;
            dgvOverview.Size = new Size(800, 426);
            dgvOverview.TabIndex = 1;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuGridEmployees, productsToolStripMenuItem, inventoryLogsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // mnuGridEmployees
            // 
            mnuGridEmployees.Name = "mnuGridEmployees";
            mnuGridEmployees.Size = new Size(76, 20);
            mnuGridEmployees.Tag = "Employees";
            mnuGridEmployees.Text = "&Employees";
            mnuGridEmployees.Click += GridUpdate;
            // 
            // productsToolStripMenuItem
            // 
            productsToolStripMenuItem.AccessibleDescription = "mnuGridProducts";
            productsToolStripMenuItem.Name = "productsToolStripMenuItem";
            productsToolStripMenuItem.Size = new Size(66, 20);
            productsToolStripMenuItem.Tag = "Products";
            productsToolStripMenuItem.Text = "&Products";
            productsToolStripMenuItem.Click += GridUpdate;
            // 
            // inventoryLogsToolStripMenuItem
            // 
            inventoryLogsToolStripMenuItem.AccessibleDescription = "mnuGridInventoryLogs";
            inventoryLogsToolStripMenuItem.Name = "inventoryLogsToolStripMenuItem";
            inventoryLogsToolStripMenuItem.Size = new Size(97, 20);
            inventoryLogsToolStripMenuItem.Tag = "Inventory";
            inventoryLogsToolStripMenuItem.Text = "&Inventory Logs";
            inventoryLogsToolStripMenuItem.Click += GridUpdate;
            // 
            // frmDataGridViews
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvOverview);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmDataGridViews";
            Text = "Browse Table";
            Load += frmDataGridViews_Load;
            ((System.ComponentModel.ISupportInitialize)dgvOverview).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvOverview;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuGridEmployees;
        private ToolStripMenuItem productsToolStripMenuItem;
        private ToolStripMenuItem inventoryLogsToolStripMenuItem;
    }
}