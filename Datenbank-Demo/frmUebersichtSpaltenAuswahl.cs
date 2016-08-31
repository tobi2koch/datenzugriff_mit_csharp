using System;
using System.Windows.Forms;

namespace Datenbank_Demo
    {
    public partial class frmUebersichtSpaltenAuswahl : Form
        {
        private string m_GeneralHiddenColumns;
        private DataGridView m_dgvAnzeige;

        #region " Konstruktor "
        public frmUebersichtSpaltenAuswahl(DataGridView dgvAnzeige, String GeneralHiddenColumns)
            {
            InitializeComponent();
            m_dgvAnzeige = dgvAnzeige;
            m_GeneralHiddenColumns = GeneralHiddenColumns;
            }
        #endregion
        
        #region " frmSpaltenAuswahl_Load "
        private void frmSpaltenAuswahl_Load(object sender, EventArgs e)
            {
            try
                {
                foreach (DataGridViewColumn col in m_dgvAnzeige.Columns)
                    {
                    clbSpalten.Items.Add(col.Name, col.Visible);
                    }
                foreach (string s in m_GeneralHiddenColumns.Split('|'))
                    {
                    clbSpalten.Items.Remove(s);
                    }
                }
            catch (Exception ex)
                {
                MessageBox.Show(ex.Message);
                }
            }
        #endregion

        #region " cmdOk_Click "
        private void cmdOk_Click(object sender, EventArgs e)
            {
            try
                {
                for (int i = 0; i < clbSpalten.Items.Count; i++)
                    {
                    m_dgvAnzeige.Columns[clbSpalten.Items[i].ToString()].Visible = clbSpalten.GetItemChecked(i);
                    }
                this.Close();
                }
            catch (Exception ex)
                {
                MessageBox.Show(ex.Message);
                }
            }
        #endregion

        #region " cmdXXXSchalten_Click "
        private void cmdXXXSchalten_Click(object sender, EventArgs e)
            {
            try
                {
                for (int i = 0; i < clbSpalten.Items.Count; i++)
                    {
                    clbSpalten.SetItemChecked(i, Convert.ToBoolean(((Button)sender).Tag));
                    }
                }
            catch (Exception ex)
                {
                MessageBox.Show(ex.Message);
                }
            }
        #endregion

        }
    }
