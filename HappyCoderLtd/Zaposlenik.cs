using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyCoderLtd
{
    abstract class Zaposlenik
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public int UkupnoVrijeme { get; set; }

        public Zaposlenik(string ime,string prezime)
        {
            Ime = ime;
            Prezime = prezime;
        }


        public abstract int OdradiPosao();
    }
}
