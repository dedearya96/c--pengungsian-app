using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// namespace for db connection
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Pengungsian
{
    class dbConnector
    {
        public string strConn; //connection string (alamat db)
        public SqlConnection masterConn; // sql connection (jalan menuju db)

        public void createConn()
        {
            strConn = "DATA SOURCE='.\\SQLEXPRESS'; " +
                "INITIAL CATALOG='dbPengungsi'; " +
                "INTEGRATED SECURITY=TRUE; ";
            //"USER ID = '';" +
            //"PASSWORD = '' ";

            masterConn = new SqlConnection(strConn);
            masterConn.Open();

            if (masterConn.State != ConnectionState.Open)
            {
                MessageBox.Show("Terjadi gangguan koneksi ke database");
                masterConn.Close();
            }
            else
            {

                masterConn.Close();
            }


        }

    }
}
