using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Datenbank_Demo
    {
    public partial class frmLand1 : Form
        {
        int modus;

        public frmLand1(int wert)
            {
            InitializeComponent();
            modus = wert;
            }

        private void cmdSpeichern_Click(object sender, EventArgs e)
            {



            if (modus == 1)
                {
                SqlCommand com;
                String SQLString;
                int anzahl;

                Guid g = Guid.NewGuid();

                SQLString = "Insert into tblland (Land_ID, Name, Einwohnerzahl, Internetkuerzel) "
                    + "values ('" + g + "','" + txtLand.Text + "', "
                    + txtEinwohnerzahl.Text + ", '" + txtInternetkuerzel.Text + "')";

                MessageBox.Show(SQLString);
                com = new SqlCommand(SQLString, clsGlobals.g_conn);
                //com = new SqlCommand();
                //com.Connection = clsGlobals.g_conn;
                //com.CommandText = SQLString;
                anzahl = com.ExecuteNonQuery();
                if (anzahl == 1)
                    MessageBox.Show("Das Land wurde erfolgreich aufgenommen");
                else
                    MessageBox.Show("hat nicht geklappt", "Kleine Fehlermeldung", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            if (modus == 2)
                {
                SqlCommand com;
                String SQLString;
                int anzahl;

                Guid g = Guid.NewGuid();

                SQLString = "Insert into tblland (Land_ID, Name, Einwohnerzahl, Internetkuerzel) "
                    + "values (@Land_ID, @Name, @Einwohnerzahl, @Internetkuerzel)";

                MessageBox.Show(SQLString);
                com = new SqlCommand(SQLString, clsGlobals.g_conn);
                com.Parameters.AddWithValue("@Land_ID", g);
                com.Parameters.AddWithValue("@Name", txtLand.Text);
                com.Parameters.AddWithValue("@Einwohnerzahl", txtEinwohnerzahl.Text);
                com.Parameters.AddWithValue("@Internetkuerzel", txtInternetkuerzel.Text);

                anzahl = com.ExecuteNonQuery();
                if (anzahl == 1)
                    MessageBox.Show("Das Land wurde erfolgreich aufgenommen");
                else
                    MessageBox.Show("hat nicht geklappt", "Kleine Fehlermeldung", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            if (modus == 3)
                {
                SqlCommand com;
                int anzahl;

                // Plausibili


                try
                    {
                    Guid g = Guid.NewGuid();

                    com = new SqlCommand("sptblLandInsert", clsGlobals.g_conn);
                    com.CommandType = CommandType.StoredProcedure;
                    com.Parameters.AddWithValue("@p_Land_ID", g);
                    com.Parameters.AddWithValue("@p_Name", txtLand.Text);
                    com.Parameters.AddWithValue("@p_Einwohnerzahl", txtEinwohnerzahl.Text);
                    com.Parameters.AddWithValue("@p_Internetkuerzel", txtInternetkuerzel.Text);

                    anzahl = com.ExecuteNonQuery();
                    if (anzahl == 1)
                        MessageBox.Show("Das Land wurde erfolgreich aufgenommen");
                    else
                        MessageBox.Show("hat nicht geklappt", "Kleine Fehlermeldung", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }
                catch (Exception ex)
                    {
                    MessageBox.Show(ex.Message);
                    }
                }

            }

  
          
        }
    }
