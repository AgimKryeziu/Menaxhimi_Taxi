
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
            this.btnHelpAddRole = new System.Windows.Forms.Button();
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
            // btnHelpAddRole
            // 
            resources.ApplyResources(this.btnHelpAddRole, "btnHelpAddRole");
            this.btnHelpAddRole.Name = "btnHelpAddRole";
            this.btnHelpAddRole.UseVisualStyleBackColor = true;
            this.btnHelpAddRole.Click += new System.EventHandler(this.btnHelpAddRole_Click);
            // 
            // ShtoRol
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnHelpAddRole);
            this.Controls.Add(this.btnShto);
            this.Controls.Add(this.txtPershkrimi);
            this.Controls.Add(this.lblPershkrimi);
            this.Name = "ShtoRol";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPershkrimi;
        private System.Windows.Forms.TextBox txtPershkrimi;
        private System.Windows.Forms.Button btnShto;
        private System.Windows.Forms.Button btnHelpAddRole;
    }
}