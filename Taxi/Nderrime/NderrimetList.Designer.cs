
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
            this.btnShtoShofer = new System.Windows.Forms.Button();
            this.dgvNdrrimet = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNdrrimet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnShtoShofer
            // 
            this.btnShtoShofer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShtoShofer.Location = new System.Drawing.Point(676, 46);
            this.btnShtoShofer.Name = "btnShtoShofer";
            this.btnShtoShofer.Size = new System.Drawing.Size(93, 33);
            this.btnShtoShofer.TabIndex = 39;
            this.btnShtoShofer.Text = "Shto";
            this.btnShtoShofer.UseVisualStyleBackColor = true;
            this.btnShtoShofer.Click += new System.EventHandler(this.btnShtoShofer_Click);
            // 
            // dgvNdrrimet
            // 
            this.dgvNdrrimet.AllowUserToAddRows = false;
            this.dgvNdrrimet.AllowUserToDeleteRows = false;
            this.dgvNdrrimet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNdrrimet.Location = new System.Drawing.Point(12, 96);
            this.dgvNdrrimet.Name = "dgvNdrrimet";
            this.dgvNdrrimet.ReadOnly = true;
            this.dgvNdrrimet.Size = new System.Drawing.Size(757, 218);
            this.dgvNdrrimet.TabIndex = 38;
            this.dgvNdrrimet.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNdrrimet_CellContentClick);
            // 
            // NderrimetList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 346);
            this.Controls.Add(this.btnShtoShofer);
            this.Controls.Add(this.dgvNdrrimet);
            this.Name = "NderrimetList";
            this.Text = "NderrimetList";
            this.Load += new System.EventHandler(this.NderrimetList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNdrrimet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnShtoShofer;
        private System.Windows.Forms.DataGridView dgvNdrrimet;
    }
}