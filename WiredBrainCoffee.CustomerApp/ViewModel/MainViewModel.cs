using WiredBrainCoffee.CustomerApp.Command;

namespace WiredBrainCoffee.CustomerApp.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private ViewModelBase? _selectedViewModel;

        public MainViewModel(CustomerViewModel customerViewModel, ProductsViewModel productsViewModel)
        {
            CustomerViewModel = customerViewModel;
            ProductsViewModel = productsViewModel;
            SelectedViewModel = CustomerViewModel;
            SelectViewModelCommand = new DelegateCommand(SelectViewModel);
        }

        public ViewModelBase? SelectedViewModel
		{
			get => _selectedViewModel;
			set 
			{ 
				_selectedViewModel = value;
				RaisePropertyChanged();
			}
		}

        public CustomerViewModel CustomerViewModel { get; }

        public ProductsViewModel ProductsViewModel { get; }

        public DelegateCommand SelectViewModelCommand { get; }

        public async override Task LoadAsync()
        {
            if (SelectedViewModel != null)
            {
                await SelectedViewModel.LoadAsync();
            }
        }

        private async void SelectViewModel(object? parameter)
        {
            SelectedViewModel = parameter as ViewModelBase;
            await LoadAsync();
        }

    }
}
