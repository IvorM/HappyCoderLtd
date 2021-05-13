using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyCoderLtd
{
    class Menadzer:Zaposlenik
    {
        public List<Voditelj> Voditelji { get; set; }
        public Menadzer(string ime,string prezime)
            :base(ime,prezime)
        {
            Voditelji = new List<Voditelj>();
        }

        public override int OdradiPosao()
        {
            Random random = new Random();
            return random.Next(10);
        }
    }
}
