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
    public partial class FormDataTunai : Form
    {
        int jumlah;
        private string sqlQuery;
        private SqlConnection conn;
        public FormDataTunai()
        {
            InitializeComponent();
            dbConnector db = new dbConnector();
            db.createConn();
            conn = db.masterConn;
        }

        private void btmTambah_Click(object sender, EventArgs e)
        {
            FormTambahTunai fr = new FormTambahTunai();
            fr.ShowDialog();
            showData();
            jmldata();
            totalTunai();
        }

        private void btmEdit_Click(object sender, EventArgs e)
        {
            EditTunai fr1 = new EditTunai();
            fr1.lblNo.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            fr1.dtTgl.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            fr1.txtNama.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            fr1.txtAlamat.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            fr1.txtTelp.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            fr1.txtJumlah.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            fr1.ShowDialog();
            showData();
        }

        private void btmHapus_Click(object sender, EventArgs e)
        {
            SqlCommand delcmd = new SqlCommand();
            if (dataGridView1.Rows.Count > 1 && dataGridView1.SelectedRows[0].Index != dataGridView1.Rows.Count - 1)
            {
                if (MessageBox.Show("Apakah anda ingin menghapus data ini?", "Konfirmasi",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    delcmd.CommandText = "DELETE FROM tb_tunai WHERE id=" + dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + "";
                    conn.Open();
                    delcmd.Connection = conn;
                    delcmd.ExecuteNonQuery();
                    conn.Close();
                    dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
                    MessageBox.Show("Data yang dipilih Terhapus");
                    jmldata();
                    totalTunai();
                }
            }
        }
        private void totalTunai()
        {
            //TotalTunai
            lblTotal.Text = (from DataGridViewRow row in dataGridView1.Rows
                             where row.Cells[5].FormattedValue.ToString() != string.Empty
                             select Convert.ToInt32(row.Cells[5].FormattedValue)).Sum().ToString();
        }

        private void jmldata()
        {
            jumlah = dataGridView1.Rows.Count;
            lblJml.Text = (jumlah - 1).ToString();
        }

        private void FormDataTunai_Load(object sender, EventArgs e)
        {
            showData();
            jmldata();
            totalTunai();
            
        }

        private void showData()
        {
            sqlQuery = "SELECT id as [No Bantuan], " +
                "tanggal as [Tanggal], " +
                "nama as [Nama Instansi], " +
                "alamat as [Alamat Instansi], " +
                "telp as [No Telp], " +
                "jumlah as [Jumlah Sumbangan] " +
                "FROM tb_tunai " +
                "ORDER BY id desc ";

            conn.Open();
            SqlDataAdapter SDA = new SqlDataAdapter(sqlQuery, conn);
            SqlCommandBuilder SCB = new SqlCommandBuilder(SDA);
            DataTable datatable = new DataTable();
            SDA.Fill(datatable);
            dataGridView1.DataSource = datatable;
            conn.Close();
        }

        private void btnLihat_Click(object sender, EventArgs e)
        {
            MessageBox.Show("No\t\t: " + dataGridView1.CurrentRow.Cells[0].Value.ToString() +
              "\nTanggal\t\t: " + dataGridView1.CurrentRow.Cells[1].Value.ToString() +
              "\nNama\t\t: " + dataGridView1.CurrentRow.Cells[2].Value.ToString() +
               "\nAlamat\t\t: " + dataGridView1.CurrentRow.Cells[3].Value.ToString() +
                "\nTelepon\t\t: " + dataGridView1.CurrentRow.Cells[4].Value.ToString() +
              "\nJumlah\t\t: " + dataGridView1.CurrentRow.Cells[5].Value.ToString());
        }

        private void txtPencarian_TextChanged(object sender, EventArgs e)
        {

            sqlQuery = "SELECT * from tb_tunai where nama like'%" + txtPencarian.Text + "%'";
            conn.Open();
            SqlDataAdapter SDA = new SqlDataAdapter(sqlQuery, conn);
            SqlCommandBuilder SCB = new SqlCommandBuilder(SDA);
            DataTable datatable = new DataTable();
            SDA.Fill(datatable);
            dataGridView1.DataSource = datatable;
            conn.Close();
            jmldata();
            totalTunai();
        }
    }
}
