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
            // TODO: This line of code loads data into the 'eDUDataSet3.tab_Logovanje' table. You can move, or remove it, as needed.
            this.tab_LogovanjeTableAdapter.Fill(this.eDUDataSet3.tab_Logovanje);

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
    }
}
