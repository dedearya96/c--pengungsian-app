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
    public partial class FormTambahLogistik : Form
    {
        private string sqlQuery;//menampung query
        private SqlConnection conn;
        public FormTambahLogistik()
        {
            InitializeComponent();
            dbConnector db = new dbConnector();
            db.createConn();
            conn = db.masterConn;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

       

       

        private void btmSimpan_Click(object sender, EventArgs e)
        {
            if (dtTgl.Text == "")
            {
                MessageBox.Show("Nama belum diisi!");
                dtTgl.Focus();
            }
            if (txtNama.Text == "")
            {
                MessageBox.Show("Nama belum diisi!");
                txtNama.Focus();
            }
            else if (txtAlamat.Text == "")
            {
                MessageBox.Show("Alamat belum diisi!");
                txtAlamat.Focus();
            }
            else if (txtTelp.Text == "")
            {
                MessageBox.Show("No Telp belum diisi!");
                txtTelp.Focus();
            }
            else
            {
                sqlQuery = "INSERT INTO tb_logistik VALUES " +
                   "('" + dtTgl.Text + "', '" + txtNama.Text + "', '" + txtAlamat.Text + "', '" + txtTelp.Text + "', '" + txtBeras.Text + "', '" + txtMie.Text + "', '" + txtMasker.Text + "', '" + txtAqua.Text + "', '" + txtNasi.Text + "', '" + txtSusu.Text + "', '" + txtSelimut.Text + "', '" + txtRoti.Text + "', '" + txtLain.Text + "')";

                conn.Open();
                SqlCommand sqlCmd = new SqlCommand(sqlQuery, conn);
                sqlCmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Data Bantuan Logistik tersimpan!");
                FormTambahLogistik fr = new FormTambahLogistik();
                this.Close();
            }
        }

        private void FormTambahLogistik_Load(object sender, EventArgs e)
        {

        }
    }
}
