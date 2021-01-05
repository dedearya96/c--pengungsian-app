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
    public partial class TambahPenggunaanTunai : Form
    {
        private string sqlQuery;//menampung query
        private SqlConnection conn;
        public TambahPenggunaanTunai()
        {
            InitializeComponent();
            dbConnector db = new dbConnector();
            db.createConn();
            conn = db.masterConn;
        }

        private void btmBatal_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btmSimpan_Click(object sender, EventArgs e)
        {
            sisaBantuanTunai();
            int jml = Convert.ToInt32(sisaBantuan.Text);
            int stok = jml;
            int input1 = Convert.ToInt32(txtHarga.Text);
            int input2 = Convert.ToInt32(txtBanyak.Text);
            int tInput = input1 * input2;
            if (dtTgl.Text == "")
            {
                MessageBox.Show("Tanggal belum diisi!");
                dtTgl.Focus();
            }
            else if (txtPembelian.Text == "")
            {
                MessageBox.Show("Pembelian belum diisi!");
                txtPembelian.Focus();
            }
            else if (txtHarga.Text == "")
            {
                MessageBox.Show("Harga belum diisi!");
                txtHarga.Focus();
            }
            else if (txtBanyak.Text == "")
            {
                MessageBox.Show("Banyak pembelian belum diisi!");
                txtBanyak.Focus();
            }
            else if (tInput > stok)
            {
                MessageBox.Show("Stock tunai tidak cukup!, Stok tunai :" + stok);
            }
            else
            {
                sqlQuery = "INSERT INTO tb_penggunaan_tunai VALUES " +
                   "('" + dtTgl.Text + "', '" + txtPembelian.Text + "', '" + txtHarga.Text + "', '" + txtBanyak.Text + "')";

                conn.Open();
                SqlCommand sqlCmd = new SqlCommand(sqlQuery, conn);
                sqlCmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Data Penggunaan Dana Tunai tersimpan!");
                this.Close();
            }
        }

        private void TambahPenggunaanTunai_Load(object sender, EventArgs e)
        {
            
        }
        //Bantuan Tunai
        private void jmlBantuanTunai()
        {
            sqlQuery = "SELECT sum(jumlah)FROM tb_tunai";
            conn.Open();
            SqlCommand sqlCmd = new SqlCommand(sqlQuery, conn);
            SqlDataReader dr = sqlCmd.ExecuteReader();
            if (dr.Read())
            {
                totalBantuan.Text = dr.GetValue(0).ToString();
            }
            conn.Close();
        }
        //Penggunaan Bantuan Tunai
        private void jmlPenggunaanTunai()
        {
            sqlQuery = "SELECT sum(harga*banyak)FROM tb_penggunaan_tunai";
            conn.Open();
            SqlCommand sqlCmd = new SqlCommand(sqlQuery, conn);
            SqlDataReader dr = sqlCmd.ExecuteReader();
            if (dr.Read())
            {
                totalBantuan2.Text = dr.GetValue(0).ToString();
            }
            conn.Close();
        }
        //Sisa Bantuan Tunai
        private void sisaBantuanTunai()
        {
            jmlBantuanTunai();
            jmlPenggunaanTunai();
            int sisabantuan, bantuan, bantuan2;
            bantuan = Convert.ToInt32(totalBantuan.Text);
            bantuan2 = Convert.ToInt32(totalBantuan2.Text);
            sisabantuan = bantuan - bantuan2;
            sisaBantuan.Text = sisabantuan.ToString();
        }
    }
}
