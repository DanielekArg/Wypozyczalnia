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
    public partial class Klient : Form
    {
        public Klient()
        {
            InitializeComponent();     
            Autono();
            load();
        }

        SqlConnection con = new SqlConnection("Server=DESKTOP-NR3O8KG; Initial Catalog=Rental; Trusted_Connection=true;MultipleActiveResultSets=False;");
        SqlCommand cmd;
        SqlDataReader dr;
        string proid;
        string sql;
        bool Mode = true;
        string op;

        public void Autono()
        {
            sql = "select IdKlienta from Użytkownik order by IdKlienta desc";
            cmd = new SqlCommand(sql, con);
            con.Open();
            dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                int op = int.Parse(dr[0].ToString()) + 1;
                proid = op.ToString("0");
            }
            else if (Convert.IsDBNull(dr))
            {
                proid = ("1");
            }
            else
            {
                proid = ("1");
            }

            txtId.Text = proid.ToString();

            con.Close();

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                string IdKlienta = txtId.Text;
                string Imie = txtImie.Text;
                string Nazwisko = txtNazwisko.Text;
                string Adres = txtAdres.Text;
                string Telefon = txtTelefon.Text;

               op = dataGridView1.CurrentRow.Cells[0].Value.ToString();

                if (Mode == true)
                {
                    sql = "insert into Użytkownik(IdKlienta,Imie,Nazwisko,Adres,Telefon)values(@IdKlienta,@Imie,@Nazwisko,@Adres,@Telefon)";
                    con.Open();
                    cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@IdKlienta", IdKlienta);
                    cmd.Parameters.AddWithValue("@Imie", Imie);
                    cmd.Parameters.AddWithValue("@Nazwisko", Nazwisko);
                    cmd.Parameters.AddWithValue("@Adres", Adres);
                    cmd.Parameters.AddWithValue("@Telefon", Telefon);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Dodanie");

                    txtImie.Clear();
                    txtNazwisko.Clear();
                    txtAdres.Clear();
                    txtTelefon.Clear();


                    txtImie.Focus();

                }
                else
                {
                    sql = "update RejestracjaProduktu set Imie = @Imie,Nazwisko= @Nazwisko, Adres = @Adres, Telefon = @Telefon, where IdKlienta = @IdIdKlienta";
                    con.Open();
                    cmd = new SqlCommand(sql, con);

                    cmd.Parameters.AddWithValue("@Imie", Imie);
                    cmd.Parameters.AddWithValue("@Nazwisko", Nazwisko);
                    cmd.Parameters.AddWithValue("@Adres", Adres);
                    cmd.Parameters.AddWithValue("@Telefon", Telefon);

                    cmd.Parameters.AddWithValue("@IdKlienta", op);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Uaktualniono");
                    txtId.Enabled = true;
                    Mode = true;


                    txtImie.Clear();
                    txtNazwisko.Clear();
                    txtAdres.Clear();
                    txtTelefon.Clear();


                    txtImie.Focus();


                }

                con.Close();
            }
        

        public void load()
        {
            sql = "select * from Użytkownik";
            cmd = new SqlCommand(sql, con);
            con.Open();
            dr = cmd.ExecuteReader();
            dataGridView1.Rows.Clear();

            while (dr.Read())
            {
                dataGridView1.Rows.Add(dr[0], dr[1], dr[2], dr[3], dr[4]);
            }
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            {
                load();
                Autono();

                txtImie.Clear();
                txtNazwisko.Clear();
                txtAdres.Clear();
                txtTelefon.Clear(); 
                txtImie.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
