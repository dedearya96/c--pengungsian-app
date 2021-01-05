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
    public partial class PenggunaanDanaLogistik : Form
    {
        int jumlah;
        private string sqlQuery;
        private SqlConnection conn;
        public PenggunaanDanaLogistik()
        {
            InitializeComponent();
            dbConnector db = new dbConnector();
            db.createConn();
            conn = db.masterConn;
        }

        private void btmTambah_Click(object sender, EventArgs e)
        {
            TambahPenggunaanLogistik fr = new TambahPenggunaanLogistik();
            fr.ShowDialog();
            showData();
            jumlah = dataGridView1.Rows.Count;
            lblJml.Text = (jumlah - 1).ToString();
            totalData();
        }

        private void totalData()
        {
            //Total Beras
            txttotalberas.Text = (from DataGridViewRow row in dataGridView1.Rows
                                  where row.Cells[2].FormattedValue.ToString() != string.Empty
                                  select Convert.ToInt32(row.Cells[2].FormattedValue)).Sum().ToString();
            //Total Mie
            txttotalmie.Text = (from DataGridViewRow row in dataGridView1.Rows
                                where row.Cells[3].FormattedValue.ToString() != string.Empty
                                select Convert.ToInt32(row.Cells[3].FormattedValue)).Sum().ToString();
            //Total Masker
            txttotalmasker.Text = (from DataGridViewRow row in dataGridView1.Rows
                                   where row.Cells[4].FormattedValue.ToString() != string.Empty
                                   select Convert.ToInt32(row.Cells[4].FormattedValue)).Sum().ToString();
            //Total Aqua
            txttotalaqua.Text = (from DataGridViewRow row in dataGridView1.Rows
                                 where row.Cells[5].FormattedValue.ToString() != string.Empty
                                 select Convert.ToInt32(row.Cells[5].FormattedValue)).Sum().ToString();
            //Total Nasi
            txttotalnasi.Text = (from DataGridViewRow row in dataGridView1.Rows
                                 where row.Cells[6].FormattedValue.ToString() != string.Empty
                                 select Convert.ToInt32(row.Cells[6].FormattedValue)).Sum().ToString();
            //Total Susu
            txttotalsusu.Text = (from DataGridViewRow row in dataGridView1.Rows
                                 where row.Cells[7].FormattedValue.ToString() != string.Empty
                                 select Convert.ToInt32(row.Cells[7].FormattedValue)).Sum().ToString();
            //Total Selimut
            txttotalselimut.Text = (from DataGridViewRow row in dataGridView1.Rows
                                    where row.Cells[8].FormattedValue.ToString() != string.Empty
                                    select Convert.ToInt32(row.Cells[8].FormattedValue)).Sum().ToString();
            //Total Roti
            txttotalroti.Text = (from DataGridViewRow row in dataGridView1.Rows
                                 where row.Cells[9].FormattedValue.ToString() != string.Empty
                                 select Convert.ToInt32(row.Cells[9].FormattedValue)).Sum().ToString();
        }

        private void PenggunaanDanaLogistik_Load(object sender, EventArgs e)
        {
            showData();
            jumlah = dataGridView1.Rows.Count;
            lblJml.Text = (jumlah - 1).ToString();
            totalData();
            
            
        }
        private void showData()
        {
            sqlQuery = "SELECT id as [No Penggunaan], " +
                "tanggal as [Tanggal], " +
                "beras as [Beras (kg)], " +
                "mie as [Mie (dus)], " +
                "masker as [Masker (kotak)], " +
                "aqua as [Aqua (dus)], " +
                "nasi as [Nasi Bungkus (bungkus)], " +
                "susu as [Susu (kotak)], " +
                "selimut as [Selimut (buah)], " +
                "roti as [Roti (bungkus)], " +
                "lain as [Lain] " +
                "FROM tb_penggunaan_logistik " +
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
            EditPenggunaanLogistik fr1 = new EditPenggunaanLogistik();
            fr1.lblNo.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            fr1.dtTgl.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            fr1.txtBeras.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            fr1.txtMie.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            fr1.txtMasker.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            fr1.txtAqua.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            fr1.txtNasi.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            fr1.txtSusu.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            fr1.txtSelimut.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            fr1.txtRoti.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            fr1.txtLain.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            fr1.ShowDialog();
            showData();
            totalData();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            SqlCommand delcmd = new SqlCommand();
            if (dataGridView1.Rows.Count > 1 && dataGridView1.SelectedRows[0].Index != dataGridView1.Rows.Count - 1)
            {
                if (MessageBox.Show("Apakah anda ingin menghapus data ini?", "Konfirmasi",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    delcmd.CommandText = "DELETE FROM tb_penggunaan_logistik WHERE id=" + dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + "";
                    conn.Open();
                    delcmd.Connection = conn;
                    delcmd.ExecuteNonQuery();
                    conn.Close();
                    dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
                    MessageBox.Show("Data yang dipilih Terhapus");
                    jumlah = dataGridView1.Rows.Count;
                    lblJml.Text = (jumlah - 1).ToString();
                    totalData();
                }  
            }
        }

        private void btnLihat_Click(object sender, EventArgs e)
        {
            MessageBox.Show("No\t\t: " + dataGridView1.CurrentRow.Cells[0].Value.ToString() +
              "\nTanggal\t\t: " + dataGridView1.CurrentRow.Cells[1].Value.ToString() +
               "\nBeras\t\t: " + dataGridView1.CurrentRow.Cells[2].Value.ToString() + " kg" +
                "\nMie\t\t: " + dataGridView1.CurrentRow.Cells[3].Value.ToString() + " dus" +
              "\nMasker\t\t: " + dataGridView1.CurrentRow.Cells[4].Value.ToString() + " kotak" +
            "\nAqua\t\t: " + dataGridView1.CurrentRow.Cells[5].Value.ToString() + " dus" +
             "\nNasi\t\t: " + dataGridView1.CurrentRow.Cells[6].Value.ToString() + " bungkus" +
              "\nSusu\t\t: " + dataGridView1.CurrentRow.Cells[7].Value.ToString() + " kotak" +
               "\nSelimut\t\t: " + dataGridView1.CurrentRow.Cells[8].Value.ToString() + " buah" +
             "\nRoti\t\t: " + dataGridView1.CurrentRow.Cells[9].Value.ToString() + " bungkus");
        }
    }
}
