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

namespace laba_7
{
    /// <summary>
    /// Interaction logic for Start.xaml
    /// </summary>
    public partial class StartPage : Page
    {
        public static readonly DependencyProperty MyColorProperty;
        public string Col
        {
            get { return (string)GetValue(MyColorProperty); }
            set { SetValue(MyColorProperty, value); }
        }

        static StartPage()
        {
            MyColorProperty = DependencyProperty.Register(
             "Col",
             typeof(string),
             typeof(StartPage),
             new FrameworkPropertyMetadata(
                 "White",
                 FrameworkPropertyMetadataOptions.BindsTwoWayByDefault,
                 new PropertyChangedCallback(PropertyChanged),
                 new CoerceValueCallback(CoerceValue),
                 true,
                 UpdateSourceTrigger.PropertyChanged),
             new ValidateValueCallback(ValidateValue)
             );
        }

        public static void PropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
        }

        public static object CoerceValue(DependencyObject d, object value)
        {
            string txt = (string)value;

            if (txt == "White" ||
                txt == "Red" ||
                txt == "Yellow" ||
                txt == "Green")
                return txt;
            return "White";
        }

        public static bool ValidateValue(object value)
        {
            string txt = (string)value;

            return !(txt == "White" &&
                txt == "Red" &&
                txt == "Yellow" &&
                txt == "Green") ||
                txt == string.Empty;
        }

        public StartPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new SecondPage());
        }

        private void EnterUp(object sender, KeyEventArgs e)
        {
            if (e.Key != Key.Enter)
                return;

            Keyboard.ClearFocus();

            if (ValidateValue(TextColor.Text))
            {
                Col = (string)CoerceValue(new DependencyObject(), TextColor.Text);
            }

            if (Col == "Red")
            {
                TextColor.Foreground = Brushes.Red;
            }
            else if (Col == "Yellow")
            {
                TextColor.Foreground = Brushes.Yellow;
            }
            else if (Col == "Green")
            {
                TextColor.Foreground = Brushes.Green;
            }
            else
            {
                TextColor.Foreground = Brushes.White;
            }
        }
    }
}
