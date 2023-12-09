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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        int loginCounter = 3;

        private void Login_Load(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }

        private void LoadAccess()
        {
            string sql = $@"
                SELECT CONCAT(FirstName, ' ',LastName) AS [FullName] ,[EmployeeId], [Position]
                FROM Employees
                WHERE Username = '{txtUsername.Text.Trim()}'
                    AND [Password] = HASHBYTES('SHA2_256', '{txtPassword.Text.Trim()}')
            ";

            DataTable dt = DataAccess.GetData(sql);

            if (dt.Rows.Count == 1)
            {
                DataRow access = dt.Rows[0];
                GlobalData.userAccess = Convert.ToString(dt.Rows[0]["Position"]);
                GlobalData.userId = Convert.ToString(dt.Rows[0]["EmployeeId"]);
                GlobalData.userFullName = Convert.ToString(dt.Rows[0]["FullName"]);
                DialogResult = DialogResult.OK;
            }

            else
            {
                if (loginCounter > 0)
                {
                    loginCounter--;
                    UT.ClearControls(this.Controls);
                    MessageBox.Show($"Login Attempts Left : {loginCounter}");
                    if (loginCounter == 0)
                    {
                        DialogResult = DialogResult.Abort;
                        MessageBox.Show($"Maximum Login Attempts Reached, Terminating App.");
                        Application.Exit();
                    }
                }
            }
        }

        private void chkShowPass_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chkShowPass.Checked;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoadAccess();
            Login_Load(sender, e);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Application.Exit();
        }
    }
}
