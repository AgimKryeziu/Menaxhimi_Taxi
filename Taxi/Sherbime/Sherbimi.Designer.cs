
namespace Taxi.Sherbime
{
    partial class Sherbimi
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
            this.dgvSherbimet = new System.Windows.Forms.DataGridView();
            this.bntShto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSherbimet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSherbimet
            // 
            this.dgvSherbimet.AllowUserToAddRows = false;
            this.dgvSherbimet.AllowUserToDeleteRows = false;
            this.dgvSherbimet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSherbimet.Location = new System.Drawing.Point(12, 119);
            this.dgvSherbimet.Name = "dgvSherbimet";
            this.dgvSherbimet.ReadOnly = true;
            this.dgvSherbimet.Size = new System.Drawing.Size(954, 299);
            this.dgvSherbimet.TabIndex = 34;
            this.dgvSherbimet.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSherbimet_CellContentClick);
            // 
            // bntShto
            // 
            this.bntShto.Location = new System.Drawing.Point(870, 74);
            this.bntShto.Name = "bntShto";
            this.bntShto.Size = new System.Drawing.Size(96, 30);
            this.bntShto.TabIndex = 35;
            this.bntShto.Text = "Shto";
            this.bntShto.UseVisualStyleBackColor = true;
            this.bntShto.Click += new System.EventHandler(this.bntShto_Click);
            // 
            // Sherbimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 434);
            this.Controls.Add(this.bntShto);
            this.Controls.Add(this.dgvSherbimet);
            this.Name = "Sherbimi";
            this.Text = "Sherbimet";
            this.Load += new System.EventHandler(this.Sherbimi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSherbimet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvSherbimet;
        private System.Windows.Forms.Button bntShto;
    }
}