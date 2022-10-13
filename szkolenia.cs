using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzkoleniaBHP
{
    public class _szkoleniaBHP
    {
        public int szklieniaID { get; set; }
        public string imie { get; set; }
        public string nazwisko { get; set; }
        public string okresWaznosci { get; set; }
        public string egzamin { get; set; }
        public string ocena { get; set; }
        public string komisja { get; set; }
        public int pracownikID { get; set; }
        public string typ { get; set; }
        public DateTime dataSzkolenia { get; set; }
        public int firmyID { get; set; }

    }
}
