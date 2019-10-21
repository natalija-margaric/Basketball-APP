using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BB_app.Model
{
    public class Prisutnost
    {
        public int Id { get; set; }
        public int Igrac_id { get; set; }
        public int Trening_id { get; set; }
        public bool Prisutan { get; set; }
        public Igraci Igrac;
        public Trening Trening;
        public string Trening_prisut { get; set; }

        public Prisutnost()
        {

        }
    }
}
