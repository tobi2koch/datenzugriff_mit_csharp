namespace Datenbank_Demo
{
    partial class frmHauptform
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmdWindowsAuthentifizierung = new System.Windows.Forms.Button();
            this.cmdSQLServerAuthentifizierung = new System.Windows.Forms.Button();
            this.cmdMitConnectionStringBuilder = new System.Windows.Forms.Button();
            this.cmdMitCryptConnectionInfo = new System.Windows.Forms.Button();
            this.cmdENQkonstant = new System.Windows.Forms.Button();
            this.cmdENQmitStringverknüpfung = new System.Windows.Forms.Button();
            this.cmdENQmitParameter = new System.Windows.Forms.Button();
            this.cmdENQmitSP = new System.Windows.Forms.Button();
            this.cmdESkonstant = new System.Windows.Forms.Button();
            this.cmdESmitParameter = new System.Windows.Forms.Button();
            this.cmdERkonstant = new System.Windows.Forms.Button();
            this.cmdERmitParameter = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmdESmitSP = new System.Windows.Forms.Button();
            this.cmdListboxSchlecht = new System.Windows.Forms.Button();
            this.cmdDataset = new System.Windows.Forms.Button();
            this.cmdDGV = new System.Windows.Forms.Button();
            this.cmdListboxGut = new System.Windows.Forms.Button();
            this.cmdDGVuniversell = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmdGuidErzeugen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdWindowsAuthentifizierung
            // 
            this.cmdWindowsAuthentifizierung.Enabled = false;
            this.cmdWindowsAuthentifizierung.Location = new System.Drawing.Point(23, 21);
            this.cmdWindowsAuthentifizierung.Name = "cmdWindowsAuthentifizierung";
            this.cmdWindowsAuthentifizierung.Size = new System.Drawing.Size(200, 35);
            this.cmdWindowsAuthentifizierung.TabIndex = 0;
            this.cmdWindowsAuthentifizierung.Text = "WindowsAuthentifizierung";
            this.cmdWindowsAuthentifizierung.UseVisualStyleBackColor = true;
            this.cmdWindowsAuthentifizierung.Click += new System.EventHandler(this.cmdWindowsAuthentifizierung_Click);
            // 
            // cmdSQLServerAuthentifizierung
            // 
            this.cmdSQLServerAuthentifizierung.Enabled = false;
            this.cmdSQLServerAuthentifizierung.Location = new System.Drawing.Point(23, 75);
            this.cmdSQLServerAuthentifizierung.Name = "cmdSQLServerAuthentifizierung";
            this.cmdSQLServerAuthentifizierung.Size = new System.Drawing.Size(200, 35);
            this.cmdSQLServerAuthentifizierung.TabIndex = 1;
            this.cmdSQLServerAuthentifizierung.Text = "SQLServerAuthentifizierung";
            this.cmdSQLServerAuthentifizierung.UseVisualStyleBackColor = true;
            this.cmdSQLServerAuthentifizierung.Click += new System.EventHandler(this.cmdSQLServerAuthentifizierung_Click);
            // 
            // cmdMitConnectionStringBuilder
            // 
            this.cmdMitConnectionStringBuilder.Enabled = false;
            this.cmdMitConnectionStringBuilder.Location = new System.Drawing.Point(23, 135);
            this.cmdMitConnectionStringBuilder.Name = "cmdMitConnectionStringBuilder";
            this.cmdMitConnectionStringBuilder.Size = new System.Drawing.Size(200, 35);
            this.cmdMitConnectionStringBuilder.TabIndex = 2;
            this.cmdMitConnectionStringBuilder.Text = "mit ConnectionStringBuilder";
            this.cmdMitConnectionStringBuilder.UseVisualStyleBackColor = true;
            this.cmdMitConnectionStringBuilder.Click += new System.EventHandler(this.cmdMitConnectionStringBuilder_Click);
            // 
            // cmdMitCryptConnectionInfo
            // 
            this.cmdMitCryptConnectionInfo.Enabled = false;
            this.cmdMitCryptConnectionInfo.Location = new System.Drawing.Point(23, 194);
            this.cmdMitCryptConnectionInfo.Name = "cmdMitCryptConnectionInfo";
            this.cmdMitCryptConnectionInfo.Size = new System.Drawing.Size(200, 35);
            this.cmdMitCryptConnectionInfo.TabIndex = 3;
            this.cmdMitCryptConnectionInfo.Text = "mit CryptConnectionInfo";
            this.cmdMitCryptConnectionInfo.UseVisualStyleBackColor = true;
            this.cmdMitCryptConnectionInfo.Click += new System.EventHandler(this.cmdMitCryptConnectionInfo_Click);
            // 
            // cmdENQkonstant
            // 
            this.cmdENQkonstant.Location = new System.Drawing.Point(247, 21);
            this.cmdENQkonstant.Name = "cmdENQkonstant";
            this.cmdENQkonstant.Size = new System.Drawing.Size(200, 35);
            this.cmdENQkonstant.TabIndex = 4;
            this.cmdENQkonstant.Text = "ExecuteNonQuery konstant";
            this.cmdENQkonstant.UseVisualStyleBackColor = true;
            this.cmdENQkonstant.Click += new System.EventHandler(this.cmdENQkonstant_Click);
            // 
            // cmdENQmitStringverknüpfung
            // 
            this.cmdENQmitStringverknüpfung.Location = new System.Drawing.Point(247, 75);
            this.cmdENQmitStringverknüpfung.Name = "cmdENQmitStringverknüpfung";
            this.cmdENQmitStringverknüpfung.Size = new System.Drawing.Size(200, 49);
            this.cmdENQmitStringverknüpfung.TabIndex = 5;
            this.cmdENQmitStringverknüpfung.Text = "ExecuteNonQuery zusammengebaut";
            this.cmdENQmitStringverknüpfung.UseVisualStyleBackColor = true;
            this.cmdENQmitStringverknüpfung.Click += new System.EventHandler(this.cmdENQmitStringverknüpfung_Click);
            // 
            // cmdENQmitParameter
            // 
            this.cmdENQmitParameter.Location = new System.Drawing.Point(247, 145);
            this.cmdENQmitParameter.Name = "cmdENQmitParameter";
            this.cmdENQmitParameter.Size = new System.Drawing.Size(200, 49);
            this.cmdENQmitParameter.TabIndex = 6;
            this.cmdENQmitParameter.Text = "ExecuteNonQuery mit Parameter";
            this.cmdENQmitParameter.UseVisualStyleBackColor = true;
            this.cmdENQmitParameter.Click += new System.EventHandler(this.cmdENQmitParameter_Click);
            // 
            // cmdENQmitSP
            // 
            this.cmdENQmitSP.Location = new System.Drawing.Point(247, 213);
            this.cmdENQmitSP.Name = "cmdENQmitSP";
            this.cmdENQmitSP.Size = new System.Drawing.Size(200, 49);
            this.cmdENQmitSP.TabIndex = 7;
            this.cmdENQmitSP.Text = "ExecuteNonQuery mit Stored Procedure";
            this.cmdENQmitSP.UseVisualStyleBackColor = true;
            this.cmdENQmitSP.Click += new System.EventHandler(this.cmdENQmitSP_Click);
            // 
            // cmdESkonstant
            // 
            this.cmdESkonstant.Location = new System.Drawing.Point(465, 21);
            this.cmdESkonstant.Name = "cmdESkonstant";
            this.cmdESkonstant.Size = new System.Drawing.Size(200, 35);
            this.cmdESkonstant.TabIndex = 8;
            this.cmdESkonstant.Text = "ExecuteScalar konstant";
            this.cmdESkonstant.UseVisualStyleBackColor = true;
            this.cmdESkonstant.Click += new System.EventHandler(this.cmdESkonstant_Click);
            // 
            // cmdESmitParameter
            // 
            this.cmdESmitParameter.Location = new System.Drawing.Point(465, 145);
            this.cmdESmitParameter.Name = "cmdESmitParameter";
            this.cmdESmitParameter.Size = new System.Drawing.Size(200, 49);
            this.cmdESmitParameter.TabIndex = 9;
            this.cmdESmitParameter.Text = "ExecuteScalar mit Parameter";
            this.cmdESmitParameter.UseVisualStyleBackColor = true;
            this.cmdESmitParameter.Click += new System.EventHandler(this.cmdESmitParameter_Click);
            // 
            // cmdERkonstant
            // 
            this.cmdERkonstant.Location = new System.Drawing.Point(685, 21);
            this.cmdERkonstant.Name = "cmdERkonstant";
            this.cmdERkonstant.Size = new System.Drawing.Size(200, 35);
            this.cmdERkonstant.TabIndex = 10;
            this.cmdERkonstant.Text = "ExecuteReader konstant";
            this.cmdERkonstant.UseVisualStyleBackColor = true;
            this.cmdERkonstant.Click += new System.EventHandler(this.cmdERkonstant_Click);
            // 
            // cmdERmitParameter
            // 
            this.cmdERmitParameter.Location = new System.Drawing.Point(685, 145);
            this.cmdERmitParameter.Name = "cmdERmitParameter";
            this.cmdERmitParameter.Size = new System.Drawing.Size(200, 49);
            this.cmdERmitParameter.TabIndex = 11;
            this.cmdERmitParameter.Text = "ExecuteReader mit Parameter";
            this.cmdERmitParameter.UseVisualStyleBackColor = true;
            this.cmdERmitParameter.Click += new System.EventHandler(this.cmdERmitParameter_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Location = new System.Drawing.Point(12, 285);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(895, 3);
            this.panel1.TabIndex = 12;
            // 
            // cmdESmitSP
            // 
            this.cmdESmitSP.Location = new System.Drawing.Point(465, 213);
            this.cmdESmitSP.Name = "cmdESmitSP";
            this.cmdESmitSP.Size = new System.Drawing.Size(200, 49);
            this.cmdESmitSP.TabIndex = 14;
            this.cmdESmitSP.Text = "ExecuteScalar mit Stored Procedure";
            this.cmdESmitSP.UseVisualStyleBackColor = true;
            this.cmdESmitSP.Click += new System.EventHandler(this.cmdESmitSP_Click);
            // 
            // cmdListboxSchlecht
            // 
            this.cmdListboxSchlecht.Location = new System.Drawing.Point(23, 305);
            this.cmdListboxSchlecht.Name = "cmdListboxSchlecht";
            this.cmdListboxSchlecht.Size = new System.Drawing.Size(200, 49);
            this.cmdListboxSchlecht.TabIndex = 15;
            this.cmdListboxSchlecht.Text = "Listbox mit Fremdschlüssel (ungünstig)";
            this.cmdListboxSchlecht.UseVisualStyleBackColor = true;
            this.cmdListboxSchlecht.Click += new System.EventHandler(this.cmdListboxSchlecht_Click);
            // 
            // cmdDataset
            // 
            this.cmdDataset.Location = new System.Drawing.Point(247, 305);
            this.cmdDataset.Name = "cmdDataset";
            this.cmdDataset.Size = new System.Drawing.Size(200, 49);
            this.cmdDataset.TabIndex = 16;
            this.cmdDataset.Text = "Dataset allgemein";
            this.cmdDataset.UseVisualStyleBackColor = true;
            this.cmdDataset.Click += new System.EventHandler(this.cmdDataset_Click);
            // 
            // cmdDGV
            // 
            this.cmdDGV.Location = new System.Drawing.Point(465, 305);
            this.cmdDGV.Name = "cmdDGV";
            this.cmdDGV.Size = new System.Drawing.Size(200, 49);
            this.cmdDGV.TabIndex = 17;
            this.cmdDGV.Text = "Datagridview";
            this.cmdDGV.UseVisualStyleBackColor = true;
            this.cmdDGV.Click += new System.EventHandler(this.cmdDGV_Click);
            // 
            // cmdListboxGut
            // 
            this.cmdListboxGut.Location = new System.Drawing.Point(247, 360);
            this.cmdListboxGut.Name = "cmdListboxGut";
            this.cmdListboxGut.Size = new System.Drawing.Size(200, 49);
            this.cmdListboxGut.TabIndex = 18;
            this.cmdListboxGut.Text = "Listbox mit Fremdschlüssel (gut)";
            this.cmdListboxGut.UseVisualStyleBackColor = true;
            this.cmdListboxGut.Click += new System.EventHandler(this.cmdListboxGut_Click);
            // 
            // cmdDGVuniversell
            // 
            this.cmdDGVuniversell.Location = new System.Drawing.Point(465, 360);
            this.cmdDGVuniversell.Name = "cmdDGVuniversell";
            this.cmdDGVuniversell.Size = new System.Drawing.Size(200, 49);
            this.cmdDGVuniversell.TabIndex = 19;
            this.cmdDGVuniversell.Text = "Datagridview (universell)";
            this.cmdDGVuniversell.UseVisualStyleBackColor = true;
            this.cmdDGVuniversell.Click += new System.EventHandler(this.cmdDGVuniversell_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Location = new System.Drawing.Point(12, 430);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(895, 3);
            this.panel2.TabIndex = 20;
            // 
            // cmdGuidErzeugen
            // 
            this.cmdGuidErzeugen.Location = new System.Drawing.Point(12, 443);
            this.cmdGuidErzeugen.Name = "cmdGuidErzeugen";
            this.cmdGuidErzeugen.Size = new System.Drawing.Size(200, 49);
            this.cmdGuidErzeugen.TabIndex = 21;
            this.cmdGuidErzeugen.Text = "Guid Erzeugen";
            this.cmdGuidErzeugen.UseVisualStyleBackColor = true;
            this.cmdGuidErzeugen.Click += new System.EventHandler(this.cmdGuidErzeugen_Click);
            // 
            // frmHauptform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 504);
            this.Controls.Add(this.cmdGuidErzeugen);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.cmdDGVuniversell);
            this.Controls.Add(this.cmdListboxGut);
            this.Controls.Add(this.cmdDGV);
            this.Controls.Add(this.cmdDataset);
            this.Controls.Add(this.cmdListboxSchlecht);
            this.Controls.Add(this.cmdESmitSP);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cmdERmitParameter);
            this.Controls.Add(this.cmdERkonstant);
            this.Controls.Add(this.cmdESmitParameter);
            this.Controls.Add(this.cmdESkonstant);
            this.Controls.Add(this.cmdENQmitSP);
            this.Controls.Add(this.cmdENQmitParameter);
            this.Controls.Add(this.cmdENQmitStringverknüpfung);
            this.Controls.Add(this.cmdENQkonstant);
            this.Controls.Add(this.cmdMitCryptConnectionInfo);
            this.Controls.Add(this.cmdMitConnectionStringBuilder);
            this.Controls.Add(this.cmdSQLServerAuthentifizierung);
            this.Controls.Add(this.cmdWindowsAuthentifizierung);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmHauptform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Haupform";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdWindowsAuthentifizierung;
        private System.Windows.Forms.Button cmdSQLServerAuthentifizierung;
        private System.Windows.Forms.Button cmdMitConnectionStringBuilder;
        private System.Windows.Forms.Button cmdMitCryptConnectionInfo;
        private System.Windows.Forms.Button cmdENQkonstant;
        private System.Windows.Forms.Button cmdENQmitStringverknüpfung;
        private System.Windows.Forms.Button cmdENQmitParameter;
        private System.Windows.Forms.Button cmdENQmitSP;
        private System.Windows.Forms.Button cmdESkonstant;
        private System.Windows.Forms.Button cmdESmitParameter;
        private System.Windows.Forms.Button cmdERkonstant;
        private System.Windows.Forms.Button cmdERmitParameter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cmdESmitSP;
        private System.Windows.Forms.Button cmdListboxSchlecht;
        private System.Windows.Forms.Button cmdDataset;
        private System.Windows.Forms.Button cmdDGV;
        private System.Windows.Forms.Button cmdListboxGut;
        private System.Windows.Forms.Button cmdDGVuniversell;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button cmdGuidErzeugen;
    }
}

