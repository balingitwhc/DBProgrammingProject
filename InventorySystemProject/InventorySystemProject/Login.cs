using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventorySystemProject
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private string position;

        public string userPosition
        { get { return position; } set { position = value; } }

        private void Login_Load(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }

        private void LoadAccess()
        {
            string sql = $@"
                SELECT [EmployeeId], [Position] FROM Employees
                WHERE Username = '{txtUsername.Text.Trim()}'
                    AND [Password] = HASHBYTES('SHA2_256', '{txtPassword.Text.Trim()}')
            ";

            DataTable dt = DataAccess.GetData(sql);

            if (dt.Rows.Count == 1)
            {
                DataRow access = dt.Rows[0];
                position = Convert.ToString(dt.Rows[0]["Position"]);
                DialogResult = DialogResult.OK;
            }

            else
            {
                DialogResult = DialogResult.Abort;
            }
        }

        private void chkShowPass_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chkShowPass.Checked;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoadAccess();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
