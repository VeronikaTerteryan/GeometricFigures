using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFigures
{
    public class Circle : Shape
    {
        public Circle(byte diameter) 
        {
            Width = Heigth = diameter;
        }        
        public override void Draw()
        {
            int thickness = 0;
            double radious = Heigth / 2;
            double rIn = radious - thickness, rOut = radious + thickness;

            for (double y = radious; y >= -radious; --y)
            {
                for (double x = -radious; x <= rOut; x += 0.5)
                //for (double x = -radious; x < radious; x += 1)
                {
                    double value = x * x + y * y;
                    if (value >= rIn * rIn && value <= rOut * rOut)
                    {
                        Console.Write('*');
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}