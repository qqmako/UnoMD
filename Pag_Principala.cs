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
    public partial class Pag_Principala : Form
    {
        public Pag_Principala()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Produse f1 = new Produse();
            f1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Comenzi f1 = new Comenzi();
            f1.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Categorii f1 = new Categorii();
            f1.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Raport_Suma f1 = new Raport_Suma();
            f1.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Report_comenzi f1 = new Report_comenzi();
            f1.Show();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            const string message = "Doriti sa inchideti ?";
            const string caption = "Iesire";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
