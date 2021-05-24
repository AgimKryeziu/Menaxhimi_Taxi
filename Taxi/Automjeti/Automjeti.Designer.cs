
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
            this.dgvAutomjeti = new System.Windows.Forms.DataGridView();
            this.btnEditoAutomjet = new System.Windows.Forms.Button();
            this.btnShtoAutomjet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutomjeti)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAutomjeti
            // 
            this.dgvAutomjeti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAutomjeti.Location = new System.Drawing.Point(12, 32);
            this.dgvAutomjeti.Name = "dgvAutomjeti";
            this.dgvAutomjeti.Size = new System.Drawing.Size(758, 237);
            this.dgvAutomjeti.TabIndex = 22;
            // 
            // btnEditoAutomjet
            // 
            this.btnEditoAutomjet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditoAutomjet.Location = new System.Drawing.Point(693, 297);
            this.btnEditoAutomjet.Name = "btnEditoAutomjet";
            this.btnEditoAutomjet.Size = new System.Drawing.Size(77, 31);
            this.btnEditoAutomjet.TabIndex = 18;
            this.btnEditoAutomjet.Text = "Edito";
            this.btnEditoAutomjet.UseVisualStyleBackColor = true;
            this.btnEditoAutomjet.Click += new System.EventHandler(this.btnEditoAutomjet_Click);
            // 
            // btnShtoAutomjet
            // 
            this.btnShtoAutomjet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShtoAutomjet.Location = new System.Drawing.Point(594, 297);
            this.btnShtoAutomjet.Name = "btnShtoAutomjet";
            this.btnShtoAutomjet.Size = new System.Drawing.Size(80, 31);
            this.btnShtoAutomjet.TabIndex = 16;
            this.btnShtoAutomjet.Text = "Shto";
            this.btnShtoAutomjet.UseVisualStyleBackColor = true;
            this.btnShtoAutomjet.Click += new System.EventHandler(this.btnShtoAutomjet_Click);
            // 
            // Automjeti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 340);
            this.Controls.Add(this.dgvAutomjeti);
            this.Controls.Add(this.btnEditoAutomjet);
            this.Controls.Add(this.btnShtoAutomjet);
            this.Name = "Automjeti";
            this.Text = "Automjetet";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutomjeti)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAutomjeti;
        private System.Windows.Forms.Button btnEditoAutomjet;
        private System.Windows.Forms.Button btnShtoAutomjet;
    }
}