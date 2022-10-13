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


namespace SzkoleniaBHP
{

    

    public partial class ListaPracowników : Form
    {
        string dGVPCell;
        public static string imie;
        public static string nazwisko;
        //private object dataSet;




        public ListaPracowników()
        {
            InitializeComponent();
            loadWorker();
                                
        }

        private void ListaPracowników_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Tutaj sprawdzisz co u Kogo było wykonane");
        }

        void loadWorker()
        {
            SqlConnection polczenie = new SqlConnection();
            polczenie.ConnectionString = "Data Source=DESKTOP-CAJMLL5,1433;Initial Catalog=szkoleniaBHP;User ID=sa;Password=Tommys#1978;";

            string powiazana1 = "SELECT * FROM PRACOWNIK;";

            try
            {
                SqlDataAdapter adpt3 = new SqlDataAdapter(powiazana1, polczenie);
                DataTable dt3 = new DataTable();
                adpt3.Fill(dt3);
                dataPracownicy.DataSource = dt3;
                dataPracownicy.ColumnHeadersVisible = false;              
            }

            catch (Exception ex)
            {
                string error = string.Format("Błąd:  " + ex.Message);
                MessageBox.Show(error, "Bład", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            polczenie.Close();
        }

        private void dataPracownicy_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //wyświetlanie ilości i rodzaju szkolenia dla klikniętego pracownika
            
            var item = dataPracownicy.Rows[e.RowIndex].Cells[0].Value;
            dGVPCell = item.ToString();

            SqlConnection polczenie = new SqlConnection();
            polczenie.ConnectionString = "Data Source=DESKTOP-CAJMLL5,1433;Initial Catalog=szkoleniaBHP;User ID=sa;Password=Tommys#1978;";


            string szkolenie = "SELECT TYP, DATA_SZKOLENIA FROM SZKOLENIA WHERE PRACOWNIKID='" + dGVPCell+"';";

            try
            {
                SqlDataAdapter adpt = new SqlDataAdapter(szkolenie, polczenie);
                DataTable dt = new DataTable();
                adpt.Fill(dt);
                dataSzkolenia.DataSource = dt;
                this.dataSzkolenia.ColumnHeadersVisible = false;
                this.dataSzkolenia.CellBorderStyle = DataGridViewCellBorderStyle.None;
            }

            catch (Exception ex)
            {
                string error = string.Format("Błąd:  " + ex.Message);
                MessageBox.Show(error, "Bład", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            string ocena = "SELECT OCENA FROM SZKOLENIA WHERE PRACOWNIKID='" + dGVPCell + "';";

            try
            {
                SqlDataAdapter adpt = new SqlDataAdapter(ocena, polczenie);
                DataTable dt = new DataTable();
                adpt.Fill(dt);
                dataOceny.DataSource = dt;
                this.dataOceny.ColumnHeadersVisible = false;
                this.dataOceny.CellBorderStyle = DataGridViewCellBorderStyle.None;
            }

            catch (Exception ex)
            {
                string error = string.Format("Błąd:  " + ex.Message);
                MessageBox.Show(error, "Bład", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


            string komisja = "SELECT KOMISJA FROM SZKOLENIA WHERE PRACOWNIKID='" + dGVPCell + "';";

            try
            {
                SqlDataAdapter adpt = new SqlDataAdapter(komisja, polczenie);
                DataTable dt = new DataTable();
                adpt.Fill(dt);
                dataKomisja.DataSource = dt;
                this.dataKomisja.ColumnHeadersVisible = false;
                this.dataKomisja.CellBorderStyle = DataGridViewCellBorderStyle.None;
            }

            

            catch (Exception ex)
            {
                string error = string.Format("Błąd:  " + ex.Message);
                MessageBox.Show(error, "Bład", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
                        
            polczenie.Close();
        }

        private void dataPracownicy_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var item = dataPracownicy.Rows[e.RowIndex].Cells[1].Value;
            imie = item.ToString();

            var item1 = dataPracownicy.Rows[e.RowIndex].Cells[2].Value;
            nazwisko = item1.ToString();

            SqlConnection polczenie = new SqlConnection();
            polczenie.ConnectionString = "Data Source=DESKTOP-CAJMLL5,1433;Initial Catalog=szkoleniaBHP;User ID=sa;Password=Tommys#1978;";
            polczenie.Open();

            polczenie.Close();
        }


        public string anp()
        {
            string i = imie;

            return i;
        }

        public string anr()
        {

            string n = nazwisko;
            return nazwisko;
        }


        private void dodajSzkolenie_Click(object sender, EventArgs e)
        {
            addSzkolenie aS = new addSzkolenie();
            aS.ShowDialog();


        }

       
    }
}

