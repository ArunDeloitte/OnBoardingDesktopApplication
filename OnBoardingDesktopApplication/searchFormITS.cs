using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnBoardingDesktopApplication
{
    public partial class Welcome2Deloitte : Form
    {
        static readonly string appFolderPath = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
        private static string dbpath = Path.Combine(Directory.GetParent(appFolderPath).Parent.FullName, "Resource") + @"\dBase\Welcome2Deloitte.accdb";
        OleDbConnection _accDbCon = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + dbpath + ";Persist Security Info=True");
        private OleDbCommand _acDbCommand;
        private OleDbDataAdapter _dbDataAdapter;
        private DataTable _dtDataTable;
        public Welcome2Deloitte()
        {
            InitializeComponent();
            lblUser.Text = "USI ITS User";
            lblLapTop.Visible = false;
        }

        private void searchFormITS_Load(object sender, EventArgs e)
        {
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 nForm1 = new Form1(lblUser.Text);
            nForm1.Show();
            Hide();
        }

        private void btnReady_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Please Select the cadidates Laptop Status", "Laptop Status",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, 0, true);
                if (result == DialogResult.OK) ;
                {
                    _accDbCon.Open();
                    _acDbCommand =
                        new OleDbCommand(
                            "update  OnBoarding set ITS_Laptop_Status='Ready to Issue' where Candidate_ID=" + txtRMSID.Text,
                            _accDbCon);
                    _acDbCommand.ExecuteNonQuery();
                }

                if (result == DialogResult.Cancel)
                {
                    MessageBox.Show("Status not updated");
                }

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                _accDbCon.Close();
            }


        }

        private void btnBarCode_Click(object sender, EventArgs e)
        {

            string barcode = txtBarcode.Text;
            GetDatafromDb("Candidate_ID=" + barcode);
            PopulateData();
        }
        public void PopulateData()
        {
            if (_dtDataTable.Rows.Count > 0)
            {
                foreach (DataRow VARIABLE in _dtDataTable.Rows)
                {
                    txtFirstName.Text = VARIABLE["CandidateFirstName"].ToString();
                    txtLastName.Text = VARIABLE["CandidateLastName"].ToString();
                    txtMobile.Text = VARIABLE["CandidateMobilePhone"].ToString();
                    txtEmailID.Text = VARIABLE["CandidateEmail"].ToString();
                    txtSeqNo.Text = VARIABLE["Sequence_Number"].ToString();
                    txtRMSID.Text = VARIABLE["Candidate_ID"].ToString();
                    txtEmployeeID.Text = VARIABLE["Employee_ID"].ToString();
                    lblDtlName.Text = VARIABLE["CandidateFirstName"].ToString() +" "+ VARIABLE["CandidateLastName"].ToString();
                    lblDtlEmail.Text = VARIABLE["CandidateEmail"].ToString();
                    lblDtlPhone.Text = VARIABLE["CandidateMobilePhone"].ToString();
                    lblOffCycle.Text = DateTime.Parse(VARIABLE["Tentative_StartDate"].ToString()).ToString("yy-MMM-dd ddd") + " " + VARIABLE["W2D_OffCycle"].ToString();
                    lblDtlLocation.Text = VARIABLE["Hiring_Location"].ToString();
                    lblDtlFunction.Text = VARIABLE["Function"].ToString();
                    lblDtlTOH.Text = VARIABLE["TypeofHire"].ToString();
                    lblDtlTable.Text = "10";
                    lblLapTop.Text = VARIABLE["ITS_Laptop_Status"].ToString();
                    lblLapTop.Visible = true;
                    string _status = VARIABLE["W2D_Day1"].ToString();
                    
                }
            }
        }
        public void GetDatafromDb(string searchId)
        {
            try
            {
                _accDbCon.Open();
                _dbDataAdapter =
                    new OleDbDataAdapter(
                        "Select CandidateFirstName,CandidateLastName,CandidateMobilePhone,CandidateEmail,Sequence_Number,Candidate_ID,Employee_ID,Tentative_StartDate,W2D_OffCycle,Hiring_Location,Function,TypeofHire,BGV,ITS_Laptop_Status,W2D_Day1,W2D_Day2 from OnBoarding where " + searchId,
                        _accDbCon);
                _dtDataTable = new DataTable();
                _dbDataAdapter.Fill(_dtDataTable);


            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                _accDbCon.Close();
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtEmailID.Text == String.Empty && txtMobile.Text == String.Empty && txtEmployeeID.Text == String.Empty &&
                txtRMSID.Text == String.Empty) return;
            if (txtEmployeeID.Text != String.Empty)
            {
                GetDatafromDb("Employee_ID=" + txtEmployeeID.Text);
                PopulateData();
            }


            if (txtEmailID.Text != String.Empty)
            {
                GetDatafromDb("CandidateEmail='" + txtEmailID.Text + "'");
                PopulateData();
            }


            if (txtMobile.Text != String.Empty)
            {
                GetDatafromDb("CandidateMobilePhone='" + txtMobile.Text + "'");
                PopulateData();
            }


            if (txtRMSID.Text != String.Empty)
            {
                GetDatafromDb("Candidate_ID=" + txtRMSID.Text);
                PopulateData();
            }
        }

        private void btnNotIssued_Click(object sender, EventArgs e)
        {
            string status = comboBox1.Text;
            try
            {
                DialogResult result = MessageBox.Show("Please Select the cadidates Laptop Status", "Laptop Status",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, 0, true);
                if (result == DialogResult.OK) ;
                {
                    _accDbCon.Open();
                    _acDbCommand =
                        new OleDbCommand(
                            "update  OnBoarding set ITS_Laptop_Status='"+status+"' where Candidate_ID=" + txtRMSID.Text,
                            _accDbCon);
                    _acDbCommand.ExecuteNonQuery();
                }

                if (result == DialogResult.Cancel)
                {
                    MessageBox.Show("Status not updated");
                }

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                _accDbCon.Close();
            }

        }

    }
}
