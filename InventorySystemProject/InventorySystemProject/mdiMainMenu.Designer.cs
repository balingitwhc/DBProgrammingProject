namespace InventorySystemProject
{
    partial class mdiMainMenu
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mdiMainMenu));
            mnuStrip = new MenuStrip();
            maintenanceToolStripMenuItem = new ToolStripMenuItem();
            employeesToolStripMenuItem = new ToolStripMenuItem();
            productsToolStripMenuItem = new ToolStripMenuItem();
            inventoryToolStripMenuItem = new ToolStripMenuItem();
            viewMenu = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            logsToolStripMenuItem = new ToolStripMenuItem();
            productsToolStripMenuItem1 = new ToolStripMenuItem();
            logsToolStripMenuItem1 = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            statusBarToolStripMenuItem = new ToolStripMenuItem();
            windowsMenu = new ToolStripMenuItem();
            newWindowToolStripMenuItem = new ToolStripMenuItem();
            cascadeToolStripMenuItem = new ToolStripMenuItem();
            tileVerticalToolStripMenuItem = new ToolStripMenuItem();
            tileHorizontalToolStripMenuItem = new ToolStripMenuItem();
            closeAllToolStripMenuItem = new ToolStripMenuItem();
            arrangeIconsToolStripMenuItem = new ToolStripMenuItem();
            helpMenu = new ToolStripMenuItem();
            contentsToolStripMenuItem = new ToolStripMenuItem();
            indexToolStripMenuItem = new ToolStripMenuItem();
            searchToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator8 = new ToolStripSeparator();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            statusStrip = new StatusStrip();
            lblStatusMDI = new ToolStripStatusLabel();
            toolTip = new ToolTip(components);
            dgvMain = new DataGridView();
            mnuStrip.SuspendLayout();
            statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMain).BeginInit();
            SuspendLayout();
            // 
            // mnuStrip
            // 
            mnuStrip.Items.AddRange(new ToolStripItem[] { maintenanceToolStripMenuItem, viewMenu, windowsMenu, helpMenu });
            mnuStrip.Location = new Point(0, 0);
            mnuStrip.MdiWindowListItem = windowsMenu;
            mnuStrip.Name = "mnuStrip";
            mnuStrip.Padding = new Padding(7, 2, 0, 2);
            mnuStrip.Size = new Size(1264, 24);
            mnuStrip.TabIndex = 0;
            mnuStrip.Text = "MenuStrip";
            // 
            // maintenanceToolStripMenuItem
            // 
            maintenanceToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { employeesToolStripMenuItem, productsToolStripMenuItem, inventoryToolStripMenuItem });
            maintenanceToolStripMenuItem.Name = "maintenanceToolStripMenuItem";
            maintenanceToolStripMenuItem.Size = new Size(88, 20);
            maintenanceToolStripMenuItem.Tag = "";
            maintenanceToolStripMenuItem.Text = "&Maintenance";
            // 
            // employeesToolStripMenuItem
            // 
            employeesToolStripMenuItem.Name = "employeesToolStripMenuItem";
            employeesToolStripMenuItem.Size = new Size(180, 22);
            employeesToolStripMenuItem.Tag = "mnuMaintenanceEmployee";
            employeesToolStripMenuItem.Text = "&Employees";
            employeesToolStripMenuItem.Click += ShowNewForm;
            // 
            // productsToolStripMenuItem
            // 
            productsToolStripMenuItem.Name = "productsToolStripMenuItem";
            productsToolStripMenuItem.Size = new Size(180, 22);
            productsToolStripMenuItem.Tag = "mnuMaintenanceProduct";
            productsToolStripMenuItem.Text = "&Products";
            productsToolStripMenuItem.Click += ShowNewForm;
            // 
            // inventoryToolStripMenuItem
            // 
            inventoryToolStripMenuItem.Name = "inventoryToolStripMenuItem";
            inventoryToolStripMenuItem.Size = new Size(180, 22);
            inventoryToolStripMenuItem.Tag = "mnuMaintenanceInventory";
            inventoryToolStripMenuItem.Text = "&Inventory";
            inventoryToolStripMenuItem.Click += ShowNewForm;
            // 
            // viewMenu
            // 
            viewMenu.DropDownItems.AddRange(new ToolStripItem[] { toolStripSeparator1, logsToolStripMenuItem, productsToolStripMenuItem1, logsToolStripMenuItem1, toolStripSeparator2, statusBarToolStripMenuItem });
            viewMenu.Name = "viewMenu";
            viewMenu.Size = new Size(44, 20);
            viewMenu.Text = "&View";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(177, 6);
            // 
            // logsToolStripMenuItem
            // 
            logsToolStripMenuItem.Name = "logsToolStripMenuItem";
            logsToolStripMenuItem.Size = new Size(180, 22);
            logsToolStripMenuItem.Tag = "mnuViewEmployees";
            logsToolStripMenuItem.Text = "E&mployees";
            // 
            // productsToolStripMenuItem1
            // 
            productsToolStripMenuItem1.Name = "productsToolStripMenuItem1";
            productsToolStripMenuItem1.Size = new Size(180, 22);
            productsToolStripMenuItem1.Tag = "mnuViewProducts";
            productsToolStripMenuItem1.Text = "P&roducts";
            // 
            // logsToolStripMenuItem1
            // 
            logsToolStripMenuItem1.Name = "logsToolStripMenuItem1";
            logsToolStripMenuItem1.Size = new Size(180, 22);
            logsToolStripMenuItem1.Tag = "mnuViewInventoryLogs";
            logsToolStripMenuItem1.Text = "I&nventory Logs";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(177, 6);
            // 
            // statusBarToolStripMenuItem
            // 
            statusBarToolStripMenuItem.Checked = true;
            statusBarToolStripMenuItem.CheckOnClick = true;
            statusBarToolStripMenuItem.CheckState = CheckState.Checked;
            statusBarToolStripMenuItem.Name = "statusBarToolStripMenuItem";
            statusBarToolStripMenuItem.Size = new Size(180, 22);
            statusBarToolStripMenuItem.Text = "&Status Bar";
            statusBarToolStripMenuItem.Click += StatusBarToolStripMenuItem_Click;
            // 
            // windowsMenu
            // 
            windowsMenu.DropDownItems.AddRange(new ToolStripItem[] { newWindowToolStripMenuItem, cascadeToolStripMenuItem, tileVerticalToolStripMenuItem, tileHorizontalToolStripMenuItem, closeAllToolStripMenuItem, arrangeIconsToolStripMenuItem });
            windowsMenu.Name = "windowsMenu";
            windowsMenu.Size = new Size(68, 20);
            windowsMenu.Text = "&Windows";
            // 
            // newWindowToolStripMenuItem
            // 
            newWindowToolStripMenuItem.Name = "newWindowToolStripMenuItem";
            newWindowToolStripMenuItem.Size = new Size(150, 22);
            newWindowToolStripMenuItem.Text = "&New Window";
            newWindowToolStripMenuItem.Click += ShowNewForm;
            // 
            // cascadeToolStripMenuItem
            // 
            cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
            cascadeToolStripMenuItem.Size = new Size(150, 22);
            cascadeToolStripMenuItem.Text = "&Cascade";
            cascadeToolStripMenuItem.Click += CascadeToolStripMenuItem_Click;
            // 
            // tileVerticalToolStripMenuItem
            // 
            tileVerticalToolStripMenuItem.Name = "tileVerticalToolStripMenuItem";
            tileVerticalToolStripMenuItem.Size = new Size(150, 22);
            tileVerticalToolStripMenuItem.Text = "Tile &Vertical";
            tileVerticalToolStripMenuItem.Click += TileVerticalToolStripMenuItem_Click;
            // 
            // tileHorizontalToolStripMenuItem
            // 
            tileHorizontalToolStripMenuItem.Name = "tileHorizontalToolStripMenuItem";
            tileHorizontalToolStripMenuItem.Size = new Size(150, 22);
            tileHorizontalToolStripMenuItem.Text = "Tile &Horizontal";
            tileHorizontalToolStripMenuItem.Click += TileHorizontalToolStripMenuItem_Click;
            // 
            // closeAllToolStripMenuItem
            // 
            closeAllToolStripMenuItem.Name = "closeAllToolStripMenuItem";
            closeAllToolStripMenuItem.Size = new Size(150, 22);
            closeAllToolStripMenuItem.Text = "C&lose All";
            closeAllToolStripMenuItem.Click += CloseAllToolStripMenuItem_Click;
            // 
            // arrangeIconsToolStripMenuItem
            // 
            arrangeIconsToolStripMenuItem.Name = "arrangeIconsToolStripMenuItem";
            arrangeIconsToolStripMenuItem.Size = new Size(150, 22);
            arrangeIconsToolStripMenuItem.Text = "&Arrange Icons";
            arrangeIconsToolStripMenuItem.Click += ArrangeIconsToolStripMenuItem_Click;
            // 
            // helpMenu
            // 
            helpMenu.DropDownItems.AddRange(new ToolStripItem[] { contentsToolStripMenuItem, indexToolStripMenuItem, searchToolStripMenuItem, toolStripSeparator8, aboutToolStripMenuItem });
            helpMenu.Name = "helpMenu";
            helpMenu.Size = new Size(44, 20);
            helpMenu.Text = "&Help";
            // 
            // contentsToolStripMenuItem
            // 
            contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
            contentsToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.F1;
            contentsToolStripMenuItem.Size = new Size(180, 22);
            contentsToolStripMenuItem.Text = "&Contents";
            // 
            // indexToolStripMenuItem
            // 
            indexToolStripMenuItem.Image = (Image)resources.GetObject("indexToolStripMenuItem.Image");
            indexToolStripMenuItem.ImageTransparentColor = Color.Black;
            indexToolStripMenuItem.Name = "indexToolStripMenuItem";
            indexToolStripMenuItem.Size = new Size(180, 22);
            indexToolStripMenuItem.Text = "&Index";
            // 
            // searchToolStripMenuItem
            // 
            searchToolStripMenuItem.Image = (Image)resources.GetObject("searchToolStripMenuItem.Image");
            searchToolStripMenuItem.ImageTransparentColor = Color.Black;
            searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            searchToolStripMenuItem.Size = new Size(180, 22);
            searchToolStripMenuItem.Text = "&Search";
            // 
            // toolStripSeparator8
            // 
            toolStripSeparator8.Name = "toolStripSeparator8";
            toolStripSeparator8.Size = new Size(177, 6);
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(180, 22);
            aboutToolStripMenuItem.Text = "&About ... ...";
            // 
            // statusStrip
            // 
            statusStrip.Items.AddRange(new ToolStripItem[] { lblStatusMDI });
            statusStrip.Location = new Point(0, 659);
            statusStrip.Name = "statusStrip";
            statusStrip.Padding = new Padding(1, 0, 16, 0);
            statusStrip.Size = new Size(1264, 22);
            statusStrip.TabIndex = 2;
            statusStrip.Text = "StatusStrip";
            // 
            // lblStatusMDI
            // 
            lblStatusMDI.Name = "lblStatusMDI";
            lblStatusMDI.Size = new Size(80, 17);
            lblStatusMDI.Text = "<MDI Status>";
            // 
            // dgvMain
            // 
            dgvMain.AllowUserToAddRows = false;
            dgvMain.AllowUserToDeleteRows = false;
            dgvMain.AllowUserToOrderColumns = true;
            dgvMain.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMain.Dock = DockStyle.Fill;
            dgvMain.Location = new Point(0, 24);
            dgvMain.Name = "dgvMain";
            dgvMain.ReadOnly = true;
            dgvMain.RowTemplate.Height = 25;
            dgvMain.Size = new Size(1264, 635);
            dgvMain.TabIndex = 4;
            // 
            // mdiMainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(dgvMain);
            Controls.Add(statusStrip);
            Controls.Add(mnuStrip);
            IsMdiContainer = true;
            MainMenuStrip = mnuStrip;
            Margin = new Padding(4, 3, 4, 3);
            Name = "mdiMainMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inventory Management System - Rinzler's Grocery";
            mnuStrip.ResumeLayout(false);
            mnuStrip.PerformLayout();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMain).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion


        private MenuStrip mnuStrip;
        private StatusStrip statusStrip;
        private ToolStripSeparator toolStripSeparator8;
        private ToolStripStatusLabel lblStatusMDI;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem tileHorizontalToolStripMenuItem;
        private ToolStripMenuItem viewMenu;
        private ToolStripMenuItem statusBarToolStripMenuItem;
        private ToolStripMenuItem windowsMenu;
        private ToolStripMenuItem newWindowToolStripMenuItem;
        private ToolStripMenuItem cascadeToolStripMenuItem;
        private ToolStripMenuItem tileVerticalToolStripMenuItem;
        private ToolStripMenuItem closeAllToolStripMenuItem;
        private ToolStripMenuItem arrangeIconsToolStripMenuItem;
        private ToolStripMenuItem helpMenu;
        private ToolStripMenuItem contentsToolStripMenuItem;
        private ToolStripMenuItem indexToolStripMenuItem;
        private ToolStripMenuItem searchToolStripMenuItem;
        private ToolTip toolTip;
        private ToolStripMenuItem maintenanceToolStripMenuItem;
        private ToolStripMenuItem employeesToolStripMenuItem;
        private ToolStripMenuItem productsToolStripMenuItem;
        private ToolStripMenuItem inventoryToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem logsToolStripMenuItem;
        private ToolStripMenuItem productsToolStripMenuItem1;
        private ToolStripMenuItem logsToolStripMenuItem1;
        private DataGridView dgvMain;
        private ToolStripSeparator toolStripSeparator2;
    }
}



