using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestTabControl 
{
    abstract public class Shape : ObservableObject
    {
        private  string _name; public string Name { get => _name; set { Set(() => Name, ref _name, value); }}

        private double _w; public double W { get => _w; set { Set(() => W, ref _w, value); } }
        private double _h; public double H { get => _h; set { Set(() => H, ref _h, value); } }

        public Shape( double w = 0, double h = 0)
        {
           
            W = w;
            H = h;
        }


    }


}
