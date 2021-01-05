﻿using System;
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
    public partial class EditPenggunaanTunai : Form
    {
        private string sqlQuery;
        private SqlConnection conn;
        public EditPenggunaanTunai()
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

        private void btmEdit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah anda ingin merubah data?", "Konfirmasi",
             MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sqlQuery = "UPDATE tb_penggunaan_tunai "
                     + "SET tanggal = '" + dtTgl.Text + "', "
                    + "pembelian = '" + txtPembelian.Text + "', "
                    + "harga = '" + txtHarga.Text + "', "
                         + "banyak = '" + txtBanyak.Text + "' "
                    + "WHERE id = " + lblNo.Text + " ";

                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlQuery, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Berhasil perbarui data");
                this.Close();
            }
        }
    }
}
