using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SzkoleniaBHP
{
    /*private string getConnecitionString()
    {
        //pobranie danych do logowania z bazą
        string host = "localhost";
        string tcpPort = 1463;
        string dbNAME = "SZKOLENIABHP";
        string login = "tomek";
        string password = "Tommys#1978";

        string connetionString =
        "Data Source" + host + "," + tcpPort + "," + ";Initial Catalog" + dbNAME + ";User" + login + ";Password" + ";";


        return connetionString;
    }*/

    static class Program
    {
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new szkoleniaBHP());


          
        }
    }
}
