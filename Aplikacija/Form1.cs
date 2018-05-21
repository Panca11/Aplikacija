using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

       private void Exit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Da li zelite da se izlogujete", "izlaz", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                this.Close();
                Logovanje l = new Logovanje();
                l.ShowDialog();
            }
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {/*
            // TODO: This line of code loads data into the 'eDUDataSet.tab_Kase' table. You can move, or remove it, as needed.
            this.tab_KaseTableAdapter.Fill(this.eDUDataSet.tab_Kase);
            // TODO: This line of code loads data into the 'eDUDataSet.tab_Objekti' table. You can move, or remove it, as needed.
            this.tab_ObjektiTableAdapter.Fill(this.eDUDataSet.tab_Objekti);
            */
        }

       /* private void pictureBox1_Click(object sender, EventArgs e)
        {

        }*/
    }
}
