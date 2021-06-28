
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
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSherbimet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
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
            // bunifuImageButton1
            // 
            resources.ApplyResources(this.bunifuImageButton1, "bunifuImageButton1");
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            // 
            // Sherbimi
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.bntShto);
            this.Controls.Add(this.dgvSherbimet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Sherbimi";
            this.Load += new System.EventHandler(this.Sherbimi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSherbimet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvSherbimet;
        private System.Windows.Forms.Button bntShto;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
    }
}