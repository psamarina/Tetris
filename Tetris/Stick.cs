using System;
using System.Collections.Generic;
using System.Text;

namespace Tetris
{
    class Stick
    {
        Point[] points = new Point[4];

        public Stick(int x, int y, char sym)
        {
            points[0] = new Point(x, y, sym);
            points[0] = new Point(x + 1, y, sym);
            points[0] = new Point(x, y + 3, sym);
            points[0] = new Point(x + 1, y + 3, sym);
        }
        public void Draw()
        {
            foreach (Point p in points)
            {
                p.Draw();
            }
               
        }

    }
}
