namespace OgrenciYonetimSistemi
{
    partial class frmSinifveOgr
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtOgrAra = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSeciliResim = new System.Windows.Forms.TextBox();
            this.btnOgrKaydet = new System.Windows.Forms.Button();
            this.btnOgrSil = new System.Windows.Forms.Button();
            this.btnOgrYeniEkle = new System.Windows.Forms.Button();
            this.btnFotoSec = new System.Windows.Forms.Button();
            this.txtOgrUlke = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtOgrCinsiyet = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtOgrPob = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpOgrDob = new System.Windows.Forms.DateTimePicker();
            this.txtOgrAd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtOgrID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.resimOgr = new System.Windows.Forms.PictureBox();
            this.btnKaydetSinif = new System.Windows.Forms.Button();
            this.btnSilSinif = new System.Windows.Forms.Button();
            this.btnYeniEkleSinif = new System.Windows.Forms.Button();
            this.txtSinifAdi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSinifID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboSinif = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grvOgr = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resimOgr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvOgr)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtOgrAra);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtSeciliResim);
            this.groupBox1.Controls.Add(this.btnOgrKaydet);
            this.groupBox1.Controls.Add(this.btnOgrSil);
            this.groupBox1.Controls.Add(this.btnOgrYeniEkle);
            this.groupBox1.Controls.Add(this.btnFotoSec);
            this.groupBox1.Controls.Add(this.txtOgrUlke);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtOgrCinsiyet);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtOgrPob);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dtpOgrDob);
            this.groupBox1.Controls.Add(this.txtOgrAd);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtOgrID);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.resimOgr);
            this.groupBox1.Controls.Add(this.btnKaydetSinif);
            this.groupBox1.Controls.Add(this.btnSilSinif);
            this.groupBox1.Controls.Add(this.btnYeniEkleSinif);
            this.groupBox1.Controls.Add(this.txtSinifAdi);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtSinifID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cboSinif);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(767, 301);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sınıf ve Öğrenci Girişi";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtOgrAra
            // 
            this.txtOgrAra.Location = new System.Drawing.Point(493, 260);
            this.txtOgrAra.Name = "txtOgrAra";
            this.txtOgrAra.Size = new System.Drawing.Size(258, 26);
            this.txtOgrAra.TabIndex = 28;
            this.txtOgrAra.TextChanged += new System.EventHandler(this.txtOgrAra_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(360, 263);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 20);
            this.label10.TabIndex = 27;
            this.label10.Text = "Bir Öğrenci Ara";
            // 
            // txtSeciliResim
            // 
            this.txtSeciliResim.Enabled = false;
            this.txtSeciliResim.Location = new System.Drawing.Point(20, 260);
            this.txtSeciliResim.Name = "txtSeciliResim";
            this.txtSeciliResim.Size = new System.Drawing.Size(276, 26);
            this.txtSeciliResim.TabIndex = 26;
            // 
            // btnOgrKaydet
            // 
            this.btnOgrKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOgrKaydet.Location = new System.Drawing.Point(584, 212);
            this.btnOgrKaydet.Name = "btnOgrKaydet";
            this.btnOgrKaydet.Size = new System.Drawing.Size(75, 28);
            this.btnOgrKaydet.TabIndex = 25;
            this.btnOgrKaydet.Text = "Kaydet";
            this.btnOgrKaydet.UseVisualStyleBackColor = true;
            this.btnOgrKaydet.Click += new System.EventHandler(this.btnOgrKaydet_Click);
            // 
            // btnOgrSil
            // 
            this.btnOgrSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOgrSil.Location = new System.Drawing.Point(676, 212);
            this.btnOgrSil.Name = "btnOgrSil";
            this.btnOgrSil.Size = new System.Drawing.Size(75, 28);
            this.btnOgrSil.TabIndex = 24;
            this.btnOgrSil.Text = "Sil";
            this.btnOgrSil.UseVisualStyleBackColor = true;
            this.btnOgrSil.Click += new System.EventHandler(this.btnOgrSil_Click_1);
            // 
            // btnOgrYeniEkle
            // 
            this.btnOgrYeniEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOgrYeniEkle.Location = new System.Drawing.Point(493, 212);
            this.btnOgrYeniEkle.Name = "btnOgrYeniEkle";
            this.btnOgrYeniEkle.Size = new System.Drawing.Size(75, 28);
            this.btnOgrYeniEkle.TabIndex = 23;
            this.btnOgrYeniEkle.Text = "Yeni Ekle";
            this.btnOgrYeniEkle.UseVisualStyleBackColor = true;
            this.btnOgrYeniEkle.Click += new System.EventHandler(this.btnOgrYeniEkle_Click);
            // 
            // btnFotoSec
            // 
            this.btnFotoSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFotoSec.Location = new System.Drawing.Point(157, 210);
            this.btnFotoSec.Name = "btnFotoSec";
            this.btnFotoSec.Size = new System.Drawing.Size(100, 28);
            this.btnFotoSec.TabIndex = 22;
            this.btnFotoSec.Text = "Fotoğraf Seç";
            this.btnFotoSec.UseVisualStyleBackColor = true;
            this.btnFotoSec.Click += new System.EventHandler(this.btnFotoSec_Click);
            // 
            // txtOgrUlke
            // 
            this.txtOgrUlke.Location = new System.Drawing.Point(376, 212);
            this.txtOgrUlke.Name = "txtOgrUlke";
            this.txtOgrUlke.Size = new System.Drawing.Size(100, 26);
            this.txtOgrUlke.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(372, 189);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 20);
            this.label9.TabIndex = 20;
            this.label9.Text = "Ülke";
            // 
            // txtOgrCinsiyet
            // 
            this.txtOgrCinsiyet.Location = new System.Drawing.Point(274, 212);
            this.txtOgrCinsiyet.Name = "txtOgrCinsiyet";
            this.txtOgrCinsiyet.Size = new System.Drawing.Size(87, 26);
            this.txtOgrCinsiyet.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(270, 189);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "Cinsiyet";
            // 
            // txtOgrPob
            // 
            this.txtOgrPob.Location = new System.Drawing.Point(608, 130);
            this.txtOgrPob.Name = "txtOgrPob";
            this.txtOgrPob.Size = new System.Drawing.Size(143, 26);
            this.txtOgrPob.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(604, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Doğum Yeri";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(489, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Doğum Tarihi";
            // 
            // dtpOgrDob
            // 
            this.dtpOgrDob.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpOgrDob.Location = new System.Drawing.Point(493, 128);
            this.dtpOgrDob.Name = "dtpOgrDob";
            this.dtpOgrDob.Size = new System.Drawing.Size(99, 26);
            this.dtpOgrDob.TabIndex = 14;
            // 
            // txtOgrAd
            // 
            this.txtOgrAd.Location = new System.Drawing.Point(274, 130);
            this.txtOgrAd.Name = "txtOgrAd";
            this.txtOgrAd.Size = new System.Drawing.Size(202, 26);
            this.txtOgrAd.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(270, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Öğrenci Adı";
            // 
            // txtOgrID
            // 
            this.txtOgrID.Enabled = false;
            this.txtOgrID.Location = new System.Drawing.Point(157, 130);
            this.txtOgrID.Name = "txtOgrID";
            this.txtOgrID.Size = new System.Drawing.Size(100, 26);
            this.txtOgrID.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(153, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Öğrenci ID";
            // 
            // resimOgr
            // 
            this.resimOgr.Location = new System.Drawing.Point(20, 109);
            this.resimOgr.Name = "resimOgr";
            this.resimOgr.Size = new System.Drawing.Size(121, 129);
            this.resimOgr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.resimOgr.TabIndex = 9;
            this.resimOgr.TabStop = false;
            // 
            // btnKaydetSinif
            // 
            this.btnKaydetSinif.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydetSinif.Location = new System.Drawing.Point(584, 58);
            this.btnKaydetSinif.Name = "btnKaydetSinif";
            this.btnKaydetSinif.Size = new System.Drawing.Size(75, 28);
            this.btnKaydetSinif.TabIndex = 8;
            this.btnKaydetSinif.Text = "Kaydet";
            this.btnKaydetSinif.UseVisualStyleBackColor = true;
            this.btnKaydetSinif.Click += new System.EventHandler(this.btnKaydetSinif_Click);
            // 
            // btnSilSinif
            // 
            this.btnSilSinif.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSilSinif.Location = new System.Drawing.Point(676, 58);
            this.btnSilSinif.Name = "btnSilSinif";
            this.btnSilSinif.Size = new System.Drawing.Size(75, 28);
            this.btnSilSinif.TabIndex = 7;
            this.btnSilSinif.Text = "Sil";
            this.btnSilSinif.UseVisualStyleBackColor = true;
            this.btnSilSinif.Click += new System.EventHandler(this.btnSilSinif_Click);
            // 
            // btnYeniEkleSinif
            // 
            this.btnYeniEkleSinif.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYeniEkleSinif.Location = new System.Drawing.Point(493, 58);
            this.btnYeniEkleSinif.Name = "btnYeniEkleSinif";
            this.btnYeniEkleSinif.Size = new System.Drawing.Size(75, 28);
            this.btnYeniEkleSinif.TabIndex = 6;
            this.btnYeniEkleSinif.Text = "Yeni Ekle";
            this.btnYeniEkleSinif.UseVisualStyleBackColor = true;
            this.btnYeniEkleSinif.Click += new System.EventHandler(this.btnYeniEkleSinif_Click);
            // 
            // txtSinifAdi
            // 
            this.txtSinifAdi.Location = new System.Drawing.Point(274, 60);
            this.txtSinifAdi.Name = "txtSinifAdi";
            this.txtSinifAdi.Size = new System.Drawing.Size(202, 26);
            this.txtSinifAdi.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(270, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sınıf Adı";
            // 
            // txtSinifID
            // 
            this.txtSinifID.Enabled = false;
            this.txtSinifID.Location = new System.Drawing.Point(157, 60);
            this.txtSinifID.Name = "txtSinifID";
            this.txtSinifID.Size = new System.Drawing.Size(100, 26);
            this.txtSinifID.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sınıf ID";
            // 
            // cboSinif
            // 
            this.cboSinif.FormattingEnabled = true;
            this.cboSinif.Location = new System.Drawing.Point(20, 58);
            this.cboSinif.Name = "cboSinif";
            this.cboSinif.Size = new System.Drawing.Size(121, 28);
            this.cboSinif.TabIndex = 1;
            this.cboSinif.SelectedIndexChanged += new System.EventHandler(this.cboSinif_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sınıf Listesi";
            // 
            // grvOgr
            // 
            this.grvOgr.AllowUserToAddRows = false;
            this.grvOgr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvOgr.Location = new System.Drawing.Point(12, 319);
            this.grvOgr.Name = "grvOgr";
            this.grvOgr.Size = new System.Drawing.Size(767, 178);
            this.grvOgr.TabIndex = 1;
            this.grvOgr.Click += new System.EventHandler(this.grvOgr_Click);
            // 
            // frmSinifveOgr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 509);
            this.Controls.Add(this.grvOgr);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Name = "frmSinifveOgr";
            this.Text = "Sınıf ve Öğrenci Bilgileri";
            this.Load += new System.EventHandler(this.frmSinifveOgr_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resimOgr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvOgr)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnKaydetSinif;
        private System.Windows.Forms.Button btnSilSinif;
        private System.Windows.Forms.Button btnYeniEkleSinif;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSinifID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboSinif;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOgrAra;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSeciliResim;
        private System.Windows.Forms.Button btnOgrKaydet;
        private System.Windows.Forms.Button btnOgrSil;
        private System.Windows.Forms.Button btnOgrYeniEkle;
        private System.Windows.Forms.Button btnFotoSec;
        private System.Windows.Forms.TextBox txtOgrUlke;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtOgrCinsiyet;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtOgrPob;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpOgrDob;
        private System.Windows.Forms.TextBox txtOgrAd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtOgrID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox resimOgr;
        private System.Windows.Forms.DataGridView grvOgr;
        private System.Windows.Forms.TextBox txtSinifAdi;
    }
}