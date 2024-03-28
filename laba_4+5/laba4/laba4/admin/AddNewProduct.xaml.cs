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
using laba4.message;
using laba4.worker;
using static System.Net.Mime.MediaTypeNames;

namespace laba4
{
    /// <summary>
    /// Interaction logic for AddNewProduct.xaml
    /// </summary>
    public partial class AddNewProduct : Page
    {
        private LanduegeSettings leng = new AngText();
        public AddNewProduct()
        {
            InitializeComponent();

            languge.SelectedIndex = 0;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
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
                languge.SelectedIndex = 0;
            }
        }

        private void TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !IsTextNumber(e.Text);
        }
        private static bool IsTextNumber(string str)
        {
            if (!int.TryParse(str, out int value) && str != ".")
                return false;
            return true;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var openFileDialog = new Microsoft.Win32.OpenFileDialog();
            openFileDialog.Filter = "Image files (*.png)|*.png";

            if (openFileDialog.ShowDialog() == true)
            {
                string imagePath = openFileDialog.FileName;
                pathImageBox.Text = imagePath;
            }
        }

        private void saveButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (nameBox.Text.Replace(" ", "") == string.Empty)
                {
                    throw new Exception(leng.nameError);
                }

                if (double.TryParse(priceBox.Text, out double doubleValue))
                {
                    if (doubleValue <= 0)
                        throw new Exception(leng.uncorrectPriceError);
                }
                else
                {
                    throw new Exception(leng.priceError);
                }

                if (pathImageBox.Text == string.Empty)
                {
                    throw new Exception(leng.pathError);
                }

                if (discriptionBox.Text.Replace(" ", "") == string.Empty)
                {
                    throw new Exception(leng.discriptionError);
                }

                if (fullDiscriptionBox.Text.Replace(" ", "") == string.Empty)
                {
                    throw new Exception(leng.fullDiscriptionError);
                }

                if (int.TryParse(quantityBox.Text, out int intValue))
                {
                    if (intValue < 0)
                        throw new Exception(leng.uncorrectQuantityError);
                }
                else
                {
                    throw new Exception(leng.quantityError);
                }

                Product prod = new Product(pathImageBox.Text, nameBox.Text, doubleValue, discriptionBox.Text, fullDiscriptionBox.Text, intValue);

                NavigationService.Navigate(new Shop(prod, Shop.GetFone()));
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }
    }
}
