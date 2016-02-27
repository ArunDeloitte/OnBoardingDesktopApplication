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
    public partial class Form1 : Form
    {

        
        public Form1(string username)
        {
            InitializeComponent();
            if (username != string.Empty)
            {
                if (username.Equals("SuperUser"))
                {
                    username = "W2D Administartor";
                    
                }
                else if (username.Equals("ITSUser"))
                {
                    username = "USI ITS User";
                }
                else
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
                var nForm1 = new SearchForm();
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

        }
    }
}
