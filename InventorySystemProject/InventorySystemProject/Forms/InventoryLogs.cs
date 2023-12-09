using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UT = InventorySystemProject.UIUtilities;

namespace InventorySystemProject
{
    public partial class InventoryLogs : Form
    {
        public InventoryLogs()
        {
            InitializeComponent();
        }

        int currentInventoryLogId = 0;
        int firstInventoryLogId = 0;
        int lastInventoryLogId = 0;
        int? previousInventoryLogId;
        int? nextInventoryLogId;
        int logCount = 0;
        int maxStock = 0;
        int currentQuantityChange = 0;
        int updatedQuantityChange = 0;
        int productQuantity = 0;


        private void InventoryLogs_Load(object sender, EventArgs e)
        {
            LoadEmployees();
            LoadProducts();
            LoadFirstInventoryLog();

            switch (GlobalData.AccessLevel())
            {
                case 5:
                    // Admininstrator has FULL ACCESS
                    break;
                case 4:
                    // Manager has complete access of THE LOGS ONLY
                    break;
                case 3:
                    // Stock Clerk can only CREATE AND DELETE LOGS
                    btnSave.Enabled = false;
                    break;
                case 0:
                    // THIS WILL TRIGGER GUEST MODE which cannot do anything but simply view the form in any case
                    UT.ClearControls(this.grpProduct.Controls);
                    UT.ClearControls(this.grpInventoryLog.Controls);
                    UT.ClearControls(this.grpEmployee.Controls);
                    UT.ClearControls(this.grpNotes.Controls);

                    UT.DisableControls(this.grpProduct.Controls);
                    UT.DisableControls(this.grpInventoryLog.Controls);
                    UT.DisableControls(this.grpEmployee.Controls);
                    UT.DisableControls(this.grpNotes.Controls);

                    lblLogIdValue.Text = string.Empty;
                    rdoAdd.Checked = false;
                    rdoRemove.Checked = false;
                    dtpLogDate.Value = DateTime.Now.Date;
                    dtpLogExpiration.Value = DateTime.Now.Date;
                    NavigationState(false);
                    DDLControlState(false);
                    break;
                default:
                    // Cashier and Deli Positions can only VIEW
                    DDLControlState(false);
                    break;
            }
        }

        private void DDLControlState(bool state)
        {
            btnAdd.Enabled = state;
            btnDelete.Enabled = state;
            btnSave.Enabled = state;
            btnCancel.Enabled = state;
        }

        private void LoadProducts()
        {
            string sql = @"
                SELECT ProductId, ProductName, ProductDescription, ProductCategory
                FROM Products
                ORDER BY ProductName
            ";

            DataTable dtProducts = DataAccess.GetData(sql);

            cmbProducts.Bind(dtProducts, "ProductName", "ProductId", "--- SELECT PRODUCT ---");
        }

        private void LoadEmployees()
        {

        }

        /// <summary>
        /// Add event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            UT.ClearControls(this.grpProduct.Controls);
            UT.ClearControls(this.grpInventoryLog.Controls);
            UT.ClearControls(this.grpEmployee.Controls);
            UT.ClearControls(this.grpNotes.Controls);

            lblLogIdValue.Text = string.Empty;
            rdoAdd.Checked = false;
            rdoRemove.Checked = false;
            dtpLogDate.Value = DateTime.Now.Date;
            //dtpLogDate.Format = DateTimePickerFormat.Custom;
            //dtpLogDate.CustomFormat = "YYYY-MM-DD";

            dtpLogExpiration.Value = DateTime.Now.Date;
            //dtpLogExpiration.Format = DateTimePickerFormat.Custom;
            //dtpLogExpiration.CustomFormat = "YYYY-MM-DD";



            txtEmployeeName.Text = GlobalData.userFullName;
            txtEmployeePosition.Text = GlobalData.userAccess;

            btnSave.Text = "Create";
            btnAdd.Enabled = false;
            btnDelete.Enabled = false;

            cmbProducts_SelectedIndexChanged(sender, e);
            NavigationState(false);
        }

