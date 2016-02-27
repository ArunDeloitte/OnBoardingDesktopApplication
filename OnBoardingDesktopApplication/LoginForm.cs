using System;
using System.Data.OleDb;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace OnBoardingDesktopApplication
{
    public partial class LoginForm : Form
    {
        static readonly string appFolderPath = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
        private static string dbpath = Path.Combine(Directory.GetParent(appFolderPath).Parent.FullName, "Resource") + @"\dBase\Welcome2Deloitte.accdb";
        OleDbConnection _accDbCon = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + dbpath + ";Persist Security Info=True");
        private OleDbCommand _acDbCommand;
        private OleDbDataReader _drDataTableReader;
        public OleDbConnection AccDbCon
        {
            get { return _accDbCon; }
            set { _accDbCon = value; }
        }


        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                _accDbCon.Open();
                _acDbCommand = new OleDbCommand("Select * from UserCredentials",_accDbCon);
                //_drDataTableReader = new OleDbDataReader(connection: _accDbCon);
               _drDataTableReader = _acDbCommand.ExecuteReader();
                
                while (_drDataTableReader != null && _drDataTableReader.Read())
                {
                    string col1 = _drDataTableReader[0].ToString() + "," + _drDataTableReader[1].ToString() + "," + _drDataTableReader[2].ToString();
                    if (_drDataTableReader == null || !_drDataTableReader[1].ToString().Equals(txtUsername.Text) ||
                        !_drDataTableReader[2].ToString().Equals(txtPasword.Text)) continue;
                    var nForm1 = new Form1(txtUsername.Text);
                    //Form1.Username = txtUsername.Text;
                    nForm1.Show();
                    Hide();

                }

            }
            catch (NullReferenceException)
            {
                
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
