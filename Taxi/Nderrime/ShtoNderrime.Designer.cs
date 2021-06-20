
namespace Taxi.Nderrime
{
    partial class ShtoNderrime
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
            this.lblShoferi = new System.Windows.Forms.Label();
            this.bntRuaj = new System.Windows.Forms.Button();
            this.lblAutomjeti = new System.Windows.Forms.Label();
            this.btnPerditeso = new System.Windows.Forms.Button();
            this.cmbAutomjetiId = new System.Windows.Forms.ComboBox();
            this.cmbShoferiId = new System.Windows.Forms.ComboBox();
            this.lblFilimiNdrimit = new System.Windows.Forms.Label();
            this.lblMbarimiNdrrimit = new System.Windows.Forms.Label();
            this.dtpFillimiINderrimit = new System.Windows.Forms.DateTimePicker();
            this.dtpMbarimiINderrimir = new System.Windows.Forms.DateTimePicker();
            this.txtNderrimiId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblShoferi
            // 
            this.lblShoferi.AutoSize = true;
            this.lblShoferi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShoferi.Location = new System.Drawing.Point(36, 31);
            this.lblShoferi.Name = "lblShoferi";
            this.lblShoferi.Size = new System.Drawing.Size(60, 20);
            this.lblShoferi.TabIndex = 0;
            this.lblShoferi.Text = "Shoferi";
            // 
            // bntRuaj
            // 
            this.bntRuaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntRuaj.Location = new System.Drawing.Point(26, 321);
            this.bntRuaj.Name = "bntRuaj";
            this.bntRuaj.Size = new System.Drawing.Size(104, 36);
            this.bntRuaj.TabIndex = 2;
            this.bntRuaj.Text = "Ruaj";
            this.bntRuaj.UseVisualStyleBackColor = true;
            this.bntRuaj.Click += new System.EventHandler(this.bntRuaj_Click);
            // 
            // lblAutomjeti
            // 
            this.lblAutomjeti.AutoSize = true;
            this.lblAutomjeti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutomjeti.Location = new System.Drawing.Point(36, 92);
            this.lblAutomjeti.Name = "lblAutomjeti";
            this.lblAutomjeti.Size = new System.Drawing.Size(76, 20);
            this.lblAutomjeti.TabIndex = 0;
            this.lblAutomjeti.Text = "Automjeti";
            // 
            // btnPerditeso
            // 
            this.btnPerditeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPerditeso.Location = new System.Drawing.Point(155, 321);
            this.btnPerditeso.Name = "btnPerditeso";
            this.btnPerditeso.Size = new System.Drawing.Size(105, 36);
            this.btnPerditeso.TabIndex = 2;
            this.btnPerditeso.Text = "Perditeso";
            this.btnPerditeso.UseVisualStyleBackColor = true;
            // 
            // cmbAutomjetiId
            // 
            this.cmbAutomjetiId.FormattingEnabled = true;
            this.cmbAutomjetiId.Location = new System.Drawing.Point(41, 115);
            this.cmbAutomjetiId.Name = "cmbAutomjetiId";
            this.cmbAutomjetiId.Size = new System.Drawing.Size(195, 21);
            this.cmbAutomjetiId.TabIndex = 43;
            // 
            // cmbShoferiId
            // 
            this.cmbShoferiId.FormattingEnabled = true;
            this.cmbShoferiId.Location = new System.Drawing.Point(39, 54);
            this.cmbShoferiId.Name = "cmbShoferiId";
            this.cmbShoferiId.Size = new System.Drawing.Size(197, 21);
            this.cmbShoferiId.TabIndex = 45;
            // 
            // lblFilimiNdrimit
            // 
            this.lblFilimiNdrimit.AutoSize = true;
            this.lblFilimiNdrimit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilimiNdrimit.Location = new System.Drawing.Point(37, 173);
            this.lblFilimiNdrimit.Name = "lblFilimiNdrimit";
            this.lblFilimiNdrimit.Size = new System.Drawing.Size(114, 20);
            this.lblFilimiNdrimit.TabIndex = 0;
            this.lblFilimiNdrimit.Text = "Fillimi  i ndrrimit";
            // 
            // lblMbarimiNdrrimit
            // 
            this.lblMbarimiNdrrimit.AutoSize = true;
            this.lblMbarimiNdrrimit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMbarimiNdrrimit.Location = new System.Drawing.Point(37, 251);
            this.lblMbarimiNdrrimit.Name = "lblMbarimiNdrrimit";
            this.lblMbarimiNdrrimit.Size = new System.Drawing.Size(127, 20);
            this.lblMbarimiNdrrimit.TabIndex = 0;
            this.lblMbarimiNdrrimit.Text = "Mbarimi i ndrrimit";
            // 
            // dtpFillimiINderrimit
            // 
            this.dtpFillimiINderrimit.CustomFormat = "MMMMdd, yyyy  |  hh:mm";
            this.dtpFillimiINderrimit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFillimiINderrimit.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFillimiINderrimit.Location = new System.Drawing.Point(41, 196);
            this.dtpFillimiINderrimit.Name = "dtpFillimiINderrimit";
            this.dtpFillimiINderrimit.ShowUpDown = true;
            this.dtpFillimiINderrimit.Size = new System.Drawing.Size(195, 22);
            this.dtpFillimiINderrimit.TabIndex = 47;
            this.dtpFillimiINderrimit.Value = new System.DateTime(2021, 6, 19, 19, 51, 0, 0);
            // 
            // dtpMbarimiINderrimir
            // 
            this.dtpMbarimiINderrimir.CustomFormat = "MMMMdd, yyyy  |  hh:mm";
            this.dtpMbarimiINderrimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpMbarimiINderrimir.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpMbarimiINderrimir.Location = new System.Drawing.Point(41, 274);
            this.dtpMbarimiINderrimir.Name = "dtpMbarimiINderrimir";
            this.dtpMbarimiINderrimir.ShowUpDown = true;
            this.dtpMbarimiINderrimir.Size = new System.Drawing.Size(195, 22);
            this.dtpMbarimiINderrimir.TabIndex = 47;
            // 
            // txtNderrimiId
            // 
            this.txtNderrimiId.Location = new System.Drawing.Point(254, 54);
            this.txtNderrimiId.Name = "txtNderrimiId";
            this.txtNderrimiId.Size = new System.Drawing.Size(19, 20);
            this.txtNderrimiId.TabIndex = 48;
            // 
            // ShtoNderrime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 369);
            this.Controls.Add(this.txtNderrimiId);
            this.Controls.Add(this.dtpMbarimiINderrimir);
            this.Controls.Add(this.dtpFillimiINderrimit);
            this.Controls.Add(this.cmbShoferiId);
            this.Controls.Add(this.cmbAutomjetiId);
            this.Controls.Add(this.btnPerditeso);
            this.Controls.Add(this.bntRuaj);
            this.Controls.Add(this.lblMbarimiNdrrimit);
            this.Controls.Add(this.lblFilimiNdrimit);
            this.Controls.Add(this.lblAutomjeti);
            this.Controls.Add(this.lblShoferi);
            this.Name = "ShtoNderrime";
            this.Text = "ShtoNderrime";
            this.Load += new System.EventHandler(this.ShtoNderrime_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblShoferi;
        private System.Windows.Forms.Button bntRuaj;
        private System.Windows.Forms.Label lblAutomjeti;
        private System.Windows.Forms.Button btnPerditeso;
        private System.Windows.Forms.ComboBox cmbAutomjetiId;
        private System.Windows.Forms.ComboBox cmbShoferiId;
        private System.Windows.Forms.Label lblFilimiNdrimit;
        private System.Windows.Forms.Label lblMbarimiNdrrimit;
        private System.Windows.Forms.DateTimePicker dtpFillimiINderrimit;
        private System.Windows.Forms.DateTimePicker dtpMbarimiINderrimir;
        private System.Windows.Forms.TextBox txtNderrimiId;
    }
}