using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFigures
{
    class Line : Shape
    {
        public Line(byte height)
        {
            Debug.Print("line constructor 1 has been called");
            Heigth = height;
        }
        public Line(byte height, byte width)
        {
            Debug.Print("line constructor 2 has been called");
            Heigth = height;
            Width = width;
        }


        private byte heigth;
        public  override byte Heigth
        {
            get => heigth;
            set
            {
                width = 0;
                heigth = value;
            }
        }

        private byte width;
        public override byte Width
        {
            get => width;
            set
            {
                heigth = 0;
                width = value;
            }
        }

        public bool IsHorizontal => heigth == 0;

        public override void Draw()
        {
            if (IsHorizontal)
            {
                for (int i = 0; i < width; i++)
                    Console.Write(" - ");
            }
            else
            {
                for (int i = 0; i < heigth; i++)
                    Console.WriteLine("|");
            }

        }
    }
}
