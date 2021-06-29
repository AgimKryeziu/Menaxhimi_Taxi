
namespace Taxi.Shoferi
{
    partial class ShoferiList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShoferiList));
            this.dgvShoferiList = new System.Windows.Forms.DataGridView();
            this.btnShtoShofer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnHelpDriver = new System.Windows.Forms.Button();
            this.exportToExcel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShoferiList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvShoferiList
            // 
            resources.ApplyResources(this.dgvShoferiList, "dgvShoferiList");
            this.dgvShoferiList.AllowUserToAddRows = false;
            this.dgvShoferiList.AllowUserToDeleteRows = false;
            this.dgvShoferiList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShoferiList.Name = "dgvShoferiList";
            this.dgvShoferiList.ReadOnly = true;
            this.dgvShoferiList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvShoferiList_CellContentClick);
            // 
            // btnShtoShofer
            // 
            resources.ApplyResources(this.btnShtoShofer, "btnShtoShofer");
            this.btnShtoShofer.Name = "btnShtoShofer";
            this.btnShtoShofer.UseVisualStyleBackColor = true;
            this.btnShtoShofer.Click += new System.EventHandler(this.btnShtoShofer_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // printDocument1
            // 
            this.printDocument1.DocumentName = " ";
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            resources.ApplyResources(this.printPreviewDialog1, "printPreviewDialog1");
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            // 
            // btnPrint
            // 
            resources.ApplyResources(this.btnPrint, "btnPrint");
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnHelpDriver
            // 
            resources.ApplyResources(this.btnHelpDriver, "btnHelpDriver");
            this.btnHelpDriver.Name = "btnHelpDriver";
            this.btnHelpDriver.UseVisualStyleBackColor = true;
            this.btnHelpDriver.Click += new System.EventHandler(this.btnHelpDriver_Click_1);
            // 
            // exportToExcel
            // 
            resources.ApplyResources(this.exportToExcel, "exportToExcel");
            this.exportToExcel.Name = "exportToExcel";
            this.exportToExcel.UseVisualStyleBackColor = true;
            this.exportToExcel.Click += new System.EventHandler(this.btnEksportoExcel_Click);
            // 
            // ShoferiList
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnHelpDriver);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exportToExcel);
            this.Controls.Add(this.btnShtoShofer);
            this.Controls.Add(this.dgvShoferiList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ShoferiList";
            this.Load += new System.EventHandler(this.ShoferiList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShoferiList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvShoferiList;
        private System.Windows.Forms.Button btnShtoShofer;
        private System.Windows.Forms.Button exportToExcel;
        private System.Windows.Forms.Label label1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnHelpDriver;
    }
}