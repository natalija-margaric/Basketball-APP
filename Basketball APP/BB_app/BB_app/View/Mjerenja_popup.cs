using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BB_app.Model.DB;
using BB_app.Model;

namespace BB_app.View
{
    public partial class Mjerenja_popup : Form
    {
        Igraci igr;
        public Mjerenja_popup(Igraci igrac, int X, int Y)
        {
            this.Location = new Point(X, Y);
            InitializeComponent();
            igr = igrac;
            lblMjerenjaIgrac.Text = igrac.Ime.ToString();
        }

        private void btnMjerenjeUnos_Click(object sender, EventArgs e)
        {
            Statistika stat = new Statistika();
            stat.Entity_Id = igr.Id;
            stat.Entity_type = 'I';
            stat.Visina = Int32.Parse(txtbMjerenjeVisina.Text);
            stat.Tezina = Int32.Parse(txtbMjerenjaTezina.Text);
            stat.Raspon_ruku = Int32.Parse(txtbMjerenjeRaspon.Text);
            stat.Brz_Spr = Int32.Parse(txtbMjerenjeBrzina01.Text);
            stat.Brz_SU = Int32.Parse(txtbMjerenjeBrzina02.Text);
            stat.Skok_ud = Int32.Parse(txtbMjerenjeSkok.Text);
            if (chcbMjerenjePrvo.Checked) { stat.Prvo_mjerenje = true; }
            else { stat.Prvo_mjerenje = false; }

            try
            {
                //spremanje podataka
                DB_connection.OpenConn();
                DB_PUT.Statistika_Put(stat);
                DB_connection.CloseConn();
                this.Close();
            }
            catch (ArgumentException err)
            {
                lblMjerenjaResult.ForeColor = Color.Red;
                Change_label("Greška kod spremanja podataka: " + err.ToString());
            }
            
        }

        private void btnMjereneIzadi_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Change_label(string str)
        {
            lblMjerenjaResult.Text = str.ToString();
            lblMjerenjaResult.Visible = true;
            var t = new Timer();
            t.Interval = 3000;
            t.Start();
            t.Tick += (s, e) =>
            {
                lblMjerenjaResult.Visible = false;
                lblMjerenjaResult.ForeColor = Color.LimeGreen;
                t.Stop();
            };
        }
    }
}
