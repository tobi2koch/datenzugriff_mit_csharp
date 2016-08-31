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
    public partial class frmLand3 : Form
        {
        public frmLand3()
            {
            InitializeComponent();
            }

        private void cmdSuchen_Click(object sender, EventArgs e)
            {
            SqlCommand com;
            String SQLString;
            SqlDataReader dr;
            String laendernamen = ""; ;
            int og;
            int ug;

            if (txtEinwohnerzahlVon.Text == "")
                ug = 0;
            else
                ug = Convert.ToInt32(txtEinwohnerzahlVon.Text);

            if (txtEinwohnerzahlBis.Text == "")
                og = int.MaxValue;
            else
                og = Convert.ToInt32(txtEinwohnerzahlBis.Text);

            SQLString = "Select Name, Einwohnerzahl from tblLand where Einwohnerzahl >= @von and Einwohnerzahl <= @bis   order by Einwohnerzahl desc";

            com = new SqlCommand(SQLString, clsGlobals.g_conn);
            com.Parameters.AddWithValue("@von", ug);
            com.Parameters.AddWithValue("@bis", og);

            dr = com.ExecuteReader();

            while (dr.Read())
                {
               // laendernamen += dr["Name"].ToString() + "(" + dr["Einwohnerzahl"].ToString() + ")" + Environment.NewLine;
                laendernamen += String.Format("{0,-20} ({1,12:#,##0})", dr["Name"], dr["Einwohnerzahl"]) + Environment.NewLine;
                // laendernamen += String.Format("{0} ({1:#,##0}){2}", dr["Name"], dr["Einwohnerzahl"] , Environment.NewLine);
                }
            dr.Close();
            txtAusgabe.Text = laendernamen;
            }

   
        }
    }
