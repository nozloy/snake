using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snakeapp
{
    class Vline
    {
        List<Point> pList;

        public Vline(int x,int yleft, int yRight, char sym)
        {
            pList = new List<Point>();
            for (int y = yleft; y <= yRight; y++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }

        }
        public void DrawLine()
        {
            foreach (Point p in pList)
            {
                p.Draw();
            }

        }
    }
}
