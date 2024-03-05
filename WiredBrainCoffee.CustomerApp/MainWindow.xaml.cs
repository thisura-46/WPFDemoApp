using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WiredBrainCoffee.CustomerApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonAddCustomer_Click(object sender, RoutedEventArgs e)
        {
            //btnAddCustomer.Content = "Customer Added";
        }

        private void ButtonMoveNavigation_Click(object sender, RoutedEventArgs e)
        {
            //var column = (int)CustomerListGrid.GetValue(Grid.ColumnProperty);
            //var newColumn = column == 0 ? 2 : 0;

            //CustomerListGrid.SetValue(Grid.ColumnProperty, newColumn);

            var column = Grid.GetColumn(CustomerListGrid);
            var newColumn = column == 0 ? 2 : 0;

            Grid.SetColumn(CustomerListGrid, newColumn);
        }
    }
}