using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace TestTabControl 
{

    public class MainWindowViewModel : ViewModelBase
    {
        private ObservableCollection<Shape> _shapes = new ObservableCollection<Shape>();
        public ObservableCollection<Shape> Shapes { get => _shapes; set { Set(() => Shapes, ref _shapes, value); } }

        public MainWindowViewModel()
        {
            Shapes.Add(new Rectangle(100, 20));
            Shapes.Add(new Rectangle(50, 30));
            Shapes.Add(new Ellipse(70, 40));
            Shapes.Add(new Ellipse(50, 50));
            Shapes.Add(new Ellipse(10, 40));
        }

    }
}
