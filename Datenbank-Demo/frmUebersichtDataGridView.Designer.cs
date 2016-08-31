namespace Datenbank_Demo
{
    partial class frmUebersichtDataGridView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvAnzeige = new System.Windows.Forms.DataGridView();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.cmdAbbrechen = new System.Windows.Forms.Button();
            this.cmdSpaltenauswahl = new System.Windows.Forms.Button();
            this.cmdOk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnzeige)).BeginInit();
            this.pnlButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAnzeige
            // 
            this.dgvAnzeige.AllowUserToAddRows = false;
            this.dgvAnzeige.AllowUserToDeleteRows = false;
            this.dgvAnzeige.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvAnzeige.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAnzeige.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAnzeige.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAnzeige.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAnzeige.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAnzeige.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAnzeige.Location = new System.Drawing.Point(0, 0);
            this.dgvAnzeige.MultiSelect = false;
            this.dgvAnzeige.Name = "dgvAnzeige";
            this.dgvAnzeige.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAnzeige.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvAnzeige.RowHeadersVisible = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Silver;
            this.dgvAnzeige.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvAnzeige.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAnzeige.Size = new System.Drawing.Size(674, 525);
            this.dgvAnzeige.TabIndex = 3;
            this.dgvAnzeige.SelectionChanged += new System.EventHandler(this.dgvAnzeige_SelectionChanged);
            // 
            // pnlButtons
            // 
            this.pnlButtons.Controls.Add(this.cmdAbbrechen);
            this.pnlButtons.Controls.Add(this.cmdSpaltenauswahl);
            this.pnlButtons.Controls.Add(this.cmdOk);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButtons.Location = new System.Drawing.Point(0, 525);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(674, 61);
            this.pnlButtons.TabIndex = 2;
            this.pnlButtons.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlButtons_Paint);
            // 
            // cmdAbbrechen
            // 
            this.cmdAbbrechen.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cmdAbbrechen.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdAbbrechen.Location = new System.Drawing.Point(512, 14);
            this.cmdAbbrechen.Name = "cmdAbbrechen";
            this.cmdAbbrechen.Size = new System.Drawing.Size(69, 33);
            this.cmdAbbrechen.TabIndex = 2;
            this.cmdAbbrechen.Text = "Abbrechen";
            this.cmdAbbrechen.UseVisualStyleBackColor = true;
            this.cmdAbbrechen.Click += new System.EventHandler(this.cmdAbbrechen_Click);
            // 
            // cmdSpaltenauswahl
            // 
            this.cmdSpaltenauswahl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmdSpaltenauswahl.Location = new System.Drawing.Point(12, 14);
            this.cmdSpaltenauswahl.Name = "cmdSpaltenauswahl";
            this.cmdSpaltenauswahl.Size = new System.Drawing.Size(100, 33);
            this.cmdSpaltenauswahl.TabIndex = 1;
            this.cmdSpaltenauswahl.Text = "Spaltenauswahl";
            this.cmdSpaltenauswahl.UseVisualStyleBackColor = true;
            this.cmdSpaltenauswahl.Click += new System.EventHandler(this.cmdSpaltenauswahl_Click);
            // 
            // cmdOk
            // 
            this.cmdOk.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cmdOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.cmdOk.Location = new System.Drawing.Point(587, 14);
            this.cmdOk.Name = "cmdOk";
            this.cmdOk.Size = new System.Drawing.Size(75, 33);
            this.cmdOk.TabIndex = 0;
            this.cmdOk.Text = "Ok";
            this.cmdOk.UseVisualStyleBackColor = true;
            this.cmdOk.Click += new System.EventHandler(this.cmdOk_Click);
            // 
            // frmUebersichtDataGridView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 586);
            this.Controls.Add(this.dgvAnzeige);
            this.Controls.Add(this.pnlButtons);
            this.Name = "frmUebersichtDataGridView";
            this.Text = "Uebersicht";
            this.Load += new System.EventHandler(this.frmUebersichtDataGridView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnzeige)).EndInit();
            this.pnlButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.DataGridView dgvAnzeige;
        internal System.Windows.Forms.Panel pnlButtons;
        internal System.Windows.Forms.Button cmdAbbrechen;
        internal System.Windows.Forms.Button cmdSpaltenauswahl;
        internal System.Windows.Forms.Button cmdOk;
    }
}