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
    public partial class Employees : Form
    {
        public Employees()
        {
            InitializeComponent();
        }

        int currentEmployeeId = 0;
        int firstEmployeeId = 0;
        int lastEmployeeId = 0;
        int? previousEmployeeId;
        int? nextEmployeeId;
        string userAccess = GlobalData.accessLevel;

        private void frmEmployees_Load(object sender, EventArgs e)
        {
            LoadFirstEmployee();
        }

        /// <summary>
        /// Add event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            UT.ClearControls(this.grpName.Controls);
            UT.ClearControls(this.grpEmployeeDetails.Controls);
            UT.ClearControls(this.grpContactInfo.Controls);
            lblEmployeeIdValue.Text = string.Empty;

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
                DeleteEmployee();
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
                    if (string.IsNullOrEmpty(lblEmployeeIdValue.Text))
                    {
                        CreateEmployee();
                    }
                    else
                    {
                        SaveEmployeeChanges();
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
            LoadEmployeeDetails();

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
        private void frmEmployees_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }

        #region [Retrieves]

        /// <summary>
        /// Load the first instructor ordered by LastName and FirstName
        /// </summary>
        private void LoadFirstEmployee()
        {

            try
            {
                object employeeId = DataAccess.GetValue("SELECT TOP (1) EmployeeId FROM Employees ORDER BY LastName, FirstName");

                if (employeeId == null)
                {
                    NavigationState(false);

                    btnAdd_Click(null, null);
                    btnCancel.Enabled = false;
                    return;
                }

                NavigationState(true);

                firstEmployeeId = Convert.ToInt32(employeeId);
                currentEmployeeId = firstEmployeeId;
                LoadEmployeeDetails();
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
        private void LoadEmployeeDetails()
        {
            errProvider.Clear();

            string[] sqlStatements = new string[]
            {
                $"SELECT * FROM Employees WHERE EmployeeId = {currentEmployeeId}",
                $@"
                SELECT 
                (
                    SELECT TOP(1) EmployeeId as FirstEmployeeId FROM Employees ORDER BY LastName,FirstName
                ) as FirstEmployeeId,
                q.PreviousEmployeeId,
                q.NextEmployeeId,
                (
                    SELECT TOP(1) EmployeeId as LastEmployeeId FROM Employees ORDER BY LastName Desc,FirstName Desc
                ) as LastEmployeeId
                FROM
                (
                    SELECT EmployeeId, LastName, FirstName,
                    LEAD(EmployeeId) OVER(ORDER BY LastName,FirstName) AS NextEmployeeId,
                    LAG(EmployeeId) OVER(ORDER BY LastName,FirstName) AS PreviousEmployeeId,
                    ROW_NUMBER() OVER(ORDER BY LastName, FirstName) AS 'RowNumber'
                    FROM Employees
                ) AS q
                WHERE q.EmployeeId = {currentEmployeeId}
                ORDER BY q.LastName,q.FirstName"
            };

            DataSet ds = new DataSet();
            ds = DataAccess.GetData(sqlStatements);

            if (ds.Tables[0].Rows.Count == 1)
            {
                DataRow selectedEmployee = ds.Tables[0].Rows[0];

                txtFirstName.Text = selectedEmployee["FirstName"].ToString();
                txtMiddleName.Text = selectedEmployee["MiddleName"].ToString();
                txtLastName.Text = selectedEmployee["LastName"].ToString();
                lblEmployeeIdValue.Text = selectedEmployee["EmployeeId"].ToString();
                txtPosition.Text = selectedEmployee["Position"].ToString();
                txtUsername.Text = selectedEmployee["Username"].ToString();
                txtPassword.Text = selectedEmployee["Password"].ToString();
                txtPhone.Text = selectedEmployee["Phone"].ToString();
                txtEmail.Text = selectedEmployee["Email"].ToString();

                firstEmployeeId = Convert.ToInt32(ds.Tables[1].Rows[0]["FirstEmployeeId"]);
                previousEmployeeId = ds.Tables[1].Rows[0]["PreviousEmployeeId"] != DBNull.Value ? Convert.ToInt32(ds.Tables["Table1"].Rows[0]["PreviousEmployeeId"]) : (int?)null;
                nextEmployeeId = ds.Tables[1].Rows[0]["NextEmployeeId"] != DBNull.Value ? Convert.ToInt32(ds.Tables["Table1"].Rows[0]["NextEmployeeId"]) : (int?)null;
                lastEmployeeId = Convert.ToInt32(ds.Tables[1].Rows[0]["LastEmployeeId"]);

            }
            else
            {
                LoadFirstEmployee();
            }
        }

        #endregion

        #region [NonQuery]

        private void DeleteEmployee()
        {
            string sql = $@"
                DELETE FROM Employees WHERE EmployeeId = {currentEmployeeId}
            ";

            int rowsAffected = DataAccess.ExecuteNonQuery(sql);

            if (rowsAffected == 1)
            {
                MessageBox.Show($"EmployeeId: {lblEmployeeIdValue.Text} was deleted");
                LoadFirstEmployee();
            }
            else if (rowsAffected == 0)
            {
                MessageBox.Show($"EmployeeId: {lblEmployeeIdValue.Text} does not exist. May already have been delete.");
                LoadFirstEmployee();
            }
        }

        private void SaveEmployeeChanges()
        {
            string sql = $@"
                UPDATE [dbo].[Employees]
                SET [FirstName]     = '{txtFirstName.Text.Trim()}'
                    ,[MiddleName]   = '{txtMiddleName.Text.Trim()}'
                    ,[LastName]     = '{txtLastName.Text.Trim()}'
                    ,[Position]     = '{txtPosition.Text.Trim()}'
                    ,[Email]        = '{txtEmail.Text.Trim()}'
                    ,[Phone]        = '{txtPhone.Text.Trim()}'
                    ,[Username]     = '{txtUsername.Text.Trim()}'
                    ,[Password]     = HASHBYTES('SHA2_256', '{txtPassword.Text.Trim()}')
                WHERE EmployeeId    = {lblEmployeeIdValue.Text}
            ";

            int rowsAffected = DataAccess.ExecuteNonQuery(sql);

            if (rowsAffected == 1)
            {
                MessageBox.Show($"EmployeeId: {lblEmployeeIdValue.Text} changes saved");
            }
            else
            {
                MessageBox.Show($"Update to EmployeeId: {lblEmployeeIdValue.Text} was not updated.");
            }
        }


        /// <summary>
        /// Insert instructor
        /// </summary>
        private void CreateEmployee()
        {
            string sqlInsertEmployee = $@"
                INSERT INTO [dbo].[Employees]
                    ([FirstName], [MiddleName], [LastName], [Position], [Email], [Phone], [Username],[Password])
                VALUES
                    (
                        '{txtFirstName.Text.Trim()}'
                        ,'{txtMiddleName.Text.Trim()}'
                        ,'{txtLastName.Text.Trim()}'
                        ,'{txtPosition.Text.Trim()}'
                        ,'{txtEmail.Text.Trim()}'
                        ,'{txtPhone.Text.Trim()}'
                        ,'{txtUsername.Text.Trim()}'
                        ,HASHBYTES('SHA2_256', '{txtPassword.Text.Trim()}')
                    )
            ";

            int rowsAffected = DataAccess.ExecuteNonQuery(sqlInsertEmployee);

            if (rowsAffected == 1)
            {
                MessageBox.Show("Employee as created");
                btnCancel_Click(null, null);
                NextPreviousButtonManagement();
                LoadFirstEmployee();
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
            btnPrevious.Enabled = previousEmployeeId != null;
            btnNext.Enabled = nextEmployeeId != null;
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
                    currentEmployeeId = firstEmployeeId;
                    break;
                case "btnLast":
                    currentEmployeeId = lastEmployeeId;
                    break;
                case "btnPrevious":
                    currentEmployeeId = previousEmployeeId.Value;
                    break;
                case "btnNext":
                    currentEmployeeId = nextEmployeeId.Value;
                    break;
            }

            LoadEmployeeDetails();
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
