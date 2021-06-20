
namespace Taxi
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCloseMainMenu = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblBibloteka = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnShkyçu = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.btnLogOut = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAdminat = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnNderrimet = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSherbimet = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnShoferet = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAutomjetet = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnHome = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseMainMenu)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.bunifuGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CadetBlue;
            this.panel1.Controls.Add(this.btnCloseMainMenu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1244, 38);
            this.panel1.TabIndex = 5;
            // 
            // btnCloseMainMenu
            // 
            this.btnCloseMainMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloseMainMenu.BackColor = System.Drawing.Color.Transparent;
            this.btnCloseMainMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnCloseMainMenu.Image")));
            this.btnCloseMainMenu.ImageActive = null;
            this.btnCloseMainMenu.Location = new System.Drawing.Point(1206, 0);
            this.btnCloseMainMenu.Name = "btnCloseMainMenu";
            this.btnCloseMainMenu.Size = new System.Drawing.Size(38, 38);
            this.btnCloseMainMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCloseMainMenu.TabIndex = 4;
            this.btnCloseMainMenu.TabStop = false;
            this.btnCloseMainMenu.Zoom = 10;
            this.btnCloseMainMenu.Click += new System.EventHandler(this.btnCloseMainMenu_Click);
            // 
            // lblBibloteka
            // 
            this.lblBibloteka.AutoSize = true;
            this.lblBibloteka.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBibloteka.Location = new System.Drawing.Point(556, 87);
            this.lblBibloteka.Name = "lblBibloteka";
            this.lblBibloteka.Size = new System.Drawing.Size(431, 31);
            this.lblBibloteka.TabIndex = 7;
            this.lblBibloteka.Text = "Sistemi për menaxhimin e taksis";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.CadetBlue;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(345, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(183, 159);
            this.panel2.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(7, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(169, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackColor = System.Drawing.Color.White;
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuGradientPanel1.Controls.Add(this.btnShkyçu);
            this.bunifuGradientPanel1.Controls.Add(this.SidePanel);
            this.bunifuGradientPanel1.Controls.Add(this.btnLogOut);
            this.bunifuGradientPanel1.Controls.Add(this.btnAdminat);
            this.bunifuGradientPanel1.Controls.Add(this.btnNderrimet);
            this.bunifuGradientPanel1.Controls.Add(this.btnSherbimet);
            this.bunifuGradientPanel1.Controls.Add(this.btnShoferet);
            this.bunifuGradientPanel1.Controls.Add(this.btnAutomjetet);
            this.bunifuGradientPanel1.Controls.Add(this.btnHome);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.DarkTurquoise;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.BlueViolet;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.Blue;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.Black;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 38);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(250, 652);
            this.bunifuGradientPanel1.TabIndex = 9;
            // 
            // btnShkyçu
            // 
            this.btnShkyçu.Active = false;
            this.btnShkyçu.Activecolor = System.Drawing.Color.MediumBlue;
            this.btnShkyçu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnShkyçu.BackColor = System.Drawing.Color.Transparent;
            this.btnShkyçu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnShkyçu.BorderRadius = 0;
            this.btnShkyçu.ButtonText = "                  Shkyçu";
            this.btnShkyçu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShkyçu.DisabledColor = System.Drawing.Color.Gray;
            this.btnShkyçu.Iconcolor = System.Drawing.Color.Transparent;
            this.btnShkyçu.Iconimage = null;
            this.btnShkyçu.Iconimage_right = null;
            this.btnShkyçu.Iconimage_right_Selected = null;
            this.btnShkyçu.Iconimage_Selected = null;
            this.btnShkyçu.IconMarginLeft = 0;
            this.btnShkyçu.IconMarginRight = 0;
            this.btnShkyçu.IconRightVisible = true;
            this.btnShkyçu.IconRightZoom = 0D;
            this.btnShkyçu.IconVisible = true;
            this.btnShkyçu.IconZoom = 50D;
            this.btnShkyçu.IsTab = false;
            this.btnShkyçu.Location = new System.Drawing.Point(5, 581);
            this.btnShkyçu.Margin = new System.Windows.Forms.Padding(5);
            this.btnShkyçu.Name = "btnShkyçu";
            this.btnShkyçu.Normalcolor = System.Drawing.Color.Transparent;
            this.btnShkyçu.OnHovercolor = System.Drawing.Color.DarkBlue;
            this.btnShkyçu.OnHoverTextColor = System.Drawing.Color.White;
            this.btnShkyçu.selected = false;
            this.btnShkyçu.Size = new System.Drawing.Size(208, 44);
            this.btnShkyçu.TabIndex = 8;
            this.btnShkyçu.Text = "                  Shkyçu";
            this.btnShkyçu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShkyçu.Textcolor = System.Drawing.Color.White;
            this.btnShkyçu.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShkyçu.Click += new System.EventHandler(this.btnShkyçu_Click);
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.Cyan;
            this.SidePanel.Location = new System.Drawing.Point(-1, 41);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(10, 59);
            this.SidePanel.TabIndex = 3;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Active = false;
            this.btnLogOut.Activecolor = System.Drawing.Color.MediumBlue;
            this.btnLogOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLogOut.BackColor = System.Drawing.Color.Transparent;
            this.btnLogOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogOut.BorderRadius = 0;
            this.btnLogOut.ButtonText = "                  Shkyçu";
            this.btnLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogOut.DisabledColor = System.Drawing.Color.Gray;
            this.btnLogOut.Iconcolor = System.Drawing.Color.Transparent;
            this.btnLogOut.Iconimage = null;
            this.btnLogOut.Iconimage_right = null;
            this.btnLogOut.Iconimage_right_Selected = null;
            this.btnLogOut.Iconimage_Selected = null;
            this.btnLogOut.IconMarginLeft = 0;
            this.btnLogOut.IconMarginRight = 0;
            this.btnLogOut.IconRightVisible = true;
            this.btnLogOut.IconRightZoom = 0D;
            this.btnLogOut.IconVisible = true;
            this.btnLogOut.IconZoom = 50D;
            this.btnLogOut.IsTab = false;
            this.btnLogOut.Location = new System.Drawing.Point(5, 786);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(5);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Normalcolor = System.Drawing.Color.Transparent;
            this.btnLogOut.OnHovercolor = System.Drawing.Color.DarkBlue;
            this.btnLogOut.OnHoverTextColor = System.Drawing.Color.White;
            this.btnLogOut.selected = false;
            this.btnLogOut.Size = new System.Drawing.Size(417, 77);
            this.btnLogOut.TabIndex = 7;
            this.btnLogOut.Text = "                  Shkyçu";
            this.btnLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.Textcolor = System.Drawing.Color.White;
            this.btnLogOut.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnAdminat
            // 
            this.btnAdminat.Active = false;
            this.btnAdminat.Activecolor = System.Drawing.Color.Transparent;
            this.btnAdminat.BackColor = System.Drawing.Color.Transparent;
            this.btnAdminat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdminat.BorderRadius = 0;
            this.btnAdminat.ButtonText = "                  Adminat";
            this.btnAdminat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdminat.DisabledColor = System.Drawing.Color.Gray;
            this.btnAdminat.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAdminat.Iconimage = null;
            this.btnAdminat.Iconimage_right = null;
            this.btnAdminat.Iconimage_right_Selected = null;
            this.btnAdminat.Iconimage_Selected = null;
            this.btnAdminat.IconMarginLeft = 0;
            this.btnAdminat.IconMarginRight = 0;
            this.btnAdminat.IconRightVisible = true;
            this.btnAdminat.IconRightZoom = 0D;
            this.btnAdminat.IconVisible = true;
            this.btnAdminat.IconZoom = 50D;
            this.btnAdminat.IsTab = false;
            this.btnAdminat.Location = new System.Drawing.Point(5, 138);
            this.btnAdminat.Margin = new System.Windows.Forms.Padding(7);
            this.btnAdminat.Name = "btnAdminat";
            this.btnAdminat.Normalcolor = System.Drawing.Color.Transparent;
            this.btnAdminat.OnHovercolor = System.Drawing.Color.DarkBlue;
            this.btnAdminat.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAdminat.selected = false;
            this.btnAdminat.Size = new System.Drawing.Size(216, 70);
            this.btnAdminat.TabIndex = 3;
            this.btnAdminat.Text = "                  Adminat";
            this.btnAdminat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdminat.Textcolor = System.Drawing.Color.White;
            this.btnAdminat.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminat.Click += new System.EventHandler(this.btnAdminat_Click);
            // 
            // btnNderrimet
            // 
            this.btnNderrimet.Active = false;
            this.btnNderrimet.Activecolor = System.Drawing.Color.Transparent;
            this.btnNderrimet.BackColor = System.Drawing.Color.Transparent;
            this.btnNderrimet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNderrimet.BorderRadius = 0;
            this.btnNderrimet.ButtonText = "              Nderrimet";
            this.btnNderrimet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNderrimet.DisabledColor = System.Drawing.Color.Gray;
            this.btnNderrimet.Iconcolor = System.Drawing.Color.Transparent;
            this.btnNderrimet.Iconimage = null;
            this.btnNderrimet.Iconimage_right = null;
            this.btnNderrimet.Iconimage_right_Selected = null;
            this.btnNderrimet.Iconimage_Selected = null;
            this.btnNderrimet.IconMarginLeft = 0;
            this.btnNderrimet.IconMarginRight = 0;
            this.btnNderrimet.IconRightVisible = true;
            this.btnNderrimet.IconRightZoom = 0D;
            this.btnNderrimet.IconVisible = true;
            this.btnNderrimet.IconZoom = 50D;
            this.btnNderrimet.IsTab = false;
            this.btnNderrimet.Location = new System.Drawing.Point(13, 396);
            this.btnNderrimet.Margin = new System.Windows.Forms.Padding(5);
            this.btnNderrimet.Name = "btnNderrimet";
            this.btnNderrimet.Normalcolor = System.Drawing.Color.Transparent;
            this.btnNderrimet.OnHovercolor = System.Drawing.Color.DarkBlue;
            this.btnNderrimet.OnHoverTextColor = System.Drawing.Color.White;
            this.btnNderrimet.selected = false;
            this.btnNderrimet.Size = new System.Drawing.Size(216, 53);
            this.btnNderrimet.TabIndex = 3;
            this.btnNderrimet.Text = "              Nderrimet";
            this.btnNderrimet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNderrimet.Textcolor = System.Drawing.Color.White;
            this.btnNderrimet.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNderrimet.Click += new System.EventHandler(this.btnNderrimet_Click);
            // 
            // btnSherbimet
            // 
            this.btnSherbimet.Active = false;
            this.btnSherbimet.Activecolor = System.Drawing.Color.Transparent;
            this.btnSherbimet.BackColor = System.Drawing.Color.Transparent;
            this.btnSherbimet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSherbimet.BorderRadius = 0;
            this.btnSherbimet.ButtonText = "               Sherbimet";
            this.btnSherbimet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSherbimet.DisabledColor = System.Drawing.Color.Gray;
            this.btnSherbimet.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSherbimet.Iconimage = null;
            this.btnSherbimet.Iconimage_right = null;
            this.btnSherbimet.Iconimage_right_Selected = null;
            this.btnSherbimet.Iconimage_Selected = null;
            this.btnSherbimet.IconMarginLeft = 0;
            this.btnSherbimet.IconMarginRight = 0;
            this.btnSherbimet.IconRightVisible = true;
            this.btnSherbimet.IconRightZoom = 0D;
            this.btnSherbimet.IconVisible = true;
            this.btnSherbimet.IconZoom = 50D;
            this.btnSherbimet.IsTab = false;
            this.btnSherbimet.Location = new System.Drawing.Point(13, 476);
            this.btnSherbimet.Margin = new System.Windows.Forms.Padding(5);
            this.btnSherbimet.Name = "btnSherbimet";
            this.btnSherbimet.Normalcolor = System.Drawing.Color.Transparent;
            this.btnSherbimet.OnHovercolor = System.Drawing.Color.DarkBlue;
            this.btnSherbimet.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSherbimet.selected = false;
            this.btnSherbimet.Size = new System.Drawing.Size(216, 53);
            this.btnSherbimet.TabIndex = 3;
            this.btnSherbimet.Text = "               Sherbimet";
            this.btnSherbimet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSherbimet.Textcolor = System.Drawing.Color.White;
            this.btnSherbimet.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSherbimet.Click += new System.EventHandler(this.btnSherbimet_Click);
            // 
            // btnShoferet
            // 
            this.btnShoferet.Active = false;
            this.btnShoferet.Activecolor = System.Drawing.Color.Transparent;
            this.btnShoferet.BackColor = System.Drawing.Color.Transparent;
            this.btnShoferet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnShoferet.BorderRadius = 0;
            this.btnShoferet.ButtonText = "                  Shoferet";
            this.btnShoferet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShoferet.DisabledColor = System.Drawing.Color.Gray;
            this.btnShoferet.Iconcolor = System.Drawing.Color.Transparent;
            this.btnShoferet.Iconimage = null;
            this.btnShoferet.Iconimage_right = null;
            this.btnShoferet.Iconimage_right_Selected = null;
            this.btnShoferet.Iconimage_Selected = null;
            this.btnShoferet.IconMarginLeft = 0;
            this.btnShoferet.IconMarginRight = 0;
            this.btnShoferet.IconRightVisible = true;
            this.btnShoferet.IconRightZoom = 0D;
            this.btnShoferet.IconVisible = true;
            this.btnShoferet.IconZoom = 50D;
            this.btnShoferet.IsTab = false;
            this.btnShoferet.Location = new System.Drawing.Point(-1, 220);
            this.btnShoferet.Margin = new System.Windows.Forms.Padding(5);
            this.btnShoferet.Name = "btnShoferet";
            this.btnShoferet.Normalcolor = System.Drawing.Color.Transparent;
            this.btnShoferet.OnHovercolor = System.Drawing.Color.DarkBlue;
            this.btnShoferet.OnHoverTextColor = System.Drawing.Color.White;
            this.btnShoferet.selected = false;
            this.btnShoferet.Size = new System.Drawing.Size(222, 70);
            this.btnShoferet.TabIndex = 2;
            this.btnShoferet.Text = "                  Shoferet";
            this.btnShoferet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShoferet.Textcolor = System.Drawing.Color.White;
            this.btnShoferet.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShoferet.Click += new System.EventHandler(this.btnShoferet_Click);
            // 
            // btnAutomjetet
            // 
            this.btnAutomjetet.Active = false;
            this.btnAutomjetet.Activecolor = System.Drawing.Color.Transparent;
            this.btnAutomjetet.BackColor = System.Drawing.Color.Transparent;
            this.btnAutomjetet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAutomjetet.BorderRadius = 0;
            this.btnAutomjetet.ButtonText = "                 Automjetet";
            this.btnAutomjetet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAutomjetet.DisabledColor = System.Drawing.Color.Gray;
            this.btnAutomjetet.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAutomjetet.Iconimage = null;
            this.btnAutomjetet.Iconimage_right = null;
            this.btnAutomjetet.Iconimage_right_Selected = null;
            this.btnAutomjetet.Iconimage_Selected = null;
            this.btnAutomjetet.IconMarginLeft = 0;
            this.btnAutomjetet.IconMarginRight = 0;
            this.btnAutomjetet.IconRightVisible = true;
            this.btnAutomjetet.IconRightZoom = 0D;
            this.btnAutomjetet.IconVisible = true;
            this.btnAutomjetet.IconZoom = 50D;
            this.btnAutomjetet.IsTab = false;
            this.btnAutomjetet.Location = new System.Drawing.Point(5, 310);
            this.btnAutomjetet.Margin = new System.Windows.Forms.Padding(5);
            this.btnAutomjetet.Name = "btnAutomjetet";
            this.btnAutomjetet.Normalcolor = System.Drawing.Color.Transparent;
            this.btnAutomjetet.OnHovercolor = System.Drawing.Color.DarkBlue;
            this.btnAutomjetet.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAutomjetet.selected = false;
            this.btnAutomjetet.Size = new System.Drawing.Size(238, 64);
            this.btnAutomjetet.TabIndex = 1;
            this.btnAutomjetet.Text = "                 Automjetet";
            this.btnAutomjetet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAutomjetet.Textcolor = System.Drawing.Color.White;
            this.btnAutomjetet.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAutomjetet.Click += new System.EventHandler(this.btnAutomjetet_Click);
            // 
            // btnHome
            // 
            this.btnHome.Active = false;
            this.btnHome.Activecolor = System.Drawing.Color.MediumBlue;
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHome.BorderRadius = 0;
            this.btnHome.ButtonText = "              Faqja kryesore       ";
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.DisabledColor = System.Drawing.Color.Gray;
            this.btnHome.Iconcolor = System.Drawing.Color.Transparent;
            this.btnHome.Iconimage = null;
            this.btnHome.Iconimage_right = null;
            this.btnHome.Iconimage_right_Selected = null;
            this.btnHome.Iconimage_Selected = null;
            this.btnHome.IconMarginLeft = 0;
            this.btnHome.IconMarginRight = 0;
            this.btnHome.IconRightVisible = true;
            this.btnHome.IconRightZoom = 0D;
            this.btnHome.IconVisible = true;
            this.btnHome.IconZoom = 50D;
            this.btnHome.IsTab = false;
            this.btnHome.Location = new System.Drawing.Point(13, 31);
            this.btnHome.Margin = new System.Windows.Forms.Padding(5);
            this.btnHome.Name = "btnHome";
            this.btnHome.Normalcolor = System.Drawing.Color.Transparent;
            this.btnHome.OnHovercolor = System.Drawing.Color.DarkBlue;
            this.btnHome.OnHoverTextColor = System.Drawing.Color.White;
            this.btnHome.selected = false;
            this.btnHome.Size = new System.Drawing.Size(200, 77);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "              Faqja kryesore       ";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Textcolor = System.Drawing.Color.White;
            this.btnHome.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // pnlContent
            // 
            this.pnlContent.Location = new System.Drawing.Point(269, 215);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(963, 420);
            this.pnlContent.TabIndex = 10;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 690);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblBibloteka);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.Text = "MainMenu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseMainMenu)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton btnCloseMainMenu;
        private System.Windows.Forms.Label lblBibloteka;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuFlatButton btnShkyçu;
        private System.Windows.Forms.Panel SidePanel;
        private Bunifu.Framework.UI.BunifuFlatButton btnLogOut;
        private Bunifu.Framework.UI.BunifuFlatButton btnAdminat;
        private Bunifu.Framework.UI.BunifuFlatButton btnSherbimet;
        private Bunifu.Framework.UI.BunifuFlatButton btnShoferet;
        private Bunifu.Framework.UI.BunifuFlatButton btnAutomjetet;
        private Bunifu.Framework.UI.BunifuFlatButton btnHome;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuFlatButton btnNderrimet;
        private System.Windows.Forms.Panel pnlContent;
    }
}