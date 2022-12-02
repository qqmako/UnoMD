using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnoMD
{
    public partial class Logare : Form
    {
        Conectare conn = new Conectare();
        //
        private static string user;

       

        public Logare()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Reset()
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Caseta fara date \n Introduceti Datele valide !");
            }
            try
            {



                string username = " ";
                string password = " ";
                string tipul = " ";
                int er = 0;

                string selectSQL = ("SELECT Nume, Parola, Tipul FROM Utilizatori;");
                SqlCommand cmd = new SqlCommand(selectSQL, conn.OpenConn());
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "Utilizator");
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                for (int i = 0; i < dt.Rows.Count; i++)
                {

                    username = dt.Rows[i]["Nume"].ToString();
                    password = dt.Rows[i]["Parola"].ToString();
                    tipul = dt.Rows[i]["Tipul"].ToString();


                    //MessageBox.Show("Nume " + username + " parola " + password + "  " + tipul);
                    if (textBox1.Text == username && textBox2.Text == password)
                    {
                        Pag_Principala f1 = new Pag_Principala();
                        f1.Show();
                        this.Hide();
                        er = 1;
                        user = textBox1.Text;
                    }

                    
                    

                }
                if(er == 0)
                {
                    MessageBox.Show("Parola sau Username incorect !");
                }
                

                

            }

            catch(Exception){
                MessageBox.Show("Eroare !");
            }

            Reset();

            
        }

            private void button2_Click(object sender, EventArgs e)
            {
                conn.CloseConn();
                Application.Exit();

            }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Pass_Reset f1 = new Pass_Reset();
            f1.Show();
            this.Hide();
        }

        private void button4_MouseDown(object sender, MouseEventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;
        }

        private void button4_MouseUp(object sender, MouseEventArgs e)
        {
            textBox2.UseSystemPasswordChar = false;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
        
        }
        public static string UserName
        {
            get { return user; }
            set { user = value; }
        }
       
    }
    }


