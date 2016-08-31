namespace Datenbank_Demo
{
    partial class frmUebersichtSpaltenAuswahl
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
            this.clbSpalten = new System.Windows.Forms.CheckedListBox();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.cmdOk = new System.Windows.Forms.Button();
            this.cmdEinSchalten = new System.Windows.Forms.Button();
            this.cmdAusschalten = new System.Windows.Forms.Button();
            this.Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // clbSpalten
            // 
            this.clbSpalten.CheckOnClick = true;
            this.clbSpalten.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clbSpalten.FormattingEnabled = true;
            this.clbSpalten.Location = new System.Drawing.Point(0, 0);
            this.clbSpalten.Name = "clbSpalten";
            this.clbSpalten.Size = new System.Drawing.Size(258, 298);
            this.clbSpalten.TabIndex = 3;
            // 
            // Panel1
            // 
            this.Panel1.Controls.Add(this.cmdOk);
            this.Panel1.Controls.Add(this.cmdEinSchalten);
            this.Panel1.Controls.Add(this.cmdAusschalten);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Panel1.Location = new System.Drawing.Point(0, 298);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(258, 39);
            this.Panel1.TabIndex = 2;
            // 
            // cmdOk
            // 
            this.cmdOk.Location = new System.Drawing.Point(169, 8);
            this.cmdOk.Name = "cmdOk";
            this.cmdOk.Size = new System.Drawing.Size(73, 21);
            this.cmdOk.TabIndex = 2;
            this.cmdOk.Text = "OK";
            this.cmdOk.UseVisualStyleBackColor = true;
            this.cmdOk.Click += new System.EventHandler(this.cmdOk_Click);
            // 
            // cmdEinSchalten
            // 
            this.cmdEinSchalten.Location = new System.Drawing.Point(90, 8);
            this.cmdEinSchalten.Name = "cmdEinSchalten";
            this.cmdEinSchalten.Size = new System.Drawing.Size(73, 21);
            this.cmdEinSchalten.TabIndex = 1;
            this.cmdEinSchalten.Tag = "true";
            this.cmdEinSchalten.Text = "Alle Ein";
            this.cmdEinSchalten.UseVisualStyleBackColor = true;
            this.cmdEinSchalten.Click += new System.EventHandler(this.cmdXXXSchalten_Click);
            // 
            // cmdAusschalten
            // 
            this.cmdAusschalten.Location = new System.Drawing.Point(11, 8);
            this.cmdAusschalten.Name = "cmdAusschalten";
            this.cmdAusschalten.Size = new System.Drawing.Size(73, 21);
            this.cmdAusschalten.TabIndex = 0;
            this.cmdAusschalten.Tag = "False";
            this.cmdAusschalten.Text = "Alle Aus";
            this.cmdAusschalten.UseVisualStyleBackColor = true;
            this.cmdAusschalten.Click += new System.EventHandler(this.cmdXXXSchalten_Click);
            // 
            // frmSpaltenAuswahl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 337);
            this.Controls.Add(this.clbSpalten);
            this.Controls.Add(this.Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmSpaltenAuswahl";
            this.Text = "Spaltenauswahl";
            this.Load += new System.EventHandler(this.frmSpaltenAuswahl_Load);
            this.Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.CheckedListBox clbSpalten;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Button cmdOk;
        internal System.Windows.Forms.Button cmdEinSchalten;
        internal System.Windows.Forms.Button cmdAusschalten;
    }
}