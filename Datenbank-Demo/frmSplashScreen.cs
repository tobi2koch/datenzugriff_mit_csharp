using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Threading;

namespace Datenbank_Demo
    {
    public partial class frmSplashScreen : Form
        {
        public frmSplashScreen()
            {
            InitializeComponent();
            }

        private void frmSplashScreen_Load(object sender, EventArgs e)
            {
  

            }

        private void frmSplashScreen_Shown(object sender, EventArgs e)
            {
            clsCryptConnectionInfo cci = new clsCryptConnectionInfo();
            SqlConnectionStringBuilder csb = new SqlConnectionStringBuilder();

            Application.DoEvents();

            //cci.ReadFromFile(Application.StartupPath + "\\" + "Verbindung.dat");
            //cci.ReadFromFile(Application.StartupPath + @"\" + "Verbindung.dat");
            //cci.ReadFromFile(Application.StartupPath + "\\Verbindung.dat");
      


            cci.ReadFromFile(Path.Combine(Application.StartupPath, "Verbindung.dat"));

            csb.Password = cci.Password;
            csb.DataSource = cci.Server;
            csb.UserID = cci.Username;
            csb.InitialCatalog = cci.Database;

            clsGlobals.g_conn = new SqlConnection(csb.ConnectionString);
            try
                {
                clsGlobals.g_conn.Open();
                //               MessageBox.Show("Supi");

                Thread.Sleep(500);

                frmHauptform haupt;
                haupt = new frmHauptform();
                this.Visible = false;
                this.Hide();

                haupt.ShowDialog();
                this.Close();

              
                }
            catch (Exception ex)
                {
                MessageBox.Show("Verbindungsaufbau ging schief\n\n" + ex.Message, "Kleine Fehlermeldung", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
                //lblAnzeige.Text = "Fehler";
                //txtFehlermeldung.Text = ex.Message;
                //this.Height = 373;
                }
            }

        private void cmdOk_Click(object sender, EventArgs e)
            {
            this.Close();
            }

 
        }
    }
