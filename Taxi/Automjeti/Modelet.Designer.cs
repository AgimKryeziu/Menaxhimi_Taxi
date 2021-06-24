
namespace Taxi.Automjeti
{
    partial class Modelet
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtPershkrimi = new System.Windows.Forms.TextBox();
            this.lblPershkrimi = new System.Windows.Forms.Label();
            this.txtEmri = new System.Windows.Forms.TextBox();
            this.lblEmri = new System.Windows.Forms.Label();
            this.btnRuaj = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtPershkrimi);
            this.panel2.Controls.Add(this.lblPershkrimi);
            this.panel2.Controls.Add(this.txtEmri);
            this.panel2.Controls.Add(this.lblEmri);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(12, 21);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(236, 206);
            this.panel2.TabIndex = 36;
            // 
            // txtPershkrimi
            // 
            this.txtPershkrimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPershkrimi.Location = new System.Drawing.Point(18, 105);
            this.txtPershkrimi.Multiline = true;
            this.txtPershkrimi.Name = "txtPershkrimi";
            this.txtPershkrimi.Size = new System.Drawing.Size(179, 82);
            this.txtPershkrimi.TabIndex = 29;
            // 
            // lblPershkrimi
            // 
            this.lblPershkrimi.AutoSize = true;
            this.lblPershkrimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPershkrimi.Location = new System.Drawing.Point(16, 79);
            this.lblPershkrimi.Name = "lblPershkrimi";
            this.lblPershkrimi.Size = new System.Drawing.Size(71, 16);
            this.lblPershkrimi.TabIndex = 25;
            this.lblPershkrimi.Text = "Pershkrimi";
            // 
            // txtEmri
            // 
            this.txtEmri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmri.Location = new System.Drawing.Point(18, 43);
            this.txtEmri.Name = "txtEmri";
            this.txtEmri.Size = new System.Drawing.Size(179, 22);
            this.txtEmri.TabIndex = 29;
            // 
            // lblEmri
            // 
            this.lblEmri.AutoSize = true;
            this.lblEmri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmri.Location = new System.Drawing.Point(15, 17);
            this.lblEmri.Name = "lblEmri";
            this.lblEmri.Size = new System.Drawing.Size(49, 16);
            this.lblEmri.TabIndex = 25;
            this.lblEmri.Text = "Modeli";
            // 
            // btnRuaj
            // 
            this.btnRuaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRuaj.Location = new System.Drawing.Point(171, 247);
            this.btnRuaj.Name = "btnRuaj";
            this.btnRuaj.Size = new System.Drawing.Size(75, 33);
            this.btnRuaj.TabIndex = 38;
            this.btnRuaj.Text = "Ruaj";
            this.btnRuaj.UseVisualStyleBackColor = true;
            this.btnRuaj.Click += new System.EventHandler(this.btnRuaj_Click);
            // 
            // Modelet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 292);
            this.Controls.Add(this.btnRuaj);
            this.Controls.Add(this.panel2);
            this.Name = "Modelet";
            this.Text = "Modelet";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtPershkrimi;
        private System.Windows.Forms.Label lblPershkrimi;
        private System.Windows.Forms.TextBox txtEmri;
        private System.Windows.Forms.Label lblEmri;
        private System.Windows.Forms.Button btnRuaj;
    }
}