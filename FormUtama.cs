using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Pengungsian
{
    public partial class FormUtama : Form
    {
        public FormUtama()
        {
            InitializeComponent();
            this.Closing += new
            System.ComponentModel.CancelEventHandler(this.FormClosingEventCancle_Closing);
        }
        private void FormClosingEventCancle_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Apakah anda ingin keluar dari aplikasi ini?", "Konfirmasi",
                MessageBoxButtons.YesNo);
            if (dr == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
                
            }
        }

        private void menuKeluar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah anda ingin keluar dari aplikasi ini?", "Konfirmasi",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void menuDataPengungsi_Click(object sender, EventArgs e)
        {
            FormDataPengungsi fr = new FormDataPengungsi();
            fr.ShowDialog();
        }

        private void menuDataTempat_Click(object sender, EventArgs e)
        {
            FormDataTempat fr = new FormDataTempat();
            fr.ShowDialog();
        }

        private void menuLogistik_Click(object sender, EventArgs e)
        {
            FormDataLogistik fr = new FormDataLogistik();
            fr.ShowDialog();
        }

        private void menuTunai_Click(object sender, EventArgs e)
        {
            FormDataTunai fr = new FormDataTunai();
            fr.ShowDialog();
        }

        private void menuGanti_Click(object sender, EventArgs e)
        {
            FormGantiPassword fr = new FormGantiPassword();
            fr.ShowDialog();
        }

        private void menuPenitipan_Click(object sender, EventArgs e)
        {
            FormDataPenitipan fr = new FormDataPenitipan();
            fr.ShowDialog();
        }

        private void menuTempat_Click(object sender, EventArgs e)
        {
            FormDataRelawan fr = new FormDataRelawan();
            fr.ShowDialog();
        }

        private void FormUtama_Load(object sender, EventArgs e)
        {
          
            
        }

        private void toolDataPengungsi_Click(object sender, EventArgs e)
        {
            FormDataPengungsi fr = new FormDataPengungsi();
            fr.ShowDialog();
        }

        private void toolDataTempat_Click(object sender, EventArgs e)
        {
            FormDataTempat fr = new FormDataTempat();
            fr.ShowDialog();
        }

        private void toolDataPenitipan_Click(object sender, EventArgs e)
        {
            FormDataPenitipan fr = new FormDataPenitipan();
            fr.ShowDialog();
        }

        private void toolDataRelawan_Click(object sender, EventArgs e)
        {

            FormDataRelawan fr = new FormDataRelawan();
            fr.ShowDialog();
        }

        private void toolGantiPass_Click(object sender, EventArgs e)
        {

            FormGantiPassword fr = new FormGantiPassword();
            fr.ShowDialog();
        }

        private void toolDataLogistik_Click(object sender, EventArgs e)
        {
            FormDataLogistik fr = new FormDataLogistik();
            fr.ShowDialog();
        }

        private void toolKeluar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah anda ingin keluar dari aplikasi ini?","Konfirmasi",
                MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    Application.Exit();
                }
        }

        private void toolDataTunai_Click(object sender, EventArgs e)
        {
            FormDataTunai fr = new FormDataTunai();
            fr.ShowDialog();
        }

        private void menuLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah anda yakin keluar dari admin?", "Konfirmasi",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
                FormLogin fr = new FormLogin();
                fr.Show();
            }
        }

        private void toolLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah anda yakin keluar dari admin?", "Konfirmasi",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
                FormLogin fr = new FormLogin();
                fr.Show();
            }
        }

        private void menuPenggunaanLogistik_Click(object sender, EventArgs e)
        {
            PenggunaanDanaLogistik fr = new PenggunaanDanaLogistik();
            fr.ShowDialog();
        }

        private void menuPenggunaanTunai_Click(object sender, EventArgs e)
        {
            PenggunaanDanaTunai fr = new PenggunaanDanaTunai();
            fr.ShowDialog();
        }

        private void toolPenggunaanDanaLogistik_Click(object sender, EventArgs e)
        {
            PenggunaanDanaLogistik fr = new PenggunaanDanaLogistik();
            fr.ShowDialog();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            PenggunaanDanaTunai fr = new PenggunaanDanaTunai();
            fr.ShowDialog();
        }

        private void laporanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Laporan fr = new Laporan();
            fr.ShowDialog();
        }

        private void menuGanti_Click_1(object sender, EventArgs e)
        {
            FormGantiPassword fr = new FormGantiPassword();
            fr.ShowDialog();
        }

        private void toolLaporan_Click(object sender, EventArgs e)
        {
            Laporan fr = new Laporan();
            fr.ShowDialog();
        }

        private void toolGanti_Click(object sender, EventArgs e)
        {
            FormGantiPassword fr = new FormGantiPassword();
            fr.ShowDialog();
        }
    }
}
