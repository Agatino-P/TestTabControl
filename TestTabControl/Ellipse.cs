using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Text;

namespace TestTabControl
{
    public class Ellipse : Shape
    {
        public Ellipse( double w, double h) : base(w, h)
        {
            Name = this.GetType().Name;
        }

    }
}
