namespace Datenbank_Demo
    {
    partial class frmDataGridView
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
            this.cmdDoIt1 = new System.Windows.Forms.Button();
            this.dgvAnzeige = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnzeige)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdDoIt1
            // 
            this.cmdDoIt1.Location = new System.Drawing.Point(12, 274);
            this.cmdDoIt1.Name = "cmdDoIt1";
            this.cmdDoIt1.Size = new System.Drawing.Size(77, 33);
            this.cmdDoIt1.TabIndex = 2;
            this.cmdDoIt1.Text = "DoIt 1";
            this.cmdDoIt1.UseVisualStyleBackColor = true;
            this.cmdDoIt1.Click += new System.EventHandler(this.cmdDoIt1_Click);
            // 
            // dgvAnzeige
            // 
            this.dgvAnzeige.AllowUserToAddRows = false;
            this.dgvAnzeige.AllowUserToDeleteRows = false;
            this.dgvAnzeige.AllowUserToOrderColumns = true;
            this.dgvAnzeige.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAnzeige.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAnzeige.Location = new System.Drawing.Point(9, 17);
            this.dgvAnzeige.Name = "dgvAnzeige";
            this.dgvAnzeige.Size = new System.Drawing.Size(476, 240);
            this.dgvAnzeige.TabIndex = 3;
            // 
            // frmDataGridView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 320);
            this.Controls.Add(this.dgvAnzeige);
            this.Controls.Add(this.cmdDoIt1);
            this.Font = new System.Drawing.Font("Calibri", 12F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDataGridView";
            this.Text = "frmDataGridView";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnzeige)).EndInit();
            this.ResumeLayout(false);

            }

        #endregion

        private System.Windows.Forms.Button cmdDoIt1;
        private System.Windows.Forms.DataGridView dgvAnzeige;
        }
    }