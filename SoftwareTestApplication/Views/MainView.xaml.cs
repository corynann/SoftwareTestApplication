using SoftwareTestApplication.ViewModels;
using System.Windows.Controls;

namespace SoftwareTestApplication.Views
{
    /// <summary>
    /// Interaction logic for MainView.xaml
    /// </summary>
    public partial class MainView : UserControl
    {
        MainViewModel vmMain = new MainViewModel();
        public MainView()
        {
            InitializeComponent();
            DataContext = vmMain;
        }
    }
}
