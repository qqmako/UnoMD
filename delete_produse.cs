using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace UnoMD
{
    public partial class delete_produse : Form
    {
        Conectare conn = new Conectare();
        SqlCommand cmd;

        public delete_produse()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("DELETE FROM Produse WHERE Id_Produs = " + textBox1.Text + ";", conn.OpenConn());
                cmd.ExecuteNonQuery();
                MessageBox.Show(" Datele au fost sterse cu succes! ");
            }
            catch (Exception)
            {

            }
            textBox1.Clear();
        }
    }
}
