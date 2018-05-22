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
    public partial class PKorisnika : Form
    {
        public PKorisnika()
        {
            InitializeComponent();
        }

        private void PKorisnika_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eDUDataSet6.tab_Logovanje' table. You can move, or remove it, as needed.
            this.tab_LogovanjeTableAdapter1.Fill(this.eDUDataSet6.tab_Logovanje);
            // TODO: This line of code loads data into the 'eDUDataSet3.tab_Logovanje' table. You can move, or remove it, as needed.
            //this.tab_LogovanjeTableAdapter.Fill(this.eDUDataSet3.tab_Logovanje);

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Da li ste sigurni da napustite pregled korisnika", "Izlaz", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                this.Hide();
                Form1 frm = new Form1();
                frm.Show();
                    
            }

        }

        private void btnOdobri_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Da li zelite da sacuvate promene?", "Potvrda", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                
                try
                {                    
                    this.tab_LogovanjeTableAdapter1.Update(eDUDataSet6.tab_Logovanje);
                    MessageBox.Show("Uspesno unete izmene.","Obavestenje",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                   

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Greska: " + ex.Message);
                }
            }
            else
            {                
                this.tab_LogovanjeTableAdapter1.Fill(this.eDUDataSet6.tab_Logovanje);
                }
            PKorisnika pk = new PKorisnika();
            pk.Show();
            

        }
    }
}
