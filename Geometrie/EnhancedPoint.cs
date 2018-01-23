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

        public static EnhancedPoint operator +(EnhancedPoint punkt1,EnhancedPoint punkt2)
            {
                return new EnhancedPoint (punkt1.x + punkt2.x, punkt1.y +punkt2.y)
            }
        public static EnhancedPoint operator -(EnhancedPoint punkt1, EnhancedPoint punkt2)
        {
            return new EnhancedPoint(punkt1.x - punkt2.x, punkt1.y - punkt2.y)   
        }

        public static bool operator ==(EnhancedPoint punkt1, EnhancedPoint punkt2)
        {
            return (punkt1.x == punkt2.x && punkt1.y == punkt2.y);
        }

        public static bool operator !=(EnhancedPoint punkt1, EnhancedPoint punkt2)
        {
            return !(punkt1 == punkt2);
        }

        public static double distance(EnhancedPoint punkt1, EnhancedPoint punkt2)
        {
            return Math.Sqrt(Math.Pow((punkt1.x - punkt2.x), 2) + Math.Pow((punkt1.y - punkt2.y), 2));
        }

        public static explicit operator float(EnhancedPoint punkt1)
        {
            return (float)Math.Sqrt(Math.Pow((punkt1.x), 2) + Math.Pow(punkt1.y, 2));
        }
    }
}
