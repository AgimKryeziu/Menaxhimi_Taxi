
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
            this.dgvShoferiList = new System.Windows.Forms.DataGridView();
            this.btnShtoShofer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShoferiList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvShoferiList
            // 
            this.dgvShoferiList.AllowUserToAddRows = false;
            this.dgvShoferiList.AllowUserToDeleteRows = false;
            this.dgvShoferiList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShoferiList.Location = new System.Drawing.Point(14, 91);
            this.dgvShoferiList.Name = "dgvShoferiList";
            this.dgvShoferiList.Size = new System.Drawing.Size(901, 340);
            this.dgvShoferiList.TabIndex = 0;
            this.dgvShoferiList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvShoferiList_CellContentClick);
            // 
            // btnShtoShofer
            // 
            this.btnShtoShofer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShtoShofer.Location = new System.Drawing.Point(807, 32);
            this.btnShtoShofer.Name = "btnShtoShofer";
            this.btnShtoShofer.Size = new System.Drawing.Size(93, 42);
            this.btnShtoShofer.TabIndex = 37;
            this.btnShtoShofer.Text = "Add";
            this.btnShtoShofer.UseVisualStyleBackColor = true;
            this.btnShtoShofer.Click += new System.EventHandler(this.btnShtoShofer_Click);
            // 
            // ShoferiList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 442);
            this.Controls.Add(this.btnShtoShofer);
            this.Controls.Add(this.dgvShoferiList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ShoferiList";
            this.Load += new System.EventHandler(this.ShoferiList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShoferiList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvShoferiList;
        private System.Windows.Forms.Button btnShtoShofer;
    }
}