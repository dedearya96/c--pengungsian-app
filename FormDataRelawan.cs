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
    public partial class FormDataRelawan : Form
    {
        int jumlah;
        private string sqlQuery;//menampung query
        private SqlConnection conn;
        public FormDataRelawan()
        {
            InitializeComponent();
            dbConnector db = new dbConnector();
            db.createConn();
            conn = db.masterConn;
        }

        private void btmTambah_Click(object sender, EventArgs e)
        {
            FormTambahRelawan fr = new FormTambahRelawan();
            fr.ShowDialog();
            showData();
            jmlData();
        }

        

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand delcmd = new SqlCommand();
            if (dataGridView1.Rows.Count > 1 && dataGridView1.SelectedRows[0].Index != dataGridView1.Rows.Count - 1)
            {
                if (MessageBox.Show("Apakah anda ingin menghapus data ini?", "Konfirmasi",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    delcmd.CommandText = "DELETE FROM tb_relawan WHERE id=" + dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + "";
                    conn.Open();
                    delcmd.Connection = conn;
                    delcmd.ExecuteNonQuery();
                    conn.Close();
                    dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
                    MessageBox.Show("Data yang dipilih Terhapus");
                    jmlData();
                }
            }
        }

        private void jmlData()
        {
            jumlah = dataGridView1.Rows.Count;
            lblJml.Text = (jumlah - 1).ToString();
        }

        private void FormDataRelawan_Load(object sender, EventArgs e)
        {
            showData();
            jmlData();
        }

        private void showData()
        {
            sqlQuery = "SELECT id as [No Relawan], " +
                "nama as [Nama Relawan], " +
                "jenis_kelamin as [Jenis Kelamin], " +
                "alamat as [Alamat Relawan], " +
                "telp as [Telp/HP], " +
                "tempat as [Tempat] " +
                "FROM tb_relawan " +
                "ORDER BY id desc ";

            conn.Open();
            SqlDataAdapter SDA = new SqlDataAdapter(sqlQuery, conn);
            SqlCommandBuilder SCB = new SqlCommandBuilder(SDA);
            DataTable datatable = new DataTable();
            SDA.Fill(datatable);
            dataGridView1.DataSource = datatable;
            conn.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditRelawan fr1 = new EditRelawan();
            fr1.lblNo.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            fr1.txtNama.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            fr1.cmbJenis.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            fr1.txtAlamat.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            fr1.txtTelp.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            fr1.cmbTempat.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            fr1.ShowDialog();
            showData();
        }

        private void btnLihat_Click(object sender, EventArgs e)
        {
            MessageBox.Show("No\t\t: " + dataGridView1.CurrentRow.Cells[0].Value.ToString() +
                "\nNama\t\t: " + dataGridView1.CurrentRow.Cells[1].Value.ToString() +
                "\nJenis Kelamin\t: " + dataGridView1.CurrentRow.Cells[2].Value.ToString() +
                 "\nAlamat\t\t: " + dataGridView1.CurrentRow.Cells[3].Value.ToString() +
                  "\nTelepon\t\t: " + dataGridView1.CurrentRow.Cells[4].Value.ToString() +
                "\nTempat\t\t: " + dataGridView1.CurrentRow.Cells[5].Value.ToString());
        }

        private void txtPencarian_TextChanged(object sender, EventArgs e)
        {
            sqlQuery = "SELECT * from tb_relawan where nama like'%" + txtPencarian.Text + "%'";
            conn.Open();
            SqlDataAdapter SDA = new SqlDataAdapter(sqlQuery, conn);
            SqlCommandBuilder SCB = new SqlCommandBuilder(SDA);
            DataTable datatable = new DataTable();
            SDA.Fill(datatable);
            dataGridView1.DataSource = datatable;
            conn.Close();
            jmlData();
        }
    }
}
