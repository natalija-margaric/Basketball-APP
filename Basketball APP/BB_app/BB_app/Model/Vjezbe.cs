using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BB_app.Model
{
    public class Vjezbe
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }
        public bool Sutevi { get; set; }
        public bool Brzina { get; set; }
        public bool Brojac { get; set; }
        public bool Udaljenost { get; set; }
        public string Drugo { get; set; }

        public Vjezbe()
        {

        }
    }
}
