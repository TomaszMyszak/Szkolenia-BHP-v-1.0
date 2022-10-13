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
    public partial class addFormFirm : Form
    {
        /*
        string autoNR;
        string nazwa;
        string ulica;
        string nr;
        string kod;
        string miasto;
        string wojewodztwo;
        string telefon;
        string fax;
        string www;
        string email;
        string notatki;
        */
        private void save_Click(object sender, EventArgs e)
        {
            dodaj();
        }

        public addFormFirm()
        {
            InitializeComponent();
        }


        
            


        void dodaj()
        {
            
            SqlConnection polczenie = new SqlConnection();
            polczenie.ConnectionString = "Data Source=DESKTOP-CAJMLL5,1433;Initial Catalog=szkoleniaBHP;User ID=sa;Password=Tommys#1978;";


            listaSzkolen lista = new listaSzkolen();
            
                     

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
             
            string addFirm = "INSERT INTO FIRMY(NAZWA, ULICA, NR, KODPOCZTOWY, MIASTO, WOJEWODZTWO, TELEFON, FAX, WWW, EMAIL, NOTATKI) VALUES ('" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "', '" + textBox4.Text+ "', '" + textBox5.Text + "', '" + textBox6.Text + "', '" + textBox7.Text + "', '" + textBox8.Text + "', '" + textBox9.Text + "', '" + textBox10.Text + "', '" + textBox11.Text + "');";

            

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

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            textBox11.Clear();
        }

        private void addFormFirm_Load(object sender, EventArgs e)
        {
            
            
        }
    }
}
