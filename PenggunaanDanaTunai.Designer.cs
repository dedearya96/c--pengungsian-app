namespace Pengungsian
{
    partial class PenggunaanDanaTunai
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PenggunaanDanaTunai));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btmTambah = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnLihat = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblJml = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(653, 304);
            this.dataGridView1.TabIndex = 13;
            // 
            // btmTambah
            // 
            this.btmTambah.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btmTambah.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btmTambah.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmTambah.Image = global::Pengungsian.Properties.Resources._95;
            this.btmTambah.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btmTambah.Location = new System.Drawing.Point(12, 31);
            this.btmTambah.Name = "btmTambah";
            this.btmTambah.Size = new System.Drawing.Size(100, 34);
            this.btmTambah.TabIndex = 14;
            this.btmTambah.Text = "    Tambah";
            this.btmTambah.UseVisualStyleBackColor = false;
            this.btmTambah.Click += new System.EventHandler(this.btmTambah_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Image = global::Pengungsian.Properties.Resources._96;
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Location = new System.Drawing.Point(118, 31);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(86, 34);
            this.btnEdit.TabIndex = 15;
            this.btnEdit.Text = "  Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnHapus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHapus.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHapus.Image = global::Pengungsian.Properties.Resources._33;
            this.btnHapus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHapus.Location = new System.Drawing.Point(210, 31);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(86, 34);
            this.btnHapus.TabIndex = 16;
            this.btnHapus.Text = "    Hapus";
            this.btnHapus.UseVisualStyleBackColor = false;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnLihat
            // 
            this.btnLihat.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnLihat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLihat.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLihat.Image = global::Pengungsian.Properties.Resources._2;
            this.btnLihat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLihat.Location = new System.Drawing.Point(578, 31);
            this.btnLihat.Name = "btnLihat";
            this.btnLihat.Size = new System.Drawing.Size(86, 34);
            this.btnLihat.TabIndex = 17;
            this.btnLihat.Text = "    Lihat";
            this.btnLihat.UseVisualStyleBackColor = false;
            this.btnLihat.Click += new System.EventHandler(this.btnLihat_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 387);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 19);
            this.label3.TabIndex = 35;
            this.label3.Text = "Jumlah Penggunaan :";
            // 
            // lblJml
            // 
            this.lblJml.AutoSize = true;
            this.lblJml.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJml.Location = new System.Drawing.Point(151, 387);
            this.lblJml.Name = "lblJml";
            this.lblJml.Size = new System.Drawing.Size(0, 19);
            this.lblJml.TabIndex = 36;
            // 
            // PenggunaanDanaTunai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 415);
            this.Controls.Add(this.lblJml);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnLihat);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btmTambah);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PenggunaanDanaTunai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Penggunaan Dana Tunai";
            this.Load += new System.EventHandler(this.PenggunaanDanaTunai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btmTambah;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnHapus;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnLihat;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label lblJml;
    }
}