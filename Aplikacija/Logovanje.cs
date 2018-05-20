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


namespace Aplikacija
{
    public partial class Logovanje : Form
    {
        public Logovanje()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Da li ste sigurni da zelite da ugasite aplikaciju", "Izlaz", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
           
        private void btnLogovanje_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbKorisnickoIme.Text) || string.IsNullOrEmpty(tbSifra.Text))//proverava da li su sva polja popunjena
            {
                MessageBox.Show("Morate popuniti polja za login");
            }
            else
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=localhost;Initial Catalog=EDU;Integrated Security=True";



                SqlCommand cmd = new SqlCommand("select count (*) as cnt from tab_Logovanje where Username=@usr and password=@pass", con);
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@usr", tbKorisnickoIme.Text);//uzima podatke sa forme
                cmd.Parameters.AddWithValue("@pass", tbSifra.Text);
<<<<<<< HEAD
                //SqlDataAdapter sda = new SqlDataAdapter("select role from tab_Logovanje where Username=" + tbKorisnickoIme.Text + "and password=" + tbSifra.Text, con);
                con.Open();
                
                //DataTable dt = new System.Data.DataTable();
                //sda.Fill(dt);
                if (cmd.ExecuteScalar().ToString() == "1")//proverava uzete podatke sa forme 
                {
                    /*switch (dt.Rows[0]["Role"] as string)
                    {
                        case "Admin":
                            {
                                this.Hide();
                                Form1 ss = new Form1();
                                ss.Show();
                                break;
                            }
=======

                con.Open();
                if (cmd.ExecuteScalar().ToString() == "1")//proverava uzete podatke sa forme 
                {
                    SqlConnection connection = new SqlConnection();
                    connection.ConnectionString = @"Data Source=localhost;Initial Catalog=EDU;Integrated Security=True";

                    connection.Open();
                    string query = "SELECT role FROM tab_Logovanje WHERE [role] = 'Admin'";

                    SqlCommand command = new SqlCommand(query, connection);
>>>>>>> 9ca54c1907d055fce8a7f94437142029f1baa493

                    String role = command.ExecuteScalar().ToString();

                    if (role == "True")
                    {
                        connection.Close();
                        MessageBox.Show("Uspesan login");
                        Form1 frm = new Form1();
                        this.Hide();    
                        frm.Show();
                    }
<<<<<<< HEAD
                            MessageBox.Show("Uspesan login");*/
                    Form1 frm = new Form1();
                    this.Hide();
                    frm.Show();
=======
                    else
                    {
                        Form2 frm2 = new Form2();
                        frm2.Show();
                        this.Hide();
                    }

                    
>>>>>>> 9ca54c1907d055fce8a7f94437142029f1baa493
                }
                else
                {
                    MessageBox.Show("Proverite korisnicko ime i lozinku");
                    tbKorisnickoIme.Clear();
                    tbSifra.Clear();
                }
            }


            
        }
    }
}
