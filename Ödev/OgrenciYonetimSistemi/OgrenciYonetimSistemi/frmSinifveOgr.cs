using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OgrenciYonetimSistemi
{
    public partial class frmSinifveOgr : Form
    {
        OgrenciSkorDataContext dt = new OgrenciSkorDataContext();
        Boolean blnEkleYeniSinif;
        Boolean blnEkleOgrenci;
        public frmSinifveOgr()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmSinifveOgr_Load(object sender, EventArgs e)
        {
            cboSinif.DisplayMember = "İsim";
            cboSinif.ValueMember = "SinifID";
            cboSinif.DataSource = dt.tbSinifs.ToList();
            txtSinifID.DataBindings.Clear();
            txtSinifID.DataBindings.Add("Text", cboSinif.DataSource, "SinifID");
            txtSinifAdi.DataBindings.Clear();
            txtSinifAdi.DataBindings.Add("Text", cboSinif.DataSource, "İsim");

            btnKaydetSinif.Enabled = false;
            btnOgrKaydet.Enabled = false;
            btnOgrSil.Enabled = true;
        }

        private void cboSinif_SelectedIndexChanged(object sender, EventArgs e)
        {
            grvOgr.DataSource = dt.spOgrenciSecimSinifID(Convert.ToInt32(cboSinif.SelectedValue));
            if (grvOgr.DataSource !=null && grvOgr.Rows.Count != 0)
            {
                txtSinifID.DataBindings.Clear();
                txtSinifID.DataBindings.Add("Text", grvOgr.DataSource, "SinifID");
                txtOgrID.DataBindings.Clear();
                txtOgrID.DataBindings.Add("Text", grvOgr.DataSource, "OgrenciID");
                txtOgrAd.DataBindings.Clear();
                txtOgrAd.DataBindings.Add("Text", grvOgr.DataSource, "Adi");
                dtpOgrDob.DataBindings.Clear();
                dtpOgrDob.DataBindings.Add("Text", grvOgr.DataSource, "Dob");
                txtOgrPob.DataBindings.Clear();
                txtOgrPob.DataBindings.Add("Text", grvOgr.DataSource, "Pob");

                txtOgrCinsiyet.DataBindings.Clear();
                txtOgrCinsiyet.DataBindings.Add("Text", grvOgr.DataSource, "Cinsiyet");
                txtOgrUlke.DataBindings.Clear();
                txtOgrUlke.DataBindings.Add("Text", grvOgr.DataSource, "Race");


                txtSeciliResim.DataBindings.Clear();
                txtSeciliResim.DataBindings.Add("Text", grvOgr.DataSource, "Resim");
                resimOgr.DataBindings.Clear();
                resimOgr.Image = Image.FromFile(txtSeciliResim.Text);

            }

            else
            {
                txtOgrID.Text = "";
                txtOgrAd.Text = "";
                txtOgrPob.Text = "";
                txtOgrUlke.Text = "";
                txtOgrCinsiyet.Text = "";
                dtpOgrDob.Value = new DateTime(2000, 01, 30);
                txtSeciliResim.Text = "";
                resimOgr.Image = null;
            }
            btnKaydetSinif.Enabled = false;
        }

        private void btnFotoSec_Click(object sender, EventArgs e)
        {
            string strDosyaAdi = "";
            OpenFileDialog ofdResim = new OpenFileDialog();
            if(ofdResim.ShowDialog()==System.Windows.Forms.DialogResult.OK)
            {
                strDosyaAdi = ofdResim.FileName;
                txtSeciliResim.Text = strDosyaAdi;
                resimOgr.Image = new Bitmap(ofdResim.FileName);
            }
        }

        private void grvOgr_Click(object sender, EventArgs e)
        {
            btnOgrSil.Enabled = true;
            txtSeciliResim.DataBindings.Clear();
            txtSeciliResim.DataBindings.Add("Text", grvOgr.DataSource, "Resim");
            resimOgr.Image = Image.FromFile(txtSeciliResim.Text);
            btnOgrKaydet.Enabled = true;
        }

        private void btnYeniEkleSinif_Click(object sender, EventArgs e)
        {

            txtSinifID.Enabled = false;
            txtSinifID.Text = "";
            txtSinifAdi.Text = "";
            txtSinifAdi.Focus();
            blnEkleYeniSinif = true;
            btnKaydetSinif.Enabled = true;
            btnOgrKaydet.Enabled = false;
            btnOgrSil.Enabled = true;

        }

        private void btnKaydetSinif_Click(object sender, EventArgs e)
        {
            if (blnEkleYeniSinif)
            {
                try
                {
                    dt.spInsertSinif(txtSinifAdi.Text);
                    btnKaydetSinif.Enabled = false;
                    blnEkleYeniSinif = false;

                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                try
                {
                    dt.spUpdateSinif(Convert.ToInt32(txtSinifID.Text), txtSinifAdi.Text);

                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            frmSinifveOgr_Load(sender, e);
             
        }

        private void btnOgrYeniEkle_Click(object sender, EventArgs e)
        {
            blnEkleOgrenci = true;
            txtSeciliResim.Enabled = false;
            txtOgrID.Enabled = false;
            txtOgrAd.Text = "";
            dtpOgrDob.Text = "";
            txtOgrPob.Text = "";
            txtOgrCinsiyet.Text = "";
            txtOgrUlke.Text = "";
            txtOgrAd.Focus();

            btnKaydetSinif.Enabled = false;
            btnOgrKaydet.Enabled = true;
            btnOgrSil.Enabled = true;
        }

        private void btnOgrKaydet_Click(object sender, EventArgs e)
        {
            if (blnEkleOgrenci)
            {
                try
                {
                    dt.spInsertOgrenci(Convert.ToInt32(txtSinifID.Text), txtSeciliResim.Text, txtOgrAd.Text, dtpOgrDob.Value, txtOgrPob.Text, txtOgrCinsiyet.Text, txtOgrUlke.Text);
                    blnEkleYeniSinif = false;
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
               
            }
            else
            {
                try
                {
                    dt.spUpdateOgrenci(Convert.ToInt32(txtOgrID.Text), txtSeciliResim.Text, txtOgrAd.Text, dtpOgrDob.Value, txtOgrPob.Text, txtOgrCinsiyet.Text, txtOgrUlke.Text);

                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            cboSinif_SelectedIndexChanged(sender, e);

            
        }

        private void txtOgrAra_TextChanged(object sender, EventArgs e)
        {
            grvOgr.DataSource = dt.spSearchOgrenci(txtOgrAra.Text);

            txtSinifID.DataBindings.Clear();
            txtSinifID.DataBindings.Add("Text", grvOgr.DataSource, "SinifID");
            txtOgrAd.DataBindings.Clear();
            txtOgrAd.DataBindings.Add("Text", grvOgr.DataSource, "Adi");
            dtpOgrDob.DataBindings.Clear();
            dtpOgrDob.DataBindings.Add("Text", grvOgr.DataSource, "Dob");
            txtOgrPob.DataBindings.Clear();
            txtOgrPob.DataBindings.Add("Text", grvOgr.DataSource, "Pob");

            txtOgrCinsiyet.DataBindings.Clear();
            txtOgrCinsiyet.DataBindings.Add("Text", grvOgr.DataSource, "Cinsiyet");
            txtOgrUlke.DataBindings.Clear();
            txtOgrUlke.DataBindings.Add("Text", grvOgr.DataSource, "Race");


            txtSeciliResim.DataBindings.Clear();
            txtSeciliResim.DataBindings.Add("Text", grvOgr.DataSource, "Resim");
            resimOgr.DataBindings.Clear();
            resimOgr.Image = Image.FromFile(txtSeciliResim.Text);
            btnKaydetSinif.Enabled = true;

        }

        private void btnSilSinif_Click(object sender, EventArgs e)
        {
            try
            {
                dt.spDeleteSinif(Convert.ToInt32(txtSinifID.Text));

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            frmSinifveOgr_Load(sender, e);
        }

        private void btnOgrSil_Click(object sender, EventArgs e)
        {
            try
            {
                dt.spDeleteOgrenci(Convert.ToInt32(txtOgrID.Text));

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            cboSinif_SelectedIndexChanged(sender, e);
            //frmSinifveOgr_Load(sender, e);
        }

        private void btnOgrSil_Click_1(object sender, EventArgs e)
        {

        }
    }
}
