namespace InventorySystemProject
{
    partial class Products
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
            btnPrevious = new Button();
            imgProfilePhoto = new PictureBox();
            btnSave = new Button();
            grpProductDetails = new GroupBox();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            txtPosition = new TextBox();
            lblUnitPrice = new Label();
            lblUnit = new Label();
            lblQuantity = new Label();
            lblEmployeeIdValue = new Label();
            lblProductId = new Label();
            grpContactInfo = new GroupBox();
            txtEmail = new TextBox();
            txtPhone = new TextBox();
            lblProductExpiration = new Label();
            lblProductStatus = new Label();
            txtLastName = new TextBox();
            btnDelete = new Button();
            txtMiddleName = new TextBox();
            btnLast = new Button();
            btnNext = new Button();
            txtFirstName = new TextBox();
            btnFirst = new Button();
            lblProductDescription = new Label();
            lblProductCategory = new Label();
            btnAdd = new Button();
            btnCancel = new Button();
            grpProduct = new GroupBox();
            lblProductName = new Label();
            ((System.ComponentModel.ISupportInitialize)imgProfilePhoto).BeginInit();
            grpProductDetails.SuspendLayout();
            grpContactInfo.SuspendLayout();
            grpProduct.SuspendLayout();
            SuspendLayout();
            // 
            // btnPrevious
            // 
            btnPrevious.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnPrevious.Location = new Point(631, 358);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(120, 50);
            btnPrevious.TabIndex = 25;
            btnPrevious.Text = "Previous";
            btnPrevious.UseVisualStyleBackColor = true;
            // 
            // imgProfilePhoto
            // 
            imgProfilePhoto.Location = new Point(341, 37);
            imgProfilePhoto.Name = "imgProfilePhoto";
            imgProfilePhoto.Size = new Size(150, 150);
            imgProfilePhoto.TabIndex = 4;
            imgProfilePhoto.TabStop = false;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.Location = new Point(757, 414);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(120, 50);
            btnSave.TabIndex = 26;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // grpProductDetails
            // 
            grpProductDetails.Controls.Add(txtPassword);
            grpProductDetails.Controls.Add(txtUsername);
            grpProductDetails.Controls.Add(txtPosition);
            grpProductDetails.Controls.Add(lblUnitPrice);
            grpProductDetails.Controls.Add(lblUnit);
            grpProductDetails.Controls.Add(lblQuantity);
            grpProductDetails.Controls.Add(lblEmployeeIdValue);
            grpProductDetails.Controls.Add(lblProductId);
            grpProductDetails.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            grpProductDetails.Location = new Point(10, 231);
            grpProductDetails.Margin = new Padding(4);
            grpProductDetails.Name = "grpProductDetails";
            grpProductDetails.Padding = new Padding(4);
            grpProductDetails.Size = new Size(479, 243);
            grpProductDetails.TabIndex = 17;
            grpProductDetails.TabStop = false;
            grpProductDetails.Text = "Product Details";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            txtPassword.Location = new Point(145, 181);
            txtPassword.Margin = new Padding(4);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(300, 32);
            txtPassword.TabIndex = 3;
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            txtUsername.Location = new Point(145, 131);
            txtUsername.Margin = new Padding(4);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(300, 32);
            txtUsername.TabIndex = 3;
            // 
            // txtPosition
            // 
            txtPosition.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            txtPosition.Location = new Point(145, 82);
            txtPosition.Margin = new Padding(4);
            txtPosition.Name = "txtPosition";
            txtPosition.Size = new Size(300, 32);
            txtPosition.TabIndex = 3;
            // 
            // lblUnitPrice
            // 
            lblUnitPrice.AutoSize = true;
            lblUnitPrice.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblUnitPrice.Location = new Point(42, 184);
            lblUnitPrice.Margin = new Padding(4, 0, 4, 0);
            lblUnitPrice.Name = "lblUnitPrice";
            lblUnitPrice.Size = new Size(95, 25);
            lblUnitPrice.TabIndex = 0;
            lblUnitPrice.Text = "Unit Price";
            // 
            // lblUnit
            // 
            lblUnit.AutoSize = true;
            lblUnit.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblUnit.Location = new Point(89, 134);
            lblUnit.Margin = new Padding(4, 0, 4, 0);
            lblUnit.Name = "lblUnit";
            lblUnit.Size = new Size(48, 25);
            lblUnit.TabIndex = 0;
            lblUnit.Text = "Unit";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblQuantity.Location = new Point(50, 85);
            lblQuantity.Margin = new Padding(4, 0, 4, 0);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(87, 25);
            lblQuantity.TabIndex = 0;
            lblQuantity.Text = "Quantity";
            // 
            // lblEmployeeIdValue
            // 
            lblEmployeeIdValue.AutoSize = true;
            lblEmployeeIdValue.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblEmployeeIdValue.Location = new Point(147, 45);
            lblEmployeeIdValue.Margin = new Padding(4, 0, 4, 0);
            lblEmployeeIdValue.Name = "lblEmployeeIdValue";
            lblEmployeeIdValue.Size = new Size(155, 25);
            lblEmployeeIdValue.TabIndex = 0;
            lblEmployeeIdValue.Text = "<EMPLOYEE ID>";
            // 
            // lblProductId
            // 
            lblProductId.AutoSize = true;
            lblProductId.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblProductId.Location = new Point(33, 45);
            lblProductId.Margin = new Padding(4, 0, 4, 0);
            lblProductId.Name = "lblProductId";
            lblProductId.Size = new Size(104, 25);
            lblProductId.TabIndex = 0;
            lblProductId.Text = "Product ID";
            // 
            // grpContactInfo
            // 
            grpContactInfo.Controls.Add(imgProfilePhoto);
            grpContactInfo.Controls.Add(txtEmail);
            grpContactInfo.Controls.Add(txtPhone);
            grpContactInfo.Controls.Add(lblProductExpiration);
            grpContactInfo.Controls.Add(lblProductStatus);
            grpContactInfo.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            grpContactInfo.Location = new Point(497, 9);
            grpContactInfo.Margin = new Padding(4);
            grpContactInfo.Name = "grpContactInfo";
            grpContactInfo.Padding = new Padding(4);
            grpContactInfo.Size = new Size(514, 214);
            grpContactInfo.TabIndex = 18;
            grpContactInfo.TabStop = false;
            grpContactInfo.Text = "Product State";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            txtEmail.Location = new Point(8, 141);
            txtEmail.Margin = new Padding(4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(300, 32);
            txtEmail.TabIndex = 3;
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            txtPhone.Location = new Point(8, 66);
            txtPhone.Margin = new Padding(4);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(300, 32);
            txtPhone.TabIndex = 3;
            // 
            // lblProductExpiration
            // 
            lblProductExpiration.AutoSize = true;
            lblProductExpiration.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblProductExpiration.Location = new Point(10, 114);
            lblProductExpiration.Margin = new Padding(4, 0, 4, 0);
            lblProductExpiration.Name = "lblProductExpiration";
            lblProductExpiration.Size = new Size(166, 25);
            lblProductExpiration.TabIndex = 1;
            lblProductExpiration.Text = "Earliest Expiration";
            // 
            // lblProductStatus
            // 
            lblProductStatus.AutoSize = true;
            lblProductStatus.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblProductStatus.Location = new Point(10, 39);
            lblProductStatus.Margin = new Padding(4, 0, 4, 0);
            lblProductStatus.Name = "lblProductStatus";
            lblProductStatus.Size = new Size(159, 25);
            lblProductStatus.TabIndex = 0;
            lblProductStatus.Text = "Stock Availability";
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            txtLastName.Location = new Point(145, 141);
            txtLastName.Margin = new Padding(4);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(300, 32);
            txtLastName.TabIndex = 3;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.Location = new Point(631, 414);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(120, 50);
            btnDelete.TabIndex = 24;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // txtMiddleName
            // 
            txtMiddleName.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            txtMiddleName.Location = new Point(145, 90);
            txtMiddleName.Margin = new Padding(4);
            txtMiddleName.Name = "txtMiddleName";
            txtMiddleName.Size = new Size(300, 32);
            txtMiddleName.TabIndex = 3;
            // 
            // btnLast
            // 
            btnLast.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLast.Location = new Point(883, 358);
            btnLast.Name = "btnLast";
            btnLast.Size = new Size(120, 50);
            btnLast.TabIndex = 20;
            btnLast.Text = "Last";
            btnLast.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            btnNext.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnNext.Location = new Point(757, 358);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(120, 50);
            btnNext.TabIndex = 21;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            txtFirstName.Location = new Point(145, 37);
            txtFirstName.Margin = new Padding(4);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(300, 32);
            txtFirstName.TabIndex = 3;
            // 
            // btnFirst
            // 
            btnFirst.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnFirst.Location = new Point(505, 358);
            btnFirst.Name = "btnFirst";
            btnFirst.Size = new Size(120, 50);
            btnFirst.TabIndex = 19;
            btnFirst.Text = "First";
            btnFirst.UseVisualStyleBackColor = true;
            // 
            // lblProductDescription
            // 
            lblProductDescription.AutoSize = true;
            lblProductDescription.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblProductDescription.Location = new Point(27, 93);
            lblProductDescription.Margin = new Padding(4, 0, 4, 0);
            lblProductDescription.Name = "lblProductDescription";
            lblProductDescription.Size = new Size(110, 25);
            lblProductDescription.TabIndex = 2;
            lblProductDescription.Text = "Description";
            // 
            // lblProductCategory
            // 
            lblProductCategory.AutoSize = true;
            lblProductCategory.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblProductCategory.Location = new Point(46, 144);
            lblProductCategory.Margin = new Padding(4, 0, 4, 0);
            lblProductCategory.Name = "lblProductCategory";
            lblProductCategory.Size = new Size(91, 25);
            lblProductCategory.TabIndex = 1;
            lblProductCategory.Text = "Category";
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.Location = new Point(505, 414);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(120, 50);
            btnAdd.TabIndex = 22;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.Location = new Point(883, 414);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(120, 50);
            btnCancel.TabIndex = 23;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // grpProduct
            // 
            grpProduct.Controls.Add(txtLastName);
            grpProduct.Controls.Add(txtMiddleName);
            grpProduct.Controls.Add(txtFirstName);
            grpProduct.Controls.Add(lblProductDescription);
            grpProduct.Controls.Add(lblProductCategory);
            grpProduct.Controls.Add(lblProductName);
            grpProduct.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            grpProduct.Location = new Point(10, 9);
            grpProduct.Margin = new Padding(4);
            grpProduct.Name = "grpProduct";
            grpProduct.Padding = new Padding(4);
            grpProduct.Size = new Size(479, 214);
            grpProduct.TabIndex = 16;
            grpProduct.TabStop = false;
            grpProduct.Text = "Product";
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblProductName.Location = new Point(73, 40);
            lblProductName.Margin = new Padding(4, 0, 4, 0);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(64, 25);
            lblProductName.TabIndex = 0;
            lblProductName.Text = "Name";
            // 
            // Products
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1021, 483);
            Controls.Add(btnPrevious);
            Controls.Add(btnSave);
            Controls.Add(grpProductDetails);
            Controls.Add(grpContactInfo);
            Controls.Add(btnDelete);
            Controls.Add(btnLast);
            Controls.Add(btnNext);
            Controls.Add(btnFirst);
            Controls.Add(btnAdd);
            Controls.Add(btnCancel);
            Controls.Add(grpProduct);
            Name = "Products";
            Text = "Products";
            ((System.ComponentModel.ISupportInitialize)imgProfilePhoto).EndInit();
            grpProductDetails.ResumeLayout(false);
            grpProductDetails.PerformLayout();
            grpContactInfo.ResumeLayout(false);
            grpContactInfo.PerformLayout();
            grpProduct.ResumeLayout(false);
            grpProduct.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnPrevious;
        private PictureBox imgProfilePhoto;
        private Button btnSave;
        private GroupBox grpProductDetails;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private TextBox txtPosition;
        private Label lblUnitPrice;
        private Label lblUnit;
        private Label lblQuantity;
        private Label lblEmployeeIdValue;
        private Label lblProductId;
        private GroupBox grpContactInfo;
        private TextBox txtEmail;
        private TextBox txtPhone;
        private Label lblProductExpiration;
        private Label lblProductStatus;
        private TextBox txtLastName;
        private Button btnDelete;
        private TextBox txtMiddleName;
        private Button btnLast;
        private Button btnNext;
        private TextBox txtFirstName;
        private Button btnFirst;
        private Label lblProductDescription;
        private Label lblProductCategory;
        private Button btnAdd;
        private Button btnCancel;
        private GroupBox grpProduct;
        private Label lblProductName;
    }
}