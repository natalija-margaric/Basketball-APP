using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BB_app.Model
{
    public class Zapisnik
    {
        public int Id { get; set; }
        public DateTime Datum { get; set; }
        public int Ekipa_id { get; set; }
        public string Ekipa_gost { get; set; }
        public int Rez_gost { get; set; }
        public int Rez_dom { get; set; }
        public string Ekipa_dom { get; set; }
        public Ekipa Ekipa_domaca;

        public Zapisnik() { }
    }
}
