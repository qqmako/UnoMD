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
    public partial class Find2 : Form
    {
        Conectare conn = new Conectare();
        public Find2()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            //converteste in formatul dat
            DateTime start = monthCalendar1.SelectionRange.Start;
            string formattedStart = start.ToString("dd-MM-yyyy");

            

            try
            {
                SqlDataAdapter sqlA = new SqlDataAdapter("Select * from Comenzi where DataComenzii = '" + formattedStart +"';", conn.OpenConn());
                DataTable dt = new DataTable();
                sqlA.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception)
            {
                MessageBox.Show("Eroare !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
