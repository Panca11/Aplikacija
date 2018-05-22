
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
                MessageBox.Show("Morate popuniti polja za login.", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=localhost;Initial Catalog=EDU;Integrated Security=True";



                SqlCommand cmd = new SqlCommand("select count (*) as cnt from tab_Logovanje where Username=@usr and password=@pass", con);
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@usr", tbKorisnickoIme.Text);//uzima podatke sa forme
                cmd.Parameters.AddWithValue("@pass", tbSifra.Text);

                con.Open();


                if (cmd.ExecuteScalar().ToString() == "1")//proverava uzete podatke sa forme 
                {
                    SqlConnection connection = new SqlConnection();
                    connection.ConnectionString = @"Data Source=localhost;Initial Catalog=EDU;Integrated Security=True";

                    string query = "SELECT Admin FROM tab_Logovanje WHERE [Admin] = 1 and [Username] = @usr AND [password] = @password " ;
                    string query2 = "SELECT Admin FROM tab_Logovanje WHERE [Admin] = 1 and [Username] = @usr AND [password] = @password and [Aktivnost]=False";
                    string query3 = "SELECT Admin FROM tab_Logovanje WHERE [Admin] = 1 and [Username] = @usr AND [password] = @password and [Aktivnost]=False";
                //    if (string query1 = "SELECT Admin FROM tab_Logovanje WHERE [Admin] = 1 and [Username] = @usr AND [password] = @password ")
                if(query2==query3)
                    {
                        MessageBox.Show("Nemate pristum serveru", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        return;
                    }

                    DataTable dt = new DataTable();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@usr", tbKorisnickoIme.Text);
                    command.Parameters.AddWithValue("@password", tbSifra.Text);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dt);
                        if (dt.Rows.Count > 0)
                        {

                            MessageBox.Show("Uspesno ste se ulogovali", "Uspesan login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Form1 frm = new Form1();
                            this.Hide();
                            frm.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("Uspesno ste se ulogovali", "Uspesan login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Form2 frm2 = new Form2();
                            this.Hide();
                            frm2.ShowDialog();
                        }
                    }

                    connection.Close();

                }

                else

                {
                    MessageBox.Show("Proverite korisnicko ime i lozinku", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbKorisnickoIme.Clear();
                    tbSifra.Clear();
                }
            }



        }

        private void tbKorisnickoIme_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                tbSifra.Focus();
        }

        private void tbSifra_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnLogovanje.Focus();
        }
    }
}
