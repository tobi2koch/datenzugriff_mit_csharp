namespace Datenbank_Demo
    {
    partial class frmDataset
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
            this.txtAnzeige = new System.Windows.Forms.TextBox();
            this.cmdDoIt1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtAnzeige
            // 
            this.txtAnzeige.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAnzeige.Location = new System.Drawing.Point(9, 16);
            this.txtAnzeige.Multiline = true;
            this.txtAnzeige.Name = "txtAnzeige";
            this.txtAnzeige.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtAnzeige.Size = new System.Drawing.Size(576, 255);
            this.txtAnzeige.TabIndex = 0;
            // 
            // cmdDoIt1
            // 
            this.cmdDoIt1.Location = new System.Drawing.Point(12, 289);
            this.cmdDoIt1.Name = "cmdDoIt1";
            this.cmdDoIt1.Size = new System.Drawing.Size(77, 33);
            this.cmdDoIt1.TabIndex = 1;
            this.cmdDoIt1.Text = "DoIt 1";
            this.cmdDoIt1.UseVisualStyleBackColor = true;
            // 
            // frmDataset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 344);
            this.Controls.Add(this.cmdDoIt1);
            this.Controls.Add(this.txtAnzeige);
            this.Font = new System.Drawing.Font("Calibri", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmDataset";
            this.Text = "frmDataset";
            this.ResumeLayout(false);
            this.PerformLayout();

            }

        #endregion

        private System.Windows.Forms.TextBox txtAnzeige;
        private System.Windows.Forms.Button cmdDoIt1;
        }
    }