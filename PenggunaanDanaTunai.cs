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
    public partial class PenggunaanDanaTunai : Form
    {
        int jumlah;
        private string sqlQuery;
        private SqlConnection conn;
        public PenggunaanDanaTunai()
        {
            InitializeComponent();
            dbConnector db = new dbConnector();
            db.createConn();
            conn = db.masterConn;
        }

        private void btmTambah_Click(object sender, EventArgs e)
        {
            TambahPenggunaanTunai fr = new TambahPenggunaanTunai();
            fr.ShowDialog();
            showData();
            jmlPenggunaan();
        }

        private void jmlPenggunaan()
        {
            jumlah = dataGridView1.Rows.Count;
            lblJml.Text = (jumlah - 1).ToString();
        }

        private void PenggunaanDanaTunai_Load(object sender, EventArgs e)
        {
            showData();
            jmlPenggunaan();
        }
        private void showData()
        {
            sqlQuery = "SELECT id as [No Penggunaan], " +
                "tanggal as [Tanggal Penggunaan], " +
                "pembelian as [Pembelian], " +
                "harga as [Harga], " +
                "banyak as [Banyak], " +
                "harga*banyak as [Total(RP)] " +
                "FROM tb_penggunaan_tunai " +
                "ORDER BY id desc ";

            conn.Open();
            SqlDataAdapter SDA = new SqlDataAdapter(sqlQuery, conn);
            SqlCommandBuilder SCB = new SqlCommandBuilder(SDA);
            DataTable datatable = new DataTable();
            SDA.Fill(datatable);
            dataGridView1.DataSource = datatable;
            conn.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditPenggunaanTunai fr1 = new EditPenggunaanTunai();
            fr1.lblNo.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            fr1.dtTgl.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            fr1.txtPembelian.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            fr1.txtHarga.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            fr1.txtBanyak.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            fr1.ShowDialog();
            showData();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            SqlCommand delcmd = new SqlCommand();
            if (dataGridView1.Rows.Count > 1 && dataGridView1.SelectedRows[0].Index != dataGridView1.Rows.Count - 1)
            {
                if (MessageBox.Show("Apakah anda ingin menghapus data ini?", "Konfirmasi",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    delcmd.CommandText = "DELETE FROM tb_penggunaan_tunai WHERE id=" + dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + "";
                    conn.Open();
                    delcmd.Connection = conn;
                    delcmd.ExecuteNonQuery();
                    conn.Close();
                    dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
                    MessageBox.Show("Data yang dipilih Terhapus");
                    jmlPenggunaan();
                }
            }
        }

        private void btnLihat_Click(object sender, EventArgs e)
        {
            MessageBox.Show("No\t\t: " + dataGridView1.CurrentRow.Cells[0].Value.ToString() +
             "\nTanggal\t\t: " + dataGridView1.CurrentRow.Cells[1].Value.ToString() +
             "\nPembelian\t: " + dataGridView1.CurrentRow.Cells[2].Value.ToString() +
              "\nHarga\t\t: " + dataGridView1.CurrentRow.Cells[3].Value.ToString() +
               "\nBanyak\t\t: " + dataGridView1.CurrentRow.Cells[4].Value.ToString() +
            "\nTotal\t\t: " + dataGridView1.CurrentRow.Cells[5].Value.ToString());
        }
    }
}
