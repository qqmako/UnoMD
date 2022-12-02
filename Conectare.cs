using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace UnoMD
{
    class Conectare
    {
        SqlConnection conn;

        public Conectare()
        {
            conn = new SqlConnection
                ("Data Source=ASUS;Database=UnoMD;Trusted_Connection=yes;");
        }

        public SqlConnection OpenConn()
        {
            try
            {
                conn.Open();
            }
            catch (Exception)
            {
                //MessageBox.Show("Erorare la conectarea cu baza de date !");
            }
            return conn;
        }

        public void CloseConn()
        {
            try
            {
                conn.Close();
            }

            catch (Exception)
            {
                MessageBox.Show("Eroare la ichiderea conexiunii cu baza de date !");
            }
        }

    }
}
