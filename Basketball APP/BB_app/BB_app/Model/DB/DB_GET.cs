using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace BB_app.Model.DB
{
    static class DB_GET
    {
        public static List<Vjezbe> Vjezbe_Get_All()
        {
            var lista = new List<Vjezbe>();

            //command to execute from connection conn (iz DB_connection)
            SQLiteCommand com = DB_connection.conn.CreateCommand();
            //sql request
            com.CommandText = String.Format(@"SELECT * FROM VJEZBE");
            //command reader
            SQLiteDataReader reader = com.ExecuteReader();
            //read through every retrived row
            while (reader.Read())
            {
               
                Vjezbe v = new Vjezbe(); //instance of vjezbe for every row
                v.Id = Convert.ToInt32(reader["ID"]);
                v.Naziv = (string) reader["Naziv"];//casting (converting) to string
                if(reader["Opis"].GetType() != typeof(DBNull))
                {
                    v.Opis = (string)reader["Opis"];
                }//check if field is NULL (DBNull)
                v.Sutevi = (bool) reader["Sutevi"];
                if (reader["Brzina"].GetType() != typeof(DBNull))
                {
                    v.Brzina = (bool)reader["Brzina"];
                }
                v.Brojac = (bool) reader["Brojac"];
                if (reader["Udaljenost"].GetType() != typeof(DBNull))
                {
                    v.Udaljenost = (bool)reader["Udaljenost"];
                }
                if (reader["Drugo"].GetType() != typeof(DBNull))
                {
                    v.Drugo = (string)reader["Drugo"];
                }

                lista.Add(v);//add to list the new vjezba retrived from DB
            }
            com.Dispose();//dispose of the command

            return lista;//return the list
        }
        public static List<Trening> Trening_Get_All()
        {
            var lista = new List<Trening>();

            SQLiteCommand com = DB_connection.conn.CreateCommand();
            com.CommandText = String.Format(@"SELECT * FROM TRENING");
            SQLiteDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                Trening t = new Trening();
                t.Id = Convert.ToInt32(reader["ID"]);
                t.Datum = DateTime.FromFileTime(reader.GetInt64(1));
                if (reader["Naziv"].GetType() != typeof(DBNull)) { t.Naziv = (string)reader["Naziv"]; }
                if (reader["Br_vjezbi"].GetType() != typeof(DBNull)) { t.Br_Vjezbi = Convert.ToInt32(reader["Br_vjezbi"]); }

                lista.Add(t);
            }
            com.Dispose();

            return lista;
        }
        public static Trening Trening_Get_Last_Add()
        {
            var lista = new Trening();

            SQLiteCommand com = DB_connection.conn.CreateCommand();
            com.CommandText = String.Format(@"SELECT * FROM TRENING ORDER BY ID DESC LIMIT 1");//get the last added record
            SQLiteDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                Trening t = new Trening();
                t.Id = Convert.ToInt32(reader["ID"]);
                t.Datum = DateTime.FromFileTime(reader.GetInt64(1));
                if (reader["Naziv"].GetType() != typeof(DBNull)) { t.Naziv = (string)reader["Naziv"]; }
                if (reader["Br_vjezbi"].GetType() != typeof(DBNull)) { t.Br_Vjezbi = Convert.ToInt32(reader["Br_vjezbi"]); }

                lista = t;
            }
            com.Dispose();

            return lista;
        }
        public static List<Igraci> Igraci_Get_All()
        {
            var lista = new List<Igraci>();

            SQLiteCommand com = DB_connection.conn.CreateCommand();
            com.CommandText = String.Format(@"SELECT * FROM IGRAC");
            SQLiteDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                Igraci i = new Igraci();
                i.Id = Convert.ToInt32(reader["ID"]);
                i.Ime = (string)reader["Ime"];
                i.Prezime = (string)reader["Prezime"];
                i.Godiste = Convert.ToInt32(reader["Godiste"]);
                i.Spol = Convert.ToChar(reader["Spol"]);
                i.Karton = (bool)reader["Zdravstveni_karton"];
                if(reader["Ekipa_ID"].GetType() != typeof(DBNull)) { i.Ekipa_id = Convert.ToInt32(reader["Ekipa_ID"]); }
                

                lista.Add(i);
            }
            com.Dispose();

            return lista;
        }
        public static List<Prisutnost> Prisutnost_Get_All()
        {
            var lista = new List<Prisutnost>();

            SQLiteCommand com = DB_connection.conn.CreateCommand();
            com.CommandText = String.Format(@"SELECT * FROM PRISUTNOST");
            SQLiteDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                Prisutnost p = new Prisutnost();
                p.Id = Convert.ToInt32(reader["ID"]);
                if(reader["Trening_ID"].GetType() != typeof(DBNull)) { p.Trening_id = Convert.ToInt32(reader["Trening_ID"]); }
                if (reader["Igrac_ID"].GetType() != typeof(DBNull)) { p.Igrac_id = Convert.ToInt32(reader["Igrac_ID"]); }
                p.Prisutan = (bool)reader["Prisutan"];

                lista.Add(p);
            }
            com.Dispose();

            return lista;
        }
        public static List<Prisutnost> Prisutnost_Get_By_Id(int t_id)
        {
            var lista = new List<Prisutnost>();

            SQLiteCommand com = DB_connection.conn.CreateCommand();
            com.CommandText = String.Format(@"SELECT * FROM PRISUTNOST WHERE Igrac_ID = {0}", t_id);//get where ID is wanted id
            SQLiteDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                Prisutnost p = new Prisutnost();
                p.Id = Convert.ToInt32(reader["ID"]);
                if (reader["Trening_ID"].GetType() != typeof(DBNull)) { p.Trening_id = Convert.ToInt32(reader["Trening_ID"]); }
                if (reader["Igrac_ID"].GetType() != typeof(DBNull)) { p.Igrac_id = Convert.ToInt32(reader["Igrac_ID"]); }
                p.Prisutan = (bool)reader["Prisutan"];


                lista.Add(p);
            }
            com.Dispose();

            return lista;
        }
        public static List<Kosevi> Kosevi_Get_By_Id(int s_id, char t_id)
        {
            var lista = new List<Kosevi>();

            SQLiteCommand com = DB_connection.conn.CreateCommand();
            com.CommandText = String.Format(@"SELECT * FROM KOSEVI WHERE Suter_ID = {0} AND Vrsta_sutera = '{1}'", s_id, t_id);
            SQLiteDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                Kosevi k = new Kosevi();
                k.Id = Convert.ToInt32(reader["ID"]);
                if(reader["Pozicija_x"].GetType() != typeof(DBNull)) { k.Poz_X = Convert.ToDecimal(reader["Pozicija_x"]); }
                if (reader["Pozicija_y"].GetType() != typeof(DBNull)) { k.Poz_Y = Convert.ToDecimal(reader["Pozicija_y"]); }
                if (reader["Suter_ID"].GetType() != typeof(DBNull)) { k.Suter_id= Convert.ToInt32(reader["Suter_ID"]); }
                if (reader["Vrsta_sutera"].GetType() != typeof(DBNull)) { k.Vrsta_sut = Convert.ToChar(reader["Vrsta_sutera"]); }
                if (reader["Pogodjeno"].GetType() != typeof(DBNull)) { k.Pogodak= (bool)reader["Pogodjeno"]; }
                if (reader["Br_bodova"].GetType() != typeof(DBNull)) { k.Br_Bod = Convert.ToInt32(reader["Br_bodova"]); }
                lista.Add(k);
            }
            com.Dispose();

            return lista;
        }
        public static List<Kosevi> Kosevi_Get_All()
        {
            var lista = new List<Kosevi>();

            SQLiteCommand com = DB_connection.conn.CreateCommand();
            com.CommandText = String.Format(@"SELECT * FROM KOSEVI");
            SQLiteDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                Kosevi k = new Kosevi();
                k.Id = Convert.ToInt32(reader["ID"]);
                if (reader["Pozicija_x"].GetType() != typeof(DBNull)) { k.Poz_X = Convert.ToDecimal(reader["Pozicija_x"]); }
                if (reader["Pozicija_y"].GetType() != typeof(DBNull)) { k.Poz_Y = Convert.ToDecimal(reader["Pozicija_y"]); }
                if (reader["Suter_ID"].GetType() != typeof(DBNull)) { k.Suter_id = Convert.ToInt32(reader["Suter_ID"]); }
                if (reader["Vrsta_sutera"].GetType() != typeof(DBNull)) { k.Vrsta_sut = Convert.ToChar(reader["Vrsta_sutera"]); }
                if (reader["Pogodjeno"].GetType() != typeof(DBNull)) { k.Pogodak = (bool)reader["Pogodjeno"]; }
                if (reader["Br_bodova"].GetType() != typeof(DBNull)) { k.Br_Bod = Convert.ToInt32(reader["Br_bodova"]); }
                lista.Add(k);
            }
            com.Dispose();

            return lista;
        }
        public static List<Ekipa> Ekipa_Get_All()
        {
            var lista = new List<Ekipa>();

            SQLiteCommand com = DB_connection.conn.CreateCommand();
            com.CommandText = String.Format(@"SELECT * FROM EKIPA");
            SQLiteDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                Ekipa ek = new Ekipa();
                ek.Id = Convert.ToInt32(reader["ID"]);
                ek.Naziv = (string)reader["Naziv"];
                if(reader["Ime_trenera"].GetType() != typeof(DBNull)) { ek.Trener = (string)reader["Ime_trenera"]; }
                
                lista.Add(ek);
            }
            com.Dispose();

            return lista;
        }
        public static List<Igraci> Ekipa_Get_By_Id(int ek_id)
        {
            var lista = new List<Igraci>();

            SQLiteCommand com = DB_connection.conn.CreateCommand();
            com.CommandText = String.Format(@"SELECT * FROM IGRAC WHERE Ekipa_ID = {0}", ek_id);
            SQLiteDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                Igraci i = new Igraci();
                i.Id = Convert.ToInt32(reader["ID"]);
                i.Ime = (string)reader["Ime"];
                i.Prezime = (string)reader["Prezime"];
                i.Godiste = Convert.ToInt32(reader["Godiste"]);
                i.Spol = Convert.ToChar(reader["Spol"]);
                i.Karton = (bool)reader["Zdravstveni_karton"];
                if (reader["Ekipa_ID"].GetType() != typeof(DBNull)) { i.Ekipa_id = Convert.ToInt32(reader["Ekipa_ID"]); }

                lista.Add(i);
            }
            com.Dispose();

            return lista;
        }
        public static List<Ekipa> Ekipa_Get_Id(int ek_id)
        {
            var lista = new List<Ekipa>();

            SQLiteCommand com = DB_connection.conn.CreateCommand();
            com.CommandText = String.Format(@"SELECT * FROM EKIPA WHERE ID = {0}", ek_id);
            SQLiteDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                Ekipa ek = new Ekipa();
                ek.Id = Convert.ToInt32(reader["ID"]);
                ek.Naziv = (string)reader["Naziv"];
                if (reader["Ime_trenera"].GetType() != typeof(DBNull)) { ek.Trener = (string)reader["Ime_trenera"]; }

                lista.Add(ek);
            }
            com.Dispose();

            return lista;
        }
        public static List<Zapisnik> Zapisnik_Get_By_Id(int e_id)
        {
            var lista = new List<Zapisnik>();

            SQLiteCommand com = DB_connection.conn.CreateCommand();
            com.CommandText = String.Format(@"SELECT * FROM ZAPISNIK WHERE Ekipa_ID = {0}", e_id);
            SQLiteDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                Zapisnik z = new Zapisnik();

                z.Id = Convert.ToInt32(reader["ID"]);
                if(DateTime.FromFileTime(reader.GetInt64(1)).GetType() != typeof(DBNull)) { z.Datum = DateTime.FromFileTime(reader.GetInt64(1)); }
                if (reader["Ekipa_ID"].GetType() != typeof(DBNull)) { z.Ekipa_id = Convert.ToInt32(reader["Ekipa_ID"]); }
                z.Ekipa_gost = (string)reader["Ekipa_G"];
                z.Rez_dom = Convert.ToInt32(reader["Rez_d"]);
                z.Rez_gost = Convert.ToInt32(reader["Rez_g"]);

                lista.Add(z);
            }
            com.Dispose();

            return lista;
        }
        public static List<Zapisnik> Zapisnik_Get_All()
        {
            var lista = new List<Zapisnik>();

            SQLiteCommand com = DB_connection.conn.CreateCommand();
            com.CommandText = String.Format(@"SELECT * FROM ZAPISNIK");
            SQLiteDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                Zapisnik z = new Zapisnik();

                z.Id = Convert.ToInt32(reader["ID"]);
                if (DateTime.FromFileTime(reader.GetInt64(1)).GetType() != typeof(DBNull)) { z.Datum = DateTime.FromFileTime(reader.GetInt64(1)); }
                if (reader["Ekipa_ID"].GetType() != typeof(DBNull)) { z.Ekipa_id = Convert.ToInt32(reader["Ekipa_ID"]); }
                z.Ekipa_gost = (string)reader["Ekipa_G"];
                z.Rez_dom = Convert.ToInt32(reader["Rez_d"]);
                z.Rez_gost = Convert.ToInt32(reader["Rez_g"]);

                lista.Add(z);
            }
            com.Dispose();

            return lista;
        }
        public static List<Statistika> Statistika_Get_By_Id(int i_id, char type)
        {
            var lista = new List<Statistika>();

            SQLiteCommand com = DB_connection.conn.CreateCommand();
            com.CommandText = String.Format(@"SELECT * FROM STATISTIKA WHERE Entitet_ID = {0} AND Vrsta_entiteta = '{1}'", i_id, type);
            SQLiteDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                Statistika s = new Statistika();

                s.Id = Convert.ToInt32(reader["ID"]);
                if (reader["Entitet_ID"].GetType() != typeof(DBNull)) { s.Entity_Id= Convert.ToInt32(reader["Entitet_ID"]); }
                if (reader["Vrsta_entiteta"].GetType() != typeof(DBNull)) { s.Entity_type = Convert.ToChar(reader["Vrsta_entiteta"]); }
                if (reader["Post_sutevi"].GetType() != typeof(DBNull)) { s.Postotak_suteva = Convert.ToDecimal(reader["Post_sutevi"]); }
                if (reader["Post_prisutnost"].GetType() != typeof(DBNull)) { s.Postotak_prisutnost = Convert.ToDecimal(reader["Post_prisutnost"]); }
                if (reader["Visina"].GetType() != typeof(DBNull)) { s.Visina = Convert.ToDecimal(reader["Visina"]); }
                if (reader["Tezina"].GetType() != typeof(DBNull)) { s.Tezina = Convert.ToDecimal(reader["Tezina"]); }
                if (reader["Raspon_ruku"].GetType() != typeof(DBNull)) { s.Raspon_ruku = Convert.ToDecimal(reader["Raspon_ruku"]); }
                if (reader["Brzina_sprint"].GetType() != typeof(DBNull)) { s.Brz_Spr = Convert.ToDecimal(reader["Brzina_sprint"]); }
                if (reader["Brzina_su"].GetType() != typeof(DBNull)) { s.Brz_SU = Convert.ToDecimal(reader["Brzina_su"]); }
                if (reader["Skok_udalj"].GetType() != typeof(DBNull)) { s.Skok_ud = Convert.ToDecimal(reader["Skok_udalj"]); }
                if (reader["Prvo_mjerenje"].GetType() != typeof(DBNull)) { s.Prvo_mjerenje = Convert.ToBoolean(reader["Prvo_mjerenje"]); }



                lista.Add(s);
            }
            com.Dispose();

            return lista;
        }
        public static List<Statistika> Statistika_Get_All()
        {
            var lista = new List<Statistika>();

            SQLiteCommand com = DB_connection.conn.CreateCommand();
            com.CommandText = String.Format(@"SELECT * FROM STATISTIKA");
            SQLiteDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                Statistika s = new Statistika();

                s.Id = Convert.ToInt32(reader["ID"]);
                if (reader["Entitet_ID"].GetType() != typeof(DBNull)) { s.Entity_Id = Convert.ToInt32(reader["Entitet_ID"]); }
                if (reader["Vrsta_entiteta"].GetType() != typeof(DBNull)) { s.Entity_type = Convert.ToChar(reader["Vrsta_entiteta"]); }
                if (reader["Post_sutevi"].GetType() != typeof(DBNull)) { s.Postotak_suteva = Convert.ToDecimal(reader["Post_sutevi"]); }
                if (reader["Post_prisutnost"].GetType() != typeof(DBNull)) { s.Postotak_prisutnost = Convert.ToDecimal(reader["Post_prisutnost"]); }
                if (reader["Visina"].GetType() != typeof(DBNull)) { s.Visina = Convert.ToDecimal(reader["Visina"]); }
                if (reader["Tezina"].GetType() != typeof(DBNull)) { s.Tezina = Convert.ToDecimal(reader["Tezina"]); }
                if (reader["Raspon_ruku"].GetType() != typeof(DBNull)) { s.Raspon_ruku = Convert.ToDecimal(reader["Raspon_ruku"]); }
                if (reader["Brzina_sprint"].GetType() != typeof(DBNull)) { s.Brz_Spr = Convert.ToDecimal(reader["Brzina_sprint"]); }
                if (reader["Brzina_su"].GetType() != typeof(DBNull)) { s.Brz_SU = Convert.ToDecimal(reader["Brzina_su"]); }
                if (reader["Skok_udalj"].GetType() != typeof(DBNull)) { s.Skok_ud = Convert.ToDecimal(reader["Skok_udalj"]); }
                if (reader["Prvo_mjerenje"].GetType() != typeof(DBNull)) { s.Prvo_mjerenje = Convert.ToBoolean(reader["Prvo_mjerenje"]); }



                lista.Add(s);
            }
            com.Dispose();

            return lista;
        }
    }
}
