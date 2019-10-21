using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BB_app.Model
{
    public class Trening
    {
        public int Id { get; set; }
        public DateTime Datum { get; set; }
        public string Naziv { get; set; }
        public int Br_Vjezbi { get; set; }
        public List<Vjezbe> Lista_vjezbe;

        public Trening() { }

        public Trening(string naz, int br)
        {
            this.Naziv = naz;
            this.Br_Vjezbi = br;
            this.Datum = DateTime.Now;
        }
    }
}
