using System;
using System.Collections.Generic;
using System.IO;
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
using static System.Net.Mime.MediaTypeNames;

namespace laba4
{
    public partial class Shop : Page
    {
        private bool Administrator;
        List<Product> prod;
        LanduegeSettings leng = new AngText();
        public Shop(bool needCreate = true)
        {
            InitializeComponent();

            this.Width = 710;
            this.Height = 590;

            ButtonAdd.Visibility = Visibility.Hidden;

            prod = new List<Product>();
            prod = FileWork.Deserialize();

            if (needCreate)
                CreatProduct(prod);
        }
        public Shop(bool admin, bool needCreate = true) : this(needCreate)
        {
            Administrator = admin;

            if (Administrator)
            {
                welcome.SetResourceReference(Control.StyleProperty, "welcomAdmin");
                ButtonAdd.Visibility = Visibility.Visible;
            }
        }
        public Shop(Product prd) : this(true, false)
        {
            prod.Add(prd);

            CreatProduct(prod);

            FileWork.Serialize(prod);
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
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
        private void CreatProduct(List<Product> produ)
        {
            foreach (var prd in produ)
            {
                Border bord = new Border
                {
                    Height = 180,
                    Width = 145,
                    Margin = new Thickness(6.5),
                    BorderThickness = new Thickness(1),
                    BorderBrush = (prd.Quantity == 0) ? Brushes.Red : Brushes.White,
                };
                Grid grid = new Grid
                {
                    Cursor = Cursors.Hand,
                };
                bord.PreviewMouseLeftButtonDown += ShowProduct;

                var img = new System.Windows.Controls.Image
                {
                    Height = 145,
                    Margin = new Thickness(0, 0, 0, 40),
                    Source = new BitmapImage(new Uri(prd.PicturePath ?? "hello.png", UriKind.RelativeOrAbsolute))
                };

                ToolTip imgTip = new ToolTip();
                imgTip.Content = prd.Description;
                img.ToolTip = imgTip;

                TextBlock txtNorma = new TextBlock
                {
                    Text = "Name = Price",
                    Margin = new Thickness(0, 135, 17, 20),
                    Foreground = Brushes.Black,
                    FontSize = 16
                };
                TextBlock txtIndivid = new TextBlock
                {
                    Text = prd.Name + " = " + prd.Price,
                    Margin = new Thickness(0, 155, 17, -1),
                    Foreground = Brushes.Black,
                    FontSize = 16
                };

                grid.Children.Add(img);
                grid.Children.Add(txtNorma);
                grid.Children.Add(txtIndivid);
                bord.Child = grid;
                productList.Children.Add(bord);
            }
        }
        private void ClearAllProduct()
        {
            productList.Children.Clear();
        }
        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddNewProduct());
        }

        private void ShowProduct(object sender, MouseButtonEventArgs e)
        {
            int index = productList.Children.IndexOf(sender as Border);

            NavigationService.Navigate(new fullProduct(prod, index, Administrator));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void TextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.Key != Key.Enter)
            {
                return;
            }

            Keyboard.ClearFocus();
            ClearAllProduct();

            if (searchBox.Text.Replace(" ", "") == string.Empty)
            {
                CreatProduct(prod);
                searchBox.Text = string.Empty;
                return;
            }

            List<Product> result = new List<Product>();

            if(filterBox.SelectedIndex == 0)
            {
                foreach (var pr in prod)
                {
                    if ((pr.Name ?? "").Contains(searchBox.Text))
                    {
                        result.Add(pr);
                    }
                }
            }
            else
            {
                if(!double.TryParse(searchBox.Text, out double price))
                {
                    CreatProduct(prod);

                    MessageBox.Show(leng.notNumberError);
                    Keyboard.ClearFocus();

                    return;
                }

                foreach (var pr in prod)
                {
                    if(price >= pr.Price)
                    {
                        result.Add(pr);
                    }
                }
            }

            if(result.Count == 0)
            {
                CreatProduct(prod);

                MessageBox.Show(leng.resultEmptyError);
                Keyboard.ClearFocus();

                return;
            }

            CreatProduct(result);
        }
    }
}
