namespace Datenbank_Demo
    {
    partial class frmStadt1
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
            this.cmdAbbrechen = new System.Windows.Forms.Button();
            this.cmdSpeichern = new System.Windows.Forms.Button();
            this.txtLaengengrad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEinwohnerzahl = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStadt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBreitengrad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cboLand = new System.Windows.Forms.ComboBox();
            this.cboLand_ID = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cmdAbbrechen
            // 
            this.cmdAbbrechen.Location = new System.Drawing.Point(144, 303);
            this.cmdAbbrechen.Name = "cmdAbbrechen";
            this.cmdAbbrechen.Size = new System.Drawing.Size(103, 32);
            this.cmdAbbrechen.TabIndex = 15;
            this.cmdAbbrechen.Text = "Abbrechen";
            this.cmdAbbrechen.UseVisualStyleBackColor = true;
            // 
            // cmdSpeichern
            // 
            this.cmdSpeichern.Location = new System.Drawing.Point(274, 303);
            this.cmdSpeichern.Name = "cmdSpeichern";
            this.cmdSpeichern.Size = new System.Drawing.Size(103, 32);
            this.cmdSpeichern.TabIndex = 14;
            this.cmdSpeichern.Text = "Speichern";
            this.cmdSpeichern.UseVisualStyleBackColor = true;
            this.cmdSpeichern.Click += new System.EventHandler(this.cmdSpeichern_Click);
            // 
            // txtLaengengrad
            // 
            this.txtLaengengrad.Location = new System.Drawing.Point(178, 130);
            this.txtLaengengrad.Margin = new System.Windows.Forms.Padding(4);
            this.txtLaengengrad.Name = "txtLaengengrad";
            this.txtLaengengrad.Size = new System.Drawing.Size(199, 27);
            this.txtLaengengrad.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(33, 133);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "Längengrad:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtEinwohnerzahl
            // 
            this.txtEinwohnerzahl.Location = new System.Drawing.Point(178, 81);
            this.txtEinwohnerzahl.Margin = new System.Windows.Forms.Padding(4);
            this.txtEinwohnerzahl.Name = "txtEinwohnerzahl";
            this.txtEinwohnerzahl.Size = new System.Drawing.Size(199, 27);
            this.txtEinwohnerzahl.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(33, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "Einwohnerzahl:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtStadt
            // 
            this.txtStadt.Location = new System.Drawing.Point(178, 31);
            this.txtStadt.Margin = new System.Windows.Forms.Padding(4);
            this.txtStadt.Name = "txtStadt";
            this.txtStadt.Size = new System.Drawing.Size(199, 27);
            this.txtStadt.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(33, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "Stadt:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtBreitengrad
            // 
            this.txtBreitengrad.Location = new System.Drawing.Point(178, 177);
            this.txtBreitengrad.Margin = new System.Windows.Forms.Padding(4);
            this.txtBreitengrad.Name = "txtBreitengrad";
            this.txtBreitengrad.Size = new System.Drawing.Size(199, 27);
            this.txtBreitengrad.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(33, 180);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 19);
            this.label4.TabIndex = 16;
            this.label4.Text = "Breitengrad:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(33, 228);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 19);
            this.label5.TabIndex = 18;
            this.label5.Text = "Land:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboLand
            // 
            this.cboLand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLand.FormattingEnabled = true;
            this.cboLand.Location = new System.Drawing.Point(178, 225);
            this.cboLand.Name = "cboLand";
            this.cboLand.Size = new System.Drawing.Size(199, 27);
            this.cboLand.TabIndex = 19;
            // 
            // cboLand_ID
            // 
            this.cboLand_ID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLand_ID.FormattingEnabled = true;
            this.cboLand_ID.Location = new System.Drawing.Point(12, 360);
            this.cboLand_ID.Name = "cboLand_ID";
            this.cboLand_ID.Size = new System.Drawing.Size(199, 27);
            this.cboLand_ID.TabIndex = 20;
            this.cboLand_ID.Visible = false;
            // 
            // frmStadt1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 388);
            this.Controls.Add(this.cboLand_ID);
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
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmStadt1";
            this.Text = "frmStadt1";
            this.Load += new System.EventHandler(this.frmStadt1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

            }

        #endregion

        private System.Windows.Forms.Button cmdAbbrechen;
        private System.Windows.Forms.Button cmdSpeichern;
        private System.Windows.Forms.TextBox txtLaengengrad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEinwohnerzahl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtStadt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBreitengrad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboLand;
        private System.Windows.Forms.ComboBox cboLand_ID;
        }
    }