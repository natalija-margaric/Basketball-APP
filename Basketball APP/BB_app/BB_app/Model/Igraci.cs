using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BB_app.Model.DB;

namespace BB_app.Model
{
    public class Igraci
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public int Godiste { get; set; }
        public char Spol { get; set; }
        public bool Karton { get; set; }
        public int Ekipa_id { get; set; }
        public bool Prisutnost { get; set; }
        public decimal Visina { get; set; }
        public decimal Tezina { get; set; }
        public decimal Raspon_ruku { get; set; }
        public decimal Brz_Spr { get; set; }
        public decimal Brz_SU { get; set; }
        public decimal Skok_ud { get; set; }
        public bool Prvo_mjerenje { get; set; }
        public string Ekipa_naziv { get; set; }
        public Ekipa Ekipa_podaci = new Ekipa();

        public Igraci() { }

        public Igraci( string ime, string prez, int god)
        {
            this.Ime = ime;
            this.Prezime = prez;
            this.Godiste = god;
        }

        public void Get_naziv_ekipe()
        {
            List<Ekipa> ek = new List<Ekipa>();
            DB_connection.OpenConn();
            ek = DB_GET.Ekipa_Get_Id(Ekipa_id);
            DB_connection.CloseConn();
            this.Ekipa_naziv = ek[0].Naziv.ToString();

        }
    }
}
