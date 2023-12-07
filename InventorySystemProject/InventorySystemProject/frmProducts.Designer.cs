namespace InventorySystemProject
{
    partial class frmProducts
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
            btnPrevious = new Button();
            imgProductPhoto = new PictureBox();
            btnSave = new Button();
            grpProductDetails = new GroupBox();
            txtUnitPrice = new TextBox();
            txtUnit = new TextBox();
            txtQuantity = new TextBox();
            lblUnitPrice = new Label();
            lblUnit = new Label();
            lblQuantity = new Label();
            lblProductIdValue = new Label();
            lblProductId = new Label();
            grpProductState = new GroupBox();
            txtMaxStockAmt = new TextBox();
            txtProductStatus = new TextBox();
            lblMaxStockAmt = new Label();
            lblProductStatus = new Label();
            txtProductCategory = new TextBox();
            btnDelete = new Button();
            txtProductDescription = new TextBox();
            btnLast = new Button();
            btnNext = new Button();
            txtProductName = new TextBox();
            btnFirst = new Button();
            lblProductDescription = new Label();
            lblProductCategory = new Label();
            btnAdd = new Button();
            btnCancel = new Button();
            grpProduct = new GroupBox();
            lblProductName = new Label();
            errProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)imgProductPhoto).BeginInit();
            grpProductDetails.SuspendLayout();
            grpProductState.SuspendLayout();
            grpProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errProvider).BeginInit();
            SuspendLayout();
            // 
            // btnPrevious
            // 
            btnPrevious.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnPrevious.Location = new Point(634, 362);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(120, 50);
            btnPrevious.TabIndex = 4;
            btnPrevious.Text = "Previous";
            btnPrevious.UseVisualStyleBackColor = true;
            btnPrevious.Click += Navigation_Handler;
            // 
            // imgProductPhoto
            // 
            imgProductPhoto.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            imgProductPhoto.Location = new Point(341, 37);
            imgProductPhoto.Name = "imgProductPhoto";
            imgProductPhoto.Size = new Size(150, 150);
            imgProductPhoto.TabIndex = 4;
            imgProductPhoto.TabStop = false;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.Location = new Point(760, 418);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(120, 50);
            btnSave.TabIndex = 9;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // grpProductDetails
            // 
            grpProductDetails.Controls.Add(txtUnitPrice);
            grpProductDetails.Controls.Add(txtUnit);
            grpProductDetails.Controls.Add(txtQuantity);
            grpProductDetails.Controls.Add(lblUnitPrice);
            grpProductDetails.Controls.Add(lblUnit);
            grpProductDetails.Controls.Add(lblQuantity);
            grpProductDetails.Controls.Add(lblProductIdValue);
            grpProductDetails.Controls.Add(lblProductId);
            grpProductDetails.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            grpProductDetails.Location = new Point(13, 235);
            grpProductDetails.Margin = new Padding(4);
            grpProductDetails.Name = "grpProductDetails";
            grpProductDetails.Padding = new Padding(4);
            grpProductDetails.Size = new Size(479, 243);
            grpProductDetails.TabIndex = 1;
            grpProductDetails.TabStop = false;
            grpProductDetails.Text = "Product Details";
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            txtUnitPrice.Location = new Point(145, 181);
            txtUnitPrice.Margin = new Padding(4);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(300, 32);
            txtUnitPrice.TabIndex = 7;
            txtUnitPrice.Tag = "Unit Price";
            txtUnitPrice.Validating += txt_Validating;
            // 
            // txtUnit
            // 
            txtUnit.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            txtUnit.Location = new Point(145, 131);
            txtUnit.Margin = new Padding(4);
            txtUnit.Name = "txtUnit";
            txtUnit.Size = new Size(300, 32);
            txtUnit.TabIndex = 6;
            txtUnit.Tag = "Unit";
            txtUnit.Validating += txt_Validating;
            // 
            // txtQuantity
            // 
            txtQuantity.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            txtQuantity.Location = new Point(145, 82);
            txtQuantity.Margin = new Padding(4);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(300, 32);
            txtQuantity.TabIndex = 5;
            txtQuantity.Tag = "Quantity";
            txtQuantity.Validating += txt_Validating;
            // 
            // lblUnitPrice
            // 
            lblUnitPrice.AutoSize = true;
            lblUnitPrice.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblUnitPrice.Location = new Point(42, 184);
            lblUnitPrice.Margin = new Padding(4, 0, 4, 0);
            lblUnitPrice.Name = "lblUnitPrice";
            lblUnitPrice.Size = new Size(95, 25);
            lblUnitPrice.TabIndex = 3;
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
            lblUnit.TabIndex = 2;
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
            lblQuantity.TabIndex = 1;
            lblQuantity.Text = "Quantity";
            // 
            // lblProductIdValue
            // 
            lblProductIdValue.AutoSize = true;
            lblProductIdValue.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblProductIdValue.Location = new Point(147, 45);
            lblProductIdValue.Margin = new Padding(4, 0, 4, 0);
            lblProductIdValue.Name = "lblProductIdValue";
            lblProductIdValue.Size = new Size(149, 25);
            lblProductIdValue.TabIndex = 4;
            lblProductIdValue.Text = "<PRODUCT ID>";
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
            // grpProductState
            // 
            grpProductState.Controls.Add(imgProductPhoto);
            grpProductState.Controls.Add(txtMaxStockAmt);
            grpProductState.Controls.Add(txtProductStatus);
            grpProductState.Controls.Add(lblMaxStockAmt);
            grpProductState.Controls.Add(lblProductStatus);
            grpProductState.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            grpProductState.Location = new Point(500, 13);
            grpProductState.Margin = new Padding(4);
            grpProductState.Name = "grpProductState";
            grpProductState.Padding = new Padding(4);
            grpProductState.Size = new Size(514, 214);
            grpProductState.TabIndex = 2;
            grpProductState.TabStop = false;
            grpProductState.Text = "Product State";
            // 
            // txtMaxStockAmt
            // 
            txtMaxStockAmt.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            txtMaxStockAmt.Location = new Point(7, 141);
            txtMaxStockAmt.Margin = new Padding(4);
            txtMaxStockAmt.Name = "txtMaxStockAmt";
            txtMaxStockAmt.Size = new Size(300, 32);
            txtMaxStockAmt.TabIndex = 3;
            txtMaxStockAmt.Tag = "Max Stock";
            txtMaxStockAmt.Validating += txt_Validating;
            // 
            // txtProductStatus
            // 
            txtProductStatus.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            txtProductStatus.Location = new Point(7, 66);
            txtProductStatus.Margin = new Padding(4);
            txtProductStatus.Name = "txtProductStatus";
            txtProductStatus.Size = new Size(300, 32);
            txtProductStatus.TabIndex = 1;
            txtProductStatus.Tag = "Product State";
            txtProductStatus.Validating += txt_Validating;
            // 
            // lblMaxStockAmt
            // 
            lblMaxStockAmt.AutoSize = true;
            lblMaxStockAmt.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblMaxStockAmt.Location = new Point(10, 114);
            lblMaxStockAmt.Margin = new Padding(4, 0, 4, 0);
            lblMaxStockAmt.Name = "lblMaxStockAmt";
            lblMaxStockAmt.Size = new Size(226, 25);
            lblMaxStockAmt.TabIndex = 2;
            lblMaxStockAmt.Text = "Maximum Stock Amount";
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
            // txtProductCategory
            // 
            txtProductCategory.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            txtProductCategory.Location = new Point(145, 141);
            txtProductCategory.Margin = new Padding(4);
            txtProductCategory.Name = "txtProductCategory";
            txtProductCategory.Size = new Size(300, 32);
            txtProductCategory.TabIndex = 5;
            txtProductCategory.Tag = "Product Category";
            txtProductCategory.Validating += txt_Validating;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.Location = new Point(634, 418);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(120, 50);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtProductDescription
            // 
            txtProductDescription.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            txtProductDescription.Location = new Point(145, 90);
            txtProductDescription.Margin = new Padding(4);
            txtProductDescription.Name = "txtProductDescription";
            txtProductDescription.Size = new Size(300, 32);
            txtProductDescription.TabIndex = 4;
            txtProductDescription.Tag = "Product Description";
            // 
            // btnLast
            // 
            btnLast.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLast.Location = new Point(886, 362);
            btnLast.Name = "btnLast";
            btnLast.Size = new Size(120, 50);
            btnLast.TabIndex = 6;
            btnLast.Text = "Last";
            btnLast.UseVisualStyleBackColor = true;
            btnLast.Click += Navigation_Handler;
            // 
            // btnNext
            // 
            btnNext.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnNext.Location = new Point(760, 362);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(120, 50);
            btnNext.TabIndex = 5;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += Navigation_Handler;
            // 
            // txtProductName
            // 
            txtProductName.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            txtProductName.Location = new Point(145, 37);
            txtProductName.Margin = new Padding(4);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(300, 32);
            txtProductName.TabIndex = 3;
            txtProductName.Tag = "Product Name";
            txtProductName.Validating += txt_Validating;
            // 
            // btnFirst
            // 
            btnFirst.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnFirst.Location = new Point(508, 362);
            btnFirst.Name = "btnFirst";
            btnFirst.Size = new Size(120, 50);
            btnFirst.TabIndex = 3;
            btnFirst.Text = "First";
            btnFirst.UseVisualStyleBackColor = true;
            btnFirst.Click += Navigation_Handler;
            // 
            // lblProductDescription
            // 
            lblProductDescription.AutoSize = true;
            lblProductDescription.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblProductDescription.Location = new Point(28, 94);
            lblProductDescription.Margin = new Padding(4, 0, 4, 0);
            lblProductDescription.Name = "lblProductDescription";
            lblProductDescription.Size = new Size(110, 25);
            lblProductDescription.TabIndex = 1;
            lblProductDescription.Text = "Description";
            // 
            // lblProductCategory
            // 
            lblProductCategory.AutoSize = true;
            lblProductCategory.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblProductCategory.Location = new Point(47, 145);
            lblProductCategory.Margin = new Padding(4, 0, 4, 0);
            lblProductCategory.Name = "lblProductCategory";
            lblProductCategory.Size = new Size(91, 25);
            lblProductCategory.TabIndex = 2;
            lblProductCategory.Text = "Category";
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.Location = new Point(508, 418);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(120, 50);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.Location = new Point(886, 418);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(120, 50);
            btnCancel.TabIndex = 10;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // grpProduct
            // 
            grpProduct.Controls.Add(txtProductCategory);
            grpProduct.Controls.Add(txtProductDescription);
            grpProduct.Controls.Add(txtProductName);
            grpProduct.Controls.Add(lblProductDescription);
            grpProduct.Controls.Add(lblProductCategory);
            grpProduct.Controls.Add(lblProductName);
            grpProduct.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            grpProduct.Location = new Point(13, 13);
            grpProduct.Margin = new Padding(4);
            grpProduct.Name = "grpProduct";
            grpProduct.Padding = new Padding(4);
            grpProduct.Size = new Size(479, 214);
            grpProduct.TabIndex = 0;
            grpProduct.TabStop = false;
            grpProduct.Text = "Product";
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblProductName.Location = new Point(74, 41);
            lblProductName.Margin = new Padding(4, 0, 4, 0);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(64, 25);
            lblProductName.TabIndex = 0;
            lblProductName.Text = "Name";
            // 
            // errProvider
            // 
            errProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errProvider.ContainerControl = this;
            // 
            // frmProducts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1025, 513);
            Controls.Add(btnPrevious);
            Controls.Add(btnSave);
            Controls.Add(grpProductDetails);
            Controls.Add(grpProductState);
            Controls.Add(btnDelete);
            Controls.Add(btnLast);
            Controls.Add(btnNext);
            Controls.Add(btnFirst);
            Controls.Add(btnAdd);
            Controls.Add(btnCancel);
            Controls.Add(grpProduct);
            Name = "frmProducts";
            Text = "Products";
            Load += frmProducts_Load;
            ((System.ComponentModel.ISupportInitialize)imgProductPhoto).EndInit();
            grpProductDetails.ResumeLayout(false);
            grpProductDetails.PerformLayout();
            grpProductState.ResumeLayout(false);
            grpProductState.PerformLayout();
            grpProduct.ResumeLayout(false);
            grpProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errProvider).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnPrevious;
        private PictureBox imgProductPhoto;
        private Button btnSave;
        private GroupBox grpProductDetails;
        private TextBox txtUnitPrice;
        private TextBox txtUnit;
        private TextBox txtQuantity;
        private Label lblUnitPrice;
        private Label lblUnit;
        private Label lblQuantity;
        private Label lblProductIdValue;
        private Label lblProductId;
        private GroupBox grpProductState;
        private TextBox txtMaxStockAmt;
        private TextBox txtProductStatus;
        private Label lblMaxStockAmt;
        private Label lblProductStatus;
        private TextBox txtProductCategory;
        private Button btnDelete;
        private TextBox txtProductDescription;
        private Button btnLast;
        private Button btnNext;
        private TextBox txtProductName;
        private Button btnFirst;
        private Label lblProductDescription;
        private Label lblProductCategory;
        private Button btnAdd;
        private Button btnCancel;
        private GroupBox grpProduct;
        private Label lblProductName;
        private ErrorProvider errProvider;
    }
}