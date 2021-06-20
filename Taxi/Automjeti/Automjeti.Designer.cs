
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
            this.exportToExcel = new System.Windows.Forms.Button();
            this.btnShtoAutomjet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutomjeti)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAutomjeti
            // 
            this.dgvAutomjeti.AllowUserToAddRows = false;
            this.dgvAutomjeti.AllowUserToDeleteRows = false;
            this.dgvAutomjeti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAutomjeti.Location = new System.Drawing.Point(12, 110);
            this.dgvAutomjeti.Name = "dgvAutomjeti";
            this.dgvAutomjeti.ReadOnly = true;
            this.dgvAutomjeti.Size = new System.Drawing.Size(568, 209);
            this.dgvAutomjeti.TabIndex = 22;
            this.dgvAutomjeti.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAutomjeti_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "Eksporto";
            // 
            // exportToExcel
            // 
            this.exportToExcel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exportToExcel.BackgroundImage")));
            this.exportToExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exportToExcel.Location = new System.Drawing.Point(12, 12);
            this.exportToExcel.Name = "exportToExcel";
            this.exportToExcel.Size = new System.Drawing.Size(51, 66);
            this.exportToExcel.TabIndex = 40;
            this.exportToExcel.UseVisualStyleBackColor = true;
            this.exportToExcel.Click += new System.EventHandler(this.exportToExcel_Click);
            // 
            // btnShtoAutomjet
            // 
            this.btnShtoAutomjet.Location = new System.Drawing.Point(482, 65);
            this.btnShtoAutomjet.Name = "btnShtoAutomjet";
            this.btnShtoAutomjet.Size = new System.Drawing.Size(84, 29);
            this.btnShtoAutomjet.TabIndex = 42;
            this.btnShtoAutomjet.Text = "Shto";
            this.btnShtoAutomjet.UseVisualStyleBackColor = true;
            this.btnShtoAutomjet.Click += new System.EventHandler(this.btnShtoAutomjet_Click);
            // 
            // Automjeti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 339);
            this.Controls.Add(this.btnShtoAutomjet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exportToExcel);
            this.Controls.Add(this.dgvAutomjeti);
            this.Name = "Automjeti";
            this.Text = "Automjetet";
            this.Load += new System.EventHandler(this.Automjeti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutomjeti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAutomjeti;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button exportToExcel;
        private System.Windows.Forms.Button btnShtoAutomjet;
    }
}