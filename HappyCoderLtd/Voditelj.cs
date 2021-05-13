using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyCoderLtd
{
    class Voditelj:Zaposlenik
    {
        public List<Programer> Programeri { get; set; }

        public Voditelj(string ime, string prezime)
           : base(ime, prezime)
        {
            Programeri = new List<Programer>();
        }

        public override int OdradiPosao()
        {
            Random random = new Random();
            return random.Next(10);
        }
    }
}
