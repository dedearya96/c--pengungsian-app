using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Pengungsian
{
    class fungsi
    {
        static SqlConnection conn;
        static SqlDataReader myreader;

        public static void Set_ComboBox(string Query, string row, ComboBox box)
        {
            try
            {
                dbConnector db = new dbConnector();
                db.createConn();
                conn = db.masterConn;
                conn.Open();
                SqlCommand comm = new SqlCommand(Query, conn);

                myreader = comm.ExecuteReader();
                box.Items.Clear();
                if (myreader.HasRows)
                {
                    while (myreader.Read())
                    {
                        box.Items.Add(myreader[row]);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (myreader != null)
                    myreader.Close();
                conn.Close();
            }
        }
    }
}
