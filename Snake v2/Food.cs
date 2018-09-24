using System.Drawing;
using System.Windows.Forms;

namespace Snake_v2
{
    class Food
    {
        public int x, y; 
        protected int size;
        protected Brush color;

        public Food()
        { x = y = 20; size = 19; color = Brushes.Orange; }

        public Food(int x, int y)
        { this.x = x; this.y = y; size = 19; color = Brushes.Orange; }

        public virtual void Rysuj(PaintEventArgs e)
        { e.Graphics.FillRectangle(color, x, y, size, size); }
    }
}
