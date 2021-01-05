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
    public partial class TambahPenggunaanLogistik : Form
    {
        private string sqlQuery;//menampung query
        private SqlConnection conn;
        public TambahPenggunaanLogistik()
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
            //beras
            stockberas();
            int jmlberas = Convert.ToInt32(stokberas.Text);
            int beras = jmlberas;
            int inputberas = Convert.ToInt32(txtBeras.Text);
            //
            if (dtTgl.Text == "")
            {
                MessageBox.Show("Tanggal penggunaan belum diisi!");
                dtTgl.Focus();
            }
            else if (inputberas > beras)
            {
                MessageBox.Show("Stock beras tidak cukup!, Stok beras :"  + beras);
            }
            else
            {
                sqlQuery = "INSERT INTO tb_penggunaan_logistik VALUES " +
                   "('" + dtTgl.Text + "', '" + txtBeras.Text + "', '" + txtMie.Text + "', '" + txtMasker.Text + "', '" + txtAqua.Text + "', '" + txtNasi.Text + "', '" + txtSusu.Text + "', '" + txtSelimut.Text + "', '" + txtRoti.Text + "', '" + txtLain.Text + "')";

                conn.Open();
                SqlCommand sqlCmd = new SqlCommand(sqlQuery, conn);
                sqlCmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Penggunaan Dana Logistik tersimpan!");
                this.Close();
            }
        }
        //cek sumbangan beras
                    private void beras()
                    {
                        sqlQuery = "SELECT sum(beras)FROM tb_logistik";
                        conn.Open();
                        SqlCommand sqlCmd = new SqlCommand(sqlQuery, conn);
                        SqlDataReader dr = sqlCmd.ExecuteReader();
                        if (dr.Read())
                        {
                            jumlahberas.Text = dr.GetValue(0).ToString();
                        }
                        conn.Close();
                    }
       
                    private void beras2()
                    {
                        sqlQuery = "SELECT sum(beras)FROM tb_penggunaan_logistik";
                        conn.Open();
                        SqlCommand sqlCmd = new SqlCommand(sqlQuery, conn);
                        SqlDataReader dr = sqlCmd.ExecuteReader();
                        if (dr.Read())
                        {
                            lblpeng.Text = dr.GetValue(0).ToString();
                        }
                        conn.Close();
                    }
                    private void stockberas()
                    {
                        beras();
                        beras2();
                        int hasil, jmlberas, peng;
                        jmlberas = Convert.ToInt32(jumlahberas.Text);
                        peng = Convert.ToInt32(lblpeng.Text);
                        hasil = jmlberas - peng;
                        stokberas.Text = hasil.ToString();
                    }
        private void TambahPenggunaanLogistik_Load(object sender, EventArgs e)
        {
           
        }
    }
}
