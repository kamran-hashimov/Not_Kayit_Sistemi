namespace Not_Kayit_Sistemi
{
    partial class frmMuellimDetal
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mskNomre = new System.Windows.Forms.MaskedTextBox();
            this.btnQeydEt = new System.Windows.Forms.Button();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnYenile = new System.Windows.Forms.Button();
            this.txtS3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtS2 = new System.Windows.Forms.TextBox();
            this.txtS1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblQalanlar = new System.Windows.Forms.Label();
            this.lblKecenler = new System.Windows.Forms.Label();
            this.lblOrtalama = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sGRİDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sGRNOMREDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sGRADDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sGRSOYADDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sGRS1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sGRS2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sGRS3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oRTALAMADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vEZIYYETDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tBLDERSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbNotKayitDataSet2 = new Not_Kayit_Sistemi.DbNotKayitDataSet2();
            this.tBLDERSTableAdapter = new Not_Kayit_Sistemi.DbNotKayitDataSet2TableAdapters.TBLDERSTableAdapter();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLDERSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbNotKayitDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mskNomre);
            this.groupBox1.Controls.Add(this.btnQeydEt);
            this.groupBox1.Controls.Add(this.txtSoyad);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtAd);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(5, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(211, 152);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Şagird əlavə et";
            // 
            // mskNomre
            // 
            this.mskNomre.Location = new System.Drawing.Point(64, 27);
            this.mskNomre.Mask = "0000";
            this.mskNomre.Name = "mskNomre";
            this.mskNomre.Size = new System.Drawing.Size(115, 23);
            this.mskNomre.TabIndex = 7;
            this.mskNomre.ValidatingType = typeof(int);
            // 
            // btnQeydEt
            // 
            this.btnQeydEt.Location = new System.Drawing.Point(64, 116);
            this.btnQeydEt.Name = "btnQeydEt";
            this.btnQeydEt.Size = new System.Drawing.Size(115, 28);
            this.btnQeydEt.TabIndex = 6;
            this.btnQeydEt.Text = "Qeyd et";
            this.btnQeydEt.UseVisualStyleBackColor = true;
            this.btnQeydEt.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(64, 87);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(115, 23);
            this.txtSoyad.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Soyad:";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(64, 58);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(115, 23);
            this.txtAd.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nömrə:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnYenile);
            this.groupBox2.Controls.Add(this.txtS3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtS2);
            this.groupBox2.Controls.Add(this.txtS1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(227, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(211, 152);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sınaq nəticələri";
            // 
            // btnYenile
            // 
            this.btnYenile.Location = new System.Drawing.Point(70, 116);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(115, 28);
            this.btnYenile.TabIndex = 6;
            this.btnYenile.Text = "Yenilə";
            this.btnYenile.UseVisualStyleBackColor = true;
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
            // 
            // txtS3
            // 
            this.txtS3.Location = new System.Drawing.Point(70, 87);
            this.txtS3.Name = "txtS3";
            this.txtS3.Size = new System.Drawing.Size(115, 23);
            this.txtS3.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Sınaq 3:";
            // 
            // txtS2
            // 
            this.txtS2.Location = new System.Drawing.Point(70, 58);
            this.txtS2.Name = "txtS2";
            this.txtS2.Size = new System.Drawing.Size(115, 23);
            this.txtS2.TabIndex = 3;
            // 
            // txtS1
            // 
            this.txtS1.Location = new System.Drawing.Point(70, 27);
            this.txtS1.Name = "txtS1";
            this.txtS1.Size = new System.Drawing.Size(115, 23);
            this.txtS1.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Sınaq 2:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Sınaq 1:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblQalanlar);
            this.groupBox3.Controls.Add(this.lblKecenler);
            this.groupBox3.Controls.Add(this.lblOrtalama);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(444, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(211, 152);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sınaq nəticələri";
            // 
            // lblQalanlar
            // 
            this.lblQalanlar.AutoSize = true;
            this.lblQalanlar.Location = new System.Drawing.Point(122, 101);
            this.lblQalanlar.Name = "lblQalanlar";
            this.lblQalanlar.Size = new System.Drawing.Size(21, 15);
            this.lblQalanlar.TabIndex = 7;
            this.lblQalanlar.Text = "00";
            // 
            // lblKecenler
            // 
            this.lblKecenler.AutoSize = true;
            this.lblKecenler.Location = new System.Drawing.Point(122, 72);
            this.lblKecenler.Name = "lblKecenler";
            this.lblKecenler.Size = new System.Drawing.Size(21, 15);
            this.lblKecenler.TabIndex = 6;
            this.lblKecenler.Text = "00";
            // 
            // lblOrtalama
            // 
            this.lblOrtalama.AutoSize = true;
            this.lblOrtalama.Location = new System.Drawing.Point(122, 41);
            this.lblOrtalama.Name = "lblOrtalama";
            this.lblOrtalama.Size = new System.Drawing.Size(21, 15);
            this.lblOrtalama.TabIndex = 5;
            this.lblOrtalama.Text = "00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 15);
            this.label7.TabIndex = 4;
            this.label7.Text = "Qalan sayı:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 15);
            this.label8.TabIndex = 1;
            this.label8.Text = "Keçən sayı:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(44, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 15);
            this.label9.TabIndex = 0;
            this.label9.Text = "Ortalama:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox4.Location = new System.Drawing.Point(0, 174);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(658, 155);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Şagird siyahısı";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sGRİDDataGridViewTextBoxColumn,
            this.sGRNOMREDataGridViewTextBoxColumn,
            this.sGRADDataGridViewTextBoxColumn,
            this.sGRSOYADDataGridViewTextBoxColumn,
            this.sGRS1DataGridViewTextBoxColumn,
            this.sGRS2DataGridViewTextBoxColumn,
            this.sGRS3DataGridViewTextBoxColumn,
            this.oRTALAMADataGridViewTextBoxColumn,
            this.vEZIYYETDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.tBLDERSBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(652, 133);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // sGRİDDataGridViewTextBoxColumn
            // 
            this.sGRİDDataGridViewTextBoxColumn.DataPropertyName = "SGRİD";
            this.sGRİDDataGridViewTextBoxColumn.HeaderText = "SGRİD";
            this.sGRİDDataGridViewTextBoxColumn.Name = "sGRİDDataGridViewTextBoxColumn";
            this.sGRİDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sGRNOMREDataGridViewTextBoxColumn
            // 
            this.sGRNOMREDataGridViewTextBoxColumn.DataPropertyName = "SGRNOMRE";
            this.sGRNOMREDataGridViewTextBoxColumn.HeaderText = "SGRNOMRE";
            this.sGRNOMREDataGridViewTextBoxColumn.Name = "sGRNOMREDataGridViewTextBoxColumn";
            // 
            // sGRADDataGridViewTextBoxColumn
            // 
            this.sGRADDataGridViewTextBoxColumn.DataPropertyName = "SGRAD";
            this.sGRADDataGridViewTextBoxColumn.HeaderText = "SGRAD";
            this.sGRADDataGridViewTextBoxColumn.Name = "sGRADDataGridViewTextBoxColumn";
            // 
            // sGRSOYADDataGridViewTextBoxColumn
            // 
            this.sGRSOYADDataGridViewTextBoxColumn.DataPropertyName = "SGRSOYAD";
            this.sGRSOYADDataGridViewTextBoxColumn.HeaderText = "SGRSOYAD";
            this.sGRSOYADDataGridViewTextBoxColumn.Name = "sGRSOYADDataGridViewTextBoxColumn";
            // 
            // sGRS1DataGridViewTextBoxColumn
            // 
            this.sGRS1DataGridViewTextBoxColumn.DataPropertyName = "SGRS1";
            this.sGRS1DataGridViewTextBoxColumn.HeaderText = "SGRS1";
            this.sGRS1DataGridViewTextBoxColumn.Name = "sGRS1DataGridViewTextBoxColumn";
            // 
            // sGRS2DataGridViewTextBoxColumn
            // 
            this.sGRS2DataGridViewTextBoxColumn.DataPropertyName = "SGRS2";
            this.sGRS2DataGridViewTextBoxColumn.HeaderText = "SGRS2";
            this.sGRS2DataGridViewTextBoxColumn.Name = "sGRS2DataGridViewTextBoxColumn";
            // 
            // sGRS3DataGridViewTextBoxColumn
            // 
            this.sGRS3DataGridViewTextBoxColumn.DataPropertyName = "SGRS3";
            this.sGRS3DataGridViewTextBoxColumn.HeaderText = "SGRS3";
            this.sGRS3DataGridViewTextBoxColumn.Name = "sGRS3DataGridViewTextBoxColumn";
            // 
            // oRTALAMADataGridViewTextBoxColumn
            // 
            this.oRTALAMADataGridViewTextBoxColumn.DataPropertyName = "ORTALAMA";
            this.oRTALAMADataGridViewTextBoxColumn.HeaderText = "ORTALAMA";
            this.oRTALAMADataGridViewTextBoxColumn.Name = "oRTALAMADataGridViewTextBoxColumn";
            // 
            // vEZIYYETDataGridViewCheckBoxColumn
            // 
            this.vEZIYYETDataGridViewCheckBoxColumn.DataPropertyName = "VEZIYYET";
            this.vEZIYYETDataGridViewCheckBoxColumn.HeaderText = "VEZIYYET";
            this.vEZIYYETDataGridViewCheckBoxColumn.Name = "vEZIYYETDataGridViewCheckBoxColumn";
            // 
            // tBLDERSBindingSource
            // 
            this.tBLDERSBindingSource.DataMember = "TBLDERS";
            this.tBLDERSBindingSource.DataSource = this.dbNotKayitDataSet2;
            // 
            // dbNotKayitDataSet2
            // 
            this.dbNotKayitDataSet2.DataSetName = "DbNotKayitDataSet2";
            this.dbNotKayitDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBLDERSTableAdapter
            // 
            this.tBLDERSTableAdapter.ClearBeforeFill = true;
            // 
            // frmMuellimDetal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(658, 329);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmMuellimDetal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMuellimDetal";
            this.Load += new System.EventHandler(this.frmMuellimDetal_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLDERSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbNotKayitDataSet2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnQeydEt;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnYenile;
        private System.Windows.Forms.TextBox txtS3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtS2;
        private System.Windows.Forms.TextBox txtS1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblQalanlar;
        private System.Windows.Forms.Label lblKecenler;
        private System.Windows.Forms.Label lblOrtalama;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.MaskedTextBox mskNomre;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DbNotKayitDataSet2 dbNotKayitDataSet2;
        private System.Windows.Forms.BindingSource tBLDERSBindingSource;
        private DbNotKayitDataSet2TableAdapters.TBLDERSTableAdapter tBLDERSTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sGRİDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sGRNOMREDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sGRADDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sGRSOYADDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sGRS1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sGRS2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sGRS3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oRTALAMADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn vEZIYYETDataGridViewCheckBoxColumn;
    }
}