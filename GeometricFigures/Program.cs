using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            Line l1 = new Line(5);
            Line l2 = new Line(0, 6);

            l1.Draw();
            l2.Draw();

            Rectangle rc = new Rectangle(19, 80);
            rc.Draw();

            Rectangle r3 = new Rectangle(rc);
            Rectangle r4 = new Rectangle(r3);

            
            Circle crc = new Circle(20);
            crc.Draw();
            

        }
    }
}
