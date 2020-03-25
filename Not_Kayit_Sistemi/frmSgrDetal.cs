using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Not_Kayit_Sistemi
{
    public partial class frmSgrDetal : Form
    {
        public frmSgrDetal()
        {
            InitializeComponent();
        }


        Sql_elaqesi elaqe = new Sql_elaqesi();
        

        public string nomre;
        private void frmSgrDetal_Load(object sender, EventArgs e)
        {
            lblNomre.Text = nomre;

            SqlCommand command = new SqlCommand("Select * from TBLDERS Where SGRNOMRE = @p1", elaqe.Elaqe());
            command.Parameters.AddWithValue("@p1", nomre);
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                lblAdSoyad.Text = dr[2] + " " + dr[3];
                lblS1.Text = dr[4].ToString();
                lblS2.Text = dr[5].ToString();
                lblS3.Text = dr[6].ToString();
                lblOrtalama.Text = dr[7].ToString();
                if (dr[8].ToString()=="True")
                {
                    lblDurum.Text = "Kecib";
                }
                else
                {
                    lblDurum.Text = "Kesilib";
                }
            }
        }
    }
}
