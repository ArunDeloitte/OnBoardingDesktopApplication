using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OnBoardingDesktopApplication.Properties;

namespace OnBoardingDesktopApplication
{
    public partial class Form1 : Form
    {

        
        public Form1(string username)
        {
            InitializeComponent();
            if (username != string.Empty)
            {
                if (username.Equals("SuperUser") || username.Equals("W2D Administartor"))
                {
                    username = "W2D Administartor";
                    
                }
                else if (username.Equals("ITSUser"))
                {
                    username = "USI ITS User";
                }
                else if (username.Equals("USI Logistics") || username.Equals("USILogistics"))
                {
                    username = "USI Logistics";
                }
                lblUser.Text = username;
            }
            

        }
        
        private void btnOverview_Click(object sender, EventArgs e)
        {

        }

        private void bTNsEARCH_Click(object sender, EventArgs e)
        {
            if (lblUser.Text.Equals("W2D Administartor") || lblUser.Text.Equals("USI Logistics"))
            {
                var nForm1 = new SearchForm(lblUser.Text);
                nForm1.Show();
            }
            else
            {
                var nForm1 = new Welcome2Deloitte();
                nForm1.Show();
            }

            this.Hide();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            if (lblUser.Text.Equals("W2D Administartor") || lblUser.Text.Equals("USI Logistics"))
            {
                var nForm1 = new AdminReport(lblUser.Text, "All");
                nForm1.Show();
            }
            else
            {
                var nForm1 = new ReportITS();
                nForm1.Show();
            }

            this.Hide();
        }

        private void pnlHyd_Click(object sender, EventArgs e)
        {
            var nForm1 = new AdminReport(lblUser.Text, "BLR");
            nForm1.Show();
            Hide();
        }

        private void btnLogOff_Click(object sender, EventArgs e)
        {
            var nForm1 = new LoginForm();
            nForm1.Show();
            Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (lblUser.Text.Equals("W2D Administartor") || lblUser.Text.Equals("USI Logistics"))
            {
                pnlHyd.BackgroundImage = Resources.BLR___W2D_Screen;
                pnlBlr.BackgroundImage = Resources.HYD___W2D_Screen;
                pnlGur.BackgroundImage = Resources.GUR___W2D_Screen;
                pnlMum.BackgroundImage = Resources.MUM___W2D_Screen;
            }
            else
            {
                pnlHyd.BackgroundImage = Resources.BLR___ITS_Screen;
                pnlBlr.BackgroundImage = Resources.HYD___ITS_Screen;
                pnlGur.BackgroundImage = Resources.GUR___ITS_Screen;
                pnlMum.BackgroundImage = Resources.MUM___ITS_Screen;
            }
        }
    }
}
