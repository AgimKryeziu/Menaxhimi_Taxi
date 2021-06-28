
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShtoRol));
            this.lblPershkrimi = new System.Windows.Forms.Label();
            this.txtPershkrimi = new System.Windows.Forms.TextBox();
            this.btnShto = new System.Windows.Forms.Button();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPershkrimi
            // 
            resources.ApplyResources(this.lblPershkrimi, "lblPershkrimi");
            this.lblPershkrimi.Name = "lblPershkrimi";
            // 
            // txtPershkrimi
            // 
            resources.ApplyResources(this.txtPershkrimi, "txtPershkrimi");
            this.txtPershkrimi.Name = "txtPershkrimi";
            // 
            // btnShto
            // 
            resources.ApplyResources(this.btnShto, "btnShto");
            this.btnShto.Name = "btnShto";
            this.btnShto.UseVisualStyleBackColor = true;
            this.btnShto.Click += new System.EventHandler(this.btnShto_Click_1);
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
            // ShtoRol
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.btnShto);
            this.Controls.Add(this.txtPershkrimi);
            this.Controls.Add(this.lblPershkrimi);
            this.Name = "ShtoRol";
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPershkrimi;
        private System.Windows.Forms.TextBox txtPershkrimi;
        private System.Windows.Forms.Button btnShto;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
    }
}