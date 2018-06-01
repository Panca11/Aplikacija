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
        public static string connString = Properties.Settings.Default.EDUConnectionString2;
        SqlConnection kon = new SqlConnection(connString);


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



        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eDUDataSet2.tab_Logovi' table. You can move, or remove it, as needed.
          //  this.tab_LogoviTableAdapter.Fill(this.eDUDataSet2.tab_Logovi);
            // TODO: This line of code loads data into the 'eDUDataSet5.tab_Objekti' table. You can move, or remove it, as needed.
            this.tab_ObjektiTableAdapter2.Fill(this.eDUDataSet5.tab_Objekti);
            // TODO: This line of code loads data into the 'eDUDataSet4.tab_Kase' table. You can move, or remove it, as needed.
            this.tab_KaseTableAdapter2.Fill(this.eDUDataSet4.tab_Kase);
            // TODO: This line of code loads data into the 'eDUDataSet2.tab_Kase' table. You can move, or remove it, as needed.


            // prikaz svih logova
            using (SqlConnection sqlConn = new SqlConnection(connString))
            {
                string sqlQuery = @"SELECT * from dbo.LOGOVI";
                SqlCommand cmd = new SqlCommand(sqlQuery, sqlConn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                da.Fill(table);
                dataGridView3.DataSource = new BindingSource(table, null);

            }


             dataGridView3.DefaultCellStyle.BackColor = Color.Yellow;


              // poredjenje i bojenje za datagrid objekata
              for (int i = 0; i < dataGridView2.Rows.Count; i++)
              {
                  for (int j = 0; j < dataGridView3.Rows.Count; j++)
                  {
                      int a, b = 0;
                      try
                      {
                          a = Convert.ToInt32(dataGridView2.Rows[i].Cells[0].Value);
                          b = Convert.ToInt32(dataGridView3.Rows[j].Cells[1].Value);
                          if (a == b)
                          {
                              dataGridView2.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                          }
                      }
                      catch(Exception ex)
                      {
                          MessageBox.Show(ex.Message);
                      }
                  }
              }

            bojiObjekte();
              bojiKase();
          }

          public void bojiKase()
          {
              // poredjenje i bojenje za datagrid kasa
              for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
              {
                  for (int j = 0; j < dataGridView3.Rows.Count; j++)
                  {
                      int c, d = 0;

                      if (dataGridView3.Rows[j].Cells[2].Value != "")
                      {
                          c = Convert.ToInt32(dataGridView3.Rows[j].Cells[2].Value);
                          d = Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value);
                          if (c == d)
                          {
                              dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                          }
                      }
                  }
              }
          }
        public void bojiObjekte()
        {
            // poredjenje i bojenje za datagrid objekata
            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView3.Rows.Count; j++)
                {
                    int a, b = 0;
                    a = Convert.ToInt32(dataGridView2.Rows[i].Cells[1].Value);
                    b = Convert.ToInt32(dataGridView3.Rows[j].Cells[1].Value);
                    if (a == b)
                    {
                        dataGridView2.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                    }
                }
            }
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
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = @"Data Source=localhost;Initial Catalog=EDU;Integrated Security=True";
            connection.Open();

            DateTime dt = DateTime.Now;

            SqlCommand cmd1 = new SqlCommand("update tab_Logovi set logout=@values ,Aktivnost=0 ", connection);
            cmd1.Parameters.AddWithValue("@values", dt);
            cmd1.ExecuteNonQuery();
            connection.Close();
        }



        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            //  MessageBox.Show(dataGridObjekat.CurrentCell.Value.ToString());
            if (dataGridView2.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridView2.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dataGridView2.Rows[selectedrowindex];
                string objekat = Convert.ToString(selectedRow.Cells[1].Value);

                SqlConnection kon = new SqlConnection();
                kon.ConnectionString = @"Data Source=localhost;Initial Catalog=EDU;Integrated Security=True";
                kon.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT * from dbo.tab_Kase where sif_obj=" + objekat + ";", kon))
                {

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    da.Fill(table);
                    dataGridView1.DataSource = new BindingSource(table, null);
                }
             //   bojiObjekte();
               bojiKase();
                kon.Close();
            }
        }

        private void btnNoviObjekat_Click(object sender, EventArgs e)
        {
            this.Hide();
            
            FormDodajObj frm = new FormDodajObj();
            frm.ShowDialog();
        }

        private void btnSveKase_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlConn = new SqlConnection(connString))
            {
                string sqlQuery = @"SELECT * from dbo.tab_Kase";
                SqlCommand cmd = new SqlCommand(sqlQuery, sqlConn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                da.Fill(table);
                dataGridView1.DataSource = new BindingSource(table, null);
            }
        }

        private void dataGridView3_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Da li zelite da sacuvate promene?", "Potvrda", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                
                try
                {
                    this.tab_KaseTableAdapter2.Update(this.eDUDataSet4.tab_Kase);
                    MessageBox.Show("Uspesno unete izmene.", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Greska: " + ex.Message);
                }
            }
            else
            {
                this.tab_KaseTableAdapter2.Fill(this.eDUDataSet4.tab_Kase);
            }
            Form1 pk = new Form1();
            pk.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                DataRowView drv = dataGridView1.CurrentRow.DataBoundItem as DataRowView;
                DataRow[] rowsToUpdate = new DataRow[] { drv.Row };

                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM dbo.tab_Objekti", kon);
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                adapter.Update(rowsToUpdate);

                MessageBox.Show("Uspesno izmenjeni podaci!", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
