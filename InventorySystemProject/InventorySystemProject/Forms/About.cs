using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventorySystemProject.Forms
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void About_Load(object sender, EventArgs e)
        {
            label1.Text = $"Product Name: {Application.ProductName}";
            label2.Text = $"Company Name: {Application.CompanyName}";
            label3.Text = $"Product Version: {Application.ProductVersion}";
            label4.Text = $"Executable Path: {Application.ExecutablePath}";
            //label6.Text = $"Base Directory: {AppDomain.CurrentDomain.BaseDirectory}";
            //label7.Text = $"User Domain Name: {Environment.UserDomainName}";
            //label8.Text = $"User Name: {Environment.UserName}";
            //label9.Text = $"OS Version: {Environment.OSVersion}";
            //label10.Text = $"System Directory: {Environment.SystemDirectory}";
            //label11.Text = $"CLR Version: {Environment.Version}";
            //label12.Text = $"User Interactive: {Environment.UserInteractive}";
            //label13.Text = $"Processor Count: {Environment.ProcessorCount}";
            //label14.Text = $"Is 64-Bit Operating System: {Environment.Is64BitOperatingSystem}";
            //label15.Text = $"Is 64-Bit Process: {Environment.Is64BitProcess}";
            //label16.Text = $"Machine Name: {Environment.MachineName}";
            //label17.Text = $"Network Domain Name: {Environment.UserDomainName}";
        }
    }
}
