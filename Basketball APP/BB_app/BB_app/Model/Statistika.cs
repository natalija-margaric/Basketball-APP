using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BB_app.Model.DB;

namespace BB_app.Model
{
    public class Statistika : Igraci
    {
        public int Id { get; set; }
        public int Entity_Id { get; set; }
        public char Entity_type { get; set; }
        public decimal Postotak_suteva { get; set; }
        public decimal Postotak_prisutnost { get; set; }
        public List<Prisutnost> pri;
        public List<Kosevi> sut;

        public Statistika() { }

        public void Izracun_postotka_suteva(List<Kosevi> sutevi)
        {
            decimal pogodeno = 0;
            if(sutevi.Count != 0)
            {
                foreach (var i in sutevi)
                {
                    if (i.Pogodak == true) { pogodeno++; }
                }
                this.Postotak_suteva = pogodeno / sutevi.Count();
            }
            
        }
        public void Izracun_postotka_prisutnosti()
        {
            pri = new List<Prisutnost>();
            DB_connection.OpenConn();
            pri = DB_GET.Prisutnost_Get_By_Id(Entity_Id);
            DB_connection.CloseConn();

            decimal count = 0;
            if(pri.Count != 0)
            {
                foreach (var i in pri)
                {
                    if (i.Prisutan == true) { count++; }
                }
                this.Postotak_prisutnost = count / pri.Count();
            }
            
        }

    }
}
