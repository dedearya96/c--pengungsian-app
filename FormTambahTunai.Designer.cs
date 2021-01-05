namespace Pengungsian
{
    partial class FormTambahTunai
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTambahTunai));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.txtTelp = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtJumlah = new System.Windows.Forms.TextBox();
            this.btmSimpan = new System.Windows.Forms.Button();
            this.btmBatal = new System.Windows.Forms.Button();
            this.txtAlamat = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtTgl = new System.Windows.Forms.DateTimePicker();
            this.lblNo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama Instansi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Alamat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telp/HP";
            // 
            // txtNama
            // 
            this.txtNama.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNama.Location = new System.Drawing.Point(145, 102);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(247, 25);
            this.txtNama.TabIndex = 4;
            // 
            // txtTelp
            // 
            this.txtTelp.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelp.Location = new System.Drawing.Point(145, 262);
            this.txtTelp.Name = "txtTelp";
            this.txtTelp.Size = new System.Drawing.Size(157, 25);
            this.txtTelp.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 308);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 19);
            this.label5.TabIndex = 7;
            this.label5.Text = "Jml Tunai";
            // 
            // txtJumlah
            // 
            this.txtJumlah.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJumlah.Location = new System.Drawing.Point(145, 307);
            this.txtJumlah.Name = "txtJumlah";
            this.txtJumlah.Size = new System.Drawing.Size(135, 25);
            this.txtJumlah.TabIndex = 8;
            // 
            // btmSimpan
            // 
            this.btmSimpan.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btmSimpan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btmSimpan.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmSimpan.Image = global::Pengungsian.Properties.Resources._22;
            this.btmSimpan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btmSimpan.Location = new System.Drawing.Point(286, 354);
            this.btmSimpan.Name = "btmSimpan";
            this.btmSimpan.Size = new System.Drawing.Size(101, 31);
            this.btmSimpan.TabIndex = 9;
            this.btmSimpan.Text = "    Simpan";
            this.btmSimpan.UseVisualStyleBackColor = false;
            this.btmSimpan.Click += new System.EventHandler(this.btmSimpan_Click);
            // 
            // btmBatal
            // 
            this.btmBatal.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btmBatal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btmBatal.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmBatal.Image = global::Pengungsian.Properties.Resources._33;
            this.btmBatal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btmBatal.Location = new System.Drawing.Point(393, 354);
            this.btmBatal.Name = "btmBatal";
            this.btmBatal.Size = new System.Drawing.Size(75, 31);
            this.btmBatal.TabIndex = 10;
            this.btmBatal.Text = "    Batal";
            this.btmBatal.UseVisualStyleBackColor = false;
            this.btmBatal.Click += new System.EventHandler(this.btmBatal_Click);
            // 
            // txtAlamat
            // 
            this.txtAlamat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAlamat.Location = new System.Drawing.Point(145, 143);
            this.txtAlamat.Name = "txtAlamat";
            this.txtAlamat.Size = new System.Drawing.Size(323, 104);
            this.txtAlamat.TabIndex = 11;
            this.txtAlamat.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 19);
            this.label1.TabIndex = 14;
            this.label1.Text = "No Bantuan";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(108, 308);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 19);
            this.label6.TabIndex = 16;
            this.label6.Text = "Rp.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(17, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 19);
            this.label8.TabIndex = 45;
            this.label8.Text = "Tanggal";
            // 
            // dtTgl
            // 
            this.dtTgl.CalendarFont = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtTgl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtTgl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtTgl.Location = new System.Drawing.Point(145, 61);
            this.dtTgl.Name = "dtTgl";
            this.dtTgl.Size = new System.Drawing.Size(164, 26);
            this.dtTgl.TabIndex = 44;
            // 
            // lblNo
            // 
            this.lblNo.AutoSize = true;
            this.lblNo.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNo.Location = new System.Drawing.Point(141, 21);
            this.lblNo.Name = "lblNo";
            this.lblNo.Size = new System.Drawing.Size(49, 22);
            this.lblNo.TabIndex = 48;
            this.lblNo.Text = "Auto";
            // 
            // FormTambahTunai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(490, 393);
            this.Controls.Add(this.lblNo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtTgl);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAlamat);
            this.Controls.Add(this.btmBatal);
            this.Controls.Add(this.btmSimpan);
            this.Controls.Add(this.txtJumlah);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTelp);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormTambahTunai";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tambah Bantuan Tunai";
            this.Load += new System.EventHandler(this.FormTambahTunai_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.TextBox txtTelp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtJumlah;
        private System.Windows.Forms.Button btmSimpan;
        private System.Windows.Forms.Button btmBatal;
        private System.Windows.Forms.RichTextBox txtAlamat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtTgl;
        private System.Windows.Forms.Label lblNo;
    }
}