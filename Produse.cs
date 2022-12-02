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
    public partial class Produse : Form
    {
        public Produse()
        {
            InitializeComponent();
        }

        private void Produse_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'unoMDDataSet.Produse' table. You can move, or remove it, as needed.
            this.produseTableAdapter.Fill(this.unoMDDataSet.Produse);

            if (Logare.UserName != "admin")
            {
                delete.Enabled = false;
                update.Enabled = false;
            }



        }

        private void add_Click(object sender, EventArgs e)
        {
            Add_Produse f1 = new Add_Produse();
            f1.Show();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Pag_Principala f1 = new Pag_Principala();
            f1.Show();
            this.Hide();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.produseTableAdapter.Fill(this.unoMDDataSet.Produse);
        }

        private void delete_Click(object sender, EventArgs e)
        {
            delete_produse f1 = new delete_produse();
            f1.Show();
        }

        private void update_Click(object sender, EventArgs e)
        {
            update_produse f1 = new update_produse();
            f1.Show();
        }
    }
}
