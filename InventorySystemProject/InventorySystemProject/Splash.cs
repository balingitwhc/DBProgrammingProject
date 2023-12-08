namespace InventorySystemProject
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            lblProduct.Text = Application.ProductName;
            lblVersion.Text = Application.ProductVersion;
            lblCompany.Text = Application.CompanyName;
        }

        private void tmrLoad_Tick(object sender, EventArgs e)
        {
            if (prgSplash.Value < 100)
                prgSplash.Increment(1);

            else
            {
                tmrLoad.Enabled = false;
                mdiMainMenu f = new();

                f.Show();
                f.FormClosed += new FormClosedEventHandler(mdiClose);
                this.Hide();
            }
        }

        private void mdiClose(object? sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}