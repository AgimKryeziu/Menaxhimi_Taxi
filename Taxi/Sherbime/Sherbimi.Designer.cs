
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sherbimi));
            this.dgvSherbimet = new System.Windows.Forms.DataGridView();
            this.bntShto = new System.Windows.Forms.Button();
            this.btnHelpService = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSherbimet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSherbimet
            // 
            resources.ApplyResources(this.dgvSherbimet, "dgvSherbimet");
            this.dgvSherbimet.AllowUserToAddRows = false;
            this.dgvSherbimet.AllowUserToDeleteRows = false;
            this.dgvSherbimet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSherbimet.Name = "dgvSherbimet";
            this.dgvSherbimet.ReadOnly = true;
            this.dgvSherbimet.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSherbimet_CellContentClick);
            // 
            // bntShto
            // 
            resources.ApplyResources(this.bntShto, "bntShto");
            this.bntShto.Name = "bntShto";
            this.bntShto.UseVisualStyleBackColor = true;
            this.bntShto.Click += new System.EventHandler(this.bntShto_Click);
            // 
            // btnHelpService
            // 
            resources.ApplyResources(this.btnHelpService, "btnHelpService");
            this.btnHelpService.Name = "btnHelpService";
            this.btnHelpService.UseVisualStyleBackColor = true;
            this.btnHelpService.Click += new System.EventHandler(this.btnHelpService_Click);
            // 
            // Sherbimi
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnHelpService);
            this.Controls.Add(this.bntShto);
            this.Controls.Add(this.dgvSherbimet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Sherbimi";
            this.Load += new System.EventHandler(this.Sherbimi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSherbimet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvSherbimet;
        private System.Windows.Forms.Button bntShto;
        private System.Windows.Forms.Button btnHelpService;
    }
}