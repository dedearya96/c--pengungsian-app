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
    public partial class FormPenitipan : Form
    {
        private string sqlQuery;//menampung query
        private SqlConnection conn;
        public FormPenitipan()
        {
            InitializeComponent();
            dbConnector db = new dbConnector();
            db.createConn();
            conn = db.masterConn;
           
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

       

       

        private void btnBatal_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (dtTgl.Text == "")
            {
                MessageBox.Show("Tanggal belum diisi!");
                dtTgl.Focus();
            }
            else if (txtNama.Text == "")
            {
                MessageBox.Show("Nama belum diisi!");
                txtNama.Focus();
            }
            else if (cmbJenis.Text == "")
            {
                MessageBox.Show("Jenis kelamin belum diisi!");
                cmbJenis.Focus();
            }
            else if (txtAlamat.Text == "")
            {
                MessageBox.Show("Alamat belum diisi!");
                txtAlamat.Focus();
            }
            else if (txtTelp.Text == "")
            {
                MessageBox.Show("Telp belum diisi!");
                txtTelp.Focus();
            }
            else if (cmbPeliharaan.Text == "")
            {
                MessageBox.Show("Peliharaan belum diisi!");
                txtJml.Focus();
            }
            else if (txtJml.Text == "")
            {
                MessageBox.Show("Jumlah peliharaan belum diisi!");
                txtJml.Focus();
            }
            else
            {
                sqlQuery = "INSERT INTO tb_penitipan VALUES " +
                     "('" + dtTgl.Text + "', '" + txtNama.Text + "', '" + cmbJenis.Text + "', '" + txtAlamat.Text + "', '" + txtTelp.Text + "', '" + cmbPeliharaan.Text + "', '" + txtJml.Text + "')";

                conn.Open();
                SqlCommand sqlCmd = new SqlCommand(sqlQuery, conn);
                sqlCmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Data Penitipan Tersimpan!");
                this.Close();
            }
        }
    }
}