        /// <summary>
        /// Delete click event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DeleteInventoryLog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Save click event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateChildren(ValidationConstraints.Enabled))
                {
                    if (string.IsNullOrEmpty(lblLogIdValue.Text))
                    {
                        CreateInventoryLog();
                    }
                    else
                    {
                        SaveInventoryLogChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            LoadInventoryLogDetails();

            btnSave.Text = "Save";
            btnAdd.Enabled = true;
            btnDelete.Enabled = true;

            NavigationState(true);
            NextPreviousButtonManagement();
        }

        /// <summary>
        /// Allow an invalid form to close
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmInventoryLogs_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }

        #region [Retrieves]

        /// <summary>
        /// Load the first instructor ordered by LastName and FirstName
        /// </summary>
        private void LoadFirstInventoryLog()
        {

            try
            {
                object inventoryLogId = DataAccess.GetValue("SELECT TOP (1) InventoryLogId FROM Inventory ORDER BY ExpirationDate, InventoryLogDate");

                if (inventoryLogId == null)
                {
                    NavigationState(false);

                    btnAdd_Click(null, null);
                    btnCancel.Enabled = false;
                    return;
                }

                NavigationState(true);

                firstInventoryLogId = Convert.ToInt32(inventoryLogId);
                currentInventoryLogId = firstInventoryLogId;
                LoadInventoryLogDetails();
                NextPreviousButtonManagement();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        /// <summary>
        /// 
        /// </summary>
        private void LoadInventoryLogDetails()
        {
            errProvider.Clear();

            string[] sqlStatements = new string[]
            {
                $@"
                SELECT
                    InventoryLogId, QuantityChange, InventoryLogDate, ExpirationDate, InventoryAction, Notes,
                    Inv.EmployeeId, CONCAT(Emp.FirstName, ' ',Emp.LastName) AS 'EmployeeName', Emp.Position,
                    Inv.ProductId, Prod.ProductName, Prod.ProductDescription, Prod.ProductCategory, Prod.Quantity, Prod.MaxStock
                FROM Inventory AS Inv
                JOIN Employees AS Emp ON Inv.EmployeeID = Emp.EmployeeID
                JOIN Products AS Prod ON Inv.ProductID = Prod.ProductID
                    WHERE InventoryLogId = {currentInventoryLogId}
                ",
                $@"
                SELECT 
                (
                    SELECT TOP(1) InventoryLogId as FirstInventoryLogId FROM Inventory ORDER BY ExpirationDate, InventoryLogDate
                ) as FirstInventoryLogId,
                q.PreviousInventoryLogId,
                q.NextInventoryLogId,
                (
                SELECT TOP(1) InventoryLogId as LastInventoryLogId FROM Inventory ORDER BY ExpirationDate Desc,InventoryLogDate Desc
                ) as LastInventoryLogId, (SELECT COUNT(InventoryLogId) FROM Inventory) as 'LogCount'
                FROM
                (
                SELECT InventoryLogId, ExpirationDate, InventoryLogDate,
                    LEAD(InventoryLogId) OVER(ORDER BY ExpirationDate, InventoryLogDate) AS NextInventoryLogId,
                    LAG(InventoryLogId) OVER(ORDER BY ExpirationDate, InventoryLogDate) AS PreviousInventoryLogId,
                    ROW_NUMBER() OVER(ORDER BY ExpirationDate, InventoryLogDate) AS 'RowNumber'
                    FROM Inventory
                ) AS q
                WHERE q.InventoryLogId = {currentInventoryLogId}
                ORDER BY q.ExpirationDate,q.InventoryLogDate"
            };

            DataSet dsInventory = new DataSet();
            dsInventory = DataAccess.GetData(sqlStatements);

            //cmbProductId.Bind(dsInventory,"ProductId", "InventoryLogId");

            if (dsInventory.Tables[0].Rows.Count == 1)
            {
                DataRow selectedInventoryLog = dsInventory.Tables[0].Rows[0];

                cmbProducts.SelectedValue = selectedInventoryLog["ProductId"];
                txtProductDescription.Text = selectedInventoryLog["ProductDescription"].ToString();
                txtProductCategory.Text = selectedInventoryLog["ProductCategory"].ToString();
                lblLogIdValue.Text = selectedInventoryLog["InventoryLogId"].ToString();
                txtLogQuantity.Text = selectedInventoryLog["QuantityChange"].ToString();
                rdoRemove.Checked = Convert.ToInt32(txtLogQuantity.Text) < 0;
                rdoAdd.Checked = !rdoRemove.Checked;
                dtpLogDate.Text = selectedInventoryLog["InventoryLogDate"].ToString();
                dtpLogExpiration.Text = selectedInventoryLog["ExpirationDate"].ToString();
                txtEmployeeName.Text = selectedInventoryLog["EmployeeName"].ToString();
                txtEmployeePosition.Text = selectedInventoryLog["Position"].ToString();
                txtLogNotes.Text = selectedInventoryLog["Notes"].ToString();

                firstInventoryLogId = Convert.ToInt32(dsInventory.Tables[1].Rows[0]["FirstInventoryLogId"]);
                previousInventoryLogId = dsInventory.Tables[1].Rows[0]["PreviousInventoryLogId"] != DBNull.Value ? Convert.ToInt32(dsInventory.Tables["Table1"].Rows[0]["PreviousInventoryLogId"]) : (int?)null;
                nextInventoryLogId = dsInventory.Tables[1].Rows[0]["NextInventoryLogId"] != DBNull.Value ? Convert.ToInt32(dsInventory.Tables["Table1"].Rows[0]["NextInventoryLogId"]) : (int?)null;
                lastInventoryLogId = Convert.ToInt32(dsInventory.Tables[1].Rows[0]["LastInventoryLogId"]);

                maxStock = Convert.ToInt32(selectedInventoryLog["MaxStock"].ToString());
                currentQuantityChange = Convert.ToInt32(txtLogQuantity.Text.Trim());
                productQuantity = Convert.ToInt32(selectedInventoryLog["Quantity"].ToString());
                logCount = Convert.ToInt32(dsInventory.Tables[1].Rows[0]["LogCount"]);

            }
            else
            {
                LoadFirstInventoryLog();
            }
        }

        #endregion

        #region [NonQuery]

        private void DeleteInventoryLog()
        {
            string sql = $@"
                DELETE FROM Inventory WHERE InventoryLogId = {currentInventoryLogId}
            ";

            int rowsAffected = DataAccess.ExecuteNonQuery(sql);

            if (rowsAffected == 1)
            {
                MessageBox.Show($"InventoryLogId: {lblLogIdValue.Text} was deleted");
                LoadFirstInventoryLog();
            }
            else if (rowsAffected == 0)
            {
                MessageBox.Show($"InventoryLogId: {lblLogIdValue.Text} does not exist. May already have been delete.");
                LoadFirstInventoryLog();
            }
        }

        private void SaveInventoryLogChanges()
        {
            string inventoryAction = rdoAdd.Checked ? "Purchase" : rdoRemove.Checked ? "Sale" : "";
            updatedQuantityChange = Convert.ToInt32(txtLogQuantity.Text.Trim());

            // UPDATE CHANGE ON PRODUCT AMOUNT WHEN EDITING A STORED LOG...
            try
            {
                int checkQuantity = productQuantity;
                checkQuantity += updatedQuantityChange + (-currentQuantityChange);

                if (checkQuantity < 0 || checkQuantity > (maxStock * 1.5))
                {
                    throw new Exception();
                }

                else
                {
                    productQuantity += updatedQuantityChange + (-currentQuantityChange);

                    string sql = $@"
                        UPDATE [dbo].[Inventory]
                        SET [EmployeeId]			= '{GlobalData.userId.Trim()}'
                            ,[ProductId]			= '{cmbProducts.SelectedValue}'
                            ,[QuantityChange]		= {Convert.ToInt32(txtLogQuantity.Text.Trim())}
                            ,[InventoryLogDate]	    = '{dtpLogDate.Value.ToString("yyyy-MM-dd")}'
                            ,[ExpirationDate]		= '{dtpLogExpiration.Value.ToString("yyyy-MM-dd")}'
                            ,[InventoryAction]	    = '{inventoryAction.Trim()}'
                            ,[Notes]				= '{txtLogNotes.Text.Trim()}'
                        WHERE InventoryLogId        = {lblLogIdValue.Text}
                    ";

                    int rowsAffected = DataAccess.ExecuteNonQuery(sql);

                    if (rowsAffected == 1)
                    {
                        MessageBox.Show($"InventoryLogId: {lblLogIdValue.Text} changes saved");
                    }
                    else
                    {
                        MessageBox.Show($"Update to InventoryLogId: {lblLogIdValue.Text} was not updated.");
                    }

                    string inventoryState = "";
                    double stockPercentage = (double)productQuantity/maxStock;

                    if (stockPercentage < 0.2) { inventoryState = "Low Stock"; }
                    else if (stockPercentage > 1.2) { inventoryState = "High Stock"; }
                    else { inventoryState = "In Stock"; }

                    string sql2 = $@"
                        UPDATE [dbo].[Products]
                           SET [ProductDescription] = '{txtProductDescription.Text.Trim()}'
                              ,[ProductCategory]    = '{txtProductCategory.Text.Trim()}'
                              ,[Quantity]           = [Quantity] + {updatedQuantityChange} + {(-currentQuantityChange)}
                              ,[State]              = '{inventoryState.Trim()}'
                         WHERE ProductId            = {cmbProducts.SelectedValue}
                    ";

                    int rowsAffected2 = DataAccess.ExecuteNonQuery(sql2);

                    if (rowsAffected2 == 1)
                    {
                        MessageBox.Show($"ProductId: {cmbProducts.SelectedValue} changes saved");
                    }
                    else
                    {
                        MessageBox.Show($"Update to ProductId: {cmbProducts.SelectedValue} was not updated.");
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("New Product quantity outside of Maximum and Minimum Thresholds. Changes reverted to original values.");
                txtLogQuantity.Text = currentQuantityChange.ToString(); ;
            }
        }


        /// <summary>
        /// Insert instructor
        /// </summary>
        private void CreateInventoryLog()
        {

            string inventoryAction = rdoAdd.Checked ? "Purchase" : rdoRemove.Checked ? "Sale" : "";
            int quantityChange = Convert.ToInt32(txtLogQuantity.Text.Trim());

            // ADD NEW INVENTORY LOG AND UPDATE CHANGE IN PRODUCTS
            try
            {
                int checkQuantity = productQuantity;
                checkQuantity += quantityChange;

                if (checkQuantity < 0 || checkQuantity > (maxStock * 1.5))
                {
                    throw new Exception();
                }
                else
                {
                    productQuantity += quantityChange;

                    string sqlInsertInventoryLog = $@"
                        INSERT INTO [dbo].[Inventory]
                            ([EmployeeId], [ProductId], [QuantityChange], [InventoryLogDate], [ExpirationDate], [InventoryAction], [Notes])
                        VALUES
                            (
                                 '{GlobalData.userId.Trim()}'
                                ,'{cmbProducts.SelectedValue}'
                                ,{Convert.ToInt32(txtLogQuantity.Text.Trim())}
                                ,'{dtpLogDate.Value.ToString("yyyy-MM-dd")}'
                                ,'{dtpLogExpiration.Value.ToString("yyyy-MM-dd")}'
                                ,'{inventoryAction.Trim()}'
                                ,'{txtLogNotes.Text.Trim()}'
                            )
                    ";

                    int rowsAffected = DataAccess.ExecuteNonQuery(sqlInsertInventoryLog);

                    if (rowsAffected == 1)
                    {
                        MessageBox.Show("InventoryLog as created");
                        btnCancel_Click(null, null);
                        NextPreviousButtonManagement();
                        LoadFirstInventoryLog();
                    }
                    else
                    {
                        MessageBox.Show("The database reported no rows affected");
                    }

                    string inventoryState = "";
                    double stockPercentage = (double)productQuantity/maxStock;

                    if (stockPercentage < 0.2) { inventoryState = "Low Stock"; }
                    else if (stockPercentage > 1.2) { inventoryState = "High Stock"; }
                    else { inventoryState = "In Stock"; }

                    string sql2 = $@"
                        UPDATE [dbo].[Products]
                           SET [ProductDescription] = '{txtProductDescription.Text.Trim()}'
                              ,[ProductCategory]    = '{txtProductCategory.Text.Trim()}'
                              ,[Quantity]           = [Quantity] + {quantityChange}
                              ,[State]              = '{inventoryState.Trim()}'
                         WHERE ProductId            = {cmbProducts.SelectedValue}
                    ";

                    int rowsAffected2 = DataAccess.ExecuteNonQuery(sql2);

                    if (rowsAffected2 == 1)
                    {
                        MessageBox.Show($"ProductId: {cmbProducts.SelectedValue} changes saved");
                    }
                    else
                    {
                        MessageBox.Show($"Update to ProductId: {cmbProducts.SelectedValue} was not updated.");
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("New Product quantity outside of Maximum and Minimum Thresholds. Quantity Cleared.");
                txtLogQuantity.Clear();
            }
        }

        #endregion

        #region [Navigation Helpers]

        /// <summary>
        /// Helps manage the enable state of our next and previous navigation buttons
        /// Depending on where we are in products we may need to set enable state based on position
        /// navigation through product records
        /// </summary>
        private void NextPreviousButtonManagement()
        {
            btnPrevious.Enabled = previousInventoryLogId != null;
            btnNext.Enabled = nextInventoryLogId != null;
        }

        /// <summary>
        /// Helper method to set state of all nav buttons
        /// </summary>
        /// <param name="enableState"></param>
        private void NavigationState(bool enableState)
        {
            btnFirst.Enabled = enableState;
            btnLast.Enabled = enableState;
            btnNext.Enabled = enableState;
            btnPrevious.Enabled = enableState;
        }

        /// <summary>
        /// Handle navigation button interaction
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Navigation_Handler(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            switch (b.Name)
            {
                case "btnFirst":
                    currentInventoryLogId = firstInventoryLogId;
                    break;
                case "btnLast":
                    currentInventoryLogId = lastInventoryLogId;
                    break;
                case "btnPrevious":
                    currentInventoryLogId = previousInventoryLogId.Value;
                    break;
                case "btnNext":
                    currentInventoryLogId = nextInventoryLogId.Value;
                    break;
            }

            LoadInventoryLogDetails();
            NextPreviousButtonManagement();
        }

        #endregion

        private void txt_Validating(object sender, CancelEventArgs e)
        {
            TextBox txt = (TextBox)sender;
            string txtBoxName = txt.Tag.ToString();
            string errMsg = null;
            bool failedValidation = false;

            if (txt.Text == string.Empty)
            {
                errMsg = $"{txtBoxName} is required";
                failedValidation = true;
            }

            if (txt.Name == "txtOfficeNumber")
            {
                if (!Validator.IsNumeric(txt.Text))
                {
                    errMsg = $"{txtBoxName} required to be numeric";
                    failedValidation = true;
                }
            }

            e.Cancel = failedValidation;

            errProvider.SetError(txt, errMsg);
        }

        private void rdoAdd_CheckedChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtLogQuantity.Text))
            {
                txtLogQuantity.Text = "0";
            }

            if (rdoAdd.Checked && Convert.ToInt32(txtLogQuantity.Text.Trim()) <= 0)
            {
                txtLogQuantity.Text = txtLogQuantity.Text.Substring(1);
            }
        }

        private void rdoRemove_CheckedChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtLogQuantity.Text))
            {
                txtLogQuantity.Text = "0";
            }

            if (rdoRemove.Checked && Convert.ToInt32(txtLogQuantity.Text.Trim()) >= 0)
            {
                txtLogQuantity.Text = '-' + txtLogQuantity.Text.Trim();
            }
        }

        private void cmbProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (btnSave.Text == "Create")
            {
                string sql = $@"
                    SELECT ProductId, ProductName, ProductDescription, ProductCategory
                    FROM Products
                    WHERE ProductId = {cmbProducts.SelectedValue}
                ";

                DataTable dt = DataAccess.GetData(sql);

                if (dt.Rows.Count == 1 && cmbProducts.SelectedIndex > 0)
                {
                    DataRow access = dt.Rows[0];
                    txtProductDescription.Text = dt.Rows[0]["ProductDescription"].ToString();
                    txtProductCategory.Text = dt.Rows[0]["ProductCategory"].ToString();
                }
                else
                {
                    txtProductDescription.Text = string.Empty;
                    txtProductCategory.Text = string.Empty;
                }
            }
        }
    }
}
