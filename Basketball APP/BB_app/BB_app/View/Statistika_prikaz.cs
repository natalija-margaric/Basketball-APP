using System;
using System.Collections.Generic;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.Wpf;
using LiveCharts.WinForms;
using LiveCharts.Defaults;
using BB_app.Model;
using BB_app.Model.DB;
using BB_app.Presenter;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Windows.Media;

namespace BB_app.View
{
    public partial class Statistika_prikaz : Form
    {
        GridView_punjenje gv;
        int trenutni; // 0 --> igraci; 1 --> ekipe
        Igraci igrac_id;
        int id_send_to_form;
        char type_send_to_form;
        string name_send_to_form;
        Ekipa ekipa_id;
        public List<Statistika> stat = new List<Statistika>();

        public Statistika_prikaz()
        {
            InitializeComponent();

        }

        private void cmbStatistikaOdabir_SelectedIndexChanged(object sender, EventArgs e)
        {
            var toDel = Controls.Find("gridview", true);
            if(toDel.Length != 0) { this.Controls.Remove(toDel[0]); }

            int X = Convert.ToInt32(cmbStatistikaOdabir.Location.X);
            int Y = Convert.ToInt32(cmbStatistikaOdabir.Location.Y)+50;
            if (cmbStatistikaOdabir.SelectedItem.ToString().Equals("Igrači"))
            {
                gv = new GridView_punjenje('I', X, Y, 0);
                gv.gv.Name = "gridview";
                GV_Click_Igrac();
                trenutni = 0;
                this.Controls.Add(gv.gv);
            }
            else if (cmbStatistikaOdabir.SelectedItem.ToString().Equals("Ekipe"))
            {
                gv = new GridView_punjenje('S', X, Y, 0);
                gv.gv.Name = "gridview";
                GV_Click_Ekipe();
                trenutni = 1;
                this.Controls.Add(gv.gv);
            }
        }

        private void GV_Click_Igrac()
        {
            gv.gv.CellClick += (s, e) =>
            {
                igrac_id = (Igraci)this.gv.igr[e.RowIndex];
                id_send_to_form = igrac_id.Id;
                type_send_to_form = 'I';
                name_send_to_form = igrac_id.Ime;
                Prikaz_statistika();
            };
        }
        private void GV_Click_Ekipe()
        {
            gv.gv.CellClick += (s, e) =>
            {
                ekipa_id = (Ekipa)this.gv.ek[e.RowIndex];
                id_send_to_form = ekipa_id.Id;
                type_send_to_form = 'E';
                name_send_to_form = ekipa_id.Naziv;
                Prikaz_statistika();
            };
        }

        private void Prikaz_statistika()
        {
            try
            {
                DB_connection.OpenConn();
                switch (trenutni)
                {
                    case 0:
                        {
                            stat = DB_GET.Statistika_Get_By_Id(igrac_id.Id, 'I');
                            break;
                        }
                    case 1:
                        {
                            stat = DB_GET.Statistika_Get_By_Id(ekipa_id.Id, 'E');
                            break;
                        }
                }
                DB_connection.CloseConn();
            }
            catch(ArgumentException err)
            {
                lblStatistikaResult.ForeColor = System.Drawing.Color.Red;
                Change_label("Greška kod čitanja podataka: " + err.ToString());
            }
            
            
            List<decimal> podaci_Visina = new List<decimal>();
            List<decimal> podaci_Tezina = new List<decimal>();
            List<decimal> podaci_Raspon = new List<decimal>();
            List<decimal> podaci_Brzina = new List<decimal>();
            List<decimal> podaci_BrzinaSU = new List<decimal>();
            List<decimal> podaci_Skok = new List<decimal>();
            List<decimal> podaci_PostotakS = new List<decimal>();
            List<decimal> podaci_PostotakP = new List<decimal>();
            decimal podatak_Prisutnos = 0;
            if (stat.Count > 0)
            {
                stat[0].Izracun_postotka_prisutnosti();
                podatak_Prisutnos = Math.Round(stat[0].Postotak_prisutnost * 100, 2);
            }
            
            
            
            foreach (var s in stat)
            {
                if (s.Postotak_prisutnost != 0) { podaci_PostotakP.Add(s.Postotak_prisutnost); }
                if (s.Visina != 0) { podaci_Visina.Add(s.Visina); }
                if (s.Tezina != 0) { podaci_Tezina.Add(s.Tezina); }
                if (s.Raspon_ruku != 0) { podaci_Raspon.Add(s.Raspon_ruku); }
                if (s.Brz_Spr != 0) { podaci_Brzina.Add(s.Brz_Spr); }
                if (s.Brz_SU != 0) { podaci_BrzinaSU.Add(s.Brz_SU); }
                if (s.Skok_ud != 0) { podaci_Skok.Add(s.Skok_ud); }

            }

            chartStatistikaVisina.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Title = "Visina",
                    Values = new ChartValues<decimal>(podaci_Visina),
                    Fill = new SolidColorBrush(System.Windows.Media.Color.FromArgb(150, 0, 40, 204))
                    
                }
            };
            chartStatistikaTezina.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Title = "Težina",
                    Fill = new SolidColorBrush(System.Windows.Media.Color.FromArgb(150, 221, 3, 3)),
                    Values = new ChartValues<decimal>(podaci_Tezina)
                }
            };
            chartStatistikaSkokU.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Title = "Skok udalj",
                    Fill = new SolidColorBrush(System.Windows.Media.Color.FromArgb(150, 33, 170, 33)),
                    Values = new ChartValues<decimal>(podaci_Skok)
                    
                }
            };
            chartStatistikaRasponR.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Title = "Raspon ruku",
                    Fill = new SolidColorBrush(System.Windows.Media.Color.FromArgb(150, 126, 11, 126)),
                    Values = new ChartValues<decimal>(podaci_Raspon)
                }
            };
            chartStatistikaBrzinaS.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Title = "Brzina šprint",
                    Fill = new SolidColorBrush(System.Windows.Media.Color.FromArgb(150, 20, 220, 200)),
                    Values = new ChartValues<decimal>(podaci_Brzina)
                }
            };
            chartStatistikaBrzinaSU.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Title = "Brzina - samoubojstvo",
                    Fill = new SolidColorBrush(System.Windows.Media.Color.FromArgb(150, 243, 235, 27)),
                    Values = new ChartValues<decimal>(podaci_BrzinaSU)
                }
            };
            pieStatistikaPrisutnost.Series = new SeriesCollection
            {
                new PieSeries
                {
                    Title = "Prisutan",
                    Fill = new SolidColorBrush(System.Windows.Media.Color.FromArgb(150, 23, 211, 111)),
                    Values = new ChartValues<decimal>{podatak_Prisutnos}
                },
                new PieSeries
                {
                    Title = "Odsutan",
                    Fill = new SolidColorBrush(System.Windows.Media.Color.FromArgb(150, 230, 10, 15)),
                    Values = new ChartValues<decimal>{ 100-podatak_Prisutnos}
                }
                
            };

        }

        private void btnStatistikaKosevi_Click(object sender, EventArgs e)
        {
            new Prikaz_suteva(id_send_to_form, type_send_to_form, name_send_to_form, stat).Show();
        }

        private void Change_label(string str)
        {
            lblStatistikaResult.Text = str.ToString();
            lblStatistikaResult.Visible = true;
            var t = new Timer();
            t.Interval = 3000;
            t.Start();
            t.Tick += (s, e) =>
            {
                lblStatistikaResult.Visible = false;
                lblStatistikaResult.ForeColor = System.Drawing.Color.LimeGreen;
                t.Stop();
            };
        }
    }
}
