namespace InventorySystemProject
{
    partial class Splash
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Splash));
            tmrLoad = new System.Windows.Forms.Timer(components);
            lblProduct = new Label();
            lblVersion = new Label();
            lblCompany = new Label();
            prgSplash = new ProgressBar();
            SuspendLayout();
            // 
            // tmrLoad
            // 
            tmrLoad.Enabled = true;
            tmrLoad.Interval = 1;
            tmrLoad.Tick += tmrLoad_Tick;
            // 
            // lblProduct
            // 
            lblProduct.AutoSize = true;
            lblProduct.BackColor = Color.Transparent;
            lblProduct.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblProduct.ForeColor = Color.Maroon;
            lblProduct.Location = new Point(22, 419);
            lblProduct.Name = "lblProduct";
            lblProduct.Size = new Size(123, 32);
            lblProduct.TabIndex = 0;
            lblProduct.Text = "[Product]";
            // 
            // lblVersion
            // 
            lblVersion.AutoSize = true;
            lblVersion.BackColor = Color.Transparent;
            lblVersion.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblVersion.ForeColor = Color.Maroon;
            lblVersion.Location = new Point(22, 451);
            lblVersion.Name = "lblVersion";
            lblVersion.Size = new Size(117, 32);
            lblVersion.TabIndex = 1;
            lblVersion.Text = "[Version]";
            // 
            // lblCompany
            // 
            lblCompany.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblCompany.AutoSize = true;
            lblCompany.BackColor = Color.Transparent;
            lblCompany.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblCompany.ForeColor = Color.Maroon;
            lblCompany.Location = new Point(22, 23);
            lblCompany.Name = "lblCompany";
            lblCompany.Size = new Size(140, 32);
            lblCompany.TabIndex = 2;
            lblCompany.Text = "[Company]";
            // 
            // prgSplash
            // 
            prgSplash.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            prgSplash.Location = new Point(0, 515);
            prgSplash.Name = "prgSplash";
            prgSplash.Size = new Size(960, 25);
            prgSplash.TabIndex = 3;
            // 
            // Splash
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(960, 540);
            Controls.Add(prgSplash);
            Controls.Add(lblCompany);
            Controls.Add(lblVersion);
            Controls.Add(lblProduct);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Splash";
            ShowInTaskbar = false;
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Splash_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer tmrLoad;
        private Label lblProduct;
        private Label lblVersion;
        private Label lblCompany;
        private ProgressBar prgSplash;
    }
}