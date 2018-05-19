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
            Application.Exit();
        }
        string conn = ("Data Source=localhost;Initial Catalog=EDU;Integrated Security=True");
        private void btnLogovanje_Click(object sender, EventArgs e)
        {
            try
            {
                if(tbKorisnickoIme.Text=="" || tbSifra.Text=="")
                {
                    MessageBox.Show("Morate popuniti sva polja.");
                }
                else
                {
                    SqlConnection con = new SqlConnection(conn);
                    SqlCommand cmd = new SqlCommand("select * from tab_Logovanje where Username=@usr and password=@pass", con);
                    cmd.Parameters.AddWithValue("@usr", tbKorisnickoIme.Text);
                    cmd.Parameters.AddWithValue("@pass", tbSifra.Text);

                    con.Open();
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    sda.Fill(ds);
                    Form1 frm = new Form1();
                    this.Hide();
                    frm.Show();
                    con.Close();
                }
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
    }
}
