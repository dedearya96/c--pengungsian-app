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
    public partial class Laporan : Form
    {
        private string sqlQuery;
        private SqlConnection conn;
        public Laporan()
        {
            InitializeComponent();
            dbConnector db = new dbConnector();
            db.createConn();
            conn = db.masterConn;
        }

        //Bantuan Logistik

        private void beras()
        {
            sqlQuery = "SELECT sum(beras)FROM tb_logistik";
            conn.Open();
            SqlCommand sqlCmd = new SqlCommand(sqlQuery, conn);
            SqlDataReader dr = sqlCmd.ExecuteReader();
            if (dr.Read())
            {
                lblBeras.Text = dr.GetValue(0).ToString();
            }
            conn.Close();
        }

        private void mie()
        {
            sqlQuery = "SELECT sum(mie)FROM tb_logistik";
            conn.Open();
            SqlCommand sqlCmd = new SqlCommand(sqlQuery, conn);
            SqlDataReader dr = sqlCmd.ExecuteReader();
            if (dr.Read())
            {
                lblMie.Text = dr.GetValue(0).ToString();
            }
            conn.Close();
        }

        private void masker()
        {
            sqlQuery = "SELECT sum(masker)FROM tb_logistik";
            conn.Open();
            SqlCommand sqlCmd = new SqlCommand(sqlQuery, conn);
            SqlDataReader dr = sqlCmd.ExecuteReader();
            if (dr.Read())
            {
                lblMasker.Text = dr.GetValue(0).ToString();
            }
            conn.Close();
        }
        private void aqua()
        {
            sqlQuery = "SELECT sum(aqua)FROM tb_logistik";
            conn.Open();
            SqlCommand sqlCmd = new SqlCommand(sqlQuery, conn);
            SqlDataReader dr = sqlCmd.ExecuteReader();
            if (dr.Read())
            {
                lblAqua.Text = dr.GetValue(0).ToString();
            }
            conn.Close();
        }
        private void nasi()
        {
            sqlQuery = "SELECT sum(nasi)FROM tb_logistik";
            conn.Open();
            SqlCommand sqlCmd = new SqlCommand(sqlQuery, conn);
            SqlDataReader dr = sqlCmd.ExecuteReader();
            if (dr.Read())
            {
                lblNasi.Text = dr.GetValue(0).ToString();
            }
            conn.Close();
        }
        private void susu()
        {
            sqlQuery = "SELECT sum(susu)FROM tb_logistik";
            conn.Open();
            SqlCommand sqlCmd = new SqlCommand(sqlQuery, conn);
            SqlDataReader dr = sqlCmd.ExecuteReader();
            if (dr.Read())
            {
                lblSusu.Text = dr.GetValue(0).ToString();
            }
            conn.Close();
        }
        private void selimut()
        {
            sqlQuery = "SELECT sum(selimut)FROM tb_logistik";
            conn.Open();
            SqlCommand sqlCmd = new SqlCommand(sqlQuery, conn);
            SqlDataReader dr = sqlCmd.ExecuteReader();
            if (dr.Read())
            {
                lblSelimut.Text = dr.GetValue(0).ToString();
            }
            conn.Close();
        }
        private void roti()
        {
            sqlQuery = "SELECT sum(roti)FROM tb_logistik";
            conn.Open();
            SqlCommand sqlCmd = new SqlCommand(sqlQuery, conn);
            SqlDataReader dr = sqlCmd.ExecuteReader();
            if (dr.Read())
            {
                lblRoti.Text = dr.GetValue(0).ToString();
            }
            conn.Close();
        }
        private void Laporan_Load(object sender, EventArgs e)
        {
            //Bantuan Logistik
            beras();
            mie();
            masker();
            aqua();
            nasi();
            susu();
            selimut();
            roti();
            //Penggunaan Logistik
            beras2();
            mie2();
            masker2();
            aqua2();
            nasi2();
            susu2();
            selimut2();
            roti2();
            //Sisa
            sisaberas();
            sisamie();
            sisamasker();
            sisaaqua();
            sisanasi();
            sisasusu();
            sisaselimut();
            sisaroti();
            //Total Bantuan Tunai

            jmlBantuanTunai();

            //Total Penggunaan Tunai
            jmlPenggunaanTunai();
            //Sisa Bantuan Tunai
            sisaBantuanTunai();
            //Jumlah Pengungsi
            JmlPengungsiTotal();
            JmlPengungsiLaki();
            JmlPengungsiPrem();
            //Jumlah Relawan
            JmlRelawanTotal();
            JmlRelawanLaki();
            JmlRelawanPrem();
            //Total Penitipan
            JmlPenitipan();
            //Total Tempat
            JmlTempat();
        }
        //Penggunaan Logistik
        private void beras2()
        {
            sqlQuery = "SELECT sum(beras)FROM tb_penggunaan_logistik";
            conn.Open();
            SqlCommand sqlCmd = new SqlCommand(sqlQuery, conn);
            SqlDataReader dr = sqlCmd.ExecuteReader();
            if (dr.Read())
            {
                lblBeras2.Text = dr.GetValue(0).ToString();
            }
            conn.Close();
        }
        private void mie2()
        {
            sqlQuery = "SELECT sum(mie)FROM tb_penggunaan_logistik";
            conn.Open();
            SqlCommand sqlCmd = new SqlCommand(sqlQuery, conn);
            SqlDataReader dr = sqlCmd.ExecuteReader();
            if (dr.Read())
            {
                lblMie2.Text = dr.GetValue(0).ToString();
            }
            conn.Close();
        }
        private void masker2()
        {
            sqlQuery = "SELECT sum(masker)FROM tb_penggunaan_logistik";
            conn.Open();
            SqlCommand sqlCmd = new SqlCommand(sqlQuery, conn);
            SqlDataReader dr = sqlCmd.ExecuteReader();
            if (dr.Read())
            {
                lblMasker2.Text = dr.GetValue(0).ToString();
            }
            conn.Close();
        }
        private void aqua2()
        {
            sqlQuery = "SELECT sum(aqua)FROM tb_penggunaan_logistik";
            conn.Open();
            SqlCommand sqlCmd = new SqlCommand(sqlQuery, conn);
            SqlDataReader dr = sqlCmd.ExecuteReader();
            if (dr.Read())
            {
                lblAqua2.Text = dr.GetValue(0).ToString();
            }
            conn.Close();
        }
        private void nasi2()
        {
            sqlQuery = "SELECT sum(nasi)FROM tb_penggunaan_logistik";
            conn.Open();
            SqlCommand sqlCmd = new SqlCommand(sqlQuery, conn);
            SqlDataReader dr = sqlCmd.ExecuteReader();
            if (dr.Read())
            {
                lblNasi2.Text = dr.GetValue(0).ToString();
            }
            conn.Close();
        }
        private void susu2()
        {
            sqlQuery = "SELECT sum(susu)FROM tb_penggunaan_logistik";
            conn.Open();
            SqlCommand sqlCmd = new SqlCommand(sqlQuery, conn);
            SqlDataReader dr = sqlCmd.ExecuteReader();
            if (dr.Read())
            {
                lblSusu2.Text = dr.GetValue(0).ToString();
            }
            conn.Close();
        }
        private void selimut2()
        {
            sqlQuery = "SELECT sum(selimut)FROM tb_penggunaan_logistik";
            conn.Open();
            SqlCommand sqlCmd = new SqlCommand(sqlQuery, conn);
            SqlDataReader dr = sqlCmd.ExecuteReader();
            if (dr.Read())
            {
                lblSelimut2.Text = dr.GetValue(0).ToString();
            }
            conn.Close();
        }
        private void roti2()
        {
            sqlQuery = "SELECT sum(roti)FROM tb_penggunaan_logistik";
            conn.Open();
            SqlCommand sqlCmd = new SqlCommand(sqlQuery, conn);
            SqlDataReader dr = sqlCmd.ExecuteReader();
            if (dr.Read())
            {
                lblRoti2.Text = dr.GetValue(0).ToString();
            }
            conn.Close();
        }

        //Sisa bantuan logistik
        private void sisaberas()
        {
            int sisaberas,beras,beras2;
            beras = Convert.ToInt32(lblBeras.Text);
            beras2 = Convert.ToInt32(lblBeras2.Text);
            sisaberas = beras - beras2;
            sisaBeras.Text = sisaberas.ToString();
        }
        private void sisamie()
        {
            int sisamie, mie, mie2;
            mie = Convert.ToInt32(lblMie.Text);
            mie2 = Convert.ToInt32(lblMie2.Text);
            sisamie = mie - mie2;
            sisaMie.Text = sisamie.ToString();
        }
        private void sisamasker()
        {
            int sisamasker, masker, masker2;
            masker = Convert.ToInt32(lblMasker.Text);
            masker2 = Convert.ToInt32(lblMasker2.Text);
            sisamasker = masker - masker2;
            sisaMasker.Text = sisamasker.ToString();
        }
        private void sisaaqua()
        {
            int sisaaqua, aqua, aqua2;
            aqua = Convert.ToInt32(lblAqua.Text);
            aqua2 = Convert.ToInt32(lblAqua2.Text);
            sisaaqua = aqua - aqua2;
            sisaAqua.Text = sisaaqua.ToString();
        }
        private void sisanasi()
        {
            int sisanasi, nasi, nasi2;
            nasi = Convert.ToInt32(lblNasi.Text);
            nasi2 = Convert.ToInt32(lblNasi2.Text);
            sisanasi = nasi - nasi2;
            siasaNasi.Text = sisanasi.ToString();
        }
        private void sisasusu()
        {
            int sisasusu, susu, susu2;
            susu = Convert.ToInt32(lblSusu.Text);
            susu2 = Convert.ToInt32(lblSusu2.Text);
            sisasusu = susu - susu2;
            sisaSusu.Text = sisasusu.ToString();
        }
        private void sisaselimut()
        {
            int sisaselimut, selimut, selimut2;
            selimut = Convert.ToInt32(lblSelimut.Text);
            selimut2 = Convert.ToInt32(lblSelimut2.Text);
            sisaselimut = selimut - selimut2;
            sisaSelimut.Text = sisaselimut.ToString();
        }
        private void sisaroti()
        {
            int sisaroti, roti, roti2;
            roti = Convert.ToInt32(lblRoti.Text);
            roti2 = Convert.ToInt32(lblRoti2.Text);
            sisaroti = roti - roti2;
            sisaRoti.Text = sisaroti.ToString();
        }

        //Bantuan Tunai
        private void jmlBantuanTunai()
        {
            sqlQuery = "SELECT sum(jumlah)FROM tb_tunai";
            conn.Open();
            SqlCommand sqlCmd = new SqlCommand(sqlQuery, conn);
            SqlDataReader dr = sqlCmd.ExecuteReader();
            if (dr.Read())
            {
                totalBantuan.Text = dr.GetValue(0).ToString();
            }
            conn.Close();
        }
        //Penggunaan Bantuan Tunai
        private void jmlPenggunaanTunai()
        {
            sqlQuery = "SELECT sum(harga*banyak)FROM tb_penggunaan_tunai";
            conn.Open();
            SqlCommand sqlCmd = new SqlCommand(sqlQuery, conn);
            SqlDataReader dr = sqlCmd.ExecuteReader();
            if (dr.Read())
            {
                totalBantuan2.Text = dr.GetValue(0).ToString();
            }
            conn.Close();
        }
        //Sisa Bantuan Tunai
        private void sisaBantuanTunai()
        {
            int sisabantuan, bantuan, bantuan2;
            bantuan = Convert.ToInt32(totalBantuan.Text);
            bantuan2 = Convert.ToInt32(totalBantuan2.Text);
            sisabantuan = bantuan - bantuan2;
            sisaBantuan.Text = sisabantuan.ToString();
        }
        //Jumlah pengungsi total
        private void JmlPengungsiTotal()
        {
            sqlQuery = "SELECT count(id)FROM tb_pengungsi";
            conn.Open();
            SqlCommand sqlCmd = new SqlCommand(sqlQuery, conn);
            SqlDataReader dr = sqlCmd.ExecuteReader();
            if (dr.Read())
            {
                totalPengungsi.Text = dr.GetValue(0).ToString();
            }
            conn.Close();
        }

        //Jumlah Relawan Total
        private void JmlRelawanTotal()
        {
            sqlQuery = "SELECT count(id)FROM tb_relawan";
            conn.Open();
            SqlCommand sqlCmd = new SqlCommand(sqlQuery, conn);
            SqlDataReader dr = sqlCmd.ExecuteReader();
            if (dr.Read())
            {
                totalRelawan.Text = dr.GetValue(0).ToString();
            }
            conn.Close();
        }
        //Jumlah Relawan Laki-Laki
        private void JmlRelawanLaki()
        {
            sqlQuery = "SELECT count(id)FROM tb_relawan where jenis_kelamin='Laki-Laki'";
            conn.Open();
            SqlCommand sqlCmd = new SqlCommand(sqlQuery, conn);
            SqlDataReader dr = sqlCmd.ExecuteReader();
            if (dr.Read())
            {
                totalRelawanLaki.Text = dr.GetValue(0).ToString();
            }
            conn.Close();
        }
        //Jumlah Relawan Prempuan
        private void JmlRelawanPrem()
        {
            sqlQuery = "SELECT count(id)FROM tb_relawan where jenis_kelamin='Prempuan'";
            conn.Open();
            SqlCommand sqlCmd = new SqlCommand(sqlQuery, conn);
            SqlDataReader dr = sqlCmd.ExecuteReader();
            if (dr.Read())
            {
                totalRelawanPrem.Text = dr.GetValue(0).ToString();
            }
            conn.Close();
        }

        //JUmlah Pengungsi Laki
        private void JmlPengungsiLaki()
        {
            sqlQuery = "SELECT count(id)FROM tb_pengungsi where jenis_kelamin='Laki-Laki'";
            conn.Open();
            SqlCommand sqlCmd = new SqlCommand(sqlQuery, conn);
            SqlDataReader dr = sqlCmd.ExecuteReader();
            if (dr.Read())
            {
                totalPengungsiLaki.Text = dr.GetValue(0).ToString();
            }
            conn.Close();
        }
        //Jumlah Pengungsi Prem
        private void JmlPengungsiPrem()
        {
            sqlQuery = "SELECT count(id)FROM tb_pengungsi where jenis_kelamin='Prempuan'";
            conn.Open();
            SqlCommand sqlCmd = new SqlCommand(sqlQuery, conn);
            SqlDataReader dr = sqlCmd.ExecuteReader();
            if (dr.Read())
            {
                totalPengungsiPrem.Text = dr.GetValue(0).ToString();
            }
            conn.Close();
        }
        //Total Penitipan
        private void JmlPenitipan()
        {
            sqlQuery = "SELECT count(id)FROM tb_penitipan";
            conn.Open();
            SqlCommand sqlCmd = new SqlCommand(sqlQuery, conn);
            SqlDataReader dr = sqlCmd.ExecuteReader();
            if (dr.Read())
            {
                totalPenitipan.Text = dr.GetValue(0).ToString();
            }
            conn.Close();
        }

        //Total Tempat
        private void JmlTempat()
        {
            sqlQuery = "SELECT count(id)FROM tb_tempat";
            conn.Open();
            SqlCommand sqlCmd = new SqlCommand(sqlQuery, conn);
            SqlDataReader dr = sqlCmd.ExecuteReader();
            if (dr.Read())
            {
                totalTempat.Text = dr.GetValue(0).ToString();
            }
            conn.Close();
        }
    }
}
