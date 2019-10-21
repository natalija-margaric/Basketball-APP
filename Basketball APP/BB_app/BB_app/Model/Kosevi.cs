using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BB_app.Model
{
    public class Kosevi
    {
        public int Id { get; set; }
        public decimal Poz_X { get; set; }
        public decimal Poz_Y { get; set; }
        public int Suter_id { get; set; }
        public char Vrsta_sut { get; set; }
        public bool Pogodak { get; set; }
        public int Br_Bod { get; set; }

        public Kosevi() { }

        //izracun pozicije suta na terenu
        //metoda prima (po redu): pozicija X od klika, pozicija Y od klika, visina slike od terena, sirina slike od terena
        public void Set_XY(decimal X, decimal Y, decimal H, decimal W)
        {
            //izmedu 0 i 1
            Poz_X = X / W;
            Poz_Y = Y / H;
        }
    }
}
