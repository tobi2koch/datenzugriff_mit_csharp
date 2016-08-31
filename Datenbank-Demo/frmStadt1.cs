using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Datenbank_Demo
    {
    public partial class frmStadt1 : Form
        {
        public frmStadt1()
            {
            InitializeComponent();
            }

        private void frmStadt1_Load(object sender, EventArgs e)
            {
            SqlCommand com;
            String SQLString;
            SqlDataReader dr;
 
            cboLand.Items.Add("<unbekannt>");
            cboLand_ID.Items.Add("");


            SQLString = "Select  Name, Land_ID from tblLand order by Name";

            com = new SqlCommand(SQLString, clsGlobals.g_conn);

            dr = com.ExecuteReader();
 
            while (dr.Read())
                {
                cboLand.Items.Add(dr["Name"].ToString());
                cboLand_ID.Items.Add(dr["Land_ID"].ToString());
                }
            dr.Close();

            cboLand.SelectedIndex = 0;
            }

            

        private void cmdSpeichern_Click(object sender, EventArgs e)
            {
            SqlCommand com;
            String SQLString;
            int anzahl;

            Guid g = Guid.NewGuid();

            SQLString = "Insert into tblStadt (Stadt_ID, Name, Einwohnerzahl, Laengengrad, Breitengrad, ID_Land) "
                + "values  (@Stadt_ID, @Name, @Einwohnerzahl, @Laengengrad, @Breitengrad, @ID_Land)";

            com = new SqlCommand(SQLString, clsGlobals.g_conn);
            com.Parameters.AddWithValue("@Stadt_ID", g);
            com.Parameters.AddWithValue("@Name", txtStadt.Text);
            com.Parameters.AddWithValue("@Einwohnerzahl", txtEinwohnerzahl.Text);
            com.Parameters.AddWithValue("@Laengengrad", Convert.ToDouble(txtLaengengrad.Text));
            com.Parameters.AddWithValue("@Breitengrad", Convert.ToDouble(txtBreitengrad.Text));
            if (cboLand.SelectedIndex == 0)
                com.Parameters.AddWithValue("@ID_Land", DBNull.Value);
            else
                com.Parameters.AddWithValue("@ID_Land", cboLand_ID.Items[cboLand.SelectedIndex]);

    

            anzahl = com.ExecuteNonQuery();
            if (anzahl == 1)
                MessageBox.Show("Die Stadt wurde erfolgreich aufgenommen");
            else
                MessageBox.Show("hat nicht geklappt", "Kleine Fehlermeldung", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
  
            }

  
        }
    }
