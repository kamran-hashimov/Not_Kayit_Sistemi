namespace Not_Kayit_Sistemi
{
    partial class frmGiris
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
            this.label1 = new System.Windows.Forms.Label();
            this.mskNomre = new System.Windows.Forms.MaskedTextBox();
            this.btnDaxilOl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Şagird Nömrəsi:";
            // 
            // mskNomre
            // 
            this.mskNomre.Location = new System.Drawing.Point(154, 36);
            this.mskNomre.Mask = "0000";
            this.mskNomre.Name = "mskNomre";
            this.mskNomre.Size = new System.Drawing.Size(118, 23);
            this.mskNomre.TabIndex = 1;
            this.mskNomre.ValidatingType = typeof(int);
            this.mskNomre.TextChanged += new System.EventHandler(this.mskNomre_TextChanged);
            // 
            // btnDaxilOl
            // 
            this.btnDaxilOl.Location = new System.Drawing.Point(154, 83);
            this.btnDaxilOl.Name = "btnDaxilOl";
            this.btnDaxilOl.Size = new System.Drawing.Size(118, 23);
            this.btnDaxilOl.TabIndex = 2;
            this.btnDaxilOl.Text = "Daxil ol";
            this.btnDaxilOl.UseVisualStyleBackColor = true;
            this.btnDaxilOl.Click += new System.EventHandler(this.btnDaxilOl_Click);
            // 
            // frmGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(390, 121);
            this.Controls.Add(this.btnDaxilOl);
            this.Controls.Add(this.mskNomre);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mskNomre;
        private System.Windows.Forms.Button btnDaxilOl;
    }
}

