using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnBoardingDesktopApplication
{
    public partial class Welcome2Deloitte : Form
    {
        public Welcome2Deloitte()
        {
            InitializeComponent();
        }

        private void pnlSearch_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void searchFormITS_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'welcome2DeloitteDataSet.OnBoarding' table. You can move, or remove it, as needed.
            this.onBoardingTableAdapter.Fill(this.welcome2DeloitteDataSet.OnBoarding);
            // TODO: This line of code loads data into the 'welcome2DeloitteDataSet.Domains' table. You can move, or remove it, as needed.
            this.domainsTableAdapter.Fill(this.welcome2DeloitteDataSet.Domains);

        }
    }
}
