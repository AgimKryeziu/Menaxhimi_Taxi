
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
            this.btnShto = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutomjeti)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAutomjeti
            // 
            this.dgvAutomjeti.AllowUserToAddRows = false;
            this.dgvAutomjeti.AllowUserToDeleteRows = false;
            this.dgvAutomjeti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAutomjeti.Location = new System.Drawing.Point(12, 73);
            this.dgvAutomjeti.Name = "dgvAutomjeti";
            this.dgvAutomjeti.ReadOnly = true;
            this.dgvAutomjeti.Size = new System.Drawing.Size(568, 209);
            this.dgvAutomjeti.TabIndex = 22;
            this.dgvAutomjeti.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAutomjeti_CellContentClick);
            // 
            // btnShto
            // 
            this.btnShto.Active = false;
            this.btnShto.Activecolor = System.Drawing.Color.Lime;
            this.btnShto.BackColor = System.Drawing.Color.Green;
            this.btnShto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnShto.BorderRadius = 0;
            this.btnShto.ButtonText = "        Shto";
            this.btnShto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShto.DisabledColor = System.Drawing.Color.Gray;
            this.btnShto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShto.ForeColor = System.Drawing.Color.Black;
            this.btnShto.Iconcolor = System.Drawing.Color.Transparent;
            this.btnShto.Iconimage = null;
            this.btnShto.Iconimage_right = null;
            this.btnShto.Iconimage_right_Selected = null;
            this.btnShto.Iconimage_Selected = null;
            this.btnShto.IconMarginLeft = 0;
            this.btnShto.IconMarginRight = 0;
            this.btnShto.IconRightVisible = true;
            this.btnShto.IconRightZoom = 0D;
            this.btnShto.IconVisible = true;
            this.btnShto.IconZoom = 70D;
            this.btnShto.IsTab = false;
            this.btnShto.Location = new System.Drawing.Point(495, 36);
            this.btnShto.Name = "btnShto";
            this.btnShto.Normalcolor = System.Drawing.Color.Green;
            this.btnShto.OnHovercolor = System.Drawing.Color.Lime;
            this.btnShto.OnHoverTextColor = System.Drawing.Color.White;
            this.btnShto.selected = false;
            this.btnShto.Size = new System.Drawing.Size(85, 31);
            this.btnShto.TabIndex = 23;
            this.btnShto.Text = "        Shto";
            this.btnShto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShto.Textcolor = System.Drawing.Color.White;
            this.btnShto.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShto.Click += new System.EventHandler(this.btnShto_Click);
            // 
            // Automjeti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 315);
            this.Controls.Add(this.btnShto);
            this.Controls.Add(this.dgvAutomjeti);
            this.Name = "Automjeti";
            this.Text = "Automjetet";
            this.Load += new System.EventHandler(this.Automjeti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutomjeti)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAutomjeti;
        private Bunifu.Framework.UI.BunifuFlatButton btnShto;
    }
}