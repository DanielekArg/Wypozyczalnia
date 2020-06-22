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

namespace Shop
{
    public partial class Wypozyczalnia : Form
    {
        public Wypozyczalnia()
        {
            InitializeComponent();
            productload();
            wypload();
            
        }

        SqlConnection con = new SqlConnection("Server=DESKTOP-NR3O8KG; Initial Catalog=Rental; Trusted_Connection=true;MultipleActiveResultSets=False;");
        SqlCommand cmd;
        SqlCommand cmd1;
        SqlDataReader dr;
        string proid;
        string sql;
        string sql1;


        public void productload()
        {
            cmd = new SqlCommand("select * from RejestracjaProduktu", con);
            con.Open();
            dr = cmd.ExecuteReader();

            while(dr.Read())
            {
                txtProduktu.Items.Add(dr["Nazwa"].ToString());
            }
            con.Close();

        }

        public void wypload()
        {
            sql = "select * from Wypozyczenie";
            cmd = new SqlCommand(sql, con);
            con.Open();
            dr = cmd.ExecuteReader();
            dataGridView1.Rows.Clear();

            while (dr.Read())
            {
               dataGridView1.Rows.Add(dr[0], dr[1], dr[2], dr[3], dr[4], dr[5], dr[6]);
            }
            con.Close();
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtProduktu_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmd = new SqlCommand("select * from RejestracjaProduktu where Nazwa = '" + txtProduktu.Text + "' ", con);
            con.Open();
            dr = cmd.ExecuteReader();

            if(dr.Read())
            {
                string dost;

                dost = dr["Dostepnosc"].ToString();

                label9.Text = dost;

                if(dost == "Nie")
                {

                    txtIdKlienta.Enabled = false;
                    txtImieKlienta.Enabled = false;
                    textBox1.Enabled = false;
                    txtOplata.Enabled = false;
                    txtDataWyp.Enabled = false;
                    txtDataOddania.Enabled = false;

                }
                else if (dost == "Tak")
                {

                    txtIdKlienta.Enabled = true;
                    txtImieKlienta.Enabled = true;
                    textBox1.Enabled = true;
                    txtOplata.Enabled = true;
                    txtDataWyp.Enabled = true;
                    txtDataOddania.Enabled = true;

                }
            } 
            
            

            con.Close();
        }

        private void txtIdKlienta_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == 13)
            {

                cmd = new SqlCommand("select * from Użytkownik where IdKlienta = '" + txtIdKlienta.Text + "' ", con);
                con.Open();
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    txtImieKlienta.Text = dr["Imie"].ToString();
                    textBox1.Text = dr["Nazwisko"].ToString();

                }
                else
                {
                    MessageBox.Show("Nie jest dostępny ten numer ID");
                }
                con.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
               
                string NazwaProduktu = txtProduktu.SelectedItem.ToString();
                string IdKlient = txtIdKlienta.Text;
                string KlientImie = txtImieKlienta.Text;
                string Oplata = txtOplata.Text;
                string datawyp = txtDataWyp.Value.Date.ToString("yyyy-MM-dd");
                string dataodd = txtDataOddania.Value.Date.ToString("yyyy-MM-dd");

           
                    sql = "insert into Wypozyczenie(Nazwa_Produktu,IdKlienta,Imie_klienta,Oplata,Data_wypozyczenia,Data_oddania)values(@Nazwa_Produktu,@IdKlienta,@Imie_klienta,@Oplata,@Data_wypozyczenia,@Data_oddania)";
                    con.Open();
                    cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@Nazwa_Produktu", NazwaProduktu);
                    cmd.Parameters.AddWithValue("@IdKlienta", IdKlient);
                    cmd.Parameters.AddWithValue("@Imie_klienta", KlientImie);
                    cmd.Parameters.AddWithValue("@Oplata", Oplata);
                    cmd.Parameters.AddWithValue("@Data_wypozyczenia", datawyp);
                    cmd.Parameters.AddWithValue("@Data_oddania", dataodd);
                    
                    cmd.ExecuteNonQuery();
                 


            MessageBox.Show("Dodanie");

            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            productload();
            wypload();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Wypozyczalnia_Load(object sender, EventArgs e)
        {

        }
    }
    }
