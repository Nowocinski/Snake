using System.Drawing;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Snake_v2
{
    public enum Kierunek { left, right, top, down };

    class Head : Food
    {
        private int speedX, speedY;

        public int X { get; set; }
        public int Y { get; set; }

        /* Dziedziczenie konstruktora bazowego */
        public Head() : base()
        { color = Brushes.DarkRed; speedX = 20; speedY = 0;}

        public Head(int x, int y) : base(x, y)
        { color = Brushes.DarkRed; speedX = 20; speedY = 0;}

        public override void Rysuj(PaintEventArgs e)
        { Speed(); base.Rysuj(e);}

        private void Speed(){X = x; Y = y; x += speedX; y += speedY;}

        public void GameOver(Timer timer, List<BodyPart> b, int h, int w)
        {
            if (x < 0 || y < 0 || x > w-15 || y > h-19) timer.Stop();

            foreach(BodyPart item in b)
                if (item.x == x && item.y == y)
                    timer.Stop();
        }

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
