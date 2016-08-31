using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
namespace Datenbank_Demo
    {
    static class Program
        {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
            {
 //           clsCryptConnectionInfo cci = new clsCryptConnectionInfo();
 //           SqlConnectionStringBuilder csb = new SqlConnectionStringBuilder();


 //           cci.ReadFromFile(Application.StartupPath + "\\" + "Verbindung.dat");
 //           cci.ReadFromFile(Application.StartupPath + @"\" + "Verbindung.dat");
 //           cci.ReadFromFile(Application.StartupPath + "\\Verbindung.dat");

 //           cci.ReadFromFile(Path.Combine(Application.StartupPath, "Verbindung.dat"));

 //           csb.Password = cci.Password;
 //           csb.DataSource = cci.Server + "x";
 //           csb.UserID = cci.Username;
 //           csb.InitialCatalog = cci.Database;
            
 //           clsGlobals.g_conn = new SqlConnection(csb.ConnectionString);
 //           try
 //               {
 //               clsGlobals.g_conn.Open();
 ////               MessageBox.Show("Supi");

 //                 }
 //           catch (Exception ex)
 //               {
 //               MessageBox.Show("Verbindungsaufbau ging schief\n\n" + ex.Message, "Kleine Fehlermeldung", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
 //               }

          Application.EnableVisualStyles();
          Application.SetCompatibleTextRenderingDefault(false);
          Application.Run(new frmSplashScreen());
 


           }
        }
    }
