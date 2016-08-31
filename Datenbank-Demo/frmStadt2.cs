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
    public partial class frmStadt2 : Form
        {
        public frmStadt2()
            {
            InitializeComponent();
            }

        private void frmStadt2_Load(object sender, EventArgs e)
            {
            String SQLString;

            DataTable dt;
            SqlDataAdapter da;

            dt = new DataTable();
 
            SQLString = "Select ' -- unbekannt -- ' as Name,'00000000-0000-0000-0000-000000000000' as Land_ID";
            da = new SqlDataAdapter(SQLString, clsGlobals.g_conn);
            da.Fill(dt);

            SQLString = "Select  Name, Land_ID from tblLand order by Name";
            da = new SqlDataAdapter(SQLString, clsGlobals.g_conn);
            da.Fill(dt);

            //DataRow dr;
            //dr = dt.NewRow();
            //dr["Name"] = " -- unbekannt ---";
            //dt.Rows.InsertAt(dr, 0);

            cboLand.DataSource = dt;
            cboLand.DisplayMember = "Name";
            cboLand.ValueMember = "Land_ID";
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
                com.Parameters.AddWithValue("@ID_Land", cboLand.SelectedValue);



            anzahl = com.ExecuteNonQuery();
            if (anzahl == 1)
                MessageBox.Show("Die Stadt wurde erfolgreich aufgenommen");
            else
                MessageBox.Show("hat nicht geklappt", "Kleine Fehlermeldung", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
  
 
          
            }

 
        }
    }
