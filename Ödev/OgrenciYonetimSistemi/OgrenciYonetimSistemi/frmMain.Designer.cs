namespace OgrenciYonetimSistemi
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuSistem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProgramKapa = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuVeriGiris = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSinifveOgr = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDonem = new System.Windows.Forms.ToolStripMenuItem();
            this.ResimOkul = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ResimOkul)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSistem,
            this.mnuVeriGiris});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(931, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuSistem
            // 
            this.mnuSistem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuProgramKapa});
            this.mnuSistem.Name = "mnuSistem";
            this.mnuSistem.Size = new System.Drawing.Size(69, 25);
            this.mnuSistem.Text = "Sistem";
            // 
            // mnuProgramKapa
            // 
            this.mnuProgramKapa.Name = "mnuProgramKapa";
            this.mnuProgramKapa.Size = new System.Drawing.Size(188, 26);
            this.mnuProgramKapa.Text = "Programı Kapat";
            this.mnuProgramKapa.Click += new System.EventHandler(this.mnuProgramKapa_Click);
            // 
            // mnuVeriGiris
            // 
            this.mnuVeriGiris.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSinifveOgr,
            this.mnuDonem});
            this.mnuVeriGiris.Name = "mnuVeriGiris";
            this.mnuVeriGiris.Size = new System.Drawing.Size(89, 25);
            this.mnuVeriGiris.Text = "Veri Girişi";
            // 
            // mnuSinifveOgr
            // 
            this.mnuSinifveOgr.Name = "mnuSinifveOgr";
            this.mnuSinifveOgr.Size = new System.Drawing.Size(299, 26);
            this.mnuSinifveOgr.Text = "Sınıflar ve Öğrenciler";
            this.mnuSinifveOgr.Click += new System.EventHandler(this.mnuSinifveOgr_Click);
            // 
            // mnuDonem
            // 
            this.mnuDonem.Name = "mnuDonem";
            this.mnuDonem.Size = new System.Drawing.Size(299, 26);
            this.mnuDonem.Text = "Öğrencileri Okuduğu Dönemler";
            this.mnuDonem.Click += new System.EventHandler(this.mnuDonem_Click);
            // 
            // ResimOkul
            // 
            this.ResimOkul.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ResimOkul.Image = ((System.Drawing.Image)(resources.GetObject("ResimOkul.Image")));
            this.ResimOkul.Location = new System.Drawing.Point(0, 29);
            this.ResimOkul.Name = "ResimOkul";
            this.ResimOkul.Size = new System.Drawing.Size(931, 614);
            this.ResimOkul.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ResimOkul.TabIndex = 1;
            this.ResimOkul.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 643);
            this.Controls.Add(this.ResimOkul);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Öğrenci Yönetim Sistemi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.PaddingChanged += new System.EventHandler(this.frmMain_PaddingChanged);
            this.Resize += new System.EventHandler(this.frmMain_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ResimOkul)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuSistem;
        private System.Windows.Forms.ToolStripMenuItem mnuProgramKapa;
        private System.Windows.Forms.PictureBox ResimOkul;
        private System.Windows.Forms.ToolStripMenuItem mnuVeriGiris;
        private System.Windows.Forms.ToolStripMenuItem mnuSinifveOgr;
        private System.Windows.Forms.ToolStripMenuItem mnuDonem;
    }
}

