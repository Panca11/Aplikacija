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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Da li ste sigurni da zelite da izadjete iz registracije", "Izlaz", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                
                Logovanje frm = new Logovanje();
                this.Hide();
                frm.ShowDialog();
                LoginTrack();
                this.Hide();
               

            }

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eDUDataSet1.tab_Objekti' table. You can move, or remove it, as needed.
            this.tab_ObjektiTableAdapter.Fill(this.eDUDataSet1.tab_Objekti);
            // TODO: This line of code loads data into the 'eDUDataSet.tab_Kase' table. You can move, or remove it, as needed.
            this.tab_KaseTableAdapter.Fill(this.eDUDataSet.tab_Kase);

        }
        private void LoginTrack()
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = @"Data Source=localhost;Initial Catalog=EDU;Integrated Security=True";
            connection.Open();

            DateTime dt = DateTime.Now;

            SqlCommand cmd1 = new SqlCommand("update tab_Logovi set logout=@values ,Aktivnost=0 ", connection);
            cmd1.Parameters.AddWithValue("@values", dt);
            cmd1.ExecuteNonQuery();
            connection.Close();
        }
    }
}
