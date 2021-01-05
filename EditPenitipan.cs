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
    public partial class EditPenitipan : Form
    {
        private string sqlQuery;
        private SqlConnection conn;
        public EditPenitipan()
        {
            InitializeComponent();
            dbConnector db = new dbConnector();
            db.createConn();
            conn = db.masterConn;
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah anda ingin merubah data?", "Konfirmasi",
              MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sqlQuery = "UPDATE tb_penitipan "
                     + "SET tanggal = '" + dtTgl.Text + "', "
                    + "nama = '" + txtNama.Text + "', "
                    + "jenis_kelamin = '" + cmbJenis.Text + "', "
                    + "alamat = '" + txtAlamat.Text + "', "
                       + "telp = '" + txtTelp.Text + "', "
                        + "peliharaan = '" + cmbPeliharaan.Text + "', "
                         + "banyak = '" + txtJml.Text + "' "
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
