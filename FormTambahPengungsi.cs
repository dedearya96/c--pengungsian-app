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
    public partial class FormTambahPengungsi : Form
    {
        private string sqlQuery;//menampung query
        private SqlConnection conn;
        public FormTambahPengungsi()
        {
            InitializeComponent();
            dbConnector db = new dbConnector();
            db.createConn();
            conn = db.masterConn;
            
        }

        

        private void cmbTempat_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
           
            if (txtNama.Text == "")
            {
                MessageBox.Show("Nama Pengungsi belum diisi!");
                txtNama.Focus();
            }
            else if (cmbJenis.Text == "")
            {
                MessageBox.Show("Jenis kelamin Pengungsi belum diisi!");
                cmbJenis.Focus();
            }
            else if (txtAlamat.Text == "")
            {
                MessageBox.Show("Alamat pengungsi belum diisi!");
                txtAlamat.Focus();
            }
            else if (txtPekerjaan.Text == "")
            {
                MessageBox.Show("Pekerjaan pengungsi belum diisi!");
                txtPekerjaan.Focus();   
            }
            else if (dtTgl.Text == "")
            {
                MessageBox.Show("Tanggal Lahir pengungsi belum diisi!");
                dtTgl.Focus();
            }
            else if (numUmur.Text == "")
            {
                MessageBox.Show("Umur pengungsi belum diisi!");
                numUmur.Focus();
            }
            else if (txtTelp.Text == "")
            {
                MessageBox.Show("No Telp pengungsi belum diisi!");
                txtTelp.Focus();
            }
            else if (cmbTempat.Text == "")
            {
                MessageBox.Show("Pilihan tempat mengungsi belum pilih!");
                cmbTempat.Focus();
            }
            else if (dtTglmasuk.Text == "")
            {
                MessageBox.Show("Tanggal Masuk pengungsi belum diisi!");
                dtTglmasuk.Focus();
            }
            else
            {

                sqlQuery = "INSERT INTO tb_pengungsi VALUES " +
                    "('" + txtNama.Text + "', '" + cmbJenis.Text + "', '" + txtAlamat.Text + "', '" + txtPekerjaan.Text + "', '" + dtTgl.Text + "', '" + numUmur.Text + "', '" + txtTelp.Text + "', '" + cmbTempat.Text + "', '" + dtTglmasuk.Text + "')";

                conn.Open();
                SqlCommand sqlCmd = new SqlCommand(sqlQuery, conn);
                sqlCmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Data Pengungsi Tersimpan!");
                this.Close();
            }
        }
        private void tampilComboBox()
        {
            string query = "select * from tb_tempat";
            fungsi.Set_ComboBox(query, "nama", cmbTempat);
        }

        private void FormTambahPengungsi_Load(object sender, EventArgs e)
        {
            tampilComboBox();
        }

        
        
    }
}
