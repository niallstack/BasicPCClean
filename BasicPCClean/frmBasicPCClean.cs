using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management.Automation;
using System.Collections.ObjectModel;
using System.Management.Automation.Runspaces;

namespace BasicPCClean
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        private void frmMain_Load(object sender, EventArgs e)
        {

        }
        private void btnRemoveTemp_Click(object sender, EventArgs e)
        {
            ResetTemp.RemoveTemp();
            MessageBox.Show("All temporary files that could be removed, were removed");
        }    
        private void btnResetIE_Click(object sender, EventArgs e)
        {
            ResetIExplorer.ResetIE();
            MessageBox.Show("Internet Explorer has been reset");
        }
        private void btnResetCCChrome_Click(object sender, EventArgs e)
        {
            ResetChrome.ResetCCChrome();
            MessageBox.Show("Google Chrome's cache and cookies have been deleted");
        }
    }
}
