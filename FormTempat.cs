using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

//1
using System.Data.Sql;
using System.Data.SqlClient;

namespace Pengungsian
{
    public partial class FormTempat : Form
    {
        //2
        private string sqlQuery;//menampung query
        private SqlConnection conn;

        public FormTempat()
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

        private void FormTempat_Load(object sender, EventArgs e)
        {

        }

        private void btmSimpan_Click(object sender, EventArgs e)
        {
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
                sqlQuery = "INSERT INTO tb_tempat VALUES " +
                    "('" + txtNama.Text + "', '" + txtAlamat.Text + "', '" + txtTelp.Text + "')";

                conn.Open();
                SqlCommand sqlCmd = new SqlCommand(sqlQuery, conn);
                sqlCmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Data tersimpan!");
                FormTempat fr = new FormTempat();
                this.Close();
            }
        }

       

    }
}
