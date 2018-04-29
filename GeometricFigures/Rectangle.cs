using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFigures
{

    public class Rectangle : Shape
    {
        
        public Rectangle(Rectangle rect)
        {
            Heigth = rect.Heigth;
            Width = rect.Width;
        }

        public Rectangle (byte height, byte width)
        {
            Heigth = height;
            Width = width;
        }



        public override void Draw()
        {
            for (int i = 0; i < Heigth; i++)
            {
                Console.WriteLine(new string('*', Width));
            }
        }
    }
}

