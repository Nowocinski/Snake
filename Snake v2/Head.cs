using System.Drawing;
using System.Windows.Forms;

namespace Snake_v2
{
    public enum Kierunek { left, right, top, down };

    class Head : BodyPart
    {
        private int speedX, speedY;
        //private Kierunek kierunek;

        /* Dziedziczenie konsturktora bazowego */
        public Head() : base()
        { color = Brushes.DarkRed; speedX = 20; speedY = 0;}

        public Head(int x, int y) : base(x, y)
        { color = Brushes.DarkRed; speedX = 20; speedY = 0;}

        public override void Rysuj(PaintEventArgs e) /* Rozdziel później!!! */
        { xx = x; yy=y ; x += speedX; y += speedY; e.Graphics.FillRectangle(color, x, y, size, size); }

        public void GameOver(Timer timer)
        { if (x <= 0 || y <= 0) timer.Stop(); }

        public void Poruszanie(Kierunek k)
        {
            if (speedY != 0)
            {
                if (k == Kierunek.left) { speedX = -20; speedY = 0; }
                else if (k == Kierunek.right) { speedX = 20; speedY = 0; }
            }
            
            else if (speedX != 0)
            {
                if (k == Kierunek.top) { speedX = 0; speedY = -20; }
                else if (k == Kierunek.down) { speedX = 0; speedY = 20; }
            }
        }
    }
}
