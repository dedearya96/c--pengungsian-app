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
    public partial class EditPengungsi : Form
    {
       private string sqlQuery;
        private SqlConnection conn;
        public EditPengungsi()
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

        private void tampilComboBox()
        {
            string query = "select * from tb_tempat";
            fungsi.Set_ComboBox(query, "nama", cmbTempat);
        }

        private void EditPengungsi_Load(object sender, EventArgs e)
        {
            tampilComboBox();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah anda ingin merubah data?", "Konfirmasi",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sqlQuery = "UPDATE tb_pengungsi "
                    + "SET nama = '" + txtNama.Text + "', "
                    + "jenis_kelamin = '" + cmbJenis.Text + "', "
                    + "alamat = '" + txtAlamat.Text + "', "
                    + "pekerjaan = '" + txtPekerjaan.Text + "', "
                     + "tgl_lahir = '" + dtTgl.Text + "', "
                      + "umur = '" + numUmur.Text + "', "
                       + "telp = '" + txtTelp.Text + "', "
                        + "tempat = '" + cmbTempat.Text + "', "
                         + "tgl_masuk = '" + dtTglmasuk.Text + "' "
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
