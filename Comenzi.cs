using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnoMD
{
    public partial class Comenzi : Form
    {
        public Comenzi()
        {
            InitializeComponent();
        }

        private void Comenzi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'unoMDDataSet.Comenzi' table. You can move, or remove it, as needed.
            this.comenziTableAdapter.Fill(this.unoMDDataSet.Comenzi);

            if (Logare.UserName != "admin")
            {
                delete.Enabled = false;
                update.Enabled = false;
            }
                

        }

        private void add_Click(object sender, EventArgs e)
        {
            Add_Comenzi f1 = new Add_Comenzi();
            f1.Show();
            
        }

        private void back_Click(object sender, EventArgs e)
        {
            Pag_Principala f1 = new Pag_Principala();
            f1.Show();
            this.Hide();
        }

        private void update_Click(object sender, EventArgs e)
        {
            update_comenzi f1 = new update_comenzi();
            f1.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.comenziTableAdapter.Fill(this.unoMDDataSet.Comenzi);
        }

        private void delete_Click(object sender, EventArgs e)
        {
            delete_comenzi f1 = new delete_comenzi();
            f1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Find2 f1 = new Find2();
            f1.Show();
        }
    }
}
