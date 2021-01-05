namespace Pengungsian
{
    partial class FormDataTunai
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDataTunai));
            this.btmTambah = new System.Windows.Forms.Button();
            this.btmEdit = new System.Windows.Forms.Button();
            this.btmHapus = new System.Windows.Forms.Button();
            this.btnLihat = new System.Windows.Forms.Button();
            this.txtPencarian = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblJml = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btmTambah
            // 
            this.btmTambah.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btmTambah.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btmTambah.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmTambah.Image = global::Pengungsian.Properties.Resources._95;
            this.btmTambah.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btmTambah.Location = new System.Drawing.Point(19, 21);
            this.btmTambah.Name = "btmTambah";
            this.btmTambah.Size = new System.Drawing.Size(89, 33);
            this.btmTambah.TabIndex = 1;
            this.btmTambah.Text = "    Tambah";
            this.btmTambah.UseVisualStyleBackColor = false;
            this.btmTambah.Click += new System.EventHandler(this.btmTambah_Click);
            // 
            // btmEdit
            // 
            this.btmEdit.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btmEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btmEdit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmEdit.Image = global::Pengungsian.Properties.Resources._96;
            this.btmEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btmEdit.Location = new System.Drawing.Point(114, 21);
            this.btmEdit.Name = "btmEdit";
            this.btmEdit.Size = new System.Drawing.Size(75, 33);
            this.btmEdit.TabIndex = 2;
            this.btmEdit.Text = "    Edit";
            this.btmEdit.UseVisualStyleBackColor = false;
            this.btmEdit.Click += new System.EventHandler(this.btmEdit_Click);
            // 
            // btmHapus
            // 
            this.btmHapus.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btmHapus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btmHapus.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmHapus.Image = global::Pengungsian.Properties.Resources._33;
            this.btmHapus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btmHapus.Location = new System.Drawing.Point(195, 21);
            this.btmHapus.Name = "btmHapus";
            this.btmHapus.Size = new System.Drawing.Size(81, 33);
            this.btmHapus.TabIndex = 3;
            this.btmHapus.Text = "     Hapus";
            this.btmHapus.UseVisualStyleBackColor = false;
            this.btmHapus.Click += new System.EventHandler(this.btmHapus_Click);
            // 
            // btnLihat
            // 
            this.btnLihat.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnLihat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLihat.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLihat.Image = global::Pengungsian.Properties.Resources._2;
            this.btnLihat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLihat.Location = new System.Drawing.Point(627, 20);
            this.btnLihat.Name = "btnLihat";
            this.btnLihat.Size = new System.Drawing.Size(86, 34);
            this.btnLihat.TabIndex = 10;
            this.btnLihat.Text = "    Lihat";
            this.btnLihat.UseVisualStyleBackColor = false;
            this.btnLihat.Click += new System.EventHandler(this.btnLihat_Click);
            // 
            // txtPencarian
            // 
            this.txtPencarian.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPencarian.Location = new System.Drawing.Point(364, 22);
            this.txtPencarian.Name = "txtPencarian";
            this.txtPencarian.Size = new System.Drawing.Size(257, 32);
            this.txtPencarian.TabIndex = 32;
            this.txtPencarian.TextChanged += new System.EventHandler(this.txtPencarian_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(19, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(694, 370);
            this.dataGridView1.TabIndex = 33;
            // 
            // lblJml
            // 
            this.lblJml.AutoSize = true;
            this.lblJml.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJml.Location = new System.Drawing.Point(127, 447);
            this.lblJml.Name = "lblJml";
            this.lblJml.Size = new System.Drawing.Size(0, 19);
            this.lblJml.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 447);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 19);
            this.label3.TabIndex = 38;
            this.label3.Text = "Jumlah Bantuan :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = global::Pengungsian.Properties.Resources._65;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(323, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 21);
            this.label1.TabIndex = 40;
            this.label1.Text = "     ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(200, 447);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 19);
            this.label2.TabIndex = 41;
            this.label2.Text = "Total Bantuan Rp ";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(311, 447);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 19);
            this.lblTotal.TabIndex = 42;
            // 
            // FormDataTunai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 472);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblJml);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtPencarian);
            this.Controls.Add(this.btnLihat);
            this.Controls.Add(this.btmHapus);
            this.Controls.Add(this.btmEdit);
            this.Controls.Add(this.btmTambah);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormDataTunai";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data Bantuan Tunai";
            this.Load += new System.EventHandler(this.FormDataTunai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btmTambah;
        private System.Windows.Forms.Button btmEdit;
        private System.Windows.Forms.Button btmHapus;
        private System.Windows.Forms.Button btnLihat;
        private System.Windows.Forms.TextBox txtPencarian;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.Label lblJml;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotal;
    }
}