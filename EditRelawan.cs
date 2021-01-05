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
    public partial class EditRelawan : Form
    {
        private string sqlQuery;
        private SqlConnection conn;
        public EditRelawan()
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

        private void tampilComboBox()
        {
            string query = "select * from tb_tempat";
            fungsi.Set_ComboBox(query, "nama", cmbTempat);
        }

        private void EditRelawan_Load(object sender, EventArgs e)
        {
            tampilComboBox();
        }

        private void btmEdit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah anda ingin merubah data?", "Konfirmasi",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sqlQuery = "UPDATE tb_relawan "
                    + "SET nama = '" + txtNama.Text + "', "
                    + "jenis_kelamin = '" + cmbJenis.Text + "', "
                    + "alamat = '" + txtAlamat.Text + "', "
                       + "telp = '" + txtTelp.Text + "', "
                        + "tempat = '" + cmbTempat.Text + "' "
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
