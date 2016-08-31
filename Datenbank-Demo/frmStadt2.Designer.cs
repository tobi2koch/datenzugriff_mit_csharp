namespace Datenbank_Demo
    {
    partial class frmStadt2
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
            this.cboLand = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBreitengrad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmdAbbrechen = new System.Windows.Forms.Button();
            this.cmdSpeichern = new System.Windows.Forms.Button();
            this.txtLaengengrad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEinwohnerzahl = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStadt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cboLand
            // 
            this.cboLand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLand.FormattingEnabled = true;
            this.cboLand.Location = new System.Drawing.Point(177, 226);
            this.cboLand.Name = "cboLand";
            this.cboLand.Size = new System.Drawing.Size(199, 27);
            this.cboLand.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(32, 229);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 19);
            this.label5.TabIndex = 30;
            this.label5.Text = "Land:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtBreitengrad
            // 
            this.txtBreitengrad.Location = new System.Drawing.Point(177, 178);
            this.txtBreitengrad.Margin = new System.Windows.Forms.Padding(4);
            this.txtBreitengrad.Name = "txtBreitengrad";
            this.txtBreitengrad.Size = new System.Drawing.Size(199, 27);
            this.txtBreitengrad.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(32, 181);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 19);
            this.label4.TabIndex = 28;
            this.label4.Text = "Breitengrad:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmdAbbrechen
            // 
            this.cmdAbbrechen.Location = new System.Drawing.Point(143, 304);
            this.cmdAbbrechen.Name = "cmdAbbrechen";
            this.cmdAbbrechen.Size = new System.Drawing.Size(103, 32);
            this.cmdAbbrechen.TabIndex = 27;
            this.cmdAbbrechen.Text = "Abbrechen";
            this.cmdAbbrechen.UseVisualStyleBackColor = true;
            // 
            // cmdSpeichern
            // 
            this.cmdSpeichern.Location = new System.Drawing.Point(273, 304);
            this.cmdSpeichern.Name = "cmdSpeichern";
            this.cmdSpeichern.Size = new System.Drawing.Size(103, 32);
            this.cmdSpeichern.TabIndex = 26;
            this.cmdSpeichern.Text = "Speichern";
            this.cmdSpeichern.UseVisualStyleBackColor = true;
            this.cmdSpeichern.Click += new System.EventHandler(this.cmdSpeichern_Click);
            // 
            // txtLaengengrad
            // 
            this.txtLaengengrad.Location = new System.Drawing.Point(177, 131);
            this.txtLaengengrad.Margin = new System.Windows.Forms.Padding(4);
            this.txtLaengengrad.Name = "txtLaengengrad";
            this.txtLaengengrad.Size = new System.Drawing.Size(199, 27);
            this.txtLaengengrad.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(32, 134);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 19);
            this.label3.TabIndex = 24;
            this.label3.Text = "Längengrad:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtEinwohnerzahl
            // 
            this.txtEinwohnerzahl.Location = new System.Drawing.Point(177, 82);
            this.txtEinwohnerzahl.Margin = new System.Windows.Forms.Padding(4);
            this.txtEinwohnerzahl.Name = "txtEinwohnerzahl";
            this.txtEinwohnerzahl.Size = new System.Drawing.Size(199, 27);
            this.txtEinwohnerzahl.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(32, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 19);
            this.label2.TabIndex = 22;
            this.label2.Text = "Einwohnerzahl:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtStadt
            // 
            this.txtStadt.Location = new System.Drawing.Point(177, 32);
            this.txtStadt.Margin = new System.Windows.Forms.Padding(4);
            this.txtStadt.Name = "txtStadt";
            this.txtStadt.Size = new System.Drawing.Size(199, 27);
            this.txtStadt.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(32, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 19);
            this.label1.TabIndex = 20;
            this.label1.Text = "Stadt:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmStadt2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 375);
            this.Controls.Add(this.cboLand);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBreitengrad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmdAbbrechen);
            this.Controls.Add(this.cmdSpeichern);
            this.Controls.Add(this.txtLaengengrad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEinwohnerzahl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtStadt);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Calibri", 12F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmStadt2";
            this.Text = "frmStadt2";
            this.Load += new System.EventHandler(this.frmStadt2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

            }

        #endregion

        private System.Windows.Forms.ComboBox cboLand;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBreitengrad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button cmdAbbrechen;
        private System.Windows.Forms.Button cmdSpeichern;
        private System.Windows.Forms.TextBox txtLaengengrad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEinwohnerzahl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtStadt;
        private System.Windows.Forms.Label label1;

        }
    }