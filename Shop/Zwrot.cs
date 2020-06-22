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
    public partial class Zwrot : Form
    {
        public Zwrot()
        {
            InitializeComponent();
            odload();
        }

        SqlConnection con = new SqlConnection("Server=DESKTOP-NR3O8KG; Initial Catalog=Rental; Trusted_Connection=true;MultipleActiveResultSets=False;");
        SqlCommand cmd;
        SqlCommand cmd1;
        SqlDataReader dr;
        string proid;
        string sql;
        string sql1;

        public void odload()
        {
            sql = "select * from Oddanie";
            cmd = new SqlCommand(sql, con);
            con.Open();
            dr = cmd.ExecuteReader();
            dataGridView1.Rows.Clear();

            while (dr.Read())
            {
                dataGridView1.Rows.Add( dr[1], dr[2], dr[3], dr[4], dr[5], dr[6]);
            }
            con.Close();
        }


        private void txtNumer_KeyPress(object sender, KeyPressEventArgs e)
        {
            {

                if (e.KeyChar == 13)
                {

                    cmd = new SqlCommand("select  Id, Nazwa_produktu,IdKlienta,Imie_klienta,Oplata,Data_wypozyczenia,Data_oddania, DATEDIFF(dd,Data_oddania,GETDATE()) as elap from Wypozyczenie where Id = '" + txtNumer.Text + "'", con);
                    con.Open();
                    dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        txtNazwa.Text = dr["Nazwa_produktu"].ToString();
                        txtIdKlienta.Text = dr["IdKlienta"].ToString();
                        txtImieKlienta.Text = dr["Imie_klienta"].ToString();
                        txtData.Text = dr["Data_oddania"].ToString();

                        string elap = dr["elap"].ToString();

                        int elapped = int.Parse(elap);

                        txtDataZwrot.Text = (elap);

                        

                        con.Close();


                    }

                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string NumerWypozyczenia = txtNumer.Text;
            string NazwaProduktu = txtNazwa.Text;
            string IdKlienta = txtIdKlienta.Text;
            string ImieKlienta = txtImieKlienta.Text;
            string DataWyp = txtData.Text;
            string DataOdd = txtDataZwrot.Text;



            sql = "insert into Oddanie(Numer_wypozyczenia,Nazwa_produktu,IdKlienta,Imie_Klienta,data_wypozyczenia,data_oddania)values(@Numer_wypozyczenia,@Nazwa_produktu,@IdKlienta,@Imie_Klienta,@data_wypozyczenia,@data_oddania)";
            con.Open();
            cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@Numer_wypozyczenia", NumerWypozyczenia);
            cmd.Parameters.AddWithValue("@Nazwa_produktu", NazwaProduktu);
            cmd.Parameters.AddWithValue("@IdKlienta", IdKlienta);
            cmd.Parameters.AddWithValue("@Imie_Klienta", ImieKlienta);
            cmd.Parameters.AddWithValue("@data_wypozyczenia", DataWyp);
            cmd.Parameters.AddWithValue("@data_oddania", DataOdd);


            cmd.ExecuteNonQuery();

            sql1 = "update Oddanie set avaible = 'NO' where Numer_wypozyczenia = @Nazwa";

            cmd1 = new SqlCommand(sql1, con);
            cmd1.Parameters.AddWithValue("@Numer_wypozyczenia", NumerWypozyczenia);


            MessageBox.Show("Dodanie");

            con.Close();
        }

            private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

            private void button1_Click(object sender, EventArgs e)
        {
            
                this.Close();
            
        }
    }
}

