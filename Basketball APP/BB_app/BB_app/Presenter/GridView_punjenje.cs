using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using BB_app.Model.DB;
using BB_app.Model;

namespace BB_app.Presenter
{
    //klasa za kreiranje grid view ovisno o izvoru (ako se zeli lista ekipa, igraca, treninga...)
    public class GridView_punjenje
    {
        public BindingSource datasource;
        public List<Igraci> igr;
        public List<Ekipa> ek;
        public Ekipa ekipa_id;
        public Igraci igrac_id;
        public char source_type;
        public DataGridView gv;
        public int get_by_id = 0;

        //konstruktor prima izvor podataka, i id ekipe za prikaz ekipe
        public GridView_punjenje(char source, int X, int Y, int id)
        {
            get_by_id = id;
            gv = new DataGridView(); //novi grid view
            gv.AutoGenerateColumns = false; //da se moze rucno postaviti stupci
            gv.Location = new System.Drawing.Point(X, Y);//pozicija pojave gv
            //kreiranje ovisno o izvoru
            switch (source)
            {
                case 'I':
                    {
                        gvIgraci();
                        break;
                    }
                case 'E':
                    {
                        gvIgraci();
                        break;
                    }
                case 'S':
                    {
                        gvEkipe();
                        break;
                    }
            }


        }
        private void gvIgraci()
        {
            //broj stupca
            gv.ColumnCount = 2;

            igr = new List<Igraci>();
            DB_connection.OpenConn();
            if(get_by_id != 0)
            {
                igr = DB_GET.Ekipa_Get_By_Id(get_by_id); //dohvacanje igraca iz iste ekipe
            }
            else
            {
                igr = DB_GET.Igraci_Get_All(); //dohvacanje igraca
            }
            
            DB_connection.CloseConn();

            var collection = new ObservableCollection<Igraci>(igr); //stvaranje kolekcije...preko presentera
            datasource = new BindingSource(collection, null); //vezanje kolekcije za datasource
            //postavljanje vidljivih stupaca
            gv.Columns[0].HeaderText = "Ime";
            gv.Columns[0].DataPropertyName = "Ime";
            gv.Columns[1].HeaderText = "Prezime";
            gv.Columns[1].DataPropertyName = "Prezime";
            
            //lambda funkcija (google it)....za dobivanje igraca kojeg se kliknulo u grid view 
            gv.CellClick += (s, e) =>
            {
                igrac_id = (Igraci)this.igr[e.RowIndex];
            };

            gv.DataSource = datasource; //vezanje grid view sa datasource (koji je kolekcija)
            gv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; //da se popuni prostor
            gv.AutoResizeColumns();
            gv.AllowUserToAddRows = false; //ne dopusta dodavanje novih redova
        }

        private void gvEkipe()
        {
            ek = new List<Ekipa>();
            DB_connection.OpenConn();
            ek = DB_GET.Ekipa_Get_All();
            DB_connection.CloseConn();

            var collection = new ObservableCollection<Ekipa>(ek);
            datasource = new BindingSource(collection, null);

            gv.ColumnCount = 1;
            gv.Columns[0].HeaderText = "Naziv";
            gv.Columns[0].DataPropertyName = "Naziv";

            gv.CellClick += (s, e) =>
            {
                ekipa_id = (Ekipa)this.ek[e.RowIndex];
            };

            gv.DataSource = datasource;
            gv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gv.AutoResizeColumns();
            gv.AllowUserToAddRows = false;
        }

    }
}
