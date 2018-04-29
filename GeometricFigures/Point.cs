using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFigures
{
     public class Point
    {
        private int x;
        private int y;
        public Point(int x, int y)
        {
            X = x;                       
            Y = y;
        }

        public int Y { get => y; set => y = value; }
        public int X { get => x; set => x = value; }

    }
}
