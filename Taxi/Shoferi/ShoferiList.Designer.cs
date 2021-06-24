
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
            this.exportToExcel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShoferiList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvShoferiList
            // 
            this.dgvShoferiList.AllowUserToAddRows = false;
            this.dgvShoferiList.AllowUserToDeleteRows = false;
            this.dgvShoferiList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShoferiList.Location = new System.Drawing.Point(12, 106);
            this.dgvShoferiList.Name = "dgvShoferiList";
            this.dgvShoferiList.ReadOnly = true;
            this.dgvShoferiList.Size = new System.Drawing.Size(929, 340);
            this.dgvShoferiList.TabIndex = 0;
            this.dgvShoferiList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvShoferiList_CellContentClick);
            // 
            // btnShtoShofer
            // 
            this.btnShtoShofer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShtoShofer.Location = new System.Drawing.Point(840, 45);
            this.btnShtoShofer.Name = "btnShtoShofer";
            this.btnShtoShofer.Size = new System.Drawing.Size(93, 33);
            this.btnShtoShofer.TabIndex = 37;
            this.btnShtoShofer.Text = "Shto";
            this.btnShtoShofer.UseVisualStyleBackColor = true;
            this.btnShtoShofer.Click += new System.EventHandler(this.btnShtoShofer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 39;
            this.label1.Text = "Eksporto";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // exportToExcel
            // 
            this.exportToExcel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exportToExcel.BackgroundImage")));
            this.exportToExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exportToExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportToExcel.Location = new System.Drawing.Point(17, 12);
            this.exportToExcel.Name = "exportToExcel";
            this.exportToExcel.Size = new System.Drawing.Size(51, 66);
            this.exportToExcel.TabIndex = 38;
            this.exportToExcel.UseVisualStyleBackColor = true;
            this.exportToExcel.Click += new System.EventHandler(this.btnEksportoExcel_Click);
            // 
            // ShoferiList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 458);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exportToExcel);
            this.Controls.Add(this.btnShtoShofer);
            this.Controls.Add(this.dgvShoferiList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ShoferiList";
            this.Text = "Shoferet";
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
    }
}