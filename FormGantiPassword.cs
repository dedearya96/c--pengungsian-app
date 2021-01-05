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
    public partial class FormGantiPassword : Form
    {
        private string sqlQuery;
        private SqlConnection conn;
        public FormGantiPassword()
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

        private void btmGanti_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah anda ingin merubah password?", "Konfirmasi",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sqlQuery = "UPDATE tb_user "
                    + "SET password = '" + txtPassword.Text + "' "
                    + "WHERE username = 'admin' ";

                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlQuery, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Password dirubah");
                this.Close();
            }
        }

        private void FormGantiPassword_Load(object sender, EventArgs e)
        {
            showData();
        }
        private void showData()
        {
            sqlQuery = "SELECT password FROM tb_user";
            conn.Open();
            SqlCommand sqlCmd = new SqlCommand(sqlQuery, conn);
            SqlDataReader dr = sqlCmd.ExecuteReader();
            if (dr.Read())
            {
                txtPassword.Text = dr.GetValue(0).ToString();
            }
            conn.Close();
        }
    }
}
