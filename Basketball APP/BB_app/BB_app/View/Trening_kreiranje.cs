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
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace BB_app.View
{
    public partial class Trening_kreiranje : Form
    {
        public List<Ekipa> ek;
        public List<Igraci> igr;
        public List<Vjezbe> vj;
        DataGridView gv;
        public Trening_kreiranje()
        {

            InitializeComponent();

            ek = new List<Ekipa>();
            vj = new List<Vjezbe>();
            try
            {
                DB_connection.OpenConn();
                ek = DB_GET.Ekipa_Get_All();
                vj = DB_GET.Vjezbe_Get_All();
                DB_connection.CloseConn();
            }
            catch(ArgumentException err)
            {
                lblTreningKreirajResult.ForeColor = Color.Red;
                Change_label("Greška kod učitavanja podataka: " + err.ToString());
            }
            

            cmbTreningKreiraj01.Items.Clear();
            cmbTreningKreiraj01.DisplayMember = "Naziv";
            foreach(var i in ek) { cmbTreningKreiraj01.Items.Add(i); }

            var collection = new ObservableCollection<Vjezbe>(vj);
            collection.CollectionChanged += Collection_CollectionChanged;
            BindingSource datasource = new BindingSource(collection, null);
            dgvTreningKreiraj01.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTreningKreiraj01.AutoResizeColumns();
            dgvTreningKreiraj01.AllowUserToAddRows = false;
            
            dgvTreningKreiraj01.DataSource = datasource;
            dgvTreningKreiraj01.Columns["Id"].Visible = false;

            DataGridViewCheckBoxColumn chbCell = new DataGridViewCheckBoxColumn();
            chbCell.ValueType = typeof(bool);
            chbCell.Name = "Koristi";
            chbCell.HeaderText = "Koristi";
            dgvTreningKreiraj01.Columns.Add(chbCell);

        }

        private void cmbTreningKreiraj01_SelectedIndexChanged(object sender, EventArgs e)
        {
            var todel = Controls.Find("gv", true);
            if (todel.Length != 0) { this.Controls.Remove(todel[0]); }
            igr = new List<Igraci>();
            try
            {
                DB_connection.OpenConn();
                igr = DB_GET.Ekipa_Get_By_Id(ek[cmbTreningKreiraj01.SelectedIndex].Id);
                DB_connection.CloseConn();
            }
            catch(ArgumentException err)
            {
                lblTreningKreirajResult.ForeColor = Color.Red;
                Change_label("Greška kod učitavanja podataka" + err.ToString());
            }
            

            gv = new DataGridView();
            gv.Name = "gv";
            gv.AutoGenerateColumns = false;
            gv.Location = new Point(lblZapisnikKreiraj02.Location.X , lblZapisnikKreiraj02.Location.Y + 20);
            gv.ColumnCount = 3;
            
            var collection = new ObservableCollection<Igraci>(igr);
            BindingSource datasource = new BindingSource(collection, null);

            gv.Columns[0].HeaderText = "ID";
            gv.Columns[0].DataPropertyName = "ID";
            gv.Columns[1].HeaderText = "Ime";
            gv.Columns[1].DataPropertyName = "Ime";
            gv.Columns[2].HeaderText = "Prezime";
            gv.Columns[2].DataPropertyName = "Prezime";
            gv.DataSource = datasource;

            DataGridViewCheckBoxColumn chbCell = new DataGridViewCheckBoxColumn();
            chbCell.ValueType = typeof(bool);
            chbCell.Name = "Prisutan";
            chbCell.HeaderText = "Prisutan";
            gv.Columns.Add(chbCell);

            gv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gv.AutoResizeColumns();
            gv.AllowUserToAddRows = false;
            this.Controls.Add(gv);
        }

        private void btnTreningKreiraj01_Click(object sender, EventArgs e)
        {
            List<Igraci> igrac = new List<Igraci>();
            List<Prisutnost> pris = new List<Prisutnost>();
            
            List<Vjezbe> tren = new List<Vjezbe>();
            foreach(DataGridViewRow row in dgvTreningKreiraj01.Rows)
            {
                if (Convert.ToBoolean(row.Cells["Koristi"].Value) == true)
                {
                    tren.Add(row.DataBoundItem as Vjezbe);
                }   
                
            }
            Trening tr = new Trening(txtbTreningKreiraj01.Text, (int)tren.Count);
            Trening tr_id = new Trening();
            //Spremanje i dohvacanje spremljenog treninga
            try
            {
                DB_connection.OpenConn();
                DB_PUT.Trening_Put(tr);
                tr_id = DB_GET.Trening_Get_Last_Add();
                DB_connection.CloseConn();
                tr.Id = tr_id.Id;
            }
            catch(ArgumentException err)
            {
                lblTreningKreirajResult.ForeColor = Color.Red;
                Change_label("Greška kod spremanja treninga" + err.ToString());
            }
           

            foreach (DataGridViewRow row in gv.Rows)
            {
                Prisutnost p = new Prisutnost();
                p.Igrac_id = Convert.ToInt32(row.Cells[0].Value);
                p.Trening_id = tr.Id;
                p.Prisutan = Convert.ToBoolean(row.Cells["Prisutan"].Value);
                if (Convert.ToBoolean(row.Cells["Prisutan"].Value) == true)
                {
                    igrac.Add(row.DataBoundItem as Igraci);
                }
                pris.Add(p);
            }
            //Spremanje prisutnosti
            try
            {
                DB_connection.OpenConn();
                DB_PUT.Prisutnost_Put_List(pris);
                DB_connection.CloseConn();
                new Trening_dashboard(tr, igrac, tren).Show();
                this.Close();
            }
            catch(ArgumentException err)
            {
                lblTreningKreirajResult.ForeColor = Color.Red;
                Change_label("Greška kod spremanja prisutnosti: " + err.ToString());
            }

        }
        private void Change_label(string str)
        {
            lblTreningKreirajResult.Text = str.ToString();
            lblTreningKreirajResult.Visible = true;
            var t = new Timer();
            t.Interval = 3000;
            t.Start();
            t.Tick += (s, e) =>
            {
                lblTreningKreirajResult.Visible = false;
                lblTreningKreirajResult.ForeColor = Color.LimeGreen;
                t.Stop();
            };
        }
    }
}
