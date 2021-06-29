
namespace Taxi
{
    partial class LogInForms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogInForms));
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chbShfaq = new System.Windows.Forms.CheckBox();
            this.lblMemberLogin = new System.Windows.Forms.Label();
            this.pcBoxMainLogin = new System.Windows.Forms.PictureBox();
            this.btnKyçu = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnHelp = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnEngLang = new System.Windows.Forms.Button();
            this.btnAlbLang = new System.Windows.Forms.Button();
            this.btnCloseLoginForm = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.pcBoxMainLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHelp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseLoginForm)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPassword
            // 
            resources.ApplyResources(this.txtPassword, "txtPassword");
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUserName
            // 
            resources.ApplyResources(this.txtUserName, "txtUserName");
            this.txtUserName.Name = "txtUserName";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Name = "label1";
            // 
            // chbShfaq
            // 
            resources.ApplyResources(this.chbShfaq, "chbShfaq");
            this.chbShfaq.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.chbShfaq.Name = "chbShfaq";
            this.chbShfaq.UseVisualStyleBackColor = true;
            this.chbShfaq.CheckedChanged += new System.EventHandler(this.chbShfaq_CheckedChanged);
            // 
            // lblMemberLogin
            // 
            resources.ApplyResources(this.lblMemberLogin, "lblMemberLogin");
            this.lblMemberLogin.ForeColor = System.Drawing.Color.White;
            this.lblMemberLogin.Name = "lblMemberLogin";
            // 
            // pcBoxMainLogin
            // 
            resources.ApplyResources(this.pcBoxMainLogin, "pcBoxMainLogin");
            this.pcBoxMainLogin.BackColor = System.Drawing.Color.GreenYellow;
            this.pcBoxMainLogin.Name = "pcBoxMainLogin";
            this.pcBoxMainLogin.TabStop = false;
            // 
            // btnKyçu
            // 
            resources.ApplyResources(this.btnKyçu, "btnKyçu");
            this.btnKyçu.ActiveBorderThickness = 1;
            this.btnKyçu.ActiveCornerRadius = 20;
            this.btnKyçu.ActiveFillColor = System.Drawing.Color.Transparent;
            this.btnKyçu.ActiveForecolor = System.Drawing.Color.SeaGreen;
            this.btnKyçu.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnKyçu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.btnKyçu.ButtonText = "LogIn";
            this.btnKyçu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKyçu.ForeColor = System.Drawing.Color.White;
            this.btnKyçu.IdleBorderThickness = 1;
            this.btnKyçu.IdleCornerRadius = 20;
            this.btnKyçu.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnKyçu.IdleForecolor = System.Drawing.Color.White;
            this.btnKyçu.IdleLineColor = System.Drawing.Color.White;
            this.btnKyçu.Name = "btnKyçu";
            this.btnKyçu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnKyçu.Click += new System.EventHandler(this.btnKyçu_Click);
            // 
            // btnHelp
            // 
            resources.ApplyResources(this.btnHelp, "btnHelp");
            this.btnHelp.BackColor = System.Drawing.Color.DarkGray;
            this.btnHelp.ImageActive = null;
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.TabStop = false;
            this.btnHelp.Zoom = 10;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnEngLang
            // 
            resources.ApplyResources(this.btnEngLang, "btnEngLang");
            this.btnEngLang.Name = "btnEngLang";
            this.btnEngLang.UseVisualStyleBackColor = true;
            this.btnEngLang.Click += new System.EventHandler(this.btnEngLang_Click);
            // 
            // btnAlbLang
            // 
            resources.ApplyResources(this.btnAlbLang, "btnAlbLang");
            this.btnAlbLang.Name = "btnAlbLang";
            this.btnAlbLang.UseVisualStyleBackColor = true;
            this.btnAlbLang.Click += new System.EventHandler(this.btnAlbLang_Click);
            // 
            // btnCloseLoginForm
            // 
            resources.ApplyResources(this.btnCloseLoginForm, "btnCloseLoginForm");
            this.btnCloseLoginForm.BackColor = System.Drawing.Color.Crimson;
            this.btnCloseLoginForm.ImageActive = null;
            this.btnCloseLoginForm.Name = "btnCloseLoginForm";
            this.btnCloseLoginForm.TabStop = false;
            this.btnCloseLoginForm.Zoom = 10;
            this.btnCloseLoginForm.Click += new System.EventHandler(this.btnCloseLoginForm_Click);
            // 
            // LogInForms
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.Controls.Add(this.pcBoxMainLogin);
            this.Controls.Add(this.lblMemberLogin);
            this.Controls.Add(this.btnKyçu);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnEngLang);
            this.Controls.Add(this.btnAlbLang);
            this.Controls.Add(this.btnCloseLoginForm);
            this.Controls.Add(this.chbShfaq);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LogInForms";
            ((System.ComponentModel.ISupportInitialize)(this.pcBoxMainLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHelp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseLoginForm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chbShfaq;
        private Bunifu.Framework.UI.BunifuImageButton btnHelp;
        private System.Windows.Forms.Button btnEngLang;
        private System.Windows.Forms.Button btnAlbLang;
        private Bunifu.Framework.UI.BunifuImageButton btnCloseLoginForm;
        private Bunifu.Framework.UI.BunifuThinButton2 btnKyçu;
        private System.Windows.Forms.Label lblMemberLogin;
        private System.Windows.Forms.PictureBox pcBoxMainLogin;
    }
}