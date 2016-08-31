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
    public partial class frmDataGridView : Form
        {
        public frmDataGridView()
            {
            InitializeComponent();
            }

        private void cmdDoIt1_Click(object sender, EventArgs e)
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

            dgvAnzeige.DataSource = dt;

            dgvAnzeige.Columns.Remove("Stadt_ID");
            dgvAnzeige.Columns.Remove("ID_Land");

            }
        }
    }
