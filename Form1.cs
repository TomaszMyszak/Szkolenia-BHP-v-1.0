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
using System.Data.Sql;
using VisioForge.Shared.MediaFoundation.OPM;
using System.Threading;

namespace SzkoleniaBHP
{
    public partial class szkoleniaBHP : Form
    {
        string dGV1Cell;
        string dGV1Celll;
       // string powiazana;


        public szkoleniaBHP()
        {
            InitializeComponent();
            Form2 wstep = new Form2();
            wstep.ShowDialog();
            wstep.Dispose();
            getFirmy();
        }

        private void dataGridView1_CellEnter(object sender,
    DataGridViewCellEventArgs e)
        {
            dataGridView1[e.ColumnIndex, e.RowIndex].Style
                .SelectionBackColor = Color.Blue;
        }

        private void dataGridView1_CellLeave(object sender,
            DataGridViewCellEventArgs e)
        {
            dataGridView1[e.ColumnIndex, e.RowIndex].Style
                .SelectionBackColor = Color.Empty;
        }

        private void firmy_Click(object sender, EventArgs e)
        {
            
            
        }

        void getFirmy()
        {
            //User Id=madzia;Password=19770730;
            //nawiązanie połączenia z bazą danych
            SqlConnection polczenie = new SqlConnection();
            polczenie.ConnectionString = "Data Source=DESKTOP-CAJMLL5,1433;Initial Catalog=szkoleniaBHP;User ID=sa;Password=Tommys#1978;";

            try
            {
                polczenie.Open();
         
            }

            catch (SqlException se)
            {
                MessageBox.Show("Błąd: " + se.StackTrace);
            }

            string query = "SELECT * FROM FIRMY";
            try
            {
                SqlDataAdapter adpt = new SqlDataAdapter(query, polczenie);
                DataTable dt = new DataTable();
                adpt.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                string error = string.Format("Błąd:  " + ex.Message);
                MessageBox.Show(error, "Bład", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        

        private void szkoleniaBHP_Load(object sender, EventArgs e)
        {
           
        }

        private void zaloguj_Click(object sender, EventArgs e)
        {
            //User Id=madzia;Password=19770730;
            //nawiązanie połączenia z bazą danych
            SqlConnection polczenie = new SqlConnection();
            polczenie.ConnectionString = "Data Source=DESKTOP-CAJMLL5,1433;Initial Catalog=szkoleniaBHP;User ID=sa;Password=Tommys#1978;";

            try
            {
                polczenie.Open();
            }

            catch (SqlException se)
            {
                MessageBox.Show("Błąd: " + se.StackTrace);
            }
            polczenie.Close();

        }

        private void pracownicy_Click(object sender, EventArgs e)
        {
            ListaPracowników lPrac = new ListaPracowników();
            lPrac.Show();
        }

        private void szkolenia_Click(object sender, EventArgs e)
        {
            listaSzkolen lszkol = new listaSzkolen();
            lszkol.Show();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var item = dataGridView1.Rows[e.RowIndex].Cells[0].Value;
            dGV1Cell = item.ToString();

            SqlConnection polczenie = new SqlConnection();
            polczenie.ConnectionString = "Data Source=DESKTOP-CAJMLL5,1433;Initial Catalog=szkoleniaBHP;User ID=sa;Password=Tommys#1978;";

            string powiazana = "SELECT * FROM PRACOWNIK WHERE FIRMYID='" + dGV1Cell + "';";
            
            try
            {
                SqlDataAdapter adpt1 = new SqlDataAdapter(powiazana, polczenie);
                DataTable dt1 = new DataTable();
                adpt1.Fill(dt1);
                dataGridViewPowiazana.DataSource = dt1;
            }

            catch (Exception ex)
            {
                string error = string.Format("Błąd:  " + ex.Message);
                MessageBox.Show(error, "Bład", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            string szkolenia = "SELECT * FROM SZKOLENIA;";
            
            try
            {
                SqlDataAdapter adpt2 = new SqlDataAdapter(szkolenia, polczenie);
                DataTable dt2 = new DataTable();
                adpt2.Fill(dt2);
                dataGridSzkolenia.DataSource = dt2;
            }

            catch (Exception ex)
            {
                string error = string.Format("Błąd:  " + ex.Message);
                MessageBox.Show(error, "Bład", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            
            polczenie.Close();
            
        }

        private void dataGridViewPowiazana_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var item = dataGridViewPowiazana.Rows[e.RowIndex].Cells[0].Value;
            dGV1Celll = item.ToString();

            SqlConnection polczenie = new SqlConnection();
            polczenie.ConnectionString = "Data Source=DESKTOP-CAJMLL5,1433;Initial Catalog=szkoleniaBHP;User ID=sa;Password=Tommys#1978;";
            
            string szkl = "SELECT * FROM SZKOLENIA WHERE PRACOWNIKID='" + dGV1Celll + "';";

            try
            {
                SqlDataAdapter adpt3 = new SqlDataAdapter(szkl, polczenie);
                DataTable dt3 = new DataTable();
                adpt3.Fill(dt3);
                dataGridSzkolenia.DataSource = dt3;
            }

            catch (Exception ex)
            {
                string error = string.Format("Błąd:  " + ex.Message);
                MessageBox.Show(error, "Bład", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            polczenie.Close();
        }

        private void addFirm_Click(object sender, EventArgs e)
        {
            addFormFirm addFirmForm = new addFormFirm();
            addFirmForm.Show();
        }

        private void odswierz_Click(object sender, EventArgs e)
        {
            SqlConnection polczenie = new SqlConnection();
            polczenie.ConnectionString = "Data Source=DESKTOP-CAJMLL5,1433;Initial Catalog=szkoleniaBHP;User ID=sa;Password=Tommys#1978;";
            polczenie.Open();
            polczenie.Close();
        }

        private void dodajPracownika_Click(object sender, EventArgs e)
        {
            dodajPracowika addWorker = new dodajPracowika();
            addWorker.Show();
        }

        private void dodajSzkolenie_Click(object sender, EventArgs e)
        {
            addSzkolenie aSzkolenie = new addSzkolenie();
            aSzkolenie.Show();
        }
    }

       
 }
