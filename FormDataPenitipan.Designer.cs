﻿namespace Pengungsian
{
    partial class FormDataPenitipan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDataPenitipan));
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btmTambah = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnLihat = new System.Windows.Forms.Button();
            this.txtPencarian = new System.Windows.Forms.TextBox();
            this.lblJml = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHapus
            // 
            this.btnHapus.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnHapus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHapus.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHapus.Image = global::Pengungsian.Properties.Resources._33;
            this.btnHapus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHapus.Location = new System.Drawing.Point(201, 12);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(86, 34);
            this.btnHapus.TabIndex = 11;
            this.btnHapus.Text = "    Hapus";
            this.btnHapus.UseVisualStyleBackColor = false;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Image = global::Pengungsian.Properties.Resources._96;
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Location = new System.Drawing.Point(124, 12);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(71, 34);
            this.btnEdit.TabIndex = 10;
            this.btnEdit.Text = "   Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btmTambah
            // 
            this.btmTambah.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btmTambah.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btmTambah.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmTambah.Image = global::Pengungsian.Properties.Resources._95;
            this.btmTambah.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btmTambah.Location = new System.Drawing.Point(12, 12);
            this.btmTambah.Name = "btmTambah";
            this.btmTambah.Size = new System.Drawing.Size(106, 34);
            this.btmTambah.TabIndex = 9;
            this.btmTambah.Text = "    Tambah";
            this.btmTambah.UseVisualStyleBackColor = false;
            this.btmTambah.Click += new System.EventHandler(this.btmTambah_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(748, 370);
            this.dataGridView1.TabIndex = 12;
            // 
            // btnLihat
            // 
            this.btnLihat.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnLihat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLihat.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLihat.Image = global::Pengungsian.Properties.Resources._2;
            this.btnLihat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLihat.Location = new System.Drawing.Point(673, 12);
            this.btnLihat.Name = "btnLihat";
            this.btnLihat.Size = new System.Drawing.Size(86, 34);
            this.btnLihat.TabIndex = 13;
            this.btnLihat.Text = "    Lihat";
            this.btnLihat.UseVisualStyleBackColor = false;
            this.btnLihat.Click += new System.EventHandler(this.btnLihat_Click);
            // 
            // txtPencarian
            // 
            this.txtPencarian.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPencarian.Location = new System.Drawing.Point(410, 12);
            this.txtPencarian.Name = "txtPencarian";
            this.txtPencarian.Size = new System.Drawing.Size(257, 32);
            this.txtPencarian.TabIndex = 35;
            this.txtPencarian.TextChanged += new System.EventHandler(this.txtPencarian_TextChanged);
            // 
            // lblJml
            // 
            this.lblJml.AutoSize = true;
            this.lblJml.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJml.Location = new System.Drawing.Point(120, 438);
            this.lblJml.Name = "lblJml";
            this.lblJml.Size = new System.Drawing.Size(0, 19);
            this.lblJml.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 438);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 19);
            this.label3.TabIndex = 36;
            this.label3.Text = "Jumlah Penitipan :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = global::Pengungsian.Properties.Resources._65;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(369, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 21);
            this.label1.TabIndex = 38;
            this.label1.Text = "     ";
            // 
            // FormDataPenitipan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 466);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblJml);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPencarian);
            this.Controls.Add(this.btnLihat);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btmTambah);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormDataPenitipan";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data Penitipan Peliharaan";
            this.Load += new System.EventHandler(this.FormDataPenitipan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btmTambah;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnLihat;
        private System.Windows.Forms.TextBox txtPencarian;
        public System.Windows.Forms.Label lblJml;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}