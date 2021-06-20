
namespace Taxi.Administratori
{
    partial class ShtoRol
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
            this.lblPershkrimi = new System.Windows.Forms.Label();
            this.txtPershkrimi = new System.Windows.Forms.TextBox();
            this.btnShto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPershkrimi
            // 
            this.lblPershkrimi.AutoSize = true;
            this.lblPershkrimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPershkrimi.Location = new System.Drawing.Point(22, 52);
            this.lblPershkrimi.Name = "lblPershkrimi";
            this.lblPershkrimi.Size = new System.Drawing.Size(126, 20);
            this.lblPershkrimi.TabIndex = 0;
            this.lblPershkrimi.Text = "Pershkrimi i rolit: ";
            // 
            // txtPershkrimi
            // 
            this.txtPershkrimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPershkrimi.Location = new System.Drawing.Point(154, 52);
            this.txtPershkrimi.Name = "txtPershkrimi";
            this.txtPershkrimi.Size = new System.Drawing.Size(158, 26);
            this.txtPershkrimi.TabIndex = 1;
            // 
            // btnShto
            // 
            this.btnShto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShto.Location = new System.Drawing.Point(331, 49);
            this.btnShto.Name = "btnShto";
            this.btnShto.Size = new System.Drawing.Size(92, 32);
            this.btnShto.TabIndex = 2;
            this.btnShto.Text = "Shto";
            this.btnShto.UseVisualStyleBackColor = true;
            this.btnShto.Click += new System.EventHandler(this.btnShto_Click_1);
            // 
            // ShtoRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 114);
            this.Controls.Add(this.btnShto);
            this.Controls.Add(this.txtPershkrimi);
            this.Controls.Add(this.lblPershkrimi);
            this.Name = "ShtoRol";
            this.Text = "ShtoRol";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPershkrimi;
        private System.Windows.Forms.TextBox txtPershkrimi;
        private System.Windows.Forms.Button btnShto;
    }
}