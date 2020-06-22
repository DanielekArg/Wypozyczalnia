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

namespace Shop
{
    public partial class rejestracjaProduktu : Form
    {
        public rejestracjaProduktu()
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
            sql = "select Id from RejestracjaProduktu order by Id desc";
            cmd = new SqlCommand(sql, con);
            con.Open();
            dr = cmd.ExecuteReader();

            if(dr.Read())
            {
                int op = int.Parse(dr[0].ToString()) + 1;
                proid = op.ToString("0");
            }    
            else if(Convert.IsDBNull(dr))
            {
                proid= ("1");
            }    
            else
            {
                proid = ("1");
            }

            txtId.Text = proid.ToString();

            con.Close();

        }


        public void load()
        {
            sql = "select * from RejestracjaProduktu";
            cmd = new SqlCommand(sql, con);
            con.Open();
            dr = cmd.ExecuteReader();
            dataGridView1.Rows.Clear();

            while(dr.Read())
            {
                dataGridView1.Rows.Add(dr[0], dr[1], dr[2], dr[3]);
            }
            con.Close();
        }


        public void getid(String op)
        {
            sql = "select * from RejestracjaProduktu where Id ='" + op + "' ";
            cmd = new SqlCommand(sql, con);
            con.Open();
            dr = cmd.ExecuteReader();

            while(dr.Read())
            {
                txtId.Text = dr[0].ToString();
                txtnazwa.Text = dr[1].ToString();
                txtkategoria.Text = dr[2].ToString();
                txtdostepnosc.Text = dr[3].ToString();
            }
            con.Close();
        }

        private void rejestracjaProduktu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Id = txtId.Text;
            string Nazwa = txtnazwa.Text;
            string Kategoria = txtkategoria.Text;
            string Dostepnosc = txtdostepnosc.SelectedItem.ToString();

            op = dataGridView1.CurrentRow.Cells[0].Value.ToString();

            if (Mode == true)
            {
                sql = "insert into RejestracjaProduktu(Id,Nazwa,Kategoria,Dostepnosc)values(@Id,@Nazwa,@Kategoria,@Dostepnosc)";
                con.Open();
                cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@Id", Id);
                cmd.Parameters.AddWithValue("@Nazwa", Nazwa);
                cmd.Parameters.AddWithValue("@Kategoria", Kategoria);
                cmd.Parameters.AddWithValue("@Dostepnosc", Dostepnosc);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Dodanie");

                txtnazwa.Clear();
                txtkategoria.Clear();
                txtdostepnosc.Items.Clear();
                txtnazwa.Focus();
               

            }
            else
            {
                sql = "update RejestracjaProduktu set Nazwa = @Nazwa,Kategoria= @Kategoria, Dostepnosc = @Dostepnosc where Id = @Id";
                con.Open();
                cmd = new SqlCommand(sql, con);
                
                cmd.Parameters.AddWithValue("@Nazwa", Nazwa);
                cmd.Parameters.AddWithValue("@Kategoria", Kategoria);
                cmd.Parameters.AddWithValue("@Dostepnosc", Dostepnosc);
                cmd.Parameters.AddWithValue("@Id", op);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Uaktualniono");
                txtId.Enabled = true;
                Mode = true;


                txtnazwa.Clear();
                txtkategoria.Clear();
                txtdostepnosc.Items.Clear();
                txtnazwa.Focus();
             

            }

            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex==dataGridView1.Columns["edytuj"].Index && e.RowIndex >=0)
            {
                Mode = false;
                txtId.Enabled = false;
                op = dataGridView1.CurrentRow.Cells[0].Value.ToString();

                getid(op);

            }
            else if (e.ColumnIndex == dataGridView1.Columns["usun"].Index && e.RowIndex >= 0)
            {
                Mode = false;
                op = dataGridView1.CurrentRow.Cells[0].Value.ToString();

                sql = "delete from RejestracjaProduktu where Id = @op";
                con.Open();
                cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@op", op);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Usunięto");
                con.Close();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            load();
            Autono();

            txtnazwa.Clear();
            txtkategoria.Clear();
            txtdostepnosc.Items.Clear();
            txtnazwa.Focus();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
