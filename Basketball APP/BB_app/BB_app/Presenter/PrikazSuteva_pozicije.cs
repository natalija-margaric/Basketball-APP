using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace BB_app.Presenter
{
    public class PrikazSuteva_pozicije
    {
        public decimal location_x;
        public decimal location_y;
        string path_true = @"C:\\Users\\Aldo\\source\\repos\\BB_app\\GitHub_repo\\PI_SportApp\\BB_app\\BB_app\\Resources\\true_sut.png";
        string path_false = @"C:\\Users\\Aldo\\source\\repos\\BB_app\\GitHub_repo\\PI_SportApp\\BB_app\\BB_app\\Resources\\false_sut.png";
        public PictureBox pic;
        
        //konstruktor prima: true/false kondicija (pogodeno ili ne), i pozicije
        public PrikazSuteva_pozicije(bool condition, decimal pX, decimal pY)
        {
            pic = new PictureBox();
            pic.Size = new Size(20, 20);
            pic.SizeMode = PictureBoxSizeMode.StretchImage;
            pic.BackColor = Color.Transparent;
            pic.Location = new Point((int)pX-10, (int)pY-10);//pozicija slike....kreira novu tocku
            if (condition) { pic.Image = new Bitmap(path_true); }//loada sliku ovisno ako je pokodeno ili ne
            else { pic.Image = new Bitmap(path_false); }


        }

    }
}
