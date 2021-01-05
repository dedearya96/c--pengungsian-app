namespace Pengungsian
{
    partial class FormTambahRelawan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTambahRelawan));
            this.btmBatal = new System.Windows.Forms.Button();
            this.btmSimpan = new System.Windows.Forms.Button();
            this.txtTelp = new System.Windows.Forms.TextBox();
            this.txtAlamat = new System.Windows.Forms.RichTextBox();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbTempat = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbJenis = new System.Windows.Forms.ComboBox();
            this.lblNo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btmBatal
            // 
            this.btmBatal.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btmBatal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btmBatal.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmBatal.Image = global::Pengungsian.Properties.Resources._33;
            this.btmBatal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btmBatal.Location = new System.Drawing.Point(419, 388);
            this.btmBatal.Name = "btmBatal";
            this.btmBatal.Size = new System.Drawing.Size(75, 30);
            this.btmBatal.TabIndex = 17;
            this.btmBatal.Text = "    Batal";
            this.btmBatal.UseVisualStyleBackColor = false;
            this.btmBatal.Click += new System.EventHandler(this.btmBatal_Click);
            // 
            // btmSimpan
            // 
            this.btmSimpan.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btmSimpan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btmSimpan.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmSimpan.Image = global::Pengungsian.Properties.Resources._22;
            this.btmSimpan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btmSimpan.Location = new System.Drawing.Point(319, 388);
            this.btmSimpan.Name = "btmSimpan";
            this.btmSimpan.Size = new System.Drawing.Size(94, 30);
            this.btmSimpan.TabIndex = 16;
            this.btmSimpan.Text = "    Simpan";
            this.btmSimpan.UseVisualStyleBackColor = false;
            this.btmSimpan.Click += new System.EventHandler(this.btmSimpan_Click);
            // 
            // txtTelp
            // 
            this.txtTelp.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelp.Location = new System.Drawing.Point(125, 283);
            this.txtTelp.Name = "txtTelp";
            this.txtTelp.Size = new System.Drawing.Size(122, 26);
            this.txtTelp.TabIndex = 15;
            // 
            // txtAlamat
            // 
            this.txtAlamat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAlamat.Location = new System.Drawing.Point(125, 157);
            this.txtAlamat.Name = "txtAlamat";
            this.txtAlamat.Size = new System.Drawing.Size(369, 96);
            this.txtAlamat.TabIndex = 14;
            this.txtAlamat.Text = "";
            // 
            // txtNama
            // 
            this.txtNama.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNama.Location = new System.Drawing.Point(125, 59);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(369, 26);
            this.txtNama.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 19);
            this.label3.TabIndex = 11;
            this.label3.Text = "No Hp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "Alamat";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nama";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 340);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 19);
            this.label6.TabIndex = 20;
            this.label6.Text = "Tempat";
            // 
            // cmbTempat
            // 
            this.cmbTempat.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cmbTempat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTempat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTempat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTempat.Location = new System.Drawing.Point(125, 337);
            this.cmbTempat.Name = "cmbTempat";
            this.cmbTempat.Size = new System.Drawing.Size(218, 27);
            this.cmbTempat.TabIndex = 36;
            this.cmbTempat.SelectedIndexChanged += new System.EventHandler(this.cmbTempat_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(17, 114);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 19);
            this.label9.TabIndex = 32;
            this.label9.Text = "Jenis Kelamin";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 19);
            this.label4.TabIndex = 37;
            this.label4.Text = "No Relawan";
            // 
            // cmbJenis
            // 
            this.cmbJenis.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cmbJenis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbJenis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbJenis.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbJenis.FormattingEnabled = true;
            this.cmbJenis.Items.AddRange(new object[] {
            "Laki-Laki",
            "Prempuan"});
            this.cmbJenis.Location = new System.Drawing.Point(125, 111);
            this.cmbJenis.Name = "cmbJenis";
            this.cmbJenis.Size = new System.Drawing.Size(129, 27);
            this.cmbJenis.TabIndex = 43;
            // 
            // lblNo
            // 
            this.lblNo.AutoSize = true;
            this.lblNo.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNo.Location = new System.Drawing.Point(121, 19);
            this.lblNo.Name = "lblNo";
            this.lblNo.Size = new System.Drawing.Size(49, 22);
            this.lblNo.TabIndex = 44;
            this.lblNo.Text = "Auto";
            // 
            // FormTambahRelawan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(523, 430);
            this.Controls.Add(this.lblNo);
            this.Controls.Add(this.cmbJenis);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbTempat);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btmBatal);
            this.Controls.Add(this.btmSimpan);
            this.Controls.Add(this.txtTelp);
            this.Controls.Add(this.txtAlamat);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormTambahRelawan";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Tambah Relawan";
            this.Load += new System.EventHandler(this.FormTambahRelawan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btmBatal;
        private System.Windows.Forms.Button btmSimpan;
        private System.Windows.Forms.TextBox txtTelp;
        private System.Windows.Forms.RichTextBox txtAlamat;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbTempat;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbJenis;
        private System.Windows.Forms.Label lblNo;
    }
}