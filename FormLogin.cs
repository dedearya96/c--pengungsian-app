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
    public partial class FormLogin : Form
    {
        private string sqlQuery;
        private SqlConnection sqlConn;
       
        public FormLogin()
        {
            InitializeComponent();
            dbConnector db = new dbConnector();
            db.createConn();
            sqlConn = db.masterConn;
         
        }
        private void btmMasuk_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                MessageBox.Show("Username belum diisi!");
                txtUsername.Focus();
            }
            else if (txtPassword.Text == "")
            {
                MessageBox.Show("Password belum diisi!");
                txtPassword.Focus();
            }
            else
            {
                sqlQuery = "SELECT * FROM tb_user WHERE username='" + txtUsername.Text + "' AND password='" + txtPassword.Text + "'";
                sqlConn.Open();
                SqlCommand sqlCmd = new SqlCommand(sqlQuery, sqlConn);
                SqlDataReader dr = sqlCmd.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("Anda berhasil masuk, Selamat menggunakan!",
                         "Warning", MessageBoxButtons.OK);
                    FormUtama fr = new FormUtama();
                    fr.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Pastikan username dan password benar!",
                        "Warning", MessageBoxButtons.OK);
                    txtUsername.Focus();
                }
                sqlConn.Close();
            }
        }
       
        private void btmBatal_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
