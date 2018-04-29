using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFigures
{
    public class Arrow : Shape
    {
        public Arrow(byte height, byte width)
        {
            Heigth = height;
            Width = width;
        }
        public bool IsHorizontal => Heigth == 0;
        public override void Draw()
        {  
            if (IsHorizontal)
            {
                Console.Write('>');
            }
            else
            {
                Console.WriteLine('v');
            }
        }
    }
}
