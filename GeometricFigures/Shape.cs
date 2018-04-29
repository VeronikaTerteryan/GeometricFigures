using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFigures
{
   public abstract class Shape
    {
        public virtual byte Heigth { get; set; }
        public virtual byte Width { get; set; }
        public abstract void Draw(); 
    }
}


    
    
