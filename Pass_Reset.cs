using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnoMD
{
    public partial class Pass_Reset : Form
    {

        Conectare conn = new Conectare();
        SqlCommand cmd;

        public Pass_Reset()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("EXEC Reset_Pass @Nume = '" + textBox1.Text + "', @Cheia =" + textBox2.Text + ",@Parola = '" + textBox3.Text + "';" , conn.OpenConn());
                cmd.ExecuteNonQuery();
                MessageBox.Show(" Parola a fost actualizata cu succes ! ");

                conn.CloseConn();
            }
            catch (Exception)
            {
                MessageBox.Show("Eroare !");
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Logare f1 = new Logare();
                f1.Show();
            this.Hide();
        }
    }
}
