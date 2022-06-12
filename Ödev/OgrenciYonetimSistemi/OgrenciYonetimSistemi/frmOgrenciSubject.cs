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
    public partial class frmOgrenciSubject : Form
    {
        OgrenciSkorDataContext dt = new OgrenciSkorDataContext();
        Boolean blnEkleDonem = false;
        Boolean blnEkleDers = false;
        public frmOgrenciSubject()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtDonemID.Text = "";
            txtDonemAdi.Text = "";
            txtDonemAdi.Focus();
            btnDonemYeniEkle.Enabled = true;
            blnEkleDonem = true;
            
            btnDonemYeniEkle.Enabled = false;
            btnDonemIptal.Enabled = true;
        }

        private void frmOgrenciSubject_Load(object sender, EventArgs e)
        {
            
            cboSinifList.DisplayMember = "İsim";
            cboSinifList.ValueMember = "SinifID";
            cboSinifList.DataSource = dt.spSinifSelectAll();

            cboDonem.DisplayMember = "Name";
            cboDonem.ValueMember = "YariYilID";
            cboDonem.DataSource = dt.spDonemSelectAll();

            txtDonemID.DataBindings.Clear();
            txtDonemID.DataBindings.Add("Text", cboDonem.DataSource, "YariYilID");
            txtDonemAdi.DataBindings.Clear();
            txtDonemAdi.DataBindings.Add("Text", cboDonem.DataSource, "Name");

            cboDersListesi.DisplayMember = "Adi";
            cboDersListesi.ValueMember = "SubjectID";
            cboDersListesi.DataSource = dt.spDerslerSelectAll();

           

            btnDonemIptal.Enabled = false;
            btnDersİptal.Enabled = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboDers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnDonemKaydet_Click(object sender, EventArgs e)
        {
            if (blnEkleDonem)
            {
                try
                {
                    dt.spInsertYariYil(txtDonemAdi.Text);
                   btnDonemKaydet.Enabled = false;
                    blnEkleDonem = false;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                try
                {
                    dt.spUpdateYariYil(Convert.ToInt32(txtDonemID.Text), txtDonemAdi.Text);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            btnDonemYeniEkle.Enabled=true;
            frmOgrenciSubject_Load(sender, e);
        }

        private void btnDonemSil_Click(object sender, EventArgs e)
        {
            try
            {
                dt.spDeleteYariYil(Convert.ToInt32(txtDonemID.Text));

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           frmOgrenciSubject_Load(sender, e);
        }

        private void btnDonemIptal_Click(object sender, EventArgs e)
        {
            txtDonemID.Text = "";
            txtDonemAdi.Text = "";
            btnDonemYeniEkle.Enabled = true;
            btnDonemIptal.Enabled = false;
        }

        private void btnDersYeniEkle_Click(object sender, EventArgs e)
        {
            txtDersID.Text = "";
            txtDersAdi.Text = "";
            
            txtKredi.Text = "";
            txtDersAdi.Focus();
            btnDersYeniEkle.Enabled = false;
            btnDersKaydet.Enabled = true;
            blnEkleDers = true;
            
        }

        private void btnDersKaydet_Click(object sender, EventArgs e)
        {
            if (blnEkleDers)
            {
                try
                {
                    dt.spInsertSubject(txtDersAdi.Text,Convert.ToInt32(txtKredi.Text));
                    btnDersKaydet.Enabled = false;
                    blnEkleDers= false;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                try
                {
                    dt.spUpdateSubject(Convert.ToInt32(txtDersID.Text), txtDersAdi.Text, Convert.ToInt32(txtKredi.Text));

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            btnDersYeniEkle.Enabled = true;
            frmOgrenciSubject_Load(sender, e);
        }

        private void btnDersSil_Click(object sender, EventArgs e)
        {
            try
            {
                dt.spDeleteSubject(Convert.ToInt32(txtDersID.Text));

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            frmOgrenciSubject_Load(sender, e);
        }

        private void btnDersİptal_Click(object sender, EventArgs e)
        {
            txtDersID.Text = "";
            txtDersID.Text = "";
            txtKredi.Text="";
            txtDersAdi.Focus();
            btnDersYeniEkle.Enabled = true;
            btnDersİptal.Enabled = false;
        }

        private void txtDonemID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtKredi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDersID_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboDersListesi_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnDersKaydet.Enabled = true;
            btnDersİptal.Enabled = true;
            /*
            txtDersID.DataBindings.Clear();
            txtDersID.DataBindings.Add("Text", cboDersListesi.DataSource, "SubjectID");
            txtDersAdi.DataBindings.Clear();
            txtDersAdi.DataBindings.Add("Text", cboDersListesi.DataSource, "Adi");
            txtKredi.DataBindings.Clear();
            txtKredi.DataBindings.Add("Text", cboDersListesi.DataSource, "Kredi");
            txtKredi.Text = "";
            */

            grvOgrPuan.DataSource = dt.spGosterOgrPuan(Convert.ToInt32(cboSinifList.SelectedValue), Convert.ToInt32(cboDersListesi.SelectedValue), Convert.ToInt32(cboDonem.SelectedValue));
        }

        private void cboDonem_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnDonemKaydet.Enabled = true;
           cboDersListesi_SelectedIndexChanged(sender, e);
        }

        private void btnGuncelleHepsi_Click(object sender, EventArgs e)
        {
            foreach(var ogrenci in dt.spOgrenciSecimSinifID(Convert.ToInt32(cboSinifList.SelectedValue)))
            {
                if(dt.spSearchOgrPuan(ogrenci.OgrenciID, Convert.ToInt32(cboDersListesi.SelectedValue), Convert.ToInt32(cboDonem.SelectedValue)).Count() == 0)
                {
                   try
                    {
                        if(string.IsNullOrWhiteSpace(txtOkulYil.Text))
                        {
                            txtOkulYil.Focus();
                            break;
                        }
                        else
                        {
                            dt.spInsertOgrPuan(ogrenci.OgrenciID, Convert.ToInt32(cboSinifList.SelectedValue), Convert.ToInt32(cboDersListesi.SelectedValue), txtOkulYil.Text);
                            cboDersListesi_SelectedIndexChanged(sender, e);
                        }


                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void cboSinifList_Click(object sender, EventArgs e)
        {
            cboDersListesi_SelectedIndexChanged(sender, e);
        }

        private void grvOgrPuan_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int r = grvOgrPuan.CurrentCell.RowIndex;
            if(!string.IsNullOrEmpty(grvOgrPuan.Rows[r].Cells["Puan"].Value.ToString()))
            {
                try
                {
                    dt.spUpdateOgrPuan(Convert.ToInt32(grvOgrPuan.Rows[r].Cells["OgrenciID"].Value),
                                       Convert.ToInt32(grvOgrPuan.Rows[r].Cells["SubjectID"].Value),
                                       Convert.ToInt32(grvOgrPuan.Rows[r].Cells["YariYilID"].Value),
                                       Convert.ToDouble(grvOgrPuan.Rows[r].Cells["Puan"].Value));
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
