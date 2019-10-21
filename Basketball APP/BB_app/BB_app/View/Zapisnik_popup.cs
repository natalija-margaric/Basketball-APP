using BB_app.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BB_app.View
{
    public partial class Zapisnik_popup : Form
    {
        public Ekipa eki = new Ekipa();
        public Zapisnik_popup(int X, int Y, Ekipa ek)
        {
            InitializeComponent();
            this.Location = new Point(X+100, Y+100);
            eki = ek;
        }

        private void btnZapisnikPop01_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnZapisnikPop02_Click(object sender, EventArgs e)
        {
            //pozivanje forme za unos suteva
            new KoseviSut('E', eki).Show();
            this.Close();
        }

        private void btnZapisnikPop03_Click(object sender, EventArgs e)
        {
            new KoseviSut('I', eki).Show();
            this.Close();
        }
    }
}
