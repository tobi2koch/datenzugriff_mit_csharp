using System;
using System.Windows.Forms;
// Namensraum für SQL-Klassen
using System.Data.SqlClient;
using System.Data;

namespace Datenbank_Demo
    {
    public partial class frmHauptform : Form
        {
        SqlConnection conn;


        public frmHauptform()
            {
            InitializeComponent();
            }

        private void cmdGuidErzeugen_Click(object sender, EventArgs e)
            {
            Guid myGuid;

            myGuid = Guid.NewGuid();

            MessageBox.Show("Die GUID ist: " + myGuid);

            }

        private void cmdWindowsAuthentifizierung_Click(object sender, EventArgs e)
            {
            //String connectionString;

            ////  connectionString = @"Server=localhost\sqlexpress;Database=dbWelt;Trusted_Connection=True;";
            ////           connectionString = "Server=localhost;Database=dbWelt;Trusted_Connection=True;";
            ////connectionString = "Server=(local);Database=dbWelt;Trusted_Connection=True;";
            ////connectionString = "Server=.;Database=dbWelt;Trusted_Connection=True;";
            //// connectionString = "Server=MR108DZW10;Database=dbWelt;Trusted_Connection=True;";
            //connectionString = "Server=.;Database=dbWeglt;Integrated Security=SSPI;Connection Timeout=15";
            //conn = new SqlConnection(connectionString);
            //try
            //    {
            //    conn.Open();
            //    MessageBox.Show("Supi");
            //    }
            //catch (Exception ex)
            //    {
            //    MessageBox.Show("Verbindungsaufbau ging schief\n\n" + ex.Message,"Kleine Fehlermeldung",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            //    }
            }

        private void cmdSQLServerAuthentifizierung_Click(object sender, EventArgs e)
            {
            //String connectionString;

            //connectionString = "Server=(local); Database=dbWelt; User ID=max; Password=mustermann";
            //conn = new SqlConnection(connectionString);
            //try
            //    {
            //    conn.Open();
            //    MessageBox.Show("Supi");
            //    }
            //catch (Exception ex)
            //    {
            //    MessageBox.Show("Verbindungsaufbau ging schief\n\n" + ex.Message, "Kleine Fehlermeldung", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    }
            }

        private void cmdMitConnectionStringBuilder_Click(object sender, EventArgs e)
            {
            SqlConnectionStringBuilder csb = new SqlConnectionStringBuilder();

            csb.Password = "mustermann";
            csb.DataSource = "(local)";
            csb.UserID = "Max Mustermann";
            csb.InitialCatalog = "dbWelt";

            conn = new SqlConnection(csb.ConnectionString);
            try
                {
                conn.Open();
                MessageBox.Show("Supi");
                }
            catch (Exception ex)
                {
                MessageBox.Show(" 1. Verbindungsaufbau ging schief\n\n" + ex.Message, "Kleine Fehlermeldung", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }


            }

        private void cmdMitCryptConnectionInfo_Click(object sender, EventArgs e)
            {
            clsCryptConnectionInfo cci = new clsCryptConnectionInfo();
            SqlConnectionStringBuilder csb = new SqlConnectionStringBuilder();

            cci.ReadFromFile("Verbindung.dat");

            csb.Password = cci.Password;
            csb.DataSource = cci.Server;
            csb.UserID = cci.Username;
            csb.InitialCatalog = cci.Database;

            conn = new SqlConnection(csb.ConnectionString);
            try
                {
                conn.Open();
                MessageBox.Show("Supi");
                }
            catch (Exception ex)
                {
                MessageBox.Show("" + ex.Message, "Kleine Fehlermeldung", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }

        private void cmdENQkonstant_Click(object sender, EventArgs e)
            {
            SqlCommand com;
            String SQLString;
            int anzahl;

            Guid g = Guid.NewGuid();

            SQLString =  "Insert into tblland (Land_ID, Name, Einwohnerzahl, Internetkuerzel) "
                + "values ('" + g + "','Lappland', 123, 'lp')";

            

            MessageBox.Show(SQLString);

  
            com = new SqlCommand(SQLString, clsGlobals.g_conn);


            //com = new SqlCommand();
            //com.Connection = clsGlobals.g_conn;
            //com.CommandText = SQLString;

            anzahl = com.ExecuteNonQuery();
            if (anzahl == 1)
                MessageBox.Show("Das Land wurde erfolgreich aufgenommen");
            else
               MessageBox.Show("hat nicht geklappt","Kleine Fehlermeldung",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);


            }

        private void cmdENQmitStringverknüpfung_Click(object sender, EventArgs e)
            {
            frmLand1 frm;
            frm = new frmLand1(1);
            frm.ShowDialog();

            //frmLand1 frm= new frmLand1();
            //frm.ShowDialog();

            // new frmLand1().ShowDialog();



            }

        private void cmdENQmitParameter_Click(object sender, EventArgs e)
            {
            frmLand1 frm;
            frm = new frmLand1(2);
            frm.ShowDialog();
            }

        private void cmdENQmitSP_Click(object sender, EventArgs e)
            {
            frmLand1 frm;
            frm = new frmLand1(3);
            frm.ShowDialog();
            }

        private void cmdESkonstant_Click(object sender, EventArgs e)
            {
            SqlCommand com;
            String SQLString;
            int anzahl;

            SQLString = "Select count(*) from tblLand";

            MessageBox.Show(SQLString);

            com = new SqlCommand(SQLString, clsGlobals.g_conn);
          
            
            anzahl = Convert.ToInt32(com.ExecuteScalar());
            MessageBox.Show(anzahl+"");

            }

        private void cmdESmitParameter_Click(object sender, EventArgs e)
            {
            frmLand2 frm;
            frm = new frmLand2(1);
            frm.ShowDialog();
            }

        private void cmdESmitSP_Click(object sender, EventArgs e)
            {
            frmLand2 frm;
            frm = new frmLand2(2);
            frm.ShowDialog();
            }

        private void cmdERkonstant_Click(object sender, EventArgs e)
            {
            SqlCommand com;
            String SQLString;
            SqlDataReader dr;
            String laendernamen = ""; ;

            SQLString = "Select distinct Name from tblLand order by Name";

            com = new SqlCommand(SQLString, clsGlobals.g_conn);


            dr = com.ExecuteReader();

            while (dr.Read())
                {

                laendernamen = laendernamen + dr["Name"].ToString() + Environment.NewLine;

               // MessageBox.Show(dr.GetString(1));
               // MessageBox.Show(dr[1].ToString());
               // MessageBox.Show(dr["Name"].ToString());
                }
            dr.Close();
            MessageBox.Show(laendernamen, "Länderliste");

  
            }

        private void cmdERmitParameter_Click(object sender, EventArgs e)
            {
            frmLand3 frm;
            frm = new frmLand3();
            frm.ShowDialog();
            }

        private void cmdListboxSchlecht_Click(object sender, EventArgs e)
            {
            frmStadt1 frm;
            frm = new frmStadt1();
            frm.ShowDialog();
 
            }

        private void cmdDataset_Click(object sender, EventArgs e)
            {
            String SQLString;

            DataTable dt;
            SqlDataAdapter da;

            SQLString = "Select * from tblLand";

            dt = new DataTable();

            da = new SqlDataAdapter(SQLString, clsGlobals.g_conn);

            da.Fill(dt);


            MessageBox.Show(dt.Rows.Count+"");
            }

        private void cmdListboxGut_Click(object sender, EventArgs e)
            {
            frmStadt2 frm;
            frm = new frmStadt2();
            frm.ShowDialog();

            }

        private void cmdDGV_Click(object sender, EventArgs e)
            {
            frmDataGridView frm;
            frm = new frmDataGridView();
            frm.ShowDialog();

            }

        private void cmdDGVuniversell_Click(object sender, EventArgs e)
            {
            String SQLString;
            DataTable dt;
            SqlDataAdapter da;

            SQLString = "SELECT tblStadt.*, tblLand.Name AS Ländername " +
                        "FROM tblStadt left JOIN " +
                        "tblLand ON tblStadt.ID_Land = tblLand.Land_ID";

            // MessageBox.Show(SQLString);
            dt = new DataTable();
            da = new SqlDataAdapter(SQLString, clsGlobals.g_conn);
            da.Fill(dt);



            frmUebersichtDataGridView frm;
            frm = new frmUebersichtDataGridView();


            frm.TableToShow = dt;
            frm.HiddenColumns = "Stadt_ID|ID_Land";
            frm.SelectMode = frmUebersichtDataGridView.enumSelectMode.Single;
            frm.KeyColumn = "Stadt_ID";
            frm.ShowDialog();

            MessageBox.Show(frm.SelectedGuid + "");
               
            }

   
        }
    }
