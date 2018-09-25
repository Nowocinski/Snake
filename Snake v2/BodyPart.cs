using System.Drawing;

namespace Snake_v2
{
    class BodyPart : Food
    {
        /* Dziedziczenie konstruktora bazowego */
        public BodyPart() : base()
        { color = Brushes.White; }

        public BodyPart(int x, int y) : base(x, y)
        { color = Brushes.White; }
    }
}
