using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adatrogzito
{
    internal class Users
    {
        public string Nev { get; set; }
        public int Kor { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public string Cim { get; set; }
        public string Nem { get; set; }
        public string Megjegyzes { get; set; }
        public Users(string nev, int kor, string email, string telefon, string cim, string nem, string megjegyzes)
        {
            Nev = nev;
            Kor = kor;
            Email = email;
            Telefon = telefon;
            Cim = cim;
            Nem = nem;
            Megjegyzes = megjegyzes;
        }
        public override string ToString()
        {
            return $"{Nev},{Kor},{Email},{Telefon},{Cim},{Nem},{Megjegyzes}";
        }
    }
}
