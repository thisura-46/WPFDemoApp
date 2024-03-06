using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WiredBrainCoffee.CustomerApp.View
{
    /// <summary>
    /// Interaction logic for CustomerView.xaml
    /// </summary>
    public partial class CustomerView : UserControl
    {
        public CustomerView()
        {
            InitializeComponent();
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
