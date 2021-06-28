
namespace Taxi.Automjeti
{
    partial class Automjeti
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Automjeti));
            this.dgvAutomjeti = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnShtoAutomjet = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.exportToExcel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutomjeti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAutomjeti
            // 
            resources.ApplyResources(this.dgvAutomjeti, "dgvAutomjeti");
            this.dgvAutomjeti.AllowUserToAddRows = false;
            this.dgvAutomjeti.AllowUserToDeleteRows = false;
            this.dgvAutomjeti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAutomjeti.Name = "dgvAutomjeti";
            this.dgvAutomjeti.ReadOnly = true;
            this.dgvAutomjeti.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAutomjeti_CellContentClick);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // btnShtoAutomjet
            // 
            resources.ApplyResources(this.btnShtoAutomjet, "btnShtoAutomjet");
            this.btnShtoAutomjet.Name = "btnShtoAutomjet";
            this.btnShtoAutomjet.UseVisualStyleBackColor = true;
            this.btnShtoAutomjet.Click += new System.EventHandler(this.btnShtoAutomjet_Click);
            // 
            // btnPrint
            // 
            resources.ApplyResources(this.btnPrint, "btnPrint");
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
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
            // exportToExcel
            // 
            resources.ApplyResources(this.exportToExcel, "exportToExcel");
            this.exportToExcel.Name = "exportToExcel";
            this.exportToExcel.UseVisualStyleBackColor = true;
            this.exportToExcel.Click += new System.EventHandler(this.exportToExcel_Click);
            // 
            // Automjeti
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnShtoAutomjet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exportToExcel);
            this.Controls.Add(this.dgvAutomjeti);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Automjeti";
            this.Load += new System.EventHandler(this.Automjeti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutomjeti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAutomjeti;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button exportToExcel;
        private System.Windows.Forms.Button btnShtoAutomjet;
        private System.Windows.Forms.Button btnPrint;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
    }
}