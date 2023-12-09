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
            dataGridView1 = new DataGridView();
            menuStrip1 = new MenuStrip();
            mnuGridEmployees = new ToolStripMenuItem();
            productsToolStripMenuItem = new ToolStripMenuItem();
            inventoryLogsToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 24);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(800, 426);
            dataGridView1.TabIndex = 1;
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
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmDataGridViews";
            Text = "Browse Table";
            Load += frmDataGridViews_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuGridEmployees;
        private ToolStripMenuItem productsToolStripMenuItem;
        private ToolStripMenuItem inventoryLogsToolStripMenuItem;
    }
}