using System;
using System.Collections.Generic;
using System.Drawing;
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
using laba4.UndoRedo;
using laba4.worker;

namespace laba4
{
    public partial class fullProduct : Page
    {
        public bool needChange { get; set; } = false;
        public List<Product> products { get; set; } = new List<Product>();
        private LanduegeSettings leng = new AngText();
        public int idx { get; set; }
        private Click click = new Click();
        public bool changNow { get; set; } = false;

        public fullProduct()
        {

        }
        public fullProduct(List<Product> prod, int index, bool admin)
        {
            InitializeComponent();

            Larr.Visibility = Visibility.Hidden;
            Rarr.Visibility = Visibility.Hidden;

            idx = index;
            products = prod;
            int quan = prod[index].Quantity;

            change.Visibility = (admin) ? Visibility.Visible : Visibility.Hidden;
            delete.Visibility = (admin) ? Visibility.Visible : Visibility.Hidden;

            Brush orderFont;

            if (Shop.GetFone() == Fone.white)
            {
                orderFont = new SolidColorBrush(System.Windows.Media.Color.FromRgb(127, 147, 145));
            }
            else
            {
                orderFont = new SolidColorBrush(System.Windows.Media.Color.FromRgb(47, 67, 65));
            }

            order.Background = (quan == 0) ? Brushes.Gray : orderFont;
            imageBord.BorderBrush = (quan == 0) ? Brushes.Red : Brushes.Green;

            image.Source = new BitmapImage(new Uri(prod[index].PicturePath ?? "hello.png", UriKind.RelativeOrAbsolute));

            name.Text = prod[index].Name;
            price.Text = prod[index].Price.ToString();
            quantity.Text = quan.ToString();
            discription.Text = prod[index].AllDescription;

            nameB.Text = name.Text;
            priceB.Text = price.Text;
            quantityB.Text = quantity.Text;
            discriptionB.Text = discription.Text;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (changNow)
            {
                MessageBoxResult chan = MessageBox.Show(leng.ansverChan, leng.hello, MessageBoxButton.YesNo);

                if (chan != MessageBoxResult.Yes)
                    return;
            }

            saveAll.clearAllVersia();

            if (needChange)
            {
                FileWork.Serialize(products);
                NavigationService.Navigate(new Shop((delete.Visibility == Visibility.Visible), true, Shop.GetFone()));
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
            click = new Click(new DeleteButton());

            MessageBoxResult delete = MessageBox.Show(leng.ansverDel, leng.hello, MessageBoxButton.YesNo);

            if (delete == MessageBoxResult.Yes)
            {
                click.ClickButton();
            }
        }
        private bool ch = false;

        private UndoRedoManeger saveAll = new UndoRedoManeger();
        private void change_Click(object sender, RoutedEventArgs e)
        {
            click = new Click(new ChangeButton());
            ch = !ch;

            if (ch)
            {
                nameB_SelectionChanged(sender, e);
                Larr.Visibility = Visibility.Visible;
                Rarr.Visibility = Visibility.Visible;
            }
            else
            {
                Larr.Visibility = Visibility.Hidden;
                Rarr.Visibility = Visibility.Hidden;
            }

            click.ClickButton();
        }

        private void nameB_SelectionChanged(object sender, RoutedEventArgs e)
        {
            if (ch)
            {
                Inform now = UndoRedoManeger.ShowNow();
                if (now.name != nameB.Text ||
                    now.Price != priceB.Text ||
                    now.Quantity != quantityB.Text ||
                    now.Dictanary != discriptionB.Text)
                {
                    saveAll.addVersia(nameB.Text, priceB.Text, discriptionB.Text, quantityB.Text);
                }
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Recreat(UndoRedoManeger.Redo());
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Recreat(UndoRedoManeger.Undo());
        }
        private void Recreat(Inform inf)
        {
            if (inf.name == null)
                return;

            ch = false;
            nameB.Text = inf.name;
            priceB.Text = inf.Price;
            quantityB.Text = inf.Quantity;
            discriptionB.Text = inf.Dictanary;
            ch = true;
        }
    }
}