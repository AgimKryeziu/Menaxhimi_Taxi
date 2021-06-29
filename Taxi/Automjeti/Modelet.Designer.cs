
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Modelet));
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtPershkrimi = new System.Windows.Forms.TextBox();
            this.lblPershkrimi = new System.Windows.Forms.Label();
            this.txtEmri = new System.Windows.Forms.TextBox();
            this.lblEmri = new System.Windows.Forms.Label();
            this.btnRuaj = new System.Windows.Forms.Button();
            this.btnHelpModel = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Controls.Add(this.txtPershkrimi);
            this.panel2.Controls.Add(this.lblPershkrimi);
            this.panel2.Controls.Add(this.txtEmri);
            this.panel2.Controls.Add(this.lblEmri);
            this.panel2.Name = "panel2";
            // 
            // txtPershkrimi
            // 
            resources.ApplyResources(this.txtPershkrimi, "txtPershkrimi");
            this.txtPershkrimi.Name = "txtPershkrimi";
            // 
            // lblPershkrimi
            // 
            resources.ApplyResources(this.lblPershkrimi, "lblPershkrimi");
            this.lblPershkrimi.Name = "lblPershkrimi";
            // 
            // txtEmri
            // 
            resources.ApplyResources(this.txtEmri, "txtEmri");
            this.txtEmri.Name = "txtEmri";
            // 
            // lblEmri
            // 
            resources.ApplyResources(this.lblEmri, "lblEmri");
            this.lblEmri.Name = "lblEmri";
            // 
            // btnRuaj
            // 
            resources.ApplyResources(this.btnRuaj, "btnRuaj");
            this.btnRuaj.Name = "btnRuaj";
            this.btnRuaj.UseVisualStyleBackColor = true;
            this.btnRuaj.Click += new System.EventHandler(this.btnRuaj_Click);
            // 
            // btnHelpModel
            // 
            resources.ApplyResources(this.btnHelpModel, "btnHelpModel");
            this.btnHelpModel.Name = "btnHelpModel";
            this.btnHelpModel.UseVisualStyleBackColor = true;
            this.btnHelpModel.Click += new System.EventHandler(this.btnHelpModel_Click);
            // 
            // Modelet
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnHelpModel);
            this.Controls.Add(this.btnRuaj);
            this.Controls.Add(this.panel2);
            this.Name = "Modelet";
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
        private System.Windows.Forms.Button btnHelpModel;
    }
}