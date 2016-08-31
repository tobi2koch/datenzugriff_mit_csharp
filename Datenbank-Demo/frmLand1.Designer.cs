namespace Datenbank_Demo
    {
    partial class frmLand1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtLand = new System.Windows.Forms.TextBox();
            this.txtEinwohnerzahl = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtInternetkuerzel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmdSpeichern = new System.Windows.Forms.Button();
            this.cmdAbbrechen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(13, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Land:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtLand
            // 
            this.txtLand.Location = new System.Drawing.Point(158, 55);
            this.txtLand.Margin = new System.Windows.Forms.Padding(4);
            this.txtLand.Name = "txtLand";
            this.txtLand.Size = new System.Drawing.Size(199, 27);
            this.txtLand.TabIndex = 1;
            // 
            // txtEinwohnerzahl
            // 
            this.txtEinwohnerzahl.Location = new System.Drawing.Point(158, 105);
            this.txtEinwohnerzahl.Margin = new System.Windows.Forms.Padding(4);
            this.txtEinwohnerzahl.Name = "txtEinwohnerzahl";
            this.txtEinwohnerzahl.Size = new System.Drawing.Size(199, 27);
            this.txtEinwohnerzahl.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(13, 108);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Einwohnerzahl:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtInternetkuerzel
            // 
            this.txtInternetkuerzel.Location = new System.Drawing.Point(158, 154);
            this.txtInternetkuerzel.Margin = new System.Windows.Forms.Padding(4);
            this.txtInternetkuerzel.Name = "txtInternetkuerzel";
            this.txtInternetkuerzel.Size = new System.Drawing.Size(199, 27);
            this.txtInternetkuerzel.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(13, 157);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Internetkürzel:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmdSpeichern
            // 
            this.cmdSpeichern.Location = new System.Drawing.Point(254, 231);
            this.cmdSpeichern.Name = "cmdSpeichern";
            this.cmdSpeichern.Size = new System.Drawing.Size(103, 32);
            this.cmdSpeichern.TabIndex = 6;
            this.cmdSpeichern.Text = "Speichern";
            this.cmdSpeichern.UseVisualStyleBackColor = true;
            this.cmdSpeichern.Click += new System.EventHandler(this.cmdSpeichern_Click);
            // 
            // cmdAbbrechen
            // 
            this.cmdAbbrechen.Location = new System.Drawing.Point(124, 231);
            this.cmdAbbrechen.Name = "cmdAbbrechen";
            this.cmdAbbrechen.Size = new System.Drawing.Size(103, 32);
            this.cmdAbbrechen.TabIndex = 7;
            this.cmdAbbrechen.Text = "Abbrechen";
            this.cmdAbbrechen.UseVisualStyleBackColor = true;
            // 
            // frmLand1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 310);
            this.Controls.Add(this.cmdAbbrechen);
            this.Controls.Add(this.cmdSpeichern);
            this.Controls.Add(this.txtInternetkuerzel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEinwohnerzahl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLand);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmLand1";
            this.Text = "frmLand1";
            this.ResumeLayout(false);
            this.PerformLayout();

            }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLand;
        private System.Windows.Forms.TextBox txtEinwohnerzahl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtInternetkuerzel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cmdSpeichern;
        private System.Windows.Forms.Button cmdAbbrechen;
        }
    }