using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CM = System.Configuration.ConfigurationManager;

namespace InventorySystemProject.Forms
{
    public partial class frmDataGridViews : Form
    {
        private static string connectionString = CM.ConnectionStrings["IMSDatabase"].ConnectionString;

        private static string dbName = CM.ConnectionStrings["IMSDatabase"].Name.ToString();

        public frmDataGridViews()
        {
            InitializeComponent();
            Load += frmDataGridViews_Load;
        }

        private void frmDataGridViews_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        public void GridUpdate(object sender, EventArgs e)
        {
            string selectedTable;

            ToolStripMenuItem m = ((ToolStripMenuItem)sender);
            selectedTable = m.Tag.ToString();

            PopulateDataAdapter(selectedTable);

            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.FillWeight = 1;
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            updateStatusMDI(GlobalData.lblRecordStatus.ToString(), "");
        }

        private void PopulateDataAdapter(string table)
        {
            string query = $"SELECT * FROM {table}";

            string msg;
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridView1.DataSource = dt;
                        msg = $"The \"{dbName}\" table \"{table}\" has {dt.Rows.Count} records.";
                        GlobalData.lblRecordStatus = msg;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Data Adapter Error");
            }

        }

        private void updateStatusMDI(string statusText, string? statusText2)
        {
            if (this.MdiParent is mdiMainMenu mdiParentForm)
            {
                mdiParentForm.updateLabels(statusText, statusText2);
            }
        }
    }
}
