namespace Datenbank_Demo
    {
    partial class frmLand3
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
            this.cmdSuchen = new System.Windows.Forms.Button();
            this.txtEinwohnerzahlBis = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEinwohnerzahlVon = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAusgabe = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmdAbbrechen
            // 
            this.cmdAbbrechen.Location = new System.Drawing.Point(380, 22);
            this.cmdAbbrechen.Name = "cmdAbbrechen";
            this.cmdAbbrechen.Size = new System.Drawing.Size(103, 32);
            this.cmdAbbrechen.TabIndex = 13;
            this.cmdAbbrechen.Text = "Abbrechen";
            this.cmdAbbrechen.UseVisualStyleBackColor = true;
            // 
            // cmdSuchen
            // 
            this.cmdSuchen.Location = new System.Drawing.Point(380, 68);
            this.cmdSuchen.Name = "cmdSuchen";
            this.cmdSuchen.Size = new System.Drawing.Size(103, 32);
            this.cmdSuchen.TabIndex = 12;
            this.cmdSuchen.Text = "Suchen";
            this.cmdSuchen.UseVisualStyleBackColor = true;
            this.cmdSuchen.Click += new System.EventHandler(this.cmdSuchen_Click);
            // 
            // txtEinwohnerzahlBis
            // 
            this.txtEinwohnerzahlBis.Location = new System.Drawing.Point(162, 80);
            this.txtEinwohnerzahlBis.Margin = new System.Windows.Forms.Padding(4);
            this.txtEinwohnerzahlBis.Name = "txtEinwohnerzahlBis";
            this.txtEinwohnerzahlBis.Size = new System.Drawing.Size(199, 20);
            this.txtEinwohnerzahlBis.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(17, 83);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 19);
            this.label3.TabIndex = 10;
            this.label3.Text = "Bis:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtEinwohnerzahlVon
            // 
            this.txtEinwohnerzahlVon.Location = new System.Drawing.Point(162, 52);
            this.txtEinwohnerzahlVon.Margin = new System.Windows.Forms.Padding(4);
            this.txtEinwohnerzahlVon.Name = "txtEinwohnerzahlVon";
            this.txtEinwohnerzahlVon.Size = new System.Drawing.Size(199, 20);
            this.txtEinwohnerzahlVon.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(64, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "Von:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Suche Länder mit einer Einwohnerzahl";
            // 
            // txtAusgabe
            // 
            this.txtAusgabe.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAusgabe.Location = new System.Drawing.Point(46, 135);
            this.txtAusgabe.Multiline = true;
            this.txtAusgabe.Name = "txtAusgabe";
            this.txtAusgabe.ReadOnly = true;
            this.txtAusgabe.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtAusgabe.Size = new System.Drawing.Size(400, 144);
            this.txtAusgabe.TabIndex = 15;
            // 
            // frmLand3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 298);
            this.Controls.Add(this.txtAusgabe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdAbbrechen);
            this.Controls.Add(this.cmdSuchen);
            this.Controls.Add(this.txtEinwohnerzahlBis);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEinwohnerzahlVon);
            this.Controls.Add(this.label2);
            this.Name = "frmLand3";
            this.Text = "frmLand3";
            this.ResumeLayout(false);
            this.PerformLayout();

            }

        #endregion

        private System.Windows.Forms.Button cmdAbbrechen;
        private System.Windows.Forms.Button cmdSuchen;
        private System.Windows.Forms.TextBox txtEinwohnerzahlBis;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEinwohnerzahlVon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAusgabe;
        }
    }