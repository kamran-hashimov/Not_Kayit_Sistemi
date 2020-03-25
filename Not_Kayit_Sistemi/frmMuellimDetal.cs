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
    public partial class frmMuellimDetal : Form
    {
        public frmMuellimDetal()
        {
            InitializeComponent();
        }

        Sql_elaqesi elaqe = new Sql_elaqesi();

        int kecen = 0, qalan = 0;

        private void frmMuellimDetal_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbNotKayitDataSet2.TBLDERS' table. You can move, or remove it, as needed.
            this.tBLDERSTableAdapter.Fill(this.dbNotKayitDataSet2.TBLDERS);
            // TODO: This line of code loads data into the 'dbNotKayitDataSet1.TBLDERS' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'dbNotKayitDataSet.TBLDERS' table. You can move, or remove it, as needed.
            SqlCommand command = new SqlCommand("select VEZIYYET from TBLDERS", elaqe.Elaqe());
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                if (dr[0].ToString()=="True")
                {
                    kecen++;
                    lblKecenler.Text = kecen.ToString();
                }
                else
                {
                    qalan++;
                    lblQalanlar.Text = qalan.ToString();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("insert into TBLDERS (SGRNOMRE , SGRAD, SGRSOYAD) values (@p1,@p2,@p3)",elaqe.Elaqe());
            command.Parameters.AddWithValue("@p1", mskNomre.Text);
            command.Parameters.AddWithValue("@p2", txtAd.Text);
            command.Parameters.AddWithValue("@p3", txtSoyad.Text);
            command.ExecuteNonQuery();
            elaqe.Elaqe().Close();
            MessageBox.Show("Elave olundu","Informasiya", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

      

        private void btnYenile_Click(object sender, EventArgs e)
        {
            double ortalama, s1, s2, s3;
            string durum;
            s1 = Convert.ToDouble(txtS1.Text);
            s2 = Convert.ToDouble(txtS2.Text);
            s3 = Convert.ToDouble(txtS3.Text);
            ortalama = (s1 + s2 + s3) / 3;
            lblOrtalama.Text = ortalama.ToString();

            if (ortalama>=50)
            {
                durum = "True";
                kecen++;
                qalan--;
                lblKecenler.Text = kecen.ToString();
                lblQalanlar.Text = qalan.ToString();
            }
            else
            {
                durum = "False";
                kecen--;
                qalan++;
                lblKecenler.Text = kecen.ToString();
                lblQalanlar.Text = qalan.ToString();
            }


            SqlCommand command = new SqlCommand("update TBLDERS set SGRS1 = @p1,SGRS2 = @p2 , SGRS3 = @p3, ORTALAMA = @p4, VEZIYYET = @p5 where SGRNOMRE = @p6 ", elaqe.Elaqe());
            command.Parameters.AddWithValue("@p1", txtS1.Text);
            command.Parameters.AddWithValue("@p2", txtS2.Text);
            command.Parameters.AddWithValue("@p3", txtS3.Text);
            command.Parameters.AddWithValue("@p4", decimal.Parse(lblOrtalama.Text));
            command.Parameters.AddWithValue("@p5", durum);
            command.Parameters.AddWithValue("@p6", mskNomre.Text);
            command.ExecuteNonQuery();
            elaqe.Elaqe().Close();
            MessageBox.Show("Sagird yenilendi");
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            mskNomre.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtAd.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtSoyad.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtS1.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtS2.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtS3.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
        }
    }
}
