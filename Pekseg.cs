using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pekseg
{
    class Pekseg
    {
        private string nev;
        private DateTime alapitva = DateTime.Now;
        private List<Pekaru> termekek= new List<Pekaru>();

        public Pekseg(string nev)
        {
            this.Nev = nev;
        }

        public string Nev { get => nev; set => nev = value;}
        public DateTime Alapitva { get => alapitva;}
        internal List<Pekaru> Termekek { get => termekek; set => termekek = value; }
        public override string ToString()
        {
            return string.Format("{0} - {1}", this.nev, this.alapitva);
        }
    }


}
