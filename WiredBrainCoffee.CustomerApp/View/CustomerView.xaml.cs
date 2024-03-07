using System.Windows;
using System.Windows.Controls;
using WiredBrainCoffee.CustomerApp.ViewModel;
using WiredBrainCoffee.CustomersApp.Data;

namespace WiredBrainCoffee.CustomerApp.View
{
    /// <summary>
    /// Interaction logic for CustomerView.xaml
    /// </summary>
    public partial class CustomerView : UserControl
    {
        private CustomerViewModel _viewModel;

        public CustomerView()
        {
            InitializeComponent();
            _viewModel = new CustomerViewModel(new CustomerDataProvider());
            DataContext = _viewModel;
            Loaded += CustomerView_Loaded;
        }

        private async void CustomerView_Loaded(object sender, RoutedEventArgs e)
        {
            await _viewModel.LoadAsync();
        }
    }
}
