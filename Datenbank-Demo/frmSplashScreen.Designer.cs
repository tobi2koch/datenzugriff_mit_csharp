namespace Datenbank_Demo
    {
    partial class frmSplashScreen
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
            this.lblAnzeige = new System.Windows.Forms.Label();
            this.txtFehlermeldung = new System.Windows.Forms.TextBox();
            this.cmdOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAnzeige
            // 
            this.lblAnzeige.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnzeige.Location = new System.Drawing.Point(29, 9);
            this.lblAnzeige.Name = "lblAnzeige";
            this.lblAnzeige.Size = new System.Drawing.Size(226, 175);
            this.lblAnzeige.TabIndex = 0;
            this.lblAnzeige.Text = "Verbindung zur Datenbank wird aufgebaut";
            this.lblAnzeige.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtFehlermeldung
            // 
            this.txtFehlermeldung.Location = new System.Drawing.Point(17, 220);
            this.txtFehlermeldung.Multiline = true;
            this.txtFehlermeldung.Name = "txtFehlermeldung";
            this.txtFehlermeldung.ReadOnly = true;
            this.txtFehlermeldung.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtFehlermeldung.Size = new System.Drawing.Size(253, 106);
            this.txtFehlermeldung.TabIndex = 1;
            // 
            // cmdOk
            // 
            this.cmdOk.Location = new System.Drawing.Point(211, 337);
            this.cmdOk.Name = "cmdOk";
            this.cmdOk.Size = new System.Drawing.Size(58, 21);
            this.cmdOk.TabIndex = 2;
            this.cmdOk.Text = "OK";
            this.cmdOk.UseVisualStyleBackColor = true;
            this.cmdOk.Click += new System.EventHandler(this.cmdOk_Click);
            // 
            // frmSplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 210);
            this.Controls.Add(this.cmdOk);
            this.Controls.Add(this.txtFehlermeldung);
            this.Controls.Add(this.lblAnzeige);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSplashScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSplashScreen";
            this.Load += new System.EventHandler(this.frmSplashScreen_Load);
            this.Shown += new System.EventHandler(this.frmSplashScreen_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

            }

        #endregion

        private System.Windows.Forms.Label lblAnzeige;
        private System.Windows.Forms.TextBox txtFehlermeldung;
        private System.Windows.Forms.Button cmdOk;
        }
    }