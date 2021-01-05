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
    public partial class FormDataTempat : Form
    {
        int jumlah;
        private string sqlQuery;
        private SqlConnection conn;
        public FormDataTempat()
        {
            InitializeComponent();
            dbConnector db = new dbConnector();
            db.createConn();
            conn = db.masterConn;
        }

        private void btmTambah_Click(object sender, EventArgs e)
        {
            FormTempat fr = new FormTempat();
            fr.ShowDialog();
            showData();
            jmlData();
        }

        private void jmlData()
        {
            jumlah = dataGridView1.Rows.Count;
            lblJml.Text = (jumlah - 1).ToString();
        }
        private void FormDataTempat_Load(object sender, EventArgs e)
        {
            showData();
            jmlData();
        }

        private void showData()
        {
            sqlQuery = "SELECT id as [No Tempat], " +
                "nama as [Nama Tempat], " +
                "alamat as [Alamat Tempat], " +
                "telp as [No Telp] " +
                "FROM tb_tempat " +
                "ORDER BY id desc ";

            conn.Open();
            SqlDataAdapter SDA = new SqlDataAdapter(sqlQuery, conn);
            SqlCommandBuilder SCB = new SqlCommandBuilder(SDA);
            DataTable datatable = new DataTable();
            SDA.Fill(datatable);
            dataGridView1.DataSource = datatable;
            conn.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
                EditTempat fr = new EditTempat();
                fr.lblNo.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                fr.txtNama.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                fr.txtAlamat.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                fr.txtTelp.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                fr.ShowDialog();
                showData();
           
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            SqlCommand delcmd = new SqlCommand();
            if (dataGridView1.Rows.Count > 1 && dataGridView1.SelectedRows[0].Index != dataGridView1.Rows.Count- 1)
            {
                if (MessageBox.Show("Apakah anda ingin menghapus data ini?", "Konfirmasi",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                delcmd.CommandText = "DELETE FROM tb_tempat WHERE id=" + dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + "";
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

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void btnLihat_Click(object sender, EventArgs e)
        {
            MessageBox.Show(">No\t: "+dataGridView1.CurrentRow.Cells[0].Value.ToString() +
                "\n>Nama\t: " + dataGridView1.CurrentRow.Cells[1].Value.ToString() +
                "\n>Alamat\t: " + dataGridView1.CurrentRow.Cells[2].Value.ToString() +
                "\n>Telepon\t: " + dataGridView1.CurrentRow.Cells[3].Value.ToString());
        }
    }
}
