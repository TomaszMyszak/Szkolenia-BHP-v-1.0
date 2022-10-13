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

namespace SzkoleniaBHP
{
    public partial class dodajPracowika : Form
    {
        public dodajPracowika()
        {
            InitializeComponent();
        }

        private void save_Click(object sender, EventArgs e)
        {
            dodaj();
        }

        void dodaj()
        {

            SqlConnection polczenie = new SqlConnection();
            polczenie.ConnectionString = "Data Source=DESKTOP-CAJMLL5,1433;Initial Catalog=szkoleniaBHP;User ID=sa;Password=Tommys#1978;";


            /*
            autoNR = ;
            nazwa = textBox1.Text;
            ulica = textBox2;
            nr = textBox3.Text;
            kod = textBox4.Text;
            miasto = textBox5.Text;
            wojewodztwo = textBox6.Text;
            telefon = textBox7.Text;
            fax = textBox8.Text;
            www = textBox9.Text;
            email = textBox10.Text;
            notatki = textBox11.Text;
            */

            string addFirm = "INSERT INTO PRACOWNIK(IMIE, NAZWISKO, ULICA, NR, KODPOCZTOWY, MIASTO, WOJEWODZTWO, TELEFON, EMAIL, NOTATKI, NAZWA, FIRMYID) VALUES ('" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "', '" + textBox4.Text + "', '" + textBox5.Text + "', '" + textBox6.Text + "', '" + textBox7.Text + "', '" + textBox8.Text + "', '" + textBox9.Text + "', '" + textBox10.Text + "', '" + textBox11.Text + "', '" + textBox12.Text + "');";

           

            try
            {
                SqlCommand command = new SqlCommand(addFirm, polczenie);
                polczenie.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        MessageBox.Show(String.Format("{0}, {1}",
                            reader[0], reader[1]));
                        MessageBox.Show("Poprawnie dodano firmę" + textBox1.Text.ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                string error = string.Format("Błąd:  " + ex.Message);
                MessageBox.Show(error, "Bład", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                polczenie.Close();
            }

        }

        private void dodajPracowika_Load(object sender, EventArgs e)
        {
            
        }
    }
}
