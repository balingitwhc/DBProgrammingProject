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
    public partial class frmProducts : Form
    {
        public frmProducts()
        {
            InitializeComponent();
        }

        int currentProductId = 0;
        int firstProductId = 0;
        int lastProductId = 0;
        int? previousProductId;
        int? nextProductId;

        private void frmProducts_Load(object sender, EventArgs e)
        {
            LoadFirstProduct();
        }


        /// <summary>
        /// Add event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            UT.ClearControls(this.grpProduct.Controls);
            UT.ClearControls(this.grpProductDetails.Controls);
            UT.ClearControls(this.grpProductState.Controls);
            lblProductIdValue.Text = string.Empty;

            btnSave.Text = "Create";
            btnAdd.Enabled = false;
            btnDelete.Enabled = false;

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
                DeleteProduct();
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
                    if (string.IsNullOrEmpty(lblProductIdValue.Text))
                    {
                        CreateProduct();
                    }
                    else
                    {
                        SaveProductChanges();
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
            LoadProductDetails();

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
        private void frmProducts_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }

        #region [Retrieves]

        /// <summary>
        /// Load the first instructor ordered by LastName and FirstName
        /// </summary>
        private void LoadFirstProduct()
        {

            try
            {
                object employeeId = DataAccess.GetValue("SELECT TOP (1) ProductId FROM Products ORDER BY ProductName");

                if (employeeId == null)
                {
                    NavigationState(false);

                    btnAdd_Click(null, null);
                    btnCancel.Enabled = false;
                    return;
                }

                NavigationState(true);

                firstProductId = Convert.ToInt32(employeeId);
                currentProductId = firstProductId;
                LoadProductDetails();
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
        private void LoadProductDetails()
        {
            errProvider.Clear();

            string[] sqlStatements = new string[]
            {
                $"SELECT * FROM Products WHERE ProductId = {currentProductId}",
                $@"
                SELECT 
                (
                    SELECT TOP(1) ProductId as FirstProductId FROM Products ORDER BY ProductName
                ) as FirstProductId,
                q.PreviousProductId,
                q.NextProductId,
                (
                    SELECT TOP(1) ProductId as LastProductId FROM Products ORDER BY ProductName Desc
                ) as LastProductId
                FROM
                (
                    SELECT ProductId, ProductName,
                    LEAD(ProductId) OVER(ORDER BY ProductName) AS NextProductId,
                    LAG(ProductId) OVER(ORDER BY ProductName) AS PreviousProductId,
                    ROW_NUMBER() OVER(ORDER BY ProductName) AS 'RowNumber'
                    FROM Products
                ) AS q
                WHERE q.ProductId = {currentProductId}
                ORDER BY q.ProductName"
            };

            DataSet ds = new DataSet();
            ds = DataAccess.GetData(sqlStatements);

            if (ds.Tables[0].Rows.Count == 1)
            {
                DataRow selectedProduct = ds.Tables[0].Rows[0];

                txtProductName.Text = selectedProduct["ProductName"].ToString();
                txtProductDescription.Text = selectedProduct["ProductDescription"].ToString();
                txtProductCategory.Text = selectedProduct["ProductCategory"].ToString();
                lblProductIdValue.Text = selectedProduct["ProductId"].ToString();
                txtQuantity.Text = selectedProduct["Quantity"].ToString();
                txtUnit.Text = selectedProduct["Unit"].ToString();
                txtUnitPrice.Text = selectedProduct["UnitPrice"].ToString();
                txtProductStatus.Text = selectedProduct["State"].ToString();
                txtMaxStockAmt.Text = selectedProduct["MaxStock"].ToString();

                firstProductId = Convert.ToInt32(ds.Tables[1].Rows[0]["FirstProductId"]);
                previousProductId = ds.Tables[1].Rows[0]["PreviousProductId"] != DBNull.Value ? Convert.ToInt32(ds.Tables["Table1"].Rows[0]["PreviousProductId"]) : (int?)null;
                nextProductId = ds.Tables[1].Rows[0]["NextProductId"] != DBNull.Value ? Convert.ToInt32(ds.Tables["Table1"].Rows[0]["NextProductId"]) : (int?)null;
                lastProductId = Convert.ToInt32(ds.Tables[1].Rows[0]["LastProductId"]);

            }
            else
            {
                LoadFirstProduct();
            }
        }

        #endregion

        #region [NonQuery]

        private void DeleteProduct()
        {
            string sql = $@"
                DELETE FROM Products WHERE ProductId = {currentProductId}
            ";

            int rowsAffected = DataAccess.ExecuteNonQuery(sql);

            if (rowsAffected == 1)
            {
                MessageBox.Show($"ProductId: {lblProductIdValue.Text} was deleted");
                LoadFirstProduct();
            }
            else if (rowsAffected == 0)
            {
                MessageBox.Show($"ProductId: {lblProductIdValue.Text} does not exist. May already have been delete.");
                LoadFirstProduct();
            }
        }

        private void SaveProductChanges()
        {
            string sql = $@"
                UPDATE [dbo].[Products]
                    SET [ProductName]           = '{txtProductName.Text.Trim()}'
                       ,[ProductDescription]    = '{txtProductDescription.Text.Trim()}'
                       ,[ProductCategory]       = '{txtProductCategory.Text.Trim()}'
                       ,[Quantity]              = '{txtQuantity.Text.Trim()}'
                       ,[Unit]                  = '{txtUnit.Text.Trim()}'
                       ,[UnitPrice]             = '{txtUnitPrice.Text.Trim()}'
                       ,[State]                 = '{txtProductStatus.Text.Trim()}'
                       ,[MaxStock]              = '{txtMaxStockAmt.Text.Trim()}'
                WHERE ProductId                 = {lblProductIdValue.Text}
            ";

            int rowsAffected = DataAccess.ExecuteNonQuery(sql);

            if (rowsAffected == 1)
            {
                MessageBox.Show($"ProductId: {lblProductIdValue.Text} changes saved");
            }
            else
            {
                MessageBox.Show($"Update to ProductId: {lblProductIdValue.Text} was not updated.");
            }
        }


        /// <summary>
        /// Insert instructor
        /// </summary>
        private void CreateProduct()
        {
            string sqlInsertProduct = $@"
                INSERT INTO [dbo].[Products]
                    ([ProductName],[ProductDescription],[ProductCategory],[Quantity],[Unit],[UnitPrice],[State],[MaxStock])
                VALUES
                    (
                         '{txtProductName.Text.Trim()}'
                        ,'{txtProductDescription.Text.Trim()}'
                        ,'{txtProductCategory.Text.Trim()}'
                        ,'{txtQuantity.Text.Trim()}'
                        ,'{txtUnit.Text.Trim()}'
                        ,'{txtUnitPrice.Text.Trim()}'
                        ,'{txtProductStatus.Text.Trim()}'
                        ,'{txtMaxStockAmt.Text.Trim()}'
                    )
            ";

            int rowsAffected = DataAccess.ExecuteNonQuery(sqlInsertProduct);

            if (rowsAffected == 1)
            {
                MessageBox.Show("Product as created");
                btnCancel_Click(null, null);
                NextPreviousButtonManagement();
                LoadFirstProduct();
            }
            else
            {
                MessageBox.Show("The database reported no rows affected");
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
            btnPrevious.Enabled = previousProductId != null;
            btnNext.Enabled = nextProductId != null;
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
                    currentProductId = firstProductId;
                    break;
                case "btnLast":
                    currentProductId = lastProductId;
                    break;
                case "btnPrevious":
                    currentProductId = previousProductId.Value;
                    break;
                case "btnNext":
                    currentProductId = nextProductId.Value;
                    break;
            }

            LoadProductDetails();
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
    }
}
