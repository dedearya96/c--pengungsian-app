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
    public partial class FormDataPengungsi : Form
    {
        int jumlah;
        private string sqlQuery;
        private SqlConnection conn;
        public FormDataPengungsi()
        {
            InitializeComponent();
            dbConnector db = new dbConnector();
            db.createConn();
            conn = db.masterConn;
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btmTambah_Click(object sender, EventArgs e)
        {
            FormTambahPengungsi fr = new FormTambahPengungsi();
            fr.ShowDialog();
            showData();
            jmlData();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void jmlData()
        {

            jumlah = dataGridView1.Rows.Count;
            lblJml.Text = (jumlah - 1).ToString();
        }

        private void FormDataPengungsi_Load(object sender, EventArgs e)
        {
            showData();
            jmlData();
        }
        private void showData()
        {
            sqlQuery = "SELECT id as [No Pengungsi], " +
                "nama as [Nama Pengungsi], " +
                "jenis_kelamin as [Jenis Kelamin], " +
                "alamat as [Alamat Pengungsi], " +
                "pekerjaan as [Pekerjaan], " +
                "tgl_lahir as [Tanggal Lahir], " +
                "umur as [Umur], " +
                "telp as [Telp], " +
                "tempat as [Tempat], " +
                "tgl_masuk as [Tanggal Masuk] " +
                "FROM tb_pengungsi " +
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
            
            EditPengungsi fr1 = new EditPengungsi();
            fr1.lblNo.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            fr1.txtNama.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            fr1.cmbJenis.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            fr1.txtAlamat.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            fr1.txtPekerjaan.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            fr1.dtTgl.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            fr1.numUmur.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            fr1.txtTelp.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            fr1.cmbTempat.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            fr1.dtTglmasuk.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            fr1.ShowDialog();
            showData();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            SqlCommand delcmd = new SqlCommand();
            if (dataGridView1.Rows.Count > 1 && dataGridView1.SelectedRows[0].Index != dataGridView1.Rows.Count - 1)
            {
                if (MessageBox.Show("Apakah anda ingin menghapus data ini?", "Konfirmasi",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    delcmd.CommandText = "DELETE FROM tb_pengungsi WHERE id =" + dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + "";
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

        private void btnLihat_Click(object sender, EventArgs e)
        {
            MessageBox.Show("No\t\t: " + dataGridView1.CurrentRow.Cells[0].Value.ToString() +
               "\nNama\t\t: " + dataGridView1.CurrentRow.Cells[1].Value.ToString() +
               "\nJenis Kelamin\t: " + dataGridView1.CurrentRow.Cells[2].Value.ToString() +
                "\nAlamat\t\t: " + dataGridView1.CurrentRow.Cells[3].Value.ToString() +
                 "\nPekerjaan\t\t: " + dataGridView1.CurrentRow.Cells[4].Value.ToString() +
                  "\nTgl Lahir\t\t: " + dataGridView1.CurrentRow.Cells[5].Value.ToString() +
                   "\nUmur\t\t: " + dataGridView1.CurrentRow.Cells[6].Value.ToString() +
                 "\nTelepon\t\t: " + dataGridView1.CurrentRow.Cells[7].Value.ToString() +
               "\nTempat\t\t: " + dataGridView1.CurrentRow.Cells[8].Value.ToString() +
                "\nTgl masuk\t\t: " + dataGridView1.CurrentRow.Cells[9].Value.ToString());
        }

        private void lblJml_Click(object sender, EventArgs e)
        {
            
        }

        private void txtPencarian_TextChanged(object sender, EventArgs e)
        {
            sqlQuery = "SELECT * from tb_pengungsi where nama like'%" + txtPencarian.Text + "%'";    
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
