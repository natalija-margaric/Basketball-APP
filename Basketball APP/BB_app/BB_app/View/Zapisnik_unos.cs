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

namespace BB_app.View
{
    public partial class Zapisnik_unos : Form
    {
        Ekipa ek;
        public Zapisnik_unos()
        {
            InitializeComponent();
            var ek = new List<Ekipa>();
            DB_connection.OpenConn();
            ek = DB_GET.Ekipa_Get_All();
            DB_connection.CloseConn();
            cmbZapisnik01.Items.Clear();
            cmbZapisnik01.DisplayMember = "Naziv";
            foreach (var i in ek) { cmbZapisnik01.Items.Add(i); }
        }

        private void btnZapisnik01_Click(object sender, EventArgs e)
        {
            var X = btnZapisnik01.Location.X;
            var Y = btnZapisnik01.Location.Y;
            new Zapisnik_popup(X, Y, ek).Show();
        }

        private void btnZapisnik02_Click(object sender, EventArgs e)
        {
            var zap = new Zapisnik();
            
            zap.Datum = (DateTime)calendarZapisnik.SelectionRange.Start;
            zap.Ekipa_id = ek.Id;
            zap.Ekipa_gost = txtbZapisnik01.Text;
            zap.Rez_dom = Int32.Parse(txtbZapisnik02.Text);
            zap.Rez_gost = Int32.Parse(txtbZapisnik03.Text);
            try
            {
                DB_connection.OpenConn();
                DB_PUT.Zapisnik_Put(zap);
                DB_connection.CloseConn();
                this.Close();
            }
            catch(ArgumentException err)
            {
                lblZapisnikResult.ForeColor = Color.Red;
                Change_label(err.ToString());
            }
            
        }

        private void btnZapisnik03_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbZapisnik01_SelectedIndexChanged(object sender, EventArgs e)
        {
            ek = new Ekipa();
            ek = (Ekipa)cmbZapisnik01.SelectedItem;
        }

        private void Change_label(string str)
        {
            lblZapisnikResult.Text = str.ToString();
            lblZapisnikResult.Visible = true;
            var t = new Timer();
            t.Interval = 3000;
            t.Start();
            t.Tick += (s, e) =>
            {
                lblZapisnikResult.Visible = false;
                lblZapisnikResult.ForeColor = Color.LimeGreen;
                t.Stop();
            };
        }
    }
}
