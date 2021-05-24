
namespace Taxi
{
    partial class MainForm
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
            this.btnDestinacionet = new System.Windows.Forms.Button();
            this.btnMenaxhoShofer = new System.Windows.Forms.Button();
            this.btnMenaxhoRezervim = new System.Windows.Forms.Button();
            this.btnMenaxhoAutomjetin = new System.Windows.Forms.Button();
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlSidebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDestinacionet
            // 
            this.btnDestinacionet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDestinacionet.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDestinacionet.Location = new System.Drawing.Point(8, 239);
            this.btnDestinacionet.Name = "btnDestinacionet";
            this.btnDestinacionet.Size = new System.Drawing.Size(160, 48);
            this.btnDestinacionet.TabIndex = 10;
            this.btnDestinacionet.Text = "Destinacionet";
            this.btnDestinacionet.UseVisualStyleBackColor = true;
            this.btnDestinacionet.Click += new System.EventHandler(this.btnDestinacionet_Click);
            // 
            // btnMenaxhoShofer
            // 
            this.btnMenaxhoShofer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenaxhoShofer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenaxhoShofer.Location = new System.Drawing.Point(10, 40);
            this.btnMenaxhoShofer.Name = "btnMenaxhoShofer";
            this.btnMenaxhoShofer.Size = new System.Drawing.Size(158, 46);
            this.btnMenaxhoShofer.TabIndex = 7;
            this.btnMenaxhoShofer.Text = "Shoferet";
            this.btnMenaxhoShofer.UseVisualStyleBackColor = true;
            this.btnMenaxhoShofer.Click += new System.EventHandler(this.btnMenaxhoShofer_Click);
            // 
            // btnMenaxhoRezervim
            // 
            this.btnMenaxhoRezervim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenaxhoRezervim.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenaxhoRezervim.Location = new System.Drawing.Point(12, 347);
            this.btnMenaxhoRezervim.Name = "btnMenaxhoRezervim";
            this.btnMenaxhoRezervim.Size = new System.Drawing.Size(158, 42);
            this.btnMenaxhoRezervim.TabIndex = 8;
            this.btnMenaxhoRezervim.Text = "Rezervimet";
            this.btnMenaxhoRezervim.UseVisualStyleBackColor = true;
            this.btnMenaxhoRezervim.Click += new System.EventHandler(this.btnMenaxhoRezervim_Click);
            // 
            // btnMenaxhoAutomjetin
            // 
            this.btnMenaxhoAutomjetin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenaxhoAutomjetin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenaxhoAutomjetin.Location = new System.Drawing.Point(12, 140);
            this.btnMenaxhoAutomjetin.Name = "btnMenaxhoAutomjetin";
            this.btnMenaxhoAutomjetin.Size = new System.Drawing.Size(160, 44);
            this.btnMenaxhoAutomjetin.TabIndex = 4;
            this.btnMenaxhoAutomjetin.Text = "Automjetet";
            this.btnMenaxhoAutomjetin.UseVisualStyleBackColor = true;
            this.btnMenaxhoAutomjetin.Click += new System.EventHandler(this.btnMenaxhoAutomjetin_Click);
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pnlSidebar.Controls.Add(this.btnMenaxhoShofer);
            this.pnlSidebar.Controls.Add(this.btnMenaxhoAutomjetin);
            this.pnlSidebar.Controls.Add(this.btnDestinacionet);
            this.pnlSidebar.Controls.Add(this.btnMenaxhoRezervim);
            this.pnlSidebar.Location = new System.Drawing.Point(12, 12);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(183, 448);
            this.pnlSidebar.TabIndex = 11;
            // 
            // pnlContent
            // 
            this.pnlContent.Location = new System.Drawing.Point(201, 12);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(922, 448);
            this.pnlContent.TabIndex = 12;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(1125, 472);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlSidebar);
            this.Name = "MainForm";
            this.Text = "Taxi";
            this.pnlSidebar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDestinacionet;
        private System.Windows.Forms.Button btnMenaxhoShofer;
        private System.Windows.Forms.Button btnMenaxhoRezervim;
        private System.Windows.Forms.Button btnMenaxhoAutomjetin;
        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Panel pnlContent;
    }
}