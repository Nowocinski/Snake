using System.Drawing;
using System.Windows.Forms;

namespace Snake_v2
{
    class BodyPart : Food
    {
        public int xx, yy;
        /* Dziedziczenie konsturktora bazowego */
        public BodyPart() : base()
        { color = Brushes.White; x = y = 20; }

        public BodyPart(int x, int y) : base(x, y)
        { color = Brushes.White; }

        public void Rysuj(PaintEventArgs e, int x, int y)
        {
            e.Graphics.FillRectangle(color, x, y, size, size);
        }

        //public void Prześlij() { }
        //public void Jedzenie() { }
    }
}
