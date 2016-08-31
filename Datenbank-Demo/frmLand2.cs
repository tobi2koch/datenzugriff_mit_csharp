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
    public partial class frmLand2 : Form
        {
        int modus;
        public frmLand2(int wert)
            {
            modus = wert;
            InitializeComponent();
            }

        private void cmdSuchen_Click(object sender, EventArgs e)
            {
            if (modus == 1)
                {
                SqlCommand com;
                String SQLString;

                SQLString = "Select name from tblLand where internetkuerzel = @suche";

                MessageBox.Show(SQLString);

                com = new SqlCommand(SQLString, clsGlobals.g_conn);
                com.Parameters.AddWithValue("@suche", txtInternetkuerzel.Text);

                txtLand.Text = Convert.ToString(com.ExecuteScalar());
                }
            if (modus == 2)
                {
                SqlCommand com;
                String SQLString;

                SQLString = "sptblLandGetLandByInternetkuerzel";


                com = new SqlCommand(SQLString, clsGlobals.g_conn);
                com.Parameters.AddWithValue("@p_Internetkuerzel", txtInternetkuerzel.Text);
                com.CommandType = CommandType.StoredProcedure;
                txtLand.Text = Convert.ToString(com.ExecuteScalar());
                }

            }
        }
    }
