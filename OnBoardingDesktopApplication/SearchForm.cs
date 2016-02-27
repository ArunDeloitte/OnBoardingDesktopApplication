﻿using System;
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
    public partial class SearchForm : Form
    {
        static readonly string appFolderPath = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
        private static string dbpath = Path.Combine(Directory.GetParent(appFolderPath).Parent.FullName, "Resource") + @"\dBase\Welcome2Deloitte.accdb";
        OleDbConnection _accDbCon = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + dbpath + ";Persist Security Info=True");
        private OleDbCommand _acDbCommand;
        private OleDbDataAdapter _dbDataAdapter;
        private DataTable _dtDataTable;
        public OleDbConnection AccDbCon
        {
            get { return _accDbCon; }
            set { _accDbCon = value; }
        }
        public SearchForm()
        {
            InitializeComponent();
        }

        private void btnBarCode_Click(object sender, EventArgs e)
        {
            txtBarcode.ReadOnly = true;
            string barcode=txtBarcode.Text;
            GetDatafromDb("Candidate_ID="+barcode);
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
                    lblDtlName.Text = VARIABLE["CandidateFirstName"].ToString() + VARIABLE["CandidateLastName"].ToString();
                    lblDtlRegisteredEmailId.Text = VARIABLE["CandidateEmail"].ToString();
                    lblDtlW2DDate.Text = VARIABLE["Tentative_StartDate"].ToString();
                    lblDtlLocation.Text = VARIABLE["Hiring_Location"].ToString();
                    lblDtlFunction.Text = VARIABLE["Function"].ToString();
                    lblDtlTOHire.Text = VARIABLE["TypeofHire"].ToString();
                    lblDtlTableNumber.Text = "10";
                    lblLaptopStatus.Text = VARIABLE["Laptop_Status"].ToString();
                    string _bgv = VARIABLE["BGV"].ToString();

                    if (_bgv == String.Empty)
                        pnlBGVStatus.BackColor = ColorTranslator.FromHtml("#99ca49");
                    else
                    {
                        pnlBGVStatus.BackColor = Color.DarkRed;
                        ;
                    }
                }
            }
            
            
        }

        private void btnBarCode_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void btnBarCode_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void btnBarCode_KeyUp(object sender, KeyEventArgs e)
        {

        }

        public void GetDatafromDb(string searchId)
        {
            try
            {
                _accDbCon.Open();
                _dbDataAdapter =
                    new OleDbDataAdapter(
                        "Select CandidateFirstName,CandidateLastName,CandidateMobilePhone,CandidateEmail,Sequence_Number,Candidate_ID,Employee_ID,Tentative_StartDate,Hiring_Location,Function,TypeofHire,BGV,Laptop_Status from OnBoarding where" + searchId,
                        _accDbCon);
                _dtDataTable= new DataTable();
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
            if(txtEmployeeID.Text!=String.Empty)
                GetDatafromDb("Employee_ID=" + txtEmployeeID.Text);

            if(txtEmailID.Text!=String.Empty)
                GetDatafromDb("CandidateEmail=" + txtEmailID.Text);

            if (txtMobile.Text != String.Empty)
                GetDatafromDb("CandidateMobilePhone=" + txtMobile.Text);

            if (txtRMSID.Text != String.Empty)
                GetDatafromDb("Candidate_ID=" + txtRMSID.Text);
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                _accDbCon.Open();
                _acDbCommand =
                    new OleDbCommand(
                        "update OnBoarding set Joining_Status=Confirm where Candidate_ID=" + txtRMSID.Text,
                        _accDbCon);
                _acDbCommand.ExecuteNonQuery();
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

        private void btnHold_Click(object sender, EventArgs e)
        {
            try
            {
                _accDbCon.Open();
                _acDbCommand =
                    new OleDbCommand(
                        "update OnBoarding set Joining_Status=Hold where Candidate_ID=" + txtRMSID.Text,
                        _accDbCon);
                _acDbCommand.ExecuteNonQuery();
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