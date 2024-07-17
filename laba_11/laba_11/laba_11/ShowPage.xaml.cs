using System.Windows;
using System.Windows.Controls;

namespace laba_11
{
    public partial class ShowPage : Page
    {
        private CartViewModel? _cartViewModel;

        public ShowPage()
        {
            InitializeComponent();
        }
        public ShowPage(CartViewModel cartViewModel):this()
        {
            this._cartViewModel = cartViewModel;
            this.DataContext = _cartViewModel;
        }

        private void GoBackButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}