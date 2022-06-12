namespace OgrenciYonetimSistemi
{
    partial class frmOgrenciSubject
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
            this.label9 = new System.Windows.Forms.Label();
            this.txtKredi = new System.Windows.Forms.TextBox();
            this.btnGuncelleHepsi = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cboDersListesi = new System.Windows.Forms.ComboBox();
            this.btnDersİptal = new System.Windows.Forms.Button();
            this.btnDersKaydet = new System.Windows.Forms.Button();
            this.btnDersSil = new System.Windows.Forms.Button();
            this.btnDersYeniEkle = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDersAdi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDersID = new System.Windows.Forms.TextBox();
            this.btnDonemIptal = new System.Windows.Forms.Button();
            this.btnDonemKaydet = new System.Windows.Forms.Button();
            this.btnDonemSil = new System.Windows.Forms.Button();
            this.btnDonemYeniEkle = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDonemAdi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDonemID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboDonem = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboSinifList = new System.Windows.Forms.ComboBox();
            this.grvOgrPuan = new System.Windows.Forms.DataGridView();
            this.txtOkulYil = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvOgrPuan)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtOkulYil);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtKredi);
            this.groupBox1.Controls.Add(this.btnGuncelleHepsi);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cboDersListesi);
            this.groupBox1.Controls.Add(this.btnDersİptal);
            this.groupBox1.Controls.Add(this.btnDersKaydet);
            this.groupBox1.Controls.Add(this.btnDersSil);
            this.groupBox1.Controls.Add(this.btnDersYeniEkle);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtDersAdi);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtDersID);
            this.groupBox1.Controls.Add(this.btnDonemIptal);
            this.groupBox1.Controls.Add(this.btnDonemKaydet);
            this.groupBox1.Controls.Add(this.btnDonemSil);
            this.groupBox1.Controls.Add(this.btnDonemYeniEkle);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtDonemAdi);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtDonemID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cboDonem);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cboSinifList);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(969, 190);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Öğrencinin Kayıtlı Olduğu Dersler";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label9
            // 
            this.label9.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(531, 119);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 20);
            this.label9.TabIndex = 27;
            this.label9.Text = "Kredi";
            // 
            // txtKredi
            // 
            this.txtKredi.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.txtKredi.Location = new System.Drawing.Point(535, 145);
            this.txtKredi.Name = "txtKredi";
            this.txtKredi.Size = new System.Drawing.Size(56, 26);
            this.txtKredi.TabIndex = 26;
            this.txtKredi.TextChanged += new System.EventHandler(this.txtKredi_TextChanged);
            // 
            // btnGuncelleHepsi
            // 
            this.btnGuncelleHepsi.Location = new System.Drawing.Point(732, 18);
            this.btnGuncelleHepsi.Name = "btnGuncelleHepsi";
            this.btnGuncelleHepsi.Size = new System.Drawing.Size(237, 28);
            this.btnGuncelleHepsi.TabIndex = 25;
            this.btnGuncelleHepsi.Text = "Kayıtlı Dersleri Güncelle";
            this.btnGuncelleHepsi.UseVisualStyleBackColor = true;
            this.btnGuncelleHepsi.Click += new System.EventHandler(this.btnGuncelleHepsi_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 119);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 20);
            this.label8.TabIndex = 24;
            this.label8.Text = "Ders Listesi";
            // 
            // cboDersListesi
            // 
            this.cboDersListesi.FormattingEnabled = true;
            this.cboDersListesi.Location = new System.Drawing.Point(16, 142);
            this.cboDersListesi.Name = "cboDersListesi";
            this.cboDersListesi.Size = new System.Drawing.Size(121, 28);
            this.cboDersListesi.TabIndex = 23;
            this.cboDersListesi.SelectedIndexChanged += new System.EventHandler(this.cboDersListesi_SelectedIndexChanged);
            // 
            // btnDersİptal
            // 
            this.btnDersİptal.Enabled = false;
            this.btnDersİptal.Location = new System.Drawing.Point(894, 143);
            this.btnDersİptal.Name = "btnDersİptal";
            this.btnDersİptal.Size = new System.Drawing.Size(75, 28);
            this.btnDersİptal.TabIndex = 22;
            this.btnDersİptal.Text = "İptal";
            this.btnDersİptal.UseVisualStyleBackColor = true;
            this.btnDersİptal.Click += new System.EventHandler(this.btnDersİptal_Click);
            // 
            // btnDersKaydet
            // 
            this.btnDersKaydet.Enabled = false;
            this.btnDersKaydet.Location = new System.Drawing.Point(732, 145);
            this.btnDersKaydet.Name = "btnDersKaydet";
            this.btnDersKaydet.Size = new System.Drawing.Size(75, 28);
            this.btnDersKaydet.TabIndex = 21;
            this.btnDersKaydet.Text = "Kaydet";
            this.btnDersKaydet.UseVisualStyleBackColor = true;
            this.btnDersKaydet.Click += new System.EventHandler(this.btnDersKaydet_Click);
            // 
            // btnDersSil
            // 
            this.btnDersSil.Location = new System.Drawing.Point(813, 145);
            this.btnDersSil.Name = "btnDersSil";
            this.btnDersSil.Size = new System.Drawing.Size(75, 28);
            this.btnDersSil.TabIndex = 20;
            this.btnDersSil.Text = "Sil";
            this.btnDersSil.UseVisualStyleBackColor = true;
            this.btnDersSil.Click += new System.EventHandler(this.btnDersSil_Click);
            // 
            // btnDersYeniEkle
            // 
            this.btnDersYeniEkle.Location = new System.Drawing.Point(637, 146);
            this.btnDersYeniEkle.Name = "btnDersYeniEkle";
            this.btnDersYeniEkle.Size = new System.Drawing.Size(89, 28);
            this.btnDersYeniEkle.TabIndex = 19;
            this.btnDersYeniEkle.Text = "Yeni Ekle";
            this.btnDersYeniEkle.UseVisualStyleBackColor = true;
            this.btnDersYeniEkle.Click += new System.EventHandler(this.btnDersYeniEkle_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(286, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Ders Adı";
            // 
            // txtDersAdi
            // 
            this.txtDersAdi.Location = new System.Drawing.Point(290, 146);
            this.txtDersAdi.Name = "txtDersAdi";
            this.txtDersAdi.Size = new System.Drawing.Size(202, 26);
            this.txtDersAdi.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(148, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Ders ID";
            // 
            // txtDersID
            // 
            this.txtDersID.Enabled = false;
            this.txtDersID.Location = new System.Drawing.Point(152, 144);
            this.txtDersID.Name = "txtDersID";
            this.txtDersID.Size = new System.Drawing.Size(121, 26);
            this.txtDersID.TabIndex = 15;
            this.txtDersID.TextChanged += new System.EventHandler(this.txtDersID_TextChanged);
            // 
            // btnDonemIptal
            // 
            this.btnDonemIptal.Location = new System.Drawing.Point(894, 55);
            this.btnDonemIptal.Name = "btnDonemIptal";
            this.btnDonemIptal.Size = new System.Drawing.Size(75, 28);
            this.btnDonemIptal.TabIndex = 12;
            this.btnDonemIptal.Text = "İptal";
            this.btnDonemIptal.UseVisualStyleBackColor = true;
            this.btnDonemIptal.Click += new System.EventHandler(this.btnDonemIptal_Click);
            // 
            // btnDonemKaydet
            // 
            this.btnDonemKaydet.Enabled = false;
            this.btnDonemKaydet.Location = new System.Drawing.Point(732, 57);
            this.btnDonemKaydet.Name = "btnDonemKaydet";
            this.btnDonemKaydet.Size = new System.Drawing.Size(75, 28);
            this.btnDonemKaydet.TabIndex = 11;
            this.btnDonemKaydet.Text = "Kaydet";
            this.btnDonemKaydet.UseVisualStyleBackColor = true;
            this.btnDonemKaydet.Click += new System.EventHandler(this.btnDonemKaydet_Click);
            // 
            // btnDonemSil
            // 
            this.btnDonemSil.Location = new System.Drawing.Point(813, 57);
            this.btnDonemSil.Name = "btnDonemSil";
            this.btnDonemSil.Size = new System.Drawing.Size(75, 28);
            this.btnDonemSil.TabIndex = 10;
            this.btnDonemSil.Text = "Sil";
            this.btnDonemSil.UseVisualStyleBackColor = true;
            this.btnDonemSil.Click += new System.EventHandler(this.btnDonemSil_Click);
            // 
            // btnDonemYeniEkle
            // 
            this.btnDonemYeniEkle.Location = new System.Drawing.Point(637, 58);
            this.btnDonemYeniEkle.Name = "btnDonemYeniEkle";
            this.btnDonemYeniEkle.Size = new System.Drawing.Size(89, 28);
            this.btnDonemYeniEkle.TabIndex = 9;
            this.btnDonemYeniEkle.Text = "Yeni Ekle";
            this.btnDonemYeniEkle.UseVisualStyleBackColor = true;
            this.btnDonemYeniEkle.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(404, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Dönem Adı";
            // 
            // txtDonemAdi
            // 
            this.txtDonemAdi.Location = new System.Drawing.Point(408, 58);
            this.txtDonemAdi.Name = "txtDonemAdi";
            this.txtDonemAdi.ShortcutsEnabled = false;
            this.txtDonemAdi.Size = new System.Drawing.Size(183, 26);
            this.txtDonemAdi.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(286, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Dönem ID";
            // 
            // txtDonemID
            // 
            this.txtDonemID.Enabled = false;
            this.txtDonemID.Location = new System.Drawing.Point(290, 56);
            this.txtDonemID.Name = "txtDonemID";
            this.txtDonemID.Size = new System.Drawing.Size(100, 26);
            this.txtDonemID.TabIndex = 4;
            this.txtDonemID.TextChanged += new System.EventHandler(this.txtDonemID_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(148, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Dönem";
            // 
            // cboDonem
            // 
            this.cboDonem.FormattingEnabled = true;
            this.cboDonem.Location = new System.Drawing.Point(152, 55);
            this.cboDonem.Name = "cboDonem";
            this.cboDonem.Size = new System.Drawing.Size(121, 28);
            this.cboDonem.TabIndex = 2;
            this.cboDonem.SelectedIndexChanged += new System.EventHandler(this.cboDonem_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sınıf Listesi";
            // 
            // cboSinifList
            // 
            this.cboSinifList.FormattingEnabled = true;
            this.cboSinifList.Location = new System.Drawing.Point(16, 56);
            this.cboSinifList.Name = "cboSinifList";
            this.cboSinifList.Size = new System.Drawing.Size(121, 28);
            this.cboSinifList.TabIndex = 0;
            this.cboSinifList.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.cboSinifList.Click += new System.EventHandler(this.cboSinifList_Click);
            // 
            // grvOgrPuan
            // 
            this.grvOgrPuan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvOgrPuan.Location = new System.Drawing.Point(12, 214);
            this.grvOgrPuan.Name = "grvOgrPuan";
            this.grvOgrPuan.Size = new System.Drawing.Size(969, 198);
            this.grvOgrPuan.TabIndex = 26;
            this.grvOgrPuan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.grvOgrPuan.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvOgrPuan_CellEndEdit);
            // 
            // txtOkulYil
            // 
            this.txtOkulYil.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.txtOkulYil.Location = new System.Drawing.Point(637, 19);
            this.txtOkulYil.Name = "txtOkulYil";
            this.txtOkulYil.Size = new System.Drawing.Size(89, 26);
            this.txtOkulYil.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(566, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 20);
            this.label7.TabIndex = 29;
            this.label7.Text = "Okul Yılı";
            // 
            // frmOgrenciSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 424);
            this.Controls.Add(this.grvOgrPuan);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmOgrenciSubject";
            this.Text = "frmOgrenciSubject";
            this.Load += new System.EventHandler(this.frmOgrenciSubject_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvOgrPuan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDonemKaydet;
        private System.Windows.Forms.Button btnDonemSil;
        private System.Windows.Forms.Button btnDonemYeniEkle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDonemAdi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDonemID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboDonem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboSinifList;
        private System.Windows.Forms.Button btnDersİptal;
        private System.Windows.Forms.Button btnDersKaydet;
        private System.Windows.Forms.Button btnDersSil;
        private System.Windows.Forms.Button btnDersYeniEkle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDersAdi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDersID;
        private System.Windows.Forms.Button btnDonemIptal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboDersListesi;
        private System.Windows.Forms.DataGridView grvOgrPuan;
        private System.Windows.Forms.Button btnGuncelleHepsi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtKredi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtOkulYil;
    }
}