using System;
using System.Collections.Generic;
using System.Drawing;
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
using laba4.message;
using laba4.worker;

namespace laba4
{
    public partial class fullProduct : Page
    {
        private bool needChange = false;
        private List<Product> products = new List<Product>();
        private LanduegeSettings leng = new AngText();
        private int idx;

        public fullProduct(List<Product> prod, int index, bool admin)
        {
            InitializeComponent();

            idx = index;
            products = prod;
            int quan = prod[index].Quantity;

            change.Visibility = (admin) ? Visibility.Visible : Visibility.Hidden;
            delete.Visibility = (admin) ? Visibility.Visible : Visibility.Hidden;

            order.Background = (quan == 0) ? Brushes.Gray : new SolidColorBrush(System.Windows.Media.Color.FromRgb(30, 66, 64));
            imageBord.BorderBrush = (quan == 0) ? Brushes.Red : Brushes.Green;

            image.Source = new BitmapImage(new Uri(prod[index].PicturePath ?? "hello.png", UriKind.RelativeOrAbsolute));
            name.Text = prod[index].Name;
            price.Text = prod[index].Price.ToString();
            quantity.Text = quan.ToString();
            discription.Text = prod[index].AllDescription;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (changNow)
            {
                MessageBoxResult chan = MessageBox.Show(leng.ansverChan, leng.hello, MessageBoxButton.YesNo);

                if (chan != MessageBoxResult.Yes)
                    return;
            }

            if (needChange)
            {
                FileWork.Serialize(products);
                NavigationService.Navigate(new Shop((delete.Visibility == Visibility.Visible), true));
                return;
            }
            NavigationService.GoBack();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (quantity.Text != "0")
            {
                products[idx].Quantity--;
                quantity.Text = products[idx].Quantity.ToString();

                if (quantity.Text == "0")
                {
                    FileWork.Serialize(products);
                    needChange = true;

                    order.Background = Brushes.Gray;
                }
            }
        }

        private void languge_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                Uri uri;
                if (languge.SelectedIndex == 0)
                {
                    uri = new Uri(@"resurs/langugeTextEng.xaml", UriKind.Relative);
                    leng = new AngText();
                }
                else
                {
                    uri = new Uri(@"resurs/langugeTextRu.xaml", UriKind.Relative);
                    leng = new RuText();
                }

                ResourceDictionary res = (System.Windows.Application.LoadComponent(uri) as ResourceDictionary) ?? throw new Exception("Error with resource");
                System.Windows.Application.Current.Resources.Clear();
                System.Windows.Application.Current.Resources.MergedDictionaries.Add(res);
            }
            catch (Exception)
            {

            }
        }

        private void delete_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult delete = MessageBox.Show(leng.ansverDel, leng.hello, MessageBoxButton.YesNo);

            if (delete == MessageBoxResult.Yes)
            {
                products.Remove(products[idx]);

                FileWork.Serialize(products);

                NavigationService.Navigate(new Shop(true, true));
            }
        }

        private bool changNow = false;

        private void change_Click(object sender, RoutedEventArgs e)
        {
            changNow = !changNow;
            needChange = true;

            if (changNow)
            {
                name.Visibility = Visibility.Hidden;
                price.Visibility = Visibility.Hidden;
                quantity.Visibility = Visibility.Hidden;
                discription.Visibility = Visibility.Hidden;

                nameB.Visibility = Visibility.Visible;
                priceB.Visibility = Visibility.Visible;
                quantityB.Visibility = Visibility.Visible;
                discriptionB.Visibility = Visibility.Visible;

                nameB.Text = name.Text;
                priceB.Text = price.Text;
                quantityB.Text = quantity.Text;
                discriptionB.Text = discription.Text;

                change.SetResourceReference(Control.StyleProperty, "ShowSaveChange");
            }
            else
            {
                if (nameB.Text.Replace(" ", "") == string.Empty)
                {
                    nameB.Text = name.Text;
                }
                if (!double.TryParse(priceB.Text, out double pri) || pri <= 0)
                {
                    priceB.Text = price.Text;
                }
                if(!int.TryParse(quantityB.Text, out int que) || que < 0)
                {
                    quantityB.Text = "0";
                }
                if(discriptionB.Text.Replace(" ", "") == string.Empty)
                {
                    discriptionB.Text = discription.Text;
                }

                products[idx].Name = nameB.Text;
                products[idx].Price = Convert.ToInt32(priceB.Text);
                products[idx].Quantity = Convert.ToInt32(quantityB.Text);
                products[idx].AllDescription = discriptionB.Text;

                nameB.Visibility = Visibility.Hidden;
                priceB.Visibility = Visibility.Hidden;
                quantityB.Visibility = Visibility.Hidden;
                discriptionB.Visibility = Visibility.Hidden;

                name.Visibility = Visibility.Visible;
                price.Visibility = Visibility.Visible;
                quantity.Visibility = Visibility.Visible;
                discription.Visibility = Visibility.Visible;

                name.Text = nameB.Text;
                price.Text = priceB.Text;
                quantity.Text = quantityB.Text;
                discription.Text = discriptionB.Text;

                change.SetResourceReference(Control.StyleProperty, "ShowChange");

                if (quantity.Text == "0")
                {
                    order.Background = Brushes.Gray;
                }
                else
                {
                    order.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(30, 66, 64));
                }
            }
        }
    }
}