using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Datenbank_Demo
    {
    public partial class frmUebersichtDataGridView : Form
        {
        #region " Deklarationen "
        #region " Aufzählungsdatentypen "
        public enum enumSelectMode
            {
            /// <summary>
            /// Kein Datensatz kann ausgewählt werden
            /// </summary>
            None = 0,
            /// <summary> 
            /// Genau ein Datensatz muss ausgewählt werden
            /// </summary>
            Single = 1,
            /// <summary> 
            /// Ein oder mehrere Datensätze müssen ausgewählt werden
            /// </summary>
            Multi = 2
            }
        #endregion

        #region " Properties "
        private DataTable m_TableToShow;
        /// <summary>
        /// Diese Datatable wird im Grid angezeigt
        /// </summary>
        public DataTable TableToShow
            {
            get { return m_TableToShow; }
            set { m_TableToShow = value; }
            }

        private string m_KeyColumn = "";
        /// <summary>
        /// Diese Spalte stellt den Primärschlüssel der Tabelle dar, die in TableToShow übergeben wurde
        /// </summary>
        public string KeyColumn
            {
            get { return m_KeyColumn; }
            set { m_KeyColumn = value; }
            }

        // what the Hell:
        // in Dokumentationskommentaren muss man Zeilenumbrüche NICHT mit </br> schreiben,
        // sondern mit <para/>
        private string m_HiddenColumns = "";
        /// <summary>
        /// Die hier angegebenen Spalten werden im Grid nicht dargestellt<para/>
        /// mehrere Spalten können mit | getrennt angegeben werden
        /// </summary>
        public string HiddenColumns
            {
            get { return m_HiddenColumns; }
            set { m_HiddenColumns = value; }
            }

        private string m_SortColumn = "";
        /// <summary>
        /// Die Spalte, über die sortiert werden soll (im Grid)<para/>
        /// Kann vom Benutzer umgestellt werden
        /// </summary>
        public string SortColumn
            {
            get { return m_SortColumn; }
            set { m_SortColumn = value; }
            }

        private enumSelectMode m_SelectMode = enumSelectMode.Single;
        /// <summary>
        /// Gibt an, welche Auswahl möglich sein soll (siehe enumSelectMode)
        /// </summary>
        public enumSelectMode SelectMode
            {
            get { return m_SelectMode; }
            set { m_SelectMode = value; }
            }

        private Guid m_SelectedGuid;
        /// <summary>
        /// Die GUID (=keycolumn) der Zeile, die beim Single-Select ausgewählt wurde (Ausgabeparameter)<para/>
        /// Die Eigenschaft kann auch verwendet werden, um eine Zeile vorauszuwählen (Eingabeparameter)
        /// </summary>
        public Guid SelectedGuid
            {
            get { return m_SelectedGuid; }
            set { m_SelectedGuid = value; }
            }

        private List<Guid> m_SelectedGuids;
        /// <summary>
        /// Die GUID (=keycolumn) der Zeilen, die beim Multi-Select ausgewählt wurden (Ausgabeparameter)<para/>
        /// Die Eigenschaft kann auch verwendet werden, um Zeilen vorauszuwählen (Eingabeparameter)
        /// </summary>
        public List<Guid> SelectedGuids
            {
            get { return m_SelectedGuids; }
            set { m_SelectedGuids = value; }
            }
        #endregion
        #endregion

        public frmUebersichtDataGridView()
            {
            InitializeComponent();
            }

        private void frmUebersichtDataGridView_Load(object sender, System.EventArgs e)
            {
            dgvAnzeige.DataSource = m_TableToShow;
            dgvAnzeige.MultiSelect = m_SelectMode == enumSelectMode.Multi;
            HideColumns();
            dgvAnzeige.AutoResizeColumns();

            if (!string.IsNullOrEmpty(m_SortColumn))
                {
                dgvAnzeige.Sort(dgvAnzeige.Columns[m_SortColumn], System.ComponentModel.ListSortDirection.Ascending);
                }

            for (int i = 0; i <= dgvAnzeige.ColumnCount - 1; i++)
                {
                if (dgvAnzeige.Columns[i].Width > 220)
                    {
                    dgvAnzeige.Columns[i].Width = 220;
                    dgvAnzeige.Columns[i].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                    }
                }

            int hoehe = 0;
            int breite = 0;
            if (dgvAnzeige.PreferredSize.Width > Screen.PrimaryScreen.WorkingArea.Width)
                {
                breite = Screen.PrimaryScreen.WorkingArea.Width;
                }
            else
                {
                breite = dgvAnzeige.PreferredSize.Width - 15;
                }

            if (dgvAnzeige.PreferredSize.Height + pnlButtons.Height > Screen.PrimaryScreen.WorkingArea.Height)
                {
                hoehe = Screen.PrimaryScreen.WorkingArea.Height - pnlButtons.Height;
                }
            else
                {
                // mit Platz für horiz. Scrollbalken
                // hoehe = dgvAnzeige.PreferredSize.Height + 45;
                // ohne
                hoehe = dgvAnzeige.PreferredSize.Height + 29;
                }

            this.ClientSize = new Size(breite, hoehe);

            // selbst ausgerechnet *g* (statt this.StartPosition = FormStartPosition.CenterScreen)
            this.Top = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;
            }

        private void dgvAnzeige_SelectionChanged(object sender, System.EventArgs e)
            {
            switch (m_SelectMode)
                {
                case enumSelectMode.None:
                    for (int i = 0; i < dgvAnzeige.SelectedRows.Count; i++)
                        {
                        dgvAnzeige.SelectedRows[i].Selected = false;
                        }

                    break;
                case enumSelectMode.Single:
                case enumSelectMode.Multi:
                    cmdOk.Enabled = dgvAnzeige.SelectedRows.Count > 0;
                    break;
                }
            }

        #region " Buttons "
        private void cmdOk_Click(System.Object sender, System.EventArgs e)
            {
            if (m_SelectMode == enumSelectMode.Single)
                {
                m_SelectedGuid = (Guid)dgvAnzeige.SelectedRows[0].Cells[m_KeyColumn].Value;
                }

            if (m_SelectMode == enumSelectMode.Multi)
                {
                m_SelectedGuids = new List<Guid>();
                for (int i = 0; i <= dgvAnzeige.SelectedRows.Count - 1; i++)
                    {
                    m_SelectedGuids.Add((Guid)dgvAnzeige.SelectedRows[i].Cells[m_KeyColumn].Value);
                    dgvAnzeige.SelectedRows[i].Selected = false;
                    }
                }
            this.Close();
            }

        private void cmdSpaltenauswahl_Click(System.Object sender, System.EventArgs e)
            {
            frmUebersichtSpaltenAuswahl frm = new frmUebersichtSpaltenAuswahl(dgvAnzeige, m_HiddenColumns);
            frm.ShowDialog();
            }

        private void cmdAbbrechen_Click(System.Object sender, System.EventArgs e)
            {
            this.Close();
            }
        #endregion



        #region " private Hilfsfunktionen "
        private void HideColumns()
            {
            try
                {
                string[] ColumnNames = null;

                if (!string.IsNullOrEmpty(m_HiddenColumns))
                    {
                    ColumnNames = m_HiddenColumns.Split('|');
                    foreach (string s in ColumnNames)
                        {
                        if (dgvAnzeige.Columns.Contains(s))
                            {
                            dgvAnzeige.Columns[s].Visible = false;
                            }
                        }
                    }
                }
            catch (Exception ex)
                {
                MessageBox.Show(ex.Message);
                }
            }
        #endregion

        private void pnlButtons_Paint(object sender, PaintEventArgs e)
            {

            }
        }


    }
