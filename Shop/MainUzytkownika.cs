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
    public partial class MainUzytkownika : Form
    {
        public MainUzytkownika()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Wypozyczalnia w = new Wypozyczalnia();
            w.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Zwrot z = new Zwrot();
            z.Show();
        }

        private void button1_Click(object sender, EventArgs e)
       {
       //     rejestracjaProduktu c = new rejestracjaProduktu();
       //     c.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 r = new Form1();
            this.Close();
            r.Show();
        }
    }
}
