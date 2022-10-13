using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using System.Configuration;
using System.Data.SqlClient;
using Word = Microsoft.Office.Interop.Word;
using System.IO;
using System.Reflection;
using System.Diagnostics;

namespace SzkoleniaBHP
{
    public partial class listaSzkolen : Form
    {
        public static string imie;
        public static string nazwisko;
        public static string komisja;
        public static string typ;
        public static string dataUrodzenia;
        public static string dataSzkol;
        public static string wazna;
        public static string firmyId;


        public listaSzkolen()
        {
            InitializeComponent();
            loadForm4();
        }


        void loadForm4()
        {
            SqlConnection polczenie = new SqlConnection();
            polczenie.ConnectionString = "Data Source=DESKTOP-CAJMLL5,1433;Initial Catalog=szkoleniaBHP;User ID=sa;Password=Tommys#1978;";
            string powiazana1 = "SELECT * FROM SZKOLENIA;";

            try
            {
                SqlDataAdapter adpt3 = new SqlDataAdapter(powiazana1, polczenie);
                DataTable dt3 = new DataTable();
                adpt3.Fill(dt3);
                dataSzkolenia.DataSource = dt3;
                dataSzkolenia.ColumnHeadersVisible = false;
            }

            catch (Exception ex)
            {
                string error = string.Format("Błąd:  " + ex.Message);
                MessageBox.Show(error, "Bład", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            polczenie.Close();
        }

        void FindAndReplace(Word.Application wordApp, object ToFindText, object replaceWithText)
        {
            object matchCase = true;
            object matchWholeWord = true;
            object matchWildCards = false;
            object matchSoundLike = false;
            object nmatchAllforms = false;
            object forward = true;
            object format = false;
            object matchKashida = false;
            object matchDiactitics = false;
            object matchAlefHamza = false;
            object matchControl = false;
            object read_only = false;
            object visible = true;
            object replace = 2;
            object wrap = 1;

            wordApp.Selection.Find.Execute(ref ToFindText,
                ref matchCase, ref matchWholeWord,
                ref matchWildCards, ref matchSoundLike,
                ref nmatchAllforms, ref forward,
                ref wrap, ref format, ref replaceWithText,
                ref replace, ref matchKashida,
                ref matchDiactitics, ref matchAlefHamza,
                ref matchControl);
        }


        public void doc(object filename, object SaveAs)
        {


            Word.Application wordApp = new Word.Application();
            object missing = Missing.Value;
            Word.Document myWordDoc = null;

            if (File.Exists((string)filename))
            {
                object readOnly = false;
                object isVisible = false;
                wordApp.Visible = false;

                myWordDoc = wordApp.Documents.Open(ref filename, ref missing, ref readOnly,
                                        ref missing, ref missing, ref missing,
                                        ref missing, ref missing, ref missing,
                                        ref missing, ref missing, ref missing,
                                        ref missing, ref missing, ref missing, ref missing);
                myWordDoc.Activate();




                //find and replace
                FindAndReplace(wordApp, "<imie>", imie);
                FindAndReplace(wordApp, "<nazwisko>", nazwisko);
                FindAndReplace(wordApp, "<komisja>", komisja);
                FindAndReplace(wordApp, "<rodzajSzkolenia>", typ);
                FindAndReplace(wordApp, "<dataUrodzenia>", dataUrodzenia);
                FindAndReplace(wordApp, "<dataSzkolenia> ", dataSzkol);
                FindAndReplace(wordApp, "<wazna>", wazna);
                FindAndReplace(wordApp, "<date>", DateTime.Now.ToShortDateString());
            }
            else
            {
                MessageBox.Show("File not Found!");
            }

            //Save as
            myWordDoc.SaveAs2(ref SaveAs, ref missing, ref missing, ref missing,
                            ref missing, ref missing, ref missing,
                            ref missing, ref missing, ref missing,
                            ref missing, ref missing, ref missing,
                            ref missing, ref missing, ref missing);

            myWordDoc.Close();
            wordApp.Quit();
            MessageBox.Show("File Created!");
        }


        private void addSzkol_Click(object sender, EventArgs e)
        {
            addSzkolenie dSzkol = new addSzkolenie();
            dSzkol.Show();
        }

        private void print_Click(object sender, EventArgs e)
        {

            SqlConnection polczenie = new SqlConnection();
            polczenie.ConnectionString = "Data Source=DESKTOP-CAJMLL5,1433;Initial Catalog=szkoleniaBHP;User ID=sa;Password=Tommys#1978;";
            polczenie.Open();

            doc(@"C:\IGNIS\szkoleniaBHP\szablony\temp.docx", @"C:\IGNIS\szkoleniaBHP\szablony\certyfikat.docx");


            //print document
            using (PrintDialog pd = new PrintDialog())
            {
                pd.ShowDialog();
                ProcessStartInfo info = new ProcessStartInfo(@"C:\IGNIS\szkoleniaBHP\szablony\certyfikat.docx");
                info.Verb = "PrintTo";
                info.Arguments = pd.PrinterSettings.PrinterName;
                info.CreateNoWindow = true;
                info.WindowStyle = ProcessWindowStyle.Hidden;
                Process.Start(info);
            }
        }



        private void dateShow_Click(object sender, EventArgs e)
        {
            dateList();
        }


        void dateList()
        {
            SqlConnection polczenie = new SqlConnection();
            polczenie.ConnectionString = "Data Source=DESKTOP-CAJMLL5,1433;Initial Catalog=szkoleniaBHP;User ID=sa;Password=Tommys#1978;";
            polczenie.Open();


            //ustawienie formatu daty na własny
            dtDateSzkolenia.CustomFormat = "yyyy.MM.dd";
            dtDateSzkolenia.Format = DateTimePickerFormat.Custom;

            //filtrowanie zawartości tabeli po dacie
            string query = $"select * from szkolenia where DATA_SZKOLENIA = '{dtDateSzkolenia.Text}';";
            try
            {
                SqlDataAdapter adpt = new SqlDataAdapter(query, polczenie);
                DataTable dt = new DataTable();
                adpt.Fill(dt);
                dataSzkolenia.DataSource = dt;

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

        public void dataSzkolenia_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var item = dataSzkolenia.Rows[e.RowIndex].Cells[1].Value;
            imie = item.ToString();

            var item1 = dataSzkolenia.Rows[e.RowIndex].Cells[2].Value;
            nazwisko = item1.ToString();

            var item2 = dataSzkolenia.Rows[e.RowIndex].Cells[6].Value;
            komisja = item2.ToString();

            var item3 = dataSzkolenia.Rows[e.RowIndex].Cells[8].Value;
            typ = item3.ToString();

            var item4 = dataSzkolenia.Rows[e.RowIndex].Cells[11].Value;
            dataUrodzenia = item4.ToString();

            var item5 = dataSzkolenia.Rows[e.RowIndex].Cells[9].Value;
            dataSzkol= item5.ToString();

            var item6 = dataSzkolenia.Rows[e.RowIndex].Cells[3].Value;
            wazna = item6.ToString();

            var item7 = dataSzkolenia.Rows[e.RowIndex].Cells[10].Value;
            firmyId = item7.ToString();

            SqlConnection polczenie = new SqlConnection();
            polczenie.ConnectionString = "Data Source=DESKTOP-CAJMLL5,1433;Initial Catalog=szkoleniaBHP;User ID=sa;Password=Tommys#1978;";
            polczenie.Open();
            
            polczenie.Close();
            
        }

        public string ans()
        {
            string i = imie;

            return i;
        }

        public string ann()
        {

            string n = nazwisko;
            return nazwisko;
        }

        public string anm()
        {
            string m = firmyId;
            return firmyId;
        }
    }
}



