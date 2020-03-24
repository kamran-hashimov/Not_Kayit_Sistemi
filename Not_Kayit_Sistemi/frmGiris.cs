using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Not_Kayit_Sistemi
{
    public partial class frmGiris : Form
    {
        public frmGiris()
        {
            InitializeComponent();
        }


        private void btnDaxilOl_Click(object sender, EventArgs e)
        {
            frmSgrDetal frm = new frmSgrDetal();
            frm.nomre = mskNomre.Text;
            frm.Show();
        }

        private void mskNomre_TextChanged(object sender, EventArgs e)
        {
            if (mskNomre.Text == "1111")
            {
                frmMuellimDetal frm = new frmMuellimDetal();
                frm.Show();
            }
        }
    }
}
