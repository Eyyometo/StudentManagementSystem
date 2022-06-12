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
  
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void mnuProgramKapa_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmMain_PaddingChanged(object sender, EventArgs e)
        {

        }

        private void frmMain_Resize(object sender, EventArgs e)
        {
            int x, y;
            x = (ClientSize.Width - ResimOkul.Width) / 2;
            y = (ClientSize.Height - ResimOkul.Height) / 2;
            if (x < 0)
                x = 0;
            if (y < 0)
                y = 0;
            ResimOkul.Location = new Point(x, y);

        }

        private void mnuSinifveOgr_Click(object sender, EventArgs e)
        {
            frmSinifveOgr frm = new frmSinifveOgr();
            frm.ShowDialog();
        }

        private void mnuDonem_Click(object sender, EventArgs e)
        {
            frmOgrenciSubject frm = new frmOgrenciSubject();
            frm.ShowDialog();
        }
    }
}
