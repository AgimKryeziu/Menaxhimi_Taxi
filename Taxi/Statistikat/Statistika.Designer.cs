
namespace Taxi.Destinacione
{
    partial class Statistika
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Statistika));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Qyteti = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblQyteti = new System.Windows.Forms.Label();
            this.Emri = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblShoferi = new System.Windows.Forms.Label();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.Qyteti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Emri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // Qyteti
            // 
            resources.ApplyResources(this.Qyteti, "Qyteti");
            chartArea1.Name = "ChartArea1";
            this.Qyteti.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.Qyteti.Legends.Add(legend1);
            this.Qyteti.Name = "Qyteti";
            this.Qyteti.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Qyteti";
            series1.YValuesPerPoint = 4;
            this.Qyteti.Series.Add(series1);
            // 
            // lblQyteti
            // 
            resources.ApplyResources(this.lblQyteti, "lblQyteti");
            this.lblQyteti.Name = "lblQyteti";
            // 
            // Emri
            // 
            resources.ApplyResources(this.Emri, "Emri");
            chartArea2.Name = "ChartArea1";
            this.Emri.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.Emri.Legends.Add(legend2);
            this.Emri.Name = "Emri";
            this.Emri.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Emri";
            this.Emri.Series.Add(series2);
            // 
            // lblShoferi
            // 
            resources.ApplyResources(this.lblShoferi, "lblShoferi");
            this.lblShoferi.Name = "lblShoferi";
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
            // Statistika
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.lblShoferi);
            this.Controls.Add(this.lblQyteti);
            this.Controls.Add(this.Emri);
            this.Controls.Add(this.Qyteti);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Statistika";
            this.Load += new System.EventHandler(this.Statistika_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Qyteti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Emri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart Qyteti;
        private System.Windows.Forms.Label lblQyteti;
        private System.Windows.Forms.DataVisualization.Charting.Chart Emri;
        private System.Windows.Forms.Label lblShoferi;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
    }
}