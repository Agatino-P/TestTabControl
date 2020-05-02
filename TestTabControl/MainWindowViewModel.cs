using GalaSoft.MvvmLight;
using System.Collections.ObjectModel;

namespace TestTabControl
{

    public class MainWindowViewModel : ViewModelBase
    {
        private ObservableCollection<Shape> _shapes = new ObservableCollection<Shape>();
        public ObservableCollection<Shape> Shapes { get => _shapes; set => Set(() => Shapes, ref _shapes, value); }




        private ObservableCollection<ShapeFilteringViewModel> _shapeFilteringViewModels = new ObservableCollection<ShapeFilteringViewModel>();
        public ObservableCollection<ShapeFilteringViewModel> ShapeFilteringViewModels { get => _shapeFilteringViewModels; set => Set(() => ShapeFilteringViewModels, ref _shapeFilteringViewModels, value); }

        public MainWindowViewModel()
        {
            Shapes = ShapeProvider.GetShapes();
            ShapeFilteringViewModels.Add(new ShapeFilteringViewModel(typeof(Rectangle).Name));
            ShapeFilteringViewModels.Add(new ShapeFilteringViewModel(typeof(Ellipse).Name));

        }

    }
}
