using System.Windows;
using M1Scan.ViewModels;

namespace M1Scan.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainViewModel();
        }
    }
}
