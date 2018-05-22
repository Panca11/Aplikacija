﻿using System;
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
             
        }
        private int numberPass(string pass)     //provera da li ima broja
        {
            int num = 0;
            foreach (char ch in pass)
            {
                num++;
            }
            return num;
        }
        private int upperCase(string pass)      //provera da li ima velikih slova
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
            SqlConnection konekcija = new SqlConnection(conn);
            StringBuilder sb = new StringBuilder();
            StringBuilder sb1 = new StringBuilder();


            sb1.Append("select id from tab_Logovanje where Username=@usr ");


            SqlCommand komanda1 = new SqlCommand(sb1.ToString(),konekcija);
            komanda1.Parameters.AddWithValue("@usr", tbKorisnickoIme.Text);
            konekcija.Open();
            var rez = komanda1.ExecuteScalar();
            if (rez != null)
            {
                MessageBox.Show("Korisnicko ime vec postoji");
                res();
                return;

            }

            konekcija.Close();
                const int MIN_LENGHT = 5;//sifra mora imati minimum 10 karaktera
                string username = tbKorisnickoIme.Text;
                string pass = tbSifra.Text;
                if (string.IsNullOrEmpty(tbKorisnickoIme.Text) || string.IsNullOrEmpty(tbIme.Text) || string.IsNullOrEmpty(tbPrezime.Text) || string.IsNullOrEmpty(tbSifra.Text))//provera unesene sifre
                {
                    MessageBox.Show("Morate popuniti sva polja");

                }
                else
                {
                try
                {
                    if (pass.Length >= MIN_LENGHT && numberPass(pass) >= 1 && upperCase(pass) >= 1)
                    {
                        MessageBox.Show("Sifra je neispravna.");
                    }

                    else
                    {


                        sb.Append("INSERT INTO tab_Logovanje");
                        sb.Append("(Username, password, Aktivnost, name, lastname, Admin)");
                        sb.Append("VALUES (@username, @password, @aktivnost, @name, @lastname, @Admin) ");

                        SqlCommand komanda = new SqlCommand(sb.ToString(), konekcija);

                        SqlParameter usernameParam = new SqlParameter("@Username", SqlDbType.VarChar, 50);
                        SqlParameter passwordParam = new SqlParameter("@password", SqlDbType.VarChar, 50);
                        SqlParameter aktivnostParam = new SqlParameter("@Aktivnost", SqlDbType.Int);
                        SqlParameter nameParam = new SqlParameter("@name", SqlDbType.VarChar, 50);
                        SqlParameter lastnameParam = new SqlParameter("@lastname", SqlDbType.VarChar, 50);
                        SqlParameter idParam = new SqlParameter("@id", SqlDbType.Int);
                        SqlParameter korisnikParam = new SqlParameter("@Admin", SqlDbType.VarChar, 50);


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
                            korisnikParam.Value = 0;//Postavlja se da ima ulogu korisnika
                        }
                        else
                        {
                            korisnikParam.Value = 1; //Postavlja se da ima ulogu admina
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



        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Da li ste sigurni da zelite da izadjete iz registracije", "Izlaz", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Close();
                Form1 frm = new Form1();
                frm.ShowDialog();
            }
        }
        private void res()
        {
            tbIme.Clear();
            tbKorisnickoIme.Clear();
            tbPrezime.Clear(); tbIme.Clear();
            cbKorisnik.Checked = false;
            tbSifra.Clear();
        }
        private void btnResetuj_Click(object sender, EventArgs e)
        {

            res();
        }
    }
        
        
    }
