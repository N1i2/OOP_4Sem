using System.Windows;
using System.Windows.Controls;

namespace laba_11
{
    /// <summary>
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class Start : Page
    {
        private CartViewModel _cartViewModel;

        public Start()
        {
            InitializeComponent();

            _cartViewModel = new CartViewModel();
            this.DataContext = _cartViewModel;
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            string name = string.Empty;
            double price = 0;
            int quantity = 0;

            if (ProductName.Text != string.Empty &&
                double.TryParse(ProductPrice.Text, out double pr) &&
                int.TryParse(ProductQuantity.Text, out int qua))
            {
                name = ProductName.Text;
                price = pr;
                quantity = qua;
            }
            else
            {
                MessageBox.Show("Uncorect Inform");
                return;
            }

            ProductName.Text = string.Empty;
            ProductPrice.Text = string.Empty;
            ProductQuantity.Text = string.Empty;

            _cartViewModel.AddProductToCart(name, price, quantity);
        }

        private void RemoveButton_Click(object sender, RoutedEventArgs e)
        {
            string name = string.Empty;
            double price = 0;
            int quantity = 0;

            if (ProductName.Text != string.Empty &&
                double.TryParse(ProductPrice.Text, out double pr) &&
                int.TryParse(ProductQuantity.Text, out int qua))
            {
                name = ProductName.Text;
                price = pr;
                quantity = qua;
            }
            else
            {
                MessageBox.Show("Uncorect Inform");
                return;
            }

            var selectedProduct = new Product(ProductName.Text, price, quantity);

            ProductName.Text = string.Empty;
            ProductPrice.Text = string.Empty;
            ProductQuantity.Text = string.Empty;

            _cartViewModel.RemoveProductFromCart(selectedProduct);
        }
        private void ShowButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ShowPage(_cartViewModel));
        }
    }
}