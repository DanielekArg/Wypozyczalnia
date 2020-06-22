using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nazwa = txtnazwa.Text;
            string haslo = txthaslo.Text;

            if(nazwa.Equals("Admin") && haslo.Equals("123"))
            {
                Main m = new Main();
                this.Hide();
                m.Show();
            }
            else if (nazwa.Equals("Uzyt") && haslo.Equals("123"))
            {
                MainUzytkownika z = new MainUzytkownika();
                this.Hide();
                z.Show();
            }
            else
            {
                MessageBox.Show("Dane niepoprawne");
                txtnazwa.Clear();
                txthaslo.Clear();
                txtnazwa.Focus();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
