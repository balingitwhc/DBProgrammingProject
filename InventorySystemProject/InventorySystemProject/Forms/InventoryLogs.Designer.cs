namespace InventorySystemProject
{
    partial class InventoryLogs
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
            lblProductName = new Label();
            imgLogPhoto = new PictureBox();
            btnAdd = new Button();
            btnCancel = new Button();
            lblProductDescription = new Label();
            lblProductCategory = new Label();
            btnFirst = new Button();
            btnLast = new Button();
            btnNext = new Button();
            txtProductDescription = new TextBox();
            btnDelete = new Button();
            txtProductCategory = new TextBox();
            txtEmployeePosition = new TextBox();
            txtEmployeeName = new TextBox();
            lblEmployeePosition = new Label();
            lblProductStatus = new Label();
            grpEmployee = new GroupBox();
            txtLogQuantity = new TextBox();
            lblExpirationDate = new Label();
            lblLogDate = new Label();
            lblQuantity = new Label();
            lblLogIdValue = new Label();
            lblLogId = new Label();
            btnPrevious = new Button();
            btnSave = new Button();
            grpInventoryLog = new GroupBox();
            dtpLogDate = new DateTimePicker();
            dtpLogExpiration = new DateTimePicker();
            rdoRemove = new RadioButton();
            rdoAdd = new RadioButton();
            grpProduct = new GroupBox();
            cmbProducts = new ComboBox();
            grpNotes = new GroupBox();
            txtLogNotes = new TextBox();
            errProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)imgLogPhoto).BeginInit();
            grpEmployee.SuspendLayout();
            grpInventoryLog.SuspendLayout();
            grpProduct.SuspendLayout();
            grpNotes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errProvider).BeginInit();
            SuspendLayout();
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblProductName.Location = new Point(73, 43);
            lblProductName.Margin = new Padding(4, 0, 4, 0);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(64, 25);
            lblProductName.TabIndex = 0;
            lblProductName.Text = "Name";
            // 
            // imgLogPhoto
            // 
            imgLogPhoto.Location = new Point(341, 37);
            imgLogPhoto.Name = "imgLogPhoto";
            imgLogPhoto.Size = new Size(150, 150);
            imgLogPhoto.TabIndex = 4;
            imgLogPhoto.TabStop = false;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.Location = new Point(508, 418);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(120, 50);
            btnAdd.TabIndex = 8;
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
            btnCancel.TabIndex = 11;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // lblProductDescription
            // 
            lblProductDescription.AutoSize = true;
            lblProductDescription.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblProductDescription.Location = new Point(26, 92);
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
            lblProductCategory.Location = new Point(45, 142);
            lblProductCategory.Margin = new Padding(4, 0, 4, 0);
            lblProductCategory.Name = "lblProductCategory";
            lblProductCategory.Size = new Size(91, 25);
            lblProductCategory.TabIndex = 2;
            lblProductCategory.Text = "Category";
            // 
            // btnFirst
            // 
            btnFirst.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnFirst.Location = new Point(508, 362);
            btnFirst.Name = "btnFirst";
            btnFirst.Size = new Size(120, 50);
            btnFirst.TabIndex = 4;
            btnFirst.Text = "First";
            btnFirst.UseVisualStyleBackColor = true;
            btnFirst.Click += Navigation_Handler;
            // 
            // btnLast
            // 
            btnLast.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLast.Location = new Point(886, 362);
            btnLast.Name = "btnLast";
            btnLast.Size = new Size(120, 50);
            btnLast.TabIndex = 7;
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
            btnNext.TabIndex = 6;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += Navigation_Handler;
            // 
            // txtProductDescription
            // 
            txtProductDescription.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            txtProductDescription.Location = new Point(144, 89);
            txtProductDescription.Margin = new Padding(4);
            txtProductDescription.Name = "txtProductDescription";
            txtProductDescription.Size = new Size(300, 32);
            txtProductDescription.TabIndex = 4;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.Location = new Point(634, 418);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(120, 50);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtProductCategory
            // 
            txtProductCategory.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            txtProductCategory.Location = new Point(144, 139);
            txtProductCategory.Margin = new Padding(4);
            txtProductCategory.Name = "txtProductCategory";
            txtProductCategory.Size = new Size(300, 32);
            txtProductCategory.TabIndex = 5;
            // 
            // txtEmployeePosition
            // 
            txtEmployeePosition.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            txtEmployeePosition.Location = new Point(8, 149);
            txtEmployeePosition.Margin = new Padding(4);
            txtEmployeePosition.Name = "txtEmployeePosition";
            txtEmployeePosition.ReadOnly = true;
            txtEmployeePosition.Size = new Size(300, 32);
            txtEmployeePosition.TabIndex = 3;
            // 
            // txtEmployeeName
            // 
            txtEmployeeName.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            txtEmployeeName.Location = new Point(8, 69);
            txtEmployeeName.Margin = new Padding(4);
            txtEmployeeName.Name = "txtEmployeeName";
            txtEmployeeName.ReadOnly = true;
            txtEmployeeName.Size = new Size(300, 32);
            txtEmployeeName.TabIndex = 1;
            // 
            // lblEmployeePosition
            // 
            lblEmployeePosition.AutoSize = true;
            lblEmployeePosition.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblEmployeePosition.Location = new Point(8, 120);
            lblEmployeePosition.Margin = new Padding(4, 0, 4, 0);
            lblEmployeePosition.Name = "lblEmployeePosition";
            lblEmployeePosition.Size = new Size(169, 25);
            lblEmployeePosition.TabIndex = 2;
            lblEmployeePosition.Text = "Employee Position";
            // 
            // lblProductStatus
            // 
            lblProductStatus.AutoSize = true;
            lblProductStatus.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblProductStatus.Location = new Point(8, 40);
            lblProductStatus.Margin = new Padding(4, 0, 4, 0);
            lblProductStatus.Name = "lblProductStatus";
            lblProductStatus.Size = new Size(153, 25);
            lblProductStatus.TabIndex = 0;
            lblProductStatus.Text = "Employee Name";
            // 
            // grpEmployee
            // 
            grpEmployee.Controls.Add(imgLogPhoto);
            grpEmployee.Controls.Add(txtEmployeePosition);
            grpEmployee.Controls.Add(txtEmployeeName);
            grpEmployee.Controls.Add(lblEmployeePosition);
            grpEmployee.Controls.Add(lblProductStatus);
            grpEmployee.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            grpEmployee.Location = new Point(500, 13);
            grpEmployee.Margin = new Padding(4);
            grpEmployee.Name = "grpEmployee";
            grpEmployee.Padding = new Padding(4);
            grpEmployee.Size = new Size(514, 214);
            grpEmployee.TabIndex = 2;
            grpEmployee.TabStop = false;
            grpEmployee.Text = "Employee";
            // 
            // txtLogQuantity
            // 
            txtLogQuantity.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            txtLogQuantity.Location = new Point(145, 87);
            txtLogQuantity.Margin = new Padding(4);
            txtLogQuantity.Name = "txtLogQuantity";
            txtLogQuantity.Size = new Size(127, 32);
            txtLogQuantity.TabIndex = 5;
            // 
            // lblExpirationDate
            // 
            lblExpirationDate.AutoSize = true;
            lblExpirationDate.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblExpirationDate.Location = new Point(38, 184);
            lblExpirationDate.Margin = new Padding(4, 0, 4, 0);
            lblExpirationDate.Name = "lblExpirationDate";
            lblExpirationDate.Size = new Size(99, 25);
            lblExpirationDate.TabIndex = 3;
            lblExpirationDate.Text = "Expiration";
            // 
            // lblLogDate
            // 
            lblLogDate.AutoSize = true;
            lblLogDate.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblLogDate.Location = new Point(48, 137);
            lblLogDate.Margin = new Padding(4, 0, 4, 0);
            lblLogDate.Name = "lblLogDate";
            lblLogDate.Size = new Size(89, 25);
            lblLogDate.TabIndex = 2;
            lblLogDate.Text = "Log Date";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblQuantity.Location = new Point(50, 90);
            lblQuantity.Margin = new Padding(4, 0, 4, 0);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(87, 25);
            lblQuantity.TabIndex = 1;
            lblQuantity.Text = "Quantity";
            // 
            // lblLogIdValue
            // 
            lblLogIdValue.AutoSize = true;
            lblLogIdValue.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblLogIdValue.Location = new Point(148, 46);
            lblLogIdValue.Margin = new Padding(4, 0, 4, 0);
            lblLogIdValue.Name = "lblLogIdValue";
            lblLogIdValue.Size = new Size(207, 25);
            lblLogIdValue.TabIndex = 4;
            lblLogIdValue.Text = "<INVENTORY LOG ID>";
            // 
            // lblLogId
            // 
            lblLogId.AutoSize = true;
            lblLogId.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblLogId.Location = new Point(69, 46);
            lblLogId.Margin = new Padding(4, 0, 4, 0);
            lblLogId.Name = "lblLogId";
            lblLogId.Size = new Size(68, 25);
            lblLogId.TabIndex = 0;
            lblLogId.Text = "Log ID";
            // 
            // btnPrevious
            // 
            btnPrevious.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnPrevious.Location = new Point(634, 362);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(120, 50);
            btnPrevious.TabIndex = 5;
            btnPrevious.Text = "Previous";
            btnPrevious.UseVisualStyleBackColor = true;
            btnPrevious.Click += Navigation_Handler;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.Location = new Point(760, 418);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(120, 50);
            btnSave.TabIndex = 10;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // grpInventoryLog
            // 
            grpInventoryLog.Controls.Add(dtpLogDate);
            grpInventoryLog.Controls.Add(dtpLogExpiration);
            grpInventoryLog.Controls.Add(rdoRemove);
            grpInventoryLog.Controls.Add(rdoAdd);
            grpInventoryLog.Controls.Add(txtLogQuantity);
            grpInventoryLog.Controls.Add(lblExpirationDate);
            grpInventoryLog.Controls.Add(lblLogDate);
            grpInventoryLog.Controls.Add(lblQuantity);
            grpInventoryLog.Controls.Add(lblLogIdValue);
            grpInventoryLog.Controls.Add(lblLogId);
            grpInventoryLog.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            grpInventoryLog.Location = new Point(13, 235);
            grpInventoryLog.Margin = new Padding(4);
            grpInventoryLog.Name = "grpInventoryLog";
            grpInventoryLog.Padding = new Padding(4);
            grpInventoryLog.Size = new Size(479, 243);
            grpInventoryLog.TabIndex = 1;
            grpInventoryLog.TabStop = false;
            grpInventoryLog.Text = "Inventory Log Details";
            // 
            // dtpLogDate
            // 
            dtpLogDate.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dtpLogDate.Location = new Point(144, 134);
            dtpLogDate.Name = "dtpLogDate";
            dtpLogDate.Size = new Size(300, 29);
            dtpLogDate.TabIndex = 12;
            // 
            // dtpLogExpiration
            // 
            dtpLogExpiration.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dtpLogExpiration.Location = new Point(144, 183);
            dtpLogExpiration.Name = "dtpLogExpiration";
            dtpLogExpiration.Size = new Size(300, 29);
            dtpLogExpiration.TabIndex = 10;
            // 
            // rdoRemove
            // 
            rdoRemove.AutoSize = true;
            rdoRemove.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            rdoRemove.Location = new Point(355, 88);
            rdoRemove.Name = "rdoRemove";
            rdoRemove.Size = new Size(99, 29);
            rdoRemove.TabIndex = 7;
            rdoRemove.TabStop = true;
            rdoRemove.Text = "Remove";
            rdoRemove.UseVisualStyleBackColor = true;
            rdoRemove.CheckedChanged += rdoRemove_CheckedChanged;
            // 
            // rdoAdd
            // 
            rdoAdd.AutoSize = true;
            rdoAdd.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            rdoAdd.Location = new Point(284, 88);
            rdoAdd.Name = "rdoAdd";
            rdoAdd.Size = new Size(65, 29);
            rdoAdd.TabIndex = 6;
            rdoAdd.TabStop = true;
            rdoAdd.Text = "Add";
            rdoAdd.UseVisualStyleBackColor = true;
            rdoAdd.CheckedChanged += rdoAdd_CheckedChanged;
            // 
            // grpProduct
            // 
            grpProduct.Controls.Add(cmbProducts);
            grpProduct.Controls.Add(txtProductCategory);
            grpProduct.Controls.Add(txtProductDescription);
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
            // cmbProducts
            // 
            cmbProducts.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProducts.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            cmbProducts.FormattingEnabled = true;
            cmbProducts.Location = new Point(144, 40);
            cmbProducts.Name = "cmbProducts";
            cmbProducts.Size = new Size(300, 33);
            cmbProducts.TabIndex = 7;
            cmbProducts.SelectedIndexChanged += cmbProducts_SelectedIndexChanged;
            // 
            // grpNotes
            // 
            grpNotes.Controls.Add(txtLogNotes);
            grpNotes.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            grpNotes.Location = new Point(500, 235);
            grpNotes.Margin = new Padding(4);
            grpNotes.Name = "grpNotes";
            grpNotes.Padding = new Padding(4);
            grpNotes.Size = new Size(514, 114);
            grpNotes.TabIndex = 3;
            grpNotes.TabStop = false;
            grpNotes.Text = "Notes";
            // 
            // txtLogNotes
            // 
            txtLogNotes.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtLogNotes.Location = new Point(8, 35);
            txtLogNotes.Multiline = true;
            txtLogNotes.Name = "txtLogNotes";
            txtLogNotes.Size = new Size(498, 72);
            txtLogNotes.TabIndex = 0;
            // 
            // errProvider
            // 
            errProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errProvider.ContainerControl = this;
            // 
            // InventoryLogs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1025, 513);
            Controls.Add(grpNotes);
            Controls.Add(btnAdd);
            Controls.Add(btnCancel);
            Controls.Add(btnFirst);
            Controls.Add(btnLast);
            Controls.Add(btnNext);
            Controls.Add(btnDelete);
            Controls.Add(grpEmployee);
            Controls.Add(btnPrevious);
            Controls.Add(btnSave);
            Controls.Add(grpInventoryLog);
            Controls.Add(grpProduct);
            Name = "InventoryLogs";
            Tag = "";
            Text = "Inventory";
            Load += InventoryLogs_Load;
            ((System.ComponentModel.ISupportInitialize)imgLogPhoto).EndInit();
            grpEmployee.ResumeLayout(false);
            grpEmployee.PerformLayout();
            grpInventoryLog.ResumeLayout(false);
            grpInventoryLog.PerformLayout();
            grpProduct.ResumeLayout(false);
            grpProduct.PerformLayout();
            grpNotes.ResumeLayout(false);
            grpNotes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errProvider).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblProductName;
        private PictureBox imgLogPhoto;
        private Button btnAdd;
        private Button btnCancel;
        private Label lblProductDescription;
        private Label lblProductCategory;
        private Button btnFirst;
        private Button btnLast;
        private Button btnNext;
        private TextBox txtProductDescription;
        private Button btnDelete;
        private TextBox txtProductCategory;
        private TextBox txtEmployeePosition;
        private TextBox txtEmployeeName;
        private Label lblEmployeePosition;
        private Label lblProductStatus;
        private GroupBox grpEmployee;
        private TextBox txtLogQuantity;
        private Label lblExpirationDate;
        private Label lblLogDate;
        private Label lblQuantity;
        private Label lblLogIdValue;
        private Label lblLogId;
        private Button btnPrevious;
        private Button btnSave;
        private GroupBox grpInventoryLog;
        private GroupBox grpProduct;
        private GroupBox grpNotes;
        private TextBox txtLogNotes;
        private RadioButton rdoRemove;
        private RadioButton rdoAdd;
        private DateTimePicker dtpLogExpiration;
        private ErrorProvider errProvider;
        private DateTimePicker dtpLogDate;
        private ComboBox comboBox1;
        private ComboBox cmbProducts;
    }
}