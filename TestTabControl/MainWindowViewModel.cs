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
            Shapes= ShapeProvider.GetShapes();
        }

    }
}
