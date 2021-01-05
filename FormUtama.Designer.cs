namespace Pengungsian
{
    partial class FormUtama
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUtama));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuKeluar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMasterData = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDataPengungsi = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDataTempat = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuPenitipan = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRelawan = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBantuan = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLogistik = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTunai = new System.Windows.Forms.ToolStripMenuItem();
            this.penggunaanDanaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPenggunaanLogistik = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPenggunaanTunai = new System.Windows.Forms.ToolStripMenuItem();
            this.laporanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.toolDataPengungsi = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.toolDataTempat = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolDataPenitipan = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolDataRelawan = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.toolDataLogistik = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolDataTunai = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator12 = new System.Windows.Forms.ToolStripSeparator();
            this.toolPenggunaanDanaLogistik = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator13 = new System.Windows.Forms.ToolStripSeparator();
            this.toolLaporan = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.toolKeluar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolGanti = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(0);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuMasterData,
            this.menuBantuan,
            this.penggunaanDanaToolStripMenuItem,
            this.laporanToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(979, 31);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuKeluar});
            this.menuFile.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(49, 25);
            this.menuFile.Text = "File";
            // 
            // menuKeluar
            // 
            this.menuKeluar.Image = global::Pengungsian.Properties.Resources.sign_emergency_code_sos_61_icon_icons_com_57216_copy;
            this.menuKeluar.Name = "menuKeluar";
            this.menuKeluar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.menuKeluar.Size = new System.Drawing.Size(191, 26);
            this.menuKeluar.Text = "Keluar";
            this.menuKeluar.Click += new System.EventHandler(this.menuKeluar_Click);
            // 
            // menuMasterData
            // 
            this.menuMasterData.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuDataPengungsi,
            this.menuDataTempat,
            this.toolStripSeparator2,
            this.menuPenitipan,
            this.menuRelawan});
            this.menuMasterData.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuMasterData.Name = "menuMasterData";
            this.menuMasterData.Size = new System.Drawing.Size(115, 25);
            this.menuMasterData.Text = "Pengungsian";
            // 
            // menuDataPengungsi
            // 
            this.menuDataPengungsi.Image = global::Pengungsian.Properties.Resources.boy_icon_icons_com_55048_copy;
            this.menuDataPengungsi.Name = "menuDataPengungsi";
            this.menuDataPengungsi.ShowShortcutKeys = false;
            this.menuDataPengungsi.Size = new System.Drawing.Size(273, 26);
            this.menuDataPengungsi.Text = "Data Pengungsi";
            this.menuDataPengungsi.Click += new System.EventHandler(this.menuDataPengungsi_Click);
            // 
            // menuDataTempat
            // 
            this.menuDataTempat.Image = global::Pengungsian.Properties.Resources._5858ee4a150ba030400ab329_1482291023_copy;
            this.menuDataTempat.Name = "menuDataTempat";
            this.menuDataTempat.Size = new System.Drawing.Size(273, 26);
            this.menuDataTempat.Text = "Data Tempat Pengungsian";
            this.menuDataTempat.Click += new System.EventHandler(this.menuDataTempat_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(270, 6);
            // 
            // menuPenitipan
            // 
            this.menuPenitipan.Image = global::Pengungsian.Properties.Resources.red_pets_icon_icons_com_59525_copy;
            this.menuPenitipan.Name = "menuPenitipan";
            this.menuPenitipan.Size = new System.Drawing.Size(273, 26);
            this.menuPenitipan.Text = "Data Penitipan Peliharaan";
            this.menuPenitipan.Click += new System.EventHandler(this.menuPenitipan_Click);
            // 
            // menuRelawan
            // 
            this.menuRelawan.Image = global::Pengungsian.Properties.Resources.logo_copy;
            this.menuRelawan.Name = "menuRelawan";
            this.menuRelawan.Size = new System.Drawing.Size(273, 26);
            this.menuRelawan.Text = "Data Relawan";
            this.menuRelawan.Click += new System.EventHandler(this.menuTempat_Click);
            // 
            // menuBantuan
            // 
            this.menuBantuan.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuLogistik,
            this.menuTunai});
            this.menuBantuan.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuBantuan.Name = "menuBantuan";
            this.menuBantuan.Size = new System.Drawing.Size(125, 25);
            this.menuBantuan.Text = "Dana Bantuan";
            // 
            // menuLogistik
            // 
            this.menuLogistik.Image = global::Pengungsian.Properties.Resources.unnamed_copy;
            this.menuLogistik.Name = "menuLogistik";
            this.menuLogistik.Size = new System.Drawing.Size(183, 26);
            this.menuLogistik.Text = "Dana Logistik";
            this.menuLogistik.Click += new System.EventHandler(this.menuLogistik_Click);
            // 
            // menuTunai
            // 
            this.menuTunai.Image = global::Pengungsian.Properties.Resources.flat_vector_money_icon_dollar_long_shadow_isolated_white_background_399394831;
            this.menuTunai.Name = "menuTunai";
            this.menuTunai.Size = new System.Drawing.Size(183, 26);
            this.menuTunai.Text = "Dana Tunai";
            this.menuTunai.Click += new System.EventHandler(this.menuTunai_Click);
            // 
            // penggunaanDanaToolStripMenuItem
            // 
            this.penggunaanDanaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuPenggunaanLogistik,
            this.menuPenggunaanTunai});
            this.penggunaanDanaToolStripMenuItem.Name = "penggunaanDanaToolStripMenuItem";
            this.penggunaanDanaToolStripMenuItem.Size = new System.Drawing.Size(154, 25);
            this.penggunaanDanaToolStripMenuItem.Text = "Penggunaan Dana";
            // 
            // menuPenggunaanLogistik
            // 
            this.menuPenggunaanLogistik.Image = global::Pengungsian.Properties.Resources.unnamed_copy;
            this.menuPenggunaanLogistik.Name = "menuPenggunaanLogistik";
            this.menuPenggunaanLogistik.Size = new System.Drawing.Size(183, 26);
            this.menuPenggunaanLogistik.Text = "Dana Logistik";
            this.menuPenggunaanLogistik.Click += new System.EventHandler(this.menuPenggunaanLogistik_Click);
            // 
            // menuPenggunaanTunai
            // 
            this.menuPenggunaanTunai.Image = global::Pengungsian.Properties.Resources.flat_vector_money_icon_dollar_long_shadow_isolated_white_background_399394831;
            this.menuPenggunaanTunai.Name = "menuPenggunaanTunai";
            this.menuPenggunaanTunai.Size = new System.Drawing.Size(183, 26);
            this.menuPenggunaanTunai.Text = "Dana Tunai";
            this.menuPenggunaanTunai.Click += new System.EventHandler(this.menuPenggunaanTunai_Click);
            // 
            // laporanToolStripMenuItem
            // 
            this.laporanToolStripMenuItem.Name = "laporanToolStripMenuItem";
            this.laporanToolStripMenuItem.Size = new System.Drawing.Size(84, 25);
            this.laporanToolStripMenuItem.Text = "Laporan";
            this.laporanToolStripMenuItem.Click += new System.EventHandler(this.laporanToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.toolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStrip1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.GripMargin = new System.Windows.Forms.Padding(24, 2, 2, 2);
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator10,
            this.toolDataPengungsi,
            this.toolStripSeparator8,
            this.toolDataTempat,
            this.toolStripSeparator7,
            this.toolDataPenitipan,
            this.toolStripSeparator6,
            this.toolDataRelawan,
            this.toolStripSeparator,
            this.toolDataLogistik,
            this.toolStripSeparator3,
            this.toolDataTunai,
            this.toolStripSeparator5});
            this.toolStrip1.Location = new System.Drawing.Point(0, 31);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(979, 26);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(6, 26);
            // 
            // toolDataPengungsi
            // 
            this.toolDataPengungsi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolDataPengungsi.Image = global::Pengungsian.Properties.Resources.boy_icon_icons_com_55048_copy;
            this.toolDataPengungsi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolDataPengungsi.Name = "toolDataPengungsi";
            this.toolDataPengungsi.Size = new System.Drawing.Size(122, 23);
            this.toolDataPengungsi.Text = "Data Pengungsi";
            this.toolDataPengungsi.Click += new System.EventHandler(this.toolDataPengungsi_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 26);
            // 
            // toolDataTempat
            // 
            this.toolDataTempat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolDataTempat.Image = global::Pengungsian.Properties.Resources._5858ee4a150ba030400ab329_1482291023_copy;
            this.toolDataTempat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolDataTempat.Name = "toolDataTempat";
            this.toolDataTempat.Size = new System.Drawing.Size(185, 23);
            this.toolDataTempat.Text = "Data Tempat Pengungsian";
            this.toolDataTempat.Click += new System.EventHandler(this.toolDataTempat_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 26);
            // 
            // toolDataPenitipan
            // 
            this.toolDataPenitipan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolDataPenitipan.Image = global::Pengungsian.Properties.Resources.red_pets_icon_icons_com_59525_copy;
            this.toolDataPenitipan.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolDataPenitipan.Name = "toolDataPenitipan";
            this.toolDataPenitipan.Size = new System.Drawing.Size(117, 23);
            this.toolDataPenitipan.Text = "Data Penitipan";
            this.toolDataPenitipan.Click += new System.EventHandler(this.toolDataPenitipan_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 26);
            // 
            // toolDataRelawan
            // 
            this.toolDataRelawan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolDataRelawan.Image = global::Pengungsian.Properties.Resources.logo_copy;
            this.toolDataRelawan.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolDataRelawan.Name = "toolDataRelawan";
            this.toolDataRelawan.Size = new System.Drawing.Size(114, 23);
            this.toolDataRelawan.Text = "Data Relawan";
            this.toolDataRelawan.Click += new System.EventHandler(this.toolDataRelawan_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 26);
            // 
            // toolDataLogistik
            // 
            this.toolDataLogistik.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolDataLogistik.Image = global::Pengungsian.Properties.Resources.unnamed;
            this.toolDataLogistik.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolDataLogistik.Name = "toolDataLogistik";
            this.toolDataLogistik.Size = new System.Drawing.Size(110, 23);
            this.toolDataLogistik.Text = "Data Logistik";
            this.toolDataLogistik.Click += new System.EventHandler(this.toolDataLogistik_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 26);
            // 
            // toolDataTunai
            // 
            this.toolDataTunai.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolDataTunai.Image = global::Pengungsian.Properties.Resources.flat_vector_money_icon_dollar_long_shadow_isolated_white_background_399394831;
            this.toolDataTunai.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolDataTunai.Name = "toolDataTunai";
            this.toolDataTunai.Size = new System.Drawing.Size(94, 23);
            this.toolDataTunai.Text = "Data Tunai";
            this.toolDataTunai.Click += new System.EventHandler(this.toolDataTunai_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 26);
            // 
            // toolStrip2
            // 
            this.toolStrip2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.toolStrip2.GripMargin = new System.Windows.Forms.Padding(24, 2, 2, 2);
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator12,
            this.toolPenggunaanDanaLogistik,
            this.toolStripSeparator1,
            this.toolStripButton1,
            this.toolStripSeparator13,
            this.toolLaporan,
            this.toolStripSeparator9,
            this.toolGanti,
            this.toolStripSeparator11,
            this.toolKeluar,
            this.toolStripSeparator4});
            this.toolStrip2.Location = new System.Drawing.Point(0, 57);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(979, 26);
            this.toolStrip2.TabIndex = 2;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripSeparator12
            // 
            this.toolStripSeparator12.Name = "toolStripSeparator12";
            this.toolStripSeparator12.Size = new System.Drawing.Size(6, 26);
            // 
            // toolPenggunaanDanaLogistik
            // 
            this.toolPenggunaanDanaLogistik.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolPenggunaanDanaLogistik.Image = global::Pengungsian.Properties.Resources.unnamed_copy;
            this.toolPenggunaanDanaLogistik.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolPenggunaanDanaLogistik.Name = "toolPenggunaanDanaLogistik";
            this.toolPenggunaanDanaLogistik.Size = new System.Drawing.Size(189, 23);
            this.toolPenggunaanDanaLogistik.Text = "Penggunaan Dana Logistik";
            this.toolPenggunaanDanaLogistik.Click += new System.EventHandler(this.toolPenggunaanDanaLogistik_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 26);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton1.Image = global::Pengungsian.Properties.Resources.flat_vector_money_icon_dollar_long_shadow_isolated_white_background_399394831;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(173, 23);
            this.toolStripButton1.Text = "Penggunaan Dana Tunai";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator13
            // 
            this.toolStripSeparator13.Name = "toolStripSeparator13";
            this.toolStripSeparator13.Size = new System.Drawing.Size(6, 26);
            // 
            // toolLaporan
            // 
            this.toolLaporan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolLaporan.Image = global::Pengungsian.Properties.Resources._63;
            this.toolLaporan.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolLaporan.Name = "toolLaporan";
            this.toolLaporan.Size = new System.Drawing.Size(80, 23);
            this.toolLaporan.Text = "Laporan";
            this.toolLaporan.Click += new System.EventHandler(this.toolLaporan_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(6, 26);
            // 
            // toolKeluar
            // 
            this.toolKeluar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolKeluar.Image = global::Pengungsian.Properties.Resources.sign_emergency_code_sos_61_icon_icons_com_57216_copy;
            this.toolKeluar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolKeluar.Name = "toolKeluar";
            this.toolKeluar.Size = new System.Drawing.Size(70, 23);
            this.toolKeluar.Text = "Keluar";
            this.toolKeluar.Click += new System.EventHandler(this.toolKeluar_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 26);
            // 
            // toolGanti
            // 
            this.toolGanti.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolGanti.Image = global::Pengungsian.Properties.Resources._72;
            this.toolGanti.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolGanti.Name = "toolGanti";
            this.toolGanti.Size = new System.Drawing.Size(125, 23);
            this.toolGanti.Text = "Ganti Password";
            this.toolGanti.Click += new System.EventHandler(this.toolGanti_Click);
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            this.toolStripSeparator11.Size = new System.Drawing.Size(6, 26);
            // 
            // FormUtama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(979, 449);
            this.ControlBox = false;
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormUtama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SISTEM INFORMASI PENDATAAN PENGUNGSI BENCANA ERUPSI GUNUNG AGUNG KABUPATEN KARANG" +
                "ASEM";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormUtama_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuKeluar;
        private System.Windows.Forms.ToolStripMenuItem menuMasterData;
        private System.Windows.Forms.ToolStripMenuItem menuDataPengungsi;
        private System.Windows.Forms.ToolStripMenuItem menuDataTempat;
        private System.Windows.Forms.ToolStripMenuItem menuBantuan;
        private System.Windows.Forms.ToolStripMenuItem menuLogistik;
        private System.Windows.Forms.ToolStripMenuItem menuTunai;
        private System.Windows.Forms.ToolStripMenuItem menuPenitipan;
        private System.Windows.Forms.ToolStripMenuItem menuRelawan;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolDataPengungsi;
        private System.Windows.Forms.ToolStripButton toolDataTempat;
        private System.Windows.Forms.ToolStripButton toolDataRelawan;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton toolDataPenitipan;
        private System.Windows.Forms.ToolStripButton toolDataLogistik;
        private System.Windows.Forms.ToolStripButton toolDataTunai;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator12;
        private System.Windows.Forms.ToolStripButton toolKeluar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator13;
        private System.Windows.Forms.ToolStripMenuItem penggunaanDanaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuPenggunaanLogistik;
        private System.Windows.Forms.ToolStripMenuItem menuPenggunaanTunai;
        private System.Windows.Forms.ToolStripButton toolPenggunaanDanaLogistik;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripMenuItem laporanToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolLaporan;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton toolGanti;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
    }
}

