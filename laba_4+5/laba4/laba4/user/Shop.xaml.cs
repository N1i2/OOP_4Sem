using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Policy;
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
    public enum Fone
    {
        white = 0,
        black = 1,
    }
    public partial class Shop : Page
    {
        private static Fone backFone = 0;

        public static Fone GetFone()
        {
            return backFone;
        }

        private bool Administrator;
        List<Product> prod;
        LanduegeSettings leng = new AngText();
        List<Product> result = new List<Product>();
        public bool find { get; set; } = false;


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
        public Shop(bool admin, bool needCreate = true, Fone fon = (Fone)0) : this(needCreate)
        {
            backFone = fon;
            Administrator = admin;

            if (backFone == Fone.black)
            {
                blackItem.IsSelected = true;
                ComboBox_SelectionChanged_1(0, null);
            }

            if (Administrator)
            {
                welcome.Visibility = Visibility.Hidden;
                welcomeA.Visibility = Visibility.Visible;
                ButtonAdd.Visibility = Visibility.Visible;
            }
        }
        public Shop(Product prd, Fone fon = (Fone)0) : this(true, false, fon)
        {
            prod.Add(prd);

            ClearAllProduct();
            CreatProduct(prod);

            FileWork.Serialize(prod);
        }
        private void CreatProduct(List<Product> produ)
        {
            foreach (var prd in produ)
            {
                Brush border;
                Brush textCol;
                Brush emptyProdBorder = new SolidColorBrush(Color.FromRgb(170, 60, 48));

                if (backFone == Fone.white)
                {
                    border = Brushes.White;
                    textCol = Brushes.Black;
                }
                else
                {
                    border = new SolidColorBrush(Color.FromRgb(34, 34, 34));
                    textCol = Brushes.White;
                }

                Border bord = new Border
                {
                    Height = 180,
                    Width = 145,
                    Margin = new Thickness(6.5),
                    BorderThickness = new Thickness(1),
                    BorderBrush = (prd.Quantity == 0) ? emptyProdBorder : border,
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
                    Foreground = textCol,
                    FontSize = 16
                };
                TextBlock txtIndivid = new TextBlock
                {
                    Text = prd.Name + " = " + prd.Price,
                    Margin = new Thickness(0, 155, 17, -1),
                    Foreground = textCol,
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
            fullProduct full;

            if (find)
            {
                full = new fullProduct(result, index, Administrator);
            }
            else
            {
                full = new fullProduct(prod, index, Administrator);
            }

            Click cl = new Click(full);

            NavigationService.Navigate(full);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void TextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key != Key.Enter)
            {
                return;
            }

            Keyboard.ClearFocus();
            ClearAllProduct();
            result = new List<Product>();

            if (searchBox.Text.Replace(" ", "") == string.Empty)
            {
                CreatProduct(prod);
                searchBox.Text = string.Empty;
                find = false;
                return;
            }

            if (filterBox.SelectedIndex == 0)
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
                if (!double.TryParse(searchBox.Text, out double price))
                {
                    CreatProduct(prod);

                    MessageBox.Show(leng.notNumberError);
                    Keyboard.ClearFocus();

                    return;
                }

                foreach (var pr in prod)
                {
                    if (price >= pr.Price)
                    {
                        result.Add(pr);
                    }
                }
            }

            if (result.Count == 0)
            {
                CreatProduct(prod);

                find = false;
                MessageBox.Show(leng.resultEmptyError);
                Keyboard.ClearFocus();

                return;
            }

            find = true;
            CreatProduct(result);
        }
        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                Uri uriL;
                ResourceDictionary res;

                if (languge.SelectedIndex == 0)
                {
                    uriL = new Uri(@"resurs/langugeTextEng.xaml", UriKind.Relative);
                    leng = new AngText();
                }
                else
                {
                    uriL = new Uri(@"resurs/langugeTextRu.xaml", UriKind.Relative);
                    leng = new RuText();
                }

                System.Windows.Application.Current.Resources.Clear();

                res = (System.Windows.Application.LoadComponent(uriL) as ResourceDictionary) ?? throw new Exception("Error with resource");
                System.Windows.Application.Current.Resources.MergedDictionaries.Add(res);
            }
            catch (Exception)
            {

            }
        }
        private void ComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                Uri uriF;
                ResourceDictionary res;

                backFone = (Fone)fone.SelectedIndex;

                if (fone.SelectedIndex == 0)
                {
                    uriF = new Uri(@"resurs/WhiteFone.xaml", UriKind.Relative);
                }
                else
                {
                    uriF = new Uri(@"resurs/BlackFone.xaml", UriKind.Relative);
                }


                System.Windows.Application.Current.Resources.Clear();

                res = (System.Windows.Application.LoadComponent(uriF) as ResourceDictionary) ?? throw new Exception("Error with resource");
                System.Windows.Application.Current.Resources.MergedDictionaries.Add(res);

                ClearAllProduct();
                CreatProduct((result.Count == 0) ? prod : result);
            }
            catch (Exception)
            {

            }
        }
    }
}
