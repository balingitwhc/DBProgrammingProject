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
        private string[] tables = new string[]
            { "Categories","Customers", "Products", "Region", "Shippers", "Suppliers", "NotATable" };
        private static string connectionString = CM.ConnectionStrings["Northwind"].ConnectionString;

        private static string dbName = CM.ConnectionStrings["IMSDatabase"].Name.ToString();

        public frmDataGridViews()
        {
            InitializeComponent();
        }

        private void frmDataGridViews_Load(object sender, EventArgs e)
        {
            foreach (string table in tables)
            {
                comboBox1.Items.Add(table);
            }
        }

        private void cmbTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedTable = comboBox1.SelectedItem.ToString();
            PopulateDataAdapter(selectedTable);
        }

        private void PopulateDataAdapter(string table)
        {
            string query = $"SELECT * FROM {table}";

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
                        //GlobalData.lblRecordStatus.ToString() = $"The {dbName} table {table} has {dt.Rows.Count} rows.";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Data Adapter Error");
            }

        }
    }
}
