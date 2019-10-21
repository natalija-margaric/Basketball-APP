using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BB_app.Model;
using BB_app.Model.DB;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace BB_app.View
{
    public partial class Trening_dashboard : Form
    {
        Trening trening_now;
        List<Igraci> igraci_now;
        List<Vjezbe> vjezbe_now;
        Igraci igrac_odabran;
        List<Statistika> statistika = new List<Statistika>();
        List<Kosevi> kosevi_lista = new List<Kosevi>();

        public Trening_dashboard(Trening tr, List<Igraci> igr, List<Vjezbe> vj)
        {
            trening_now = tr;
            igraci_now = igr;
            vjezbe_now = vj;

            InitializeComponent();
            lblDashboard01.Text = tr.Naziv.ToString() + " - " + String.Format("{0:MM/dd/yy}", (DateTime)tr.Datum);
            //GRIDVIEW
            //punjenje gridview-a sa igracima
            BindingSource datasource;
            dgvDashboardIgraci.AutoGenerateColumns = false;
            dgvDashboardIgraci.ColumnCount = 2;

            var collection = new ObservableCollection<Igraci>(igraci_now);
            datasource = new BindingSource(collection, null);

            dgvDashboardIgraci.Columns[0].HeaderText = "Ime";
            dgvDashboardIgraci.Columns[0].DataPropertyName = "Ime";
            dgvDashboardIgraci.Columns[1].HeaderText = "Prezime";
            dgvDashboardIgraci.Columns[1].DataPropertyName = "Prezime";

            dgvDashboardIgraci.DataSource = datasource;
            dgvDashboardIgraci.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDashboardIgraci.AutoResizeColumns();
            dgvDashboardIgraci.AllowUserToAddRows = false;

            dgvDashboardIgraci.CellClick += (s, e) =>
            {
                Check_Kosevi_List();
                igrac_odabran = (Igraci)this.igraci_now[e.RowIndex];
            };


        }
        //TIMER
        int sto = 0;
        int sec = 0;
        int min = 0;

        private void timerDashboard_Tick(object sender, EventArgs e)
        {
            sto++;
            if (sto == 99)
            {
                sec++;
                sto = 0;
            }
            if (sec == 59)
            {
                min++;
                sec = 0;
            }
            lblDashboradTimer.Text = min.ToString() + ":" + sec.ToString() + ":" + sto.ToString();
        }
        bool status = false;
        private void btnTimerStar_Click(object sender, EventArgs e)
        {

            if (status == false && btnTimerStar.Text == "START")
            {
                timerDashboard.Interval = 10;
                timerDashboard.Start();
                btnTimerStar.Text = "STOP";
                status = true;
            }
            else if(status == true && btnTimerStar.Text == "STOP")
            {
                timerDashboard.Stop();
                btnTimerStar.Text = "START";
                status = false;
            }

        }

        private void btnTimerReset_Click(object sender, EventArgs e)
        {
            sto = 0;
            sec = 0;
            min = 0;
            lblDashboradTimer.Text = min.ToString() + ":" + sec.ToString() + ":" + sto.ToString();
        }


        //GUMBOVI
        private void btnDashboardBrzina_Click(object sender, EventArgs e)
        {
            if (igrac_odabran != null)//pozivanje funkcije za prikaz panela ako je odabran igrac u gridview-u
            {
                Show_panel("Brzina", igrac_odabran.Ime.ToString(), igrac_odabran.Prezime.ToString());
            }
        }

        private void btnDashboardSprint_Click(object sender, EventArgs e)
        {
            if (igrac_odabran != null)
            {
                Show_panel("Šprint", igrac_odabran.Ime.ToString(), igrac_odabran.Prezime.ToString());
            }
        }

        private void btnDashboardSU_Click(object sender, EventArgs e)
        {
            if (igrac_odabran != null)
            {
                Show_panel("Samoubojstvo", igrac_odabran.Ime.ToString(), igrac_odabran.Prezime.ToString());
            }
        }

        private void btnDashboardSkUd_Click(object sender, EventArgs e)
        {
            if (igrac_odabran != null)
            {
                Show_panel("Skok udalj", igrac_odabran.Ime.ToString(), igrac_odabran.Prezime.ToString());
            }
        }

        //otvaranje prozora sa unosom mjerenja
        private void btnDashboardMjerenja_Click(object sender, EventArgs e)
        {
            new Mjerenja_popup(igrac_odabran, this.DesktopLocation.X+btnDashboardBrzina.Width, this.DesktopLocation.Y).Show();
        }
        //kraj treninga i spremanje podataka
        private void btnDashboardKraj_Click(object sender, EventArgs e)
        {
            Spremanje_kraj_treninga();
            this.Close();
        }

        // GUMBOVI UNUTAR UNOSA
        private void btnPanelUnos_Click(object sender, EventArgs e)
        {
            //spremanje podataka ovisno odabranog tipa unosa (buttona)

            Statistika stat = Check_instance();//provjera ako instanca sa igracem vec postoj
            switch (lblPanelTitle.Text)
            {
                case "Brzina":
                    {
                        stat.Brz_Spr = Decimal.Parse(txtbPanelValue.Text);
                        break;
                    }
                case "Šprint":
                    {
                        stat.Brz_Spr = Decimal.Parse(txtbPanelValue.Text);
                        break;
                    }
                case "Samoubojstvo":
                    {
                        stat.Brz_SU = Decimal.Parse(txtbPanelValue.Text);
                        break;
                    }
                case "Skok udalj":
                    {
                        stat.Skok_ud = Decimal.Parse(txtbPanelValue.Text);
                        break;
                    }
            }
            Change_label("Podatak spremljen");
            panelDashboardUnos.Visible = false;
            txtbPanelValue.Text = "";
        }

        private void btnPanelIzadi_Click(object sender, EventArgs e)
        {
            txtbPanelValue.Text = "";
            panelDashboardUnos.Visible = false;
        }
        //FUNKCIJE i METODE
        //prikaz panela za unos ovisno o buttonu koje se pretislo
        public void Show_panel(string titel, string igrac_ime, string igrac_prezime)
        {
            //prikaz panela
            lblPanelTitle.Text = titel;
            lblPanelIgrac.Text = igrac_ime + " " + igrac_prezime;
            panelDashboardUnos.Visible = true;
        }

        //provjeri ako instanca vec postoji; ako da vraca tu istancu, ako ne stvara novu te se dodaje listi instanca
        public Statistika Check_instance()
        {
            foreach (var s in statistika)
            {
                if (s.Entity_Id == igrac_odabran.Id) { return s; }
            }
            Statistika stat = new Statistika();
            stat.Entity_Id = igrac_odabran.Id;
            stat.Entity_type = 'I';
            statistika.Add(stat);
            return stat;
        }

        //spremanje svih statistika prije zavrsavanja/zatvaranja treninga
        public void Spremanje_kraj_treninga()
        {
            try
            {
                Check_Kosevi_List();
                Postotak_prisutnosti();
                DB_connection.OpenConn();
                DB_PUT.Statistika_Put_List(statistika);
                DB_connection.CloseConn();
                Change_label("Statistika spremljena");
                this.Close();
            }
            catch (ArgumentException e)
            {
                lblDashboardResult.ForeColor = Color.Red;
                Change_label(Convert.ToString(e));
            }
            
        }

        //unos koseva na terernu
        private void picbDashboardTeren_MouseUp(object sender, MouseEventArgs e)
        {
            Kosevi kos = new Kosevi();
            kos.Set_XY((decimal)e.Location.X,
                       (decimal)e.Location.Y,
                       (decimal)picbDashboardTeren.Height,
                       (decimal)picbDashboardTeren.Width);
            kos.Suter_id = igrac_odabran.Id;
            kos.Vrsta_sut = 'I';
            //dohvacanje podataka iz forme Kosevi_popup
            try
            {

                using (var form = new Kosevi_popup(picbDashboardTeren.Location.X + e.Location.X,
                             picbDashboardTeren.Location.Y + e.Location.Y,
                             this.DesktopLocation.X,
                             this.DesktopLocation.Y,
                             kos))
                {
                    form.ShowDialog();
                    kos.Pogodak = form.Pogodeno_popup;
                    kos.Br_Bod = form.Bodovi_popup;
                }
                kosevi_lista.Add(kos);
                Change_label("Šut je zabilježen");
            }
            catch(ArgumentException err)
            {
                lblDashboardResult.ForeColor = Color.Red;
                Change_label(Convert.ToString(err));
            }

        }

        //provjeri ako je lista prazna; ako nije izracunaj postotak za tog igraca te isprazni listu
        private void Check_Kosevi_List()
        {
            if (kosevi_lista.Count > 0)
            {
                Statistika stat = Check_instance();
                stat.Izracun_postotka_suteva(kosevi_lista);
                kosevi_lista.Clear();
            }
        }

        private void Change_label(string str)
        {
            lblDashboardResult.Text = str.ToString();
            lblDashboardResult.Visible = true;
            var t = new Timer();
            t.Interval = 3000;
            t.Start();
            t.Tick += (s, e) =>
            {
                lblDashboardResult.Visible = false;
                lblDashboardResult.ForeColor = Color.LimeGreen;
                t.Stop();
            };
        }

        private void Postotak_prisutnosti()
        {
            foreach(var s in statistika)
            {
                s.Izracun_postotka_prisutnosti();
            }
        }
        
    }
    
}
