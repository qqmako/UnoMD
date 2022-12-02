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
    public partial class Categorii : Form
    {
        public Categorii()
        {
            InitializeComponent();
        }

       

        private void Categorii_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'unoMDDataSet.Categorii' table. You can move, or remove it, as needed.
            this.categoriiTableAdapter.Fill(this.unoMDDataSet.Categorii);

            ///


          

            if (Logare.UserName != "admin")
            {
                delete.Enabled = false;
                update.Enabled = false;
            }
            
          //  MessageBox.Show(Logare.UserName);

        }

        private void back_Click(object sender, EventArgs e)
        {
            Pag_Principala f1 = new Pag_Principala();
            f1.Show();
            this.Hide();
        }

        private void add_Click(object sender, EventArgs e)
        {
            Add_Categorie f1 = new Add_Categorie();
            f1.Show();
        }

        private void update_Click(object sender, EventArgs e)
        {
            update_categorii f1 = new update_categorii();
            f1.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.categoriiTableAdapter.Fill(this.unoMDDataSet.Categorii);
        }

        
        private void delete_Click(object sender, EventArgs e)
        {
            delete_categorii f1 = new delete_categorii();
            f1.Show();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            try
            {
                this.categoriiTableAdapter.Fill(this.unoMDDataSet.Categorii);
            }
            catch (Exception)
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Find f1 = new Find();
            f1.Show();
        }
    }
}
