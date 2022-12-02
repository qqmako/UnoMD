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
    public partial class update_produse : Form
    {
        Conectare conn = new Conectare();
        SqlCommand cmd;

        public update_produse()
        {
            InitializeComponent();
        }

        void Reset()
        {
            textBox1.Clear();
            textBox2.Clear();
            comboBox1.ResetText();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Categorie")
                try
                {
                    cmd = new SqlCommand("UPDATE Produse SET Id_Categorie = " + textBox2.Text +
                        " WHERE Id_Produs = " + textBox1.Text + ";", conn.OpenConn());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(" Datele au fost actualizate cu succes! ");
                }
                catch (Exception)
                {

                }
            //
            if (comboBox1.Text == "Denumire")
                try
                {
                    cmd = new SqlCommand("UPDATE Produse SET Den_Produs = '" + textBox2.Text +
                        "' WHERE Id_Produs = " + textBox1.Text + ";", conn.OpenConn());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(" Datele au fost actualizate cu succes! ");
                }
                catch (Exception)
                {

                }
            //
            if (comboBox1.Text == "Pret")
                try
                {
                    cmd = new SqlCommand("UPDATE Produse SET Pret = " + textBox2.Text +
                        " WHERE Id_Produs = " + textBox1.Text + ";", conn.OpenConn());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(" Datele au fost actualizate cu succes! ");
                }
                catch (Exception)
                {

                }
            //

            Reset();
            

        }
    }
}
