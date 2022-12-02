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
    public partial class update_categorii : Form
    {
        Conectare conn = new Conectare();
        SqlCommand cmd;

        public update_categorii()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
        
            this.Hide();
        }
        void Reset()
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("UPDATE CATEGORII SET Den_Cat = '" + textBox2.Text + "' WHERE Den_Cat = '" + textBox1.Text + "';", conn.OpenConn());
                cmd.ExecuteNonQuery();
                MessageBox.Show(" Datele au fost actualizate cu succes! ");
            }
            catch (Exception)
            {

            }

            Reset();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
