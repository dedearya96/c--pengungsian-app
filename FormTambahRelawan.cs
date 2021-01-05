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
    public partial class FormTambahRelawan : Form
    {
        private string sqlQuery;//menampung query
        private SqlConnection conn;
        public FormTambahRelawan()
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
           
            if (txtNama.Text == "")
            {
                MessageBox.Show("Nama belum diisi!");
                txtNama.Focus();
            }
            else if (cmbJenis.Text == "")
            {
                MessageBox.Show("Jenis kelamin belum dipilih!");
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
            else if (cmbTempat.Text == "")
            {
                MessageBox.Show("Tempat belum dipilih!");
                cmbTempat.Focus();
            }
            else
            {
                sqlQuery = "INSERT INTO tb_relawan VALUES " +
                     "('" + txtNama.Text + "', '" + cmbJenis.Text + "', '" + txtAlamat.Text + "', '" + txtTelp.Text + "', '" + cmbTempat.Text + "')";

                conn.Open();
                SqlCommand sqlCmd = new SqlCommand(sqlQuery, conn);
                sqlCmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Data Relawan Tersimpan!");
                this.Close();
            }
        }

        private void FormTambahRelawan_Load(object sender, EventArgs e)
        {
            tampilComboBox();
        }
        private void tampilComboBox()
        {
            string query = "select * from tb_tempat";
            fungsi.Set_ComboBox(query, "nama", cmbTempat);
        }

        private void cmbTempat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
