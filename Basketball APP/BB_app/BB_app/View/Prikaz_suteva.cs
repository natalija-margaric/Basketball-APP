using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.Wpf;
using LiveCharts.WinForms;
using BB_app.Presenter;
using BB_app.Model.DB;
using BB_app.Model;
using System.Windows.Media;

namespace BB_app.View
{
    public partial class Prikaz_suteva : Form
    {
        public decimal count_pogodeno = 0;
        List<Statistika> statistika = new List<Statistika>();
        public Prikaz_suteva(int entitet_id, char vrsta, string naslov, List<Statistika> stat)
        {
            InitializeComponent();
            statistika = stat;
            DB_connection.OpenConn();
            List<Kosevi> sut = DB_GET.Kosevi_Get_By_Id(entitet_id, vrsta); //dobivanje suteva po igracu/ekipi
            DB_connection.CloseConn();
            var picb_H = picbPrikazSutevaTeren.Height;
            var picb_W = picbPrikazSutevaTeren.Width;

            
            foreach (var sutevi in sut)
            {
                if(sutevi.Pogodak == true)
                {
                    count_pogodeno++;
                }
                var poz_X = sutevi.Poz_X * picb_W + picbPrikazSutevaTeren.Location.X;
                var poz_Y = sutevi.Poz_Y * picb_H + picbPrikazSutevaTeren.Location.Y;
                var img = new PrikazSuteva_pozicije(sutevi.Pogodak, poz_X, poz_Y); //instanciranje novog prikaza za svaki sut
                this.Controls.Add(img.pic);
                img.pic.BringToFront(); //da bude ispred prijasnje dodanih
                img.pic.BackColor = System.Drawing.Color.FromArgb(255, 0, 6, 58);
            }

            List<decimal> podaci_sutevi = new List<decimal>();
            foreach(var s in statistika)
            {
                if(s.Postotak_suteva != 0) { podaci_sutevi.Add(Math.Round(s.Postotak_suteva * 100, 2)); }
            }
            decimal rate = Math.Round((count_pogodeno / sut.Count) * 100, 2);
            lblPrikazSutevaIme.Text = naslov.ToString();

            piePrikazSuteva.Series = new SeriesCollection
            {
                new PieSeries
                {
                    Title = "Pogođeno",
                    Fill = new SolidColorBrush(System.Windows.Media.Color.FromArgb(150, 8, 231, 223)),
                    Values = new ChartValues<decimal> {rate}
                },
                new PieSeries
                {
                    Title = "Promašeno",
                    Fill = new SolidColorBrush(System.Windows.Media.Color.FromArgb(150, 210, 8, 12)),
                    Values = new ChartValues<decimal> {100-rate}
                }
            };

            chartPrikazSuteva.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Title = "Postotak šuteva po sekcij",
                    Fill = new SolidColorBrush(System.Windows.Media.Color.FromArgb(150, 7, 232, 180)),
                    Values = new ChartValues<decimal>(podaci_sutevi)
                }
            };
        }
    }
}
