namespace Pengungsian
{
    partial class FormTempat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTempat));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.txtAlamat = new System.Windows.Forms.RichTextBox();
            this.txtTelp = new System.Windows.Forms.TextBox();
            this.btmBatal = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btmSimpan = new System.Windows.Forms.Button();
            this.lblNo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Alamat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "No Hp";
            // 
            // txtNama
            // 
            this.txtNama.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNama.Location = new System.Drawing.Point(126, 72);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(253, 26);
            this.txtNama.TabIndex = 4;
            // 
            // txtAlamat
            // 
            this.txtAlamat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAlamat.Location = new System.Drawing.Point(126, 121);
            this.txtAlamat.Name = "txtAlamat";
            this.txtAlamat.Size = new System.Drawing.Size(253, 98);
            this.txtAlamat.TabIndex = 5;
            this.txtAlamat.Text = "";
            // 
            // txtTelp
            // 
            this.txtTelp.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelp.Location = new System.Drawing.Point(126, 240);
            this.txtTelp.Name = "txtTelp";
            this.txtTelp.Size = new System.Drawing.Size(130, 26);
            this.txtTelp.TabIndex = 6;
            // 
            // btmBatal
            // 
            this.btmBatal.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btmBatal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btmBatal.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmBatal.Image = global::Pengungsian.Properties.Resources._33;
            this.btmBatal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btmBatal.Location = new System.Drawing.Point(304, 301);
            this.btmBatal.Name = "btmBatal";
            this.btmBatal.Size = new System.Drawing.Size(75, 32);
            this.btmBatal.TabIndex = 8;
            this.btmBatal.Text = "    Batal";
            this.btmBatal.UseVisualStyleBackColor = false;
            this.btmBatal.Click += new System.EventHandler(this.btmBatal_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "No Tempat";
            // 
            // btmSimpan
            // 
            this.btmSimpan.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btmSimpan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btmSimpan.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmSimpan.Image = global::Pengungsian.Properties.Resources._22;
            this.btmSimpan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btmSimpan.Location = new System.Drawing.Point(203, 301);
            this.btmSimpan.Name = "btmSimpan";
            this.btmSimpan.Size = new System.Drawing.Size(95, 32);
            this.btmSimpan.TabIndex = 7;
            this.btmSimpan.Text = "    Simpan";
            this.btmSimpan.UseVisualStyleBackColor = false;
            this.btmSimpan.Click += new System.EventHandler(this.btmSimpan_Click);
            // 
            // lblNo
            // 
            this.lblNo.AutoSize = true;
            this.lblNo.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNo.Location = new System.Drawing.Point(122, 23);
            this.lblNo.Name = "lblNo";
            this.lblNo.Size = new System.Drawing.Size(49, 22);
            this.lblNo.TabIndex = 48;
            this.lblNo.Text = "Auto";
            // 
            // FormTempat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(407, 344);
            this.Controls.Add(this.lblNo);
            this.Controls.Add(this.label4);
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
            this.Name = "FormTempat";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tambah Tempat";
            this.Load += new System.EventHandler(this.FormTempat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.RichTextBox txtAlamat;
        private System.Windows.Forms.TextBox txtTelp;
        private System.Windows.Forms.Button btmSimpan;
        private System.Windows.Forms.Button btmBatal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblNo;
    }
}