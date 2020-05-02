using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace TestTabControl
{
    static class ShapeProvider
    {
        public static ObservableCollection<Shape> GetShapes()
        {
            var retColl = new ObservableCollection<Shape>()
            {
            new Rectangle(100, 20),
            new Rectangle(50, 30),
            new Ellipse(70, 40),
            new Ellipse(50, 50),
            new Ellipse(0, 40)
            };
            return retColl;

        }
    }
}
