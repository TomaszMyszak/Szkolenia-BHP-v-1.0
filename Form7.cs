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
    public partial class addSzkolenie : Form
    {
        

        public addSzkolenie()
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
            polczenie.Open();

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

            dateTimePicker1.CustomFormat = "yyyy.MM.dd";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;

            dateTimePicker2.CustomFormat = "yyyy.MM.dd";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;

            string addFirm = "INSERT INTO SZKOLENIA(IMIE, NAZWISKO, OKRES_WAŻNOŚCI, EGZAMIN, OCENA, KOMISJA, PRACOWNIKID, TYP, DATA_SZKOLENIA, FIRMYID) VALUES ('" + textBox1.Text + "', '" + textBox2.Text + "', '" + dateTimePicker2.Text + "', '" + egzaminBox2.Text + "', '" + ocenaBox3.Text + "', '" + textBox6.Text + "', '" + textBox7.Text + "', '" + comboBox1.Text + "', '" + dateTimePicker1.Text + "', '" + textBox10.Text + "');";
            MessageBox.Show(addFirm);


            try
            {
                SqlCommand command = new SqlCommand(addFirm, polczenie);
                
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
            egzaminBox2.Items.Equals(0);
            ocenaBox3.Items.Equals(0);
            textBox6.Clear();
            textBox7.Clear();
            textBox10.Clear();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //nic
        }
        
        public string ls()
        {
            listaSzkolen ls = new listaSzkolen();
            textBox1.Text = ls.ans();
            textBox2.Text = ls.ann();
            textBox10.Text = ls.anm();
            return textBox1.Text;
        }

        public string lp()
        {
            ListaPracowników lp = new ListaPracowników();
            textBox1.Text = lp.anp();
            textBox2.Text = lp.anr();
            
            return textBox1.Text;
        }
        public void addSzkolenie_Load(object sender, EventArgs e)
        {
           if (textBox1.Text != null)
            {
                ls();
            }
            else
            {
                textBox1.Text = null;
                textBox2.Text = null;
                lp();
            } 
        }
    }
}
