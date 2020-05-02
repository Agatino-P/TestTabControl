using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace TestTabControl
{
    public class ShapeFilteringViewModel: ViewModelBase
    {
        private string _shapeType; public string ShapeType { get => _shapeType; set { Set(() => ShapeType, ref _shapeType, value); }}

        private ObservableCollection<Shape> _filteredShapes= new ObservableCollection<Shape>();
        public ObservableCollection<Shape> FilteredShapes { get => _filteredShapes; set { Set(() => FilteredShapes, ref _filteredShapes, value); }}

        public ShapeFilteringViewModel(string shapeType)
        {
            FilteredShapes = new  ObservableCollection<Shape> ( ShapeProvider.GetShapes().Where((s) => s.Name == shapeType) );
        }
    }
}
