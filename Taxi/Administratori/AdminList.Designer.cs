
namespace Taxi.Stafi
{
    partial class Admin
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
            this.dgvAdmin = new System.Windows.Forms.DataGridView();
            this.btnShto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmin)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAdmin
            // 
            this.dgvAdmin.AllowUserToAddRows = false;
            this.dgvAdmin.AllowUserToDeleteRows = false;
            this.dgvAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdmin.Location = new System.Drawing.Point(11, 73);
            this.dgvAdmin.Margin = new System.Windows.Forms.Padding(2);
            this.dgvAdmin.Name = "dgvAdmin";
            this.dgvAdmin.ReadOnly = true;
            this.dgvAdmin.RowTemplate.Height = 24;
            this.dgvAdmin.Size = new System.Drawing.Size(900, 300);
            this.dgvAdmin.TabIndex = 118;
            this.dgvAdmin.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAdmin_CellContentClick);
            // 
            // btnShto
            // 
            this.btnShto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShto.Location = new System.Drawing.Point(818, 35);
            this.btnShto.Name = "btnShto";
            this.btnShto.Size = new System.Drawing.Size(93, 33);
            this.btnShto.TabIndex = 119;
            this.btnShto.Text = "Shto";
            this.btnShto.UseVisualStyleBackColor = true;
            this.btnShto.Click += new System.EventHandler(this.btnShto_Click_1);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 381);
            this.ControlBox = false;
            this.Controls.Add(this.btnShto);
            this.Controls.Add(this.dgvAdmin);
            this.Name = "Admin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvAdmin;
        private System.Windows.Forms.Button btnShto;
    }
}