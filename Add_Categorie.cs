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
    public partial class Add_Categorie : Form
    {
        Conectare conn = new Conectare();
        SqlCommand cmd;
        public Add_Categorie()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
            
        {
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void add_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand(" INSERT INTO Categorii VALUES('" + textBox1.Text + "' )", conn.OpenConn());
                cmd.ExecuteNonQuery();
                MessageBox.Show("Datele au fost salvate cu succes !");
            }
            catch (Exception)
            {

            }
            textBox1.Clear();
        }
    }
}
