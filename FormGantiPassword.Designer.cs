namespace Pengungsian
{
    partial class FormGantiPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGantiPassword));
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btmBatal = new System.Windows.Forms.Button();
            this.btmGanti = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(83, 12);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(203, 26);
            this.txtPassword.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password";
            // 
            // btmBatal
            // 
            this.btmBatal.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btmBatal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btmBatal.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmBatal.Image = global::Pengungsian.Properties.Resources._33;
            this.btmBatal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btmBatal.Location = new System.Drawing.Point(206, 47);
            this.btmBatal.Name = "btmBatal";
            this.btmBatal.Size = new System.Drawing.Size(75, 28);
            this.btmBatal.TabIndex = 9;
            this.btmBatal.Text = "    Batal";
            this.btmBatal.UseVisualStyleBackColor = false;
            this.btmBatal.Click += new System.EventHandler(this.btmBatal_Click);
            // 
            // btmGanti
            // 
            this.btmGanti.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btmGanti.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btmGanti.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmGanti.Image = global::Pengungsian.Properties.Resources._72;
            this.btmGanti.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btmGanti.Location = new System.Drawing.Point(125, 47);
            this.btmGanti.Name = "btmGanti";
            this.btmGanti.Size = new System.Drawing.Size(75, 28);
            this.btmGanti.TabIndex = 8;
            this.btmGanti.Text = "    Ganti";
            this.btmGanti.UseVisualStyleBackColor = false;
            this.btmGanti.Click += new System.EventHandler(this.btmGanti_Click);
            // 
            // FormGantiPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 81);
            this.Controls.Add(this.btmBatal);
            this.Controls.Add(this.btmGanti);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormGantiPassword";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ganti Password";
            this.Load += new System.EventHandler(this.FormGantiPassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btmGanti;
        private System.Windows.Forms.Button btmBatal;
    }
}