namespace Datenbank_Demo
    {
    partial class frmLand2
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
            this.txtInternetkuerzel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLand = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmdAbbrechen
            // 
            this.cmdAbbrechen.Location = new System.Drawing.Point(392, 82);
            this.cmdAbbrechen.Name = "cmdAbbrechen";
            this.cmdAbbrechen.Size = new System.Drawing.Size(103, 32);
            this.cmdAbbrechen.TabIndex = 15;
            this.cmdAbbrechen.Text = "Abbrechen";
            this.cmdAbbrechen.UseVisualStyleBackColor = true;
            // 
            // cmdSuchen
            // 
            this.cmdSuchen.Location = new System.Drawing.Point(392, 22);
            this.cmdSuchen.Name = "cmdSuchen";
            this.cmdSuchen.Size = new System.Drawing.Size(103, 32);
            this.cmdSuchen.TabIndex = 14;
            this.cmdSuchen.Text = "Suchen";
            this.cmdSuchen.UseVisualStyleBackColor = true;
            this.cmdSuchen.Click += new System.EventHandler(this.cmdSuchen_Click);
            // 
            // txtInternetkuerzel
            // 
            this.txtInternetkuerzel.Location = new System.Drawing.Point(179, 29);
            this.txtInternetkuerzel.Margin = new System.Windows.Forms.Padding(4);
            this.txtInternetkuerzel.Name = "txtInternetkuerzel";
            this.txtInternetkuerzel.Size = new System.Drawing.Size(199, 20);
            this.txtInternetkuerzel.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(34, 32);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "Internetkürzel:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtLand
            // 
            this.txtLand.Location = new System.Drawing.Point(179, 89);
            this.txtLand.Margin = new System.Windows.Forms.Padding(4);
            this.txtLand.Name = "txtLand";
            this.txtLand.ReadOnly = true;
            this.txtLand.Size = new System.Drawing.Size(199, 20);
            this.txtLand.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(34, 92);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "Land:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmLand2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 141);
            this.Controls.Add(this.cmdAbbrechen);
            this.Controls.Add(this.cmdSuchen);
            this.Controls.Add(this.txtInternetkuerzel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLand);
            this.Controls.Add(this.label1);
            this.Name = "frmLand2";
            this.Text = "frmLand2";
            this.ResumeLayout(false);
            this.PerformLayout();

            }

        #endregion

        private System.Windows.Forms.Button cmdAbbrechen;
        private System.Windows.Forms.Button cmdSuchen;
        private System.Windows.Forms.TextBox txtInternetkuerzel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLand;
        private System.Windows.Forms.Label label1;
        }
    }