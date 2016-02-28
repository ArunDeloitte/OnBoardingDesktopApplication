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
    public partial class ITSReport2 : Form
    {
        public ITSReport2()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dgvITSReport2.DataSource = null;
                dgvITSReport2.Rows.Clear();
                dgvITSReport2.Refresh();
                var location = comboBox1.SelectedItem.ToString();
                if (location == "Bangalore")
                {
                    dgvITSReport2.DataSource = locationBangaloreBindingSource;
                    // TODO: This line of code loads data into the 'welcome2DeloitteDataSet.Location_Bangalore' table. You can move, or remove it, as needed.
                    this.location_BangaloreTableAdapter.Fill(this.welcome2DeloitteDataSet.Location_Bangalore);
                    dgvITSReport2.Refresh();
                }
                else if (location == "Gurgaon")
                {
                    dgvITSReport2.DataSource = locationGurgaonBindingSource;
                    // TODO: This line of code loads data into the 'welcome2DeloitteDataSet.Location_Gurgaon' table. You can move, or remove it, as needed.
                    this.location_GurgaonTableAdapter.Fill(this.welcome2DeloitteDataSet.Location_Gurgaon);
                }
                else if (location == "Hyderabad")
                {
                    dgvITSReport2.DataSource = locationHyderabadBindingSource;
                    // TODO: This line of code loads data into the 'welcome2DeloitteDataSet.Location_Hyderabad' table. You can move, or remove it, as needed.
                    this.location_HyderabadTableAdapter.Fill(this.welcome2DeloitteDataSet.Location_Hyderabad);
                }
                else if (location == "Mumbai")
                {
                    dgvITSReport2.DataSource = locationMumbaiBindingSource;
                    // TODO: This line of code loads data into the 'welcome2DeloitteDataSet.Location_Mumbai' table. You can move, or remove it, as needed.
                    this.location_MumbaiTableAdapter.Fill(this.welcome2DeloitteDataSet.Location_Mumbai);
                }
                else
                {
                    dgvITSReport2.Rows.Clear();
                    dgvITSReport2.Refresh();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void ITSReport2_Load(object sender, EventArgs e)
        {
            
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            try
            {
                // creating Excel Application
                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();


                // creating new WorkBook within Excel application
                Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);


                // creating new Excelsheet in workbook
                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;

                // see the excel sheet behind the program
                app.Visible = true;

                // get the reference of first sheet. By default its name is Sheet1.
                // store its reference to worksheet
                worksheet = workbook.Sheets["Sheet1"];
                worksheet = workbook.ActiveSheet;

                // changing the name of active sheet
                worksheet.Name = "Onboarding";


                // storing header part in Excel
                for (int i = 1; i < dgvITSReport2.Columns.Count + 1; i++)
                {
                    worksheet.Cells[1, i] = dgvITSReport2.Columns[i - 1].HeaderText;
                }



                // storing Each row and column value to excel sheet
                for (int i = 0; i < dgvITSReport2.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dgvITSReport2.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = dgvITSReport2.Rows[i].Cells[j].Value.ToString();
                    }
                }


                // save the application
                workbook.SaveAs("C:\\Users\\achuthabhanu\\Downloads\\ITSReport.xlsx", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);

                // Exit from the application
                app.Quit();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
