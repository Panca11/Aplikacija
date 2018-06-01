using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplikacija
{
    public partial class FormDodajObj : Form
    {
        public FormDodajObj()
        {
            InitializeComponent();
        }
        string conn = ("Data Source=localhost;Initial Catalog=EDU;Integrated Security=True");
        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
            {
                SqlConnection Konekcija = new SqlConnection(conn);
            StringBuilder sb = new StringBuilder();
            Konekcija.Open();

            Regex r = new Regex("^[0-9]*$");
            if (r.IsMatch(tbSifraObjekta.Text))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM tab_Objekti", Konekcija);

                DataSet ds = new DataSet();
                da.Fill(ds, "tab_Objekti");

                DataTable dt = ds.Tables["tab_Objekti"];
                DataRow NoviRed = dt.NewRow();
                try
                {
                    NoviRed["sif_obj"] = tbSifraObjekta.Text;
                    NoviRed["ip_adresa"] = tbIpAdresa.Text;
                    NoviRed["TipBO"] = comboBox1.SelectedItem.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                dt.Rows.Add(NoviRed);


                SqlConnection kon = new SqlConnection(conn);
                SqlCommand cmd = new SqlCommand("Select id from tab_Objekti where sif_obj= @sifobj", kon);
                cmd.Parameters.AddWithValue("@sifobj", this.tbSifraObjekta.Text);
                kon.Open();

                var nId = cmd.ExecuteScalar();

                    if (nId != null)
                    {
                        MessageBox.Show("Objekat sa unetom sifrom vec postoji  !");
                    }
                    else
                    {
                        string SQLInsert = String.Format("INSERT INTO tab_Objekti(sif_obj, ip_adresa, TipBO) " +
                        "VALUES ('{0}','{1}','{2}');", Convert.ToInt32(tbSifraObjekta.Text), tbIpAdresa.Text, comboBox1.SelectedItem.ToString());


                        da.InsertCommand = new SqlCommand(SQLInsert, kon);

                        int brRedova = 0;

                        try
                        {
                            brRedova = da.Update(dt);
                            MessageBox.Show("Registracija je uspesno obavljena", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            this.Close();
                            Form1 f = new Form1();
                            f.Show();

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);

                        }
                        finally
                        {
                            this.Close();
                        }
                    }
                }
            }
        }
            


        //   StringBuilder sb1 = new StringBuilder();

        //     sb1.Append("select id from tab_Logovanje where Username=@usr ");

        //     SqlCommand komanda1 = new SqlCommand(sb1.ToString(), konekcija);
        //   komanda1.Parameters.AddWithValue("@usr", tbKorisnickoIme.Text);


        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Da li ste sigurni da zelite da zatvorite formu", "Izlaz", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                this.Hide();
                Form1 frm = new Form1();
                frm.Show();
            }
        }

        private void tbSifraObjekta_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if ( ch != 8 && ch != 46 && !Char.IsNumber(ch))
            {
                e.Handled = true;
            }
        }
    }
}
