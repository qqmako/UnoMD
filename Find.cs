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
    public partial class Find : Form
    {
        Conectare conn = new Conectare();
        
        public Find()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter sqlA = new SqlDataAdapter("select Den_Produs" +
                 " from Produse p" +
                 " inner join Categorii c " +
                 "on p.Id_Categorie = c.Id_Categorie" +
                 " where p.Id_Categorie = " + textBox1.Text + ";", conn.OpenConn());
                DataTable dt = new DataTable();
                sqlA.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch(Exception )
            {
                MessageBox.Show("Eroare !","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

           
        }
    }
}
