
namespace Taxi.Destinacione
{
    partial class Destinacioni
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Destinacioni));
            this.txtLagjja = new System.Windows.Forms.TextBox();
            this.lblLagjja = new System.Windows.Forms.Label();
            this.txtRruga = new System.Windows.Forms.TextBox();
            this.lblRruga = new System.Windows.Forms.Label();
            this.txtShteti = new System.Windows.Forms.TextBox();
            this.lblShteti = new System.Windows.Forms.Label();
            this.txtQyteti = new System.Windows.Forms.TextBox();
            this.lblQyteti = new System.Windows.Forms.Label();
            this.btnRuaj = new System.Windows.Forms.Button();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtLagjja
            // 
            resources.ApplyResources(this.txtLagjja, "txtLagjja");
            this.txtLagjja.Name = "txtLagjja";
            // 
            // lblLagjja
            // 
            resources.ApplyResources(this.lblLagjja, "lblLagjja");
            this.lblLagjja.Name = "lblLagjja";
            // 
            // txtRruga
            // 
            resources.ApplyResources(this.txtRruga, "txtRruga");
            this.txtRruga.Name = "txtRruga";
            // 
            // lblRruga
            // 
            resources.ApplyResources(this.lblRruga, "lblRruga");
            this.lblRruga.Name = "lblRruga";
            // 
            // txtShteti
            // 
            resources.ApplyResources(this.txtShteti, "txtShteti");
            this.txtShteti.Name = "txtShteti";
            // 
            // lblShteti
            // 
            resources.ApplyResources(this.lblShteti, "lblShteti");
            this.lblShteti.Name = "lblShteti";
            // 
            // txtQyteti
            // 
            resources.ApplyResources(this.txtQyteti, "txtQyteti");
            this.txtQyteti.Name = "txtQyteti";
            // 
            // lblQyteti
            // 
            resources.ApplyResources(this.lblQyteti, "lblQyteti");
            this.lblQyteti.Name = "lblQyteti";
            // 
            // btnRuaj
            // 
            resources.ApplyResources(this.btnRuaj, "btnRuaj");
            this.btnRuaj.Name = "btnRuaj";
            this.btnRuaj.UseVisualStyleBackColor = true;
            this.btnRuaj.Click += new System.EventHandler(this.btnRuaj_Click);
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
            // Destinacioni
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.btnRuaj);
            this.Controls.Add(this.txtLagjja);
            this.Controls.Add(this.lblLagjja);
            this.Controls.Add(this.txtRruga);
            this.Controls.Add(this.lblRruga);
            this.Controls.Add(this.txtShteti);
            this.Controls.Add(this.lblShteti);
            this.Controls.Add(this.txtQyteti);
            this.Controls.Add(this.lblQyteti);
            this.Name = "Destinacioni";
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtLagjja;
        private System.Windows.Forms.Label lblLagjja;
        private System.Windows.Forms.TextBox txtRruga;
        private System.Windows.Forms.Label lblRruga;
        private System.Windows.Forms.TextBox txtShteti;
        private System.Windows.Forms.Label lblShteti;
        private System.Windows.Forms.TextBox txtQyteti;
        private System.Windows.Forms.Label lblQyteti;
        private System.Windows.Forms.Button btnRuaj;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
    }
}