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
    public partial class FormTambahTunai : Form
    {
        private string sqlQuery;//menampung query
        private SqlConnection conn;
        public FormTambahTunai()
        {
            InitializeComponent();
            dbConnector db = new dbConnector();
            db.createConn();
            conn = db.masterConn;
        }

        private void btmBatal_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btmSimpan_Click(object sender, EventArgs e)
        {
            if (dtTgl.Text == "")
            {
                MessageBox.Show("Nama belum diisi!");
                dtTgl.Focus();
            }
            else if (txtNama.Text == "")
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
            else if (txtJumlah.Text == "")
            {
                MessageBox.Show("Jumlah sumbangan belum diisi!");
                txtJumlah.Focus();
            }
            else
            {
                sqlQuery = "INSERT INTO tb_tunai VALUES " +
                   "('" + dtTgl.Text + "', '" + txtNama.Text + "', '" + txtAlamat.Text + "', '" + txtTelp.Text + "', '" + txtJumlah.Text + "')";

                conn.Open();
                SqlCommand sqlCmd = new SqlCommand(sqlQuery, conn);
                sqlCmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Data Bantuan Tunai tersimpan!");
                FormTambahTunai fr = new FormTambahTunai();
                this.Close();
            }
        }

        private void FormTambahTunai_Load(object sender, EventArgs e)
        {

        }

        
    }
}
