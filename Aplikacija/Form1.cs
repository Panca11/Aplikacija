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

namespace Aplikacija
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegistracija_Click(object sender, EventArgs e)
        {
            Registracija reg = new Registracija();
            this.Hide();
            reg.Show();
        }

       private void pictureBox1_Click(object sender, EventArgs e)
        {
         
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eDUDataSet5.tab_Objekti' table. You can move, or remove it, as needed.
            this.tab_ObjektiTableAdapter2.Fill(this.eDUDataSet5.tab_Objekti);
            // TODO: This line of code loads data into the 'eDUDataSet4.tab_Kase' table. You can move, or remove it, as needed.
            this.tab_KaseTableAdapter2.Fill(this.eDUDataSet4.tab_Kase);
            // TODO: This line of code loads data into the 'eDUDataSet2.tab_Kase' table. You can move, or remove it, as needed.
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Da li zelite da se izlogujete", "izlaz", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
               
                Logovanje l = new Logovanje();
                this.Hide();
                l.ShowDialog();
                LoginTrack();
                this.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            PKorisnika pk = new PKorisnika();
            pk.ShowDialog();
            this.Hide();
        }
        private void LoginTrack()
        {
           /* SqlConnection connection = new SqlConnection();
            connection.ConnectionString = @"Data Source=localhost;Initial Catalog=EDU;Integrated Security=True";
            connection.Open();

            DateTime dt = DateTime.Now;
            
            SqlCommand cmd1 = new SqlCommand("insert into tab_Logovi (logout) values (@values) ", connection);
            cmd1.Parameters.AddWithValue("@values", dt);
            cmd1.ExecuteNonQuery();
            connection.Close();*/
        }
    }
}
