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
    public partial class Registracija : Form
    {
        public Registracija()
        {
            InitializeComponent();
        }

        string conn = ("Data Source=localhost;Initial Catalog=EDU;Integrated Security=True");

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           DialogResult dr =  MessageBox.Show("Da li ste sigurni da zelite da izadjete iz registracije", "Izlaz", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Close();
                Form1 frm = new Form1();
                frm.ShowDialog();
            }       
        }
        private int numberPass(string pass)//provra da li ima broja
        {
            int num = 0;
            foreach (char ch in pass)
            {
                num++;
            }
            return num;
        }
        private int upperCase(string pass)//provera da l ima velikih slova
        {
            int num = 0;
            foreach (char ch in pass)
            {
                if(char.IsUpper(ch))
                {
                    num++;
                }
            }
            return num;
        }

        private void btnRegistracija_Click(object sender, EventArgs e)
        {
            const int MIN_LENGHT = 10;//sifra mora imati minimum 10 karaktera
                string username = tbKorisnickoIme.Text;
                string pass = tbSifra.Text;
                if(pass.Length>=MIN_LENGHT && numberPass(pass)>=1 && upperCase(pass)>=1)//provera unesene sifre
                {
                try
                {
                    if (tbKorisnickoIme.Text == "" || tbSifra.Text == "" || tbIme.Text == "" || tbPrezime.Text == "")
                    {
                        MessageBox.Show("Morate popuniti sva polja.");
                    }

                    else
                    {
                        SqlConnection konekcija = new SqlConnection(conn);
                        StringBuilder sb = new StringBuilder();

                        sb.Append("INSERT INTO tab_Logovanje");
                        sb.Append("(Username, password, Aktivnost, name, lastname, role)");
                        sb.Append("VALUES (@username, @password, @aktivnost, @name, @lastname, @role) ");

                        SqlCommand komanda = new SqlCommand(sb.ToString(), konekcija);

                        SqlParameter usernameParam = new SqlParameter("@Username", SqlDbType.VarChar, 50);
                        SqlParameter passwordParam = new SqlParameter("@password", SqlDbType.VarChar, 50);
                        SqlParameter aktivnostParam = new SqlParameter("@Aktivnost", SqlDbType.Int);
                        SqlParameter nameParam = new SqlParameter("@name", SqlDbType.VarChar, 50);
                        SqlParameter lastnameParam = new SqlParameter("@lastname", SqlDbType.VarChar, 50);
                        SqlParameter idParam = new SqlParameter("@id", SqlDbType.Int);
                        SqlParameter korisnikParam = new SqlParameter("@role", SqlDbType.VarChar, 50);


                        // uzima unete podatke iz TextBox i smesta u parametre
                        komanda.Parameters.Add(usernameParam);
                        komanda.Parameters.Add(passwordParam);
                        komanda.Parameters.Add(aktivnostParam);
                        komanda.Parameters.Add(nameParam);
                        komanda.Parameters.Add(lastnameParam);
                        komanda.Parameters.Add(korisnikParam);

                        usernameParam.Value = tbKorisnickoIme.Text;
                        passwordParam.Value = tbSifra.Text;
                        aktivnostParam.Value = "1";//Postavlja se Aktivnost na 1(true)
                        nameParam.Value = tbIme.Text;
                        lastnameParam.Value = tbPrezime.Text;
                        if (cbKorisnik.Checked)
                        {
                            korisnikParam.Value = "Korisnik";//Postavlja se da ima ulogu korisnika
                        }
                        else
                        {
                            korisnikParam.Value = "Admin"; //Postavlja se da ima ulogu admina
                        }
                        

                        try
                        {
                            konekcija.Open();
                            komanda.ExecuteNonQuery();
                            konekcija.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                            return;
                        }

                        MessageBox.Show("Uspesno ste se registovali.");

                        this.Close();
                        Logovanje log = new Logovanje();
                        log.Show();
                    }
                }


                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    throw;
                }


            }
            else
                {
                    MessageBox.Show("SIfra je neispravna");
                }
           

                              
        }
            

        }
        
        
    }
