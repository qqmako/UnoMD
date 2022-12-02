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
    public partial class update_comenzi : Form
    {
        Conectare conn = new Conectare();
        SqlCommand cmd;

        public update_comenzi()
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
            comboBox1.ResetText();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(comboBox1.Text == "Numarul Comenzii")
                try
                {
                    cmd = new SqlCommand("UPDATE Comenzi SET Nr_Comenzii = " + textBox2.Text + 
                        " WHERE Id_Comanda = " + textBox1.Text + ";", conn.OpenConn());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(" Datele au fost actualizate cu succes! ");
                }
                catch (Exception)
                {

                }
            //
            if (comboBox1.Text == "ID Produs")
                try
                {
                    cmd = new SqlCommand("UPDATE Comenzi SET Id_Produs = " + textBox2.Text +
                        " WHERE Id_Comanda = " + textBox1.Text + ";", conn.OpenConn());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(" Datele au fost actualizate cu succes! ");
                }
                catch (Exception)
                {

                }
            //
            if (comboBox1.Text == "Data Comenzii")
                try
                {
                    cmd = new SqlCommand("UPDATE Comenzi SET DataComenzii = '" + textBox2.Text +
                        "' WHERE Id_Comanda = " + textBox1.Text + ";", conn.OpenConn());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(" Datele au fost actualizate cu succes! ");
                }
                catch (Exception)
                {

                }
            //
            if (comboBox1.Text == "Adresa")
                try
                {
                    cmd = new SqlCommand("UPDATE Comenzi SET Adresa = '" + textBox2.Text +
                        "' WHERE Id_Comanda = " + textBox1.Text + ";", conn.OpenConn());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(" Datele au fost actualizate cu succes! ");
                }
                catch (Exception)
                {

                }



            Reset();
        }
    }
}
