
namespace Taxi.Nderrime
{
    partial class NderrimetList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NderrimetList));
            this.btnShtoShofer = new System.Windows.Forms.Button();
            this.dgvNdrrimet = new System.Windows.Forms.DataGridView();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNdrrimet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnShtoShofer
            // 
            resources.ApplyResources(this.btnShtoShofer, "btnShtoShofer");
            this.btnShtoShofer.Name = "btnShtoShofer";
            this.btnShtoShofer.UseVisualStyleBackColor = true;
            this.btnShtoShofer.Click += new System.EventHandler(this.btnShtoShofer_Click);
            // 
            // dgvNdrrimet
            // 
            resources.ApplyResources(this.dgvNdrrimet, "dgvNdrrimet");
            this.dgvNdrrimet.AllowUserToAddRows = false;
            this.dgvNdrrimet.AllowUserToDeleteRows = false;
            this.dgvNdrrimet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNdrrimet.Name = "dgvNdrrimet";
            this.dgvNdrrimet.ReadOnly = true;
            this.dgvNdrrimet.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNdrrimet_CellContentClick);
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
            // NderrimetList
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.btnShtoShofer);
            this.Controls.Add(this.dgvNdrrimet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NderrimetList";
            this.Load += new System.EventHandler(this.NderrimetList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNdrrimet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnShtoShofer;
        private System.Windows.Forms.DataGridView dgvNdrrimet;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
    }
}