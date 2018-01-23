using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometrie
{
    class EnhancedPoint : Point
    {
        EnhancedPoint()
        {
            x = 0;
            y = 0; 
        }

        EnhancedPoint(Point p)
        {
            x = p.x;
            y = p.y;
        }

        EnhancedPoint(int koordx, int koordy)
        {
            x = koordx;
            y = koordy;
        }

        public override string toString()
        {
            //string ret = "x-Wert:" + x.ToString() + ", y-Wert:" + y.ToString();
            return string.Format("x-Wert: {0}, y-Wert: {1}", x, y);
        }
    }
}
