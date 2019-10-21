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
    public partial class Unos : Form
    {
        public Unos()
        {
            InitializeComponent();
        }

        private void btnUnosIgrac_Click(object sender, EventArgs e)
        {
            //za poziciju na ekranu, da se pojavi na sredini slike
            var x = (this.Width / 2) - (panelUnosIgr.Width / 2); 
            var y = (this.Height / 2) - (panelUnosIgr.Height / 2);
            panelUnosIgr.Location = new Point(x, y);

            var ek = new List<Ekipa>();

            try
            {
                DB_connection.OpenConn();
                ek = DB_GET.Ekipa_Get_All();
                DB_connection.CloseConn();
                cmbUnosIgr01.Items.Clear();
                cmbUnosIgr01.DisplayMember = "Naziv";
                foreach (var i in ek) { cmbUnosIgr01.Items.Add(i); }
            }
            catch(ArgumentException err)
            {
                lblUnosResult.ForeColor = Color.Red;
                Change_label("Greška kod punjenja liste: "+err.ToString());
            }
            

            //enable --> neme interakcije, visible --> ne vidi se
            panelUnosIgr.Visible = true;
            panelUnosIgr.Enabled = true;
            btnUnosIgrac.Visible = false;
            btnUnosIgrac.Enabled = false;
            btnUnosVjezba.Visible = false;
            btnUnosVjezba.Enabled = false;
            btnUnosEkipa.Visible = false;
            btnUnosEkipa.Enabled = false;
            btnUnosBrisi.Visible = false;
            btnUnosBrisi.Enabled = false;
        }

        private void btnUnosIgrPut_Click(object sender, EventArgs e)
        {
            var Igr = new Igraci();
            var Ek = new Ekipa();
            Ek = (Ekipa)cmbUnosIgr01.SelectedItem; 
            Igr.Ime = txtbUnosIgr01.Text;
            Igr.Prezime = txtbUnosIgr02.Text;
            Igr.Godiste = Int32.Parse(txtbUnosIgr03.Text);

            if (rbtnUnosIgr01.Checked) { Igr.Spol = Char.Parse(rbtnUnosIgr01.Text); }
            else if (rbtnUnosIgr02.Checked) { Igr.Spol = Char.Parse(rbtnUnosIgr02.Text); }

            if (chbUnosIgr01.Checked){ Igr.Karton = true; } 
            else{ Igr.Karton = false; }
            Igr.Ekipa_id = Ek.Id;

            try
            {
                DB_connection.OpenConn();
                DB_PUT.Igraci_Put(Igr);
                DB_connection.CloseConn();
                Change_label("Igrač " + Igr.Ime.ToString() + " unešen");
                btnUnosIgraca02_Click(sender, e);
            }
            catch(ArgumentException err)
            {
                lblUnosResult.ForeColor = Color.Red;
                Change_label("Greška kod unosa igrača: "+err.ToString());
            }
            
        }

        private void chbUnosVj05_CheckedChanged(object sender, EventArgs e)
        {
            //ovisno ako je check box oznacen se prikazuje textbox
            if (chbUnosVj05.Checked) { txtbUnosVj03.Visible = true; } 
            else { txtbUnosVj03.Visible = false; }
        }

        private void btnUnosVjezba_Click(object sender, EventArgs e)
        {
            var x = (this.Width/2)-(panelUnosVj.Width/2);
            var y = (this.Height/2)-(panelUnosVj.Height/2);
            panelUnosVj.Location = new Point(x, y);
            panelUnosVj.Enabled = true;
            panelUnosVj.Visible = true;

            btnUnosIgrac.Visible = false;
            btnUnosIgrac.Enabled = false;
            btnUnosVjezba.Visible = false;
            btnUnosVjezba.Enabled = false;
            btnUnosEkipa.Visible = false;
            btnUnosEkipa.Enabled = false;
            btnUnosBrisi.Visible = false;
            btnUnosBrisi.Enabled = false;
        }

        private void btnUnosVj01_Click(object sender, EventArgs e)
        {
            var vj = new Vjezbe();

            vj.Naziv = txtbUnosVj01.Text;
            vj.Opis = txtbUnosVj02.Text;

            if(chbUnosVj05.Checked && txtbUnosVj03.Text.Length != 0) { vj.Drugo = txtbUnosVj03.Text; }

            if (chbUnosVj01.Checked) { vj.Sutevi = true; }
            if (chbUnosVj02.Checked) { vj.Brzina = true; }
            if (chbUnosVj03.Checked) { vj.Brojac = true; }
            if (chbUnosVj04.Checked) { vj.Udaljenost = true; }
            try
            {
                DB_connection.OpenConn();
                DB_PUT.Vjezbe_Put(vj);
                DB_connection.CloseConn();
                Change_label("Vježba " + vj.Naziv.ToString() + " unesena");
                btnUnosVjezbi02_Click(sender, e);
            }
            catch(ArgumentException err)
            {
                lblUnosResult.ForeColor = Color.Red;
                Change_label("Greška kod unosa vježbe: "+err.ToString());
            }
            
        }

        private void btnUnosEkipa_Click(object sender, EventArgs e)
        {
            var x = (this.Width / 2) - (panelUnosEkipa.Width / 2);
            var y = (this.Height / 2) - (panelUnosEkipa.Height / 2);
            panelUnosEkipa.Location = new Point(x, y);
            panelUnosEkipa.Visible = true;
            panelUnosEkipa.Enabled = true;
            btnUnosIgrac.Visible = false;
            btnUnosIgrac.Enabled = false;
            btnUnosVjezba.Visible = false;
            btnUnosVjezba.Enabled = false;
            btnUnosEkipa.Visible = false;
            btnUnosEkipa.Enabled = false;
            btnUnosBrisi.Visible = false;
            btnUnosBrisi.Enabled = false;
        }

        private void btnUnosIgraca02_Click(object sender, EventArgs e)
        {
            panelUnosIgr.Visible = false;
            panelUnosIgr.Enabled = false;
            btnUnosIgrac.Visible = true;
            btnUnosIgrac.Enabled = true;
            btnUnosVjezba.Visible = true;
            btnUnosVjezba.Enabled = true;
            btnUnosEkipa.Visible = true;
            btnUnosEkipa.Enabled = true;
            btnUnosBrisi.Visible = true;
            btnUnosBrisi.Enabled = true;
        }

        private void btnUnosVjezbi02_Click(object sender, EventArgs e)
        {
            panelUnosVj.Visible = false;
            panelUnosVj.Enabled = false;
            btnUnosIgrac.Visible = true;
            btnUnosIgrac.Enabled = true;
            btnUnosVjezba.Visible = true;
            btnUnosVjezba.Enabled = true;
            btnUnosEkipa.Visible = true;
            btnUnosEkipa.Enabled = true;
            btnUnosBrisi.Visible = true;
            btnUnosBrisi.Enabled = true;
        }

        private void btnUnosEkipe02_Click(object sender, EventArgs e)
        {
            panelUnosEkipa.Visible = false;
            panelUnosEkipa.Enabled = false;
            btnUnosIgrac.Visible = true;
            btnUnosIgrac.Enabled = true;
            btnUnosVjezba.Visible = true;
            btnUnosVjezba.Enabled = true;
            btnUnosEkipa.Visible = true;
            btnUnosEkipa.Enabled = true;
            btnUnosBrisi.Visible = true;
            btnUnosBrisi.Enabled = true;
        }

        private void btnUnosEkipe01_Click(object sender, EventArgs e)
        {
            var ek = new Ekipa();
            ek.Naziv = txtbUnosEkipe.Text;
            ek.Trener = txtbUnosEkipe02.Text;

            try
            {
                DB_connection.OpenConn();
                DB_PUT.Ekipa_Put(ek);
                DB_connection.CloseConn();
                Change_label("Ekipa "+ek.Naziv.ToString()+" unešena");
                btnUnosEkipe02_Click(sender, e);
            }
            catch(ArgumentException err)
            {
                lblUnosResult.ForeColor = Color.Red;
                Change_label("Greška kod unosa ekipe: "+err.ToString());
            }
            
        }

        private void btnUnosBrisi_Click(object sender, EventArgs e)
        {
            new Brisanje_popup().Show();
        }

        private void Change_label(string str)
        {
            lblUnosResult.Text = str.ToString();
            lblUnosResult.Visible = true;
            var t = new Timer();
            t.Interval = 3000;
            t.Start();
            t.Tick += (s, e) =>
            {
                lblUnosResult.Visible = false;
                lblUnosResult.ForeColor = Color.LimeGreen;
                t.Stop();
            };
        }
    }
}
