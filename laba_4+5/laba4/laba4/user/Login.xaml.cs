using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
using System.Windows.Threading;

namespace laba4
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Page
    {
        private Shop shop;
        private DispatcherTimer _timer;
        private bool _press = false;
        private bool tryAdmin = false;
        private string password = "12345678";
        public Login()
        {
            InitializeComponent();
            _timer = new DispatcherTimer();
            _timer.Interval = TimeSpan.FromSeconds(3);
            _timer.Tick += Timer_Tick;
        }
        public void ButtonUpFone(object sender, MouseButtonEventArgs e)
        {
            fon.Background = Brushes.White;
        }
        public void ButtonDownFone(object sender, MouseButtonEventArgs e)
        {
            fon.Background = Brushes.Gray;
        }
        public void ButtonDown(object sender, MouseButtonEventArgs e)
        {
            but.Foreground = Brushes.Gray;
        }
        public void ButtonUp(object sender, MouseButtonEventArgs e)
        {
            but.Foreground = Brushes.White;
        }
        public void ButtonClick(object sender, RoutedEventArgs e)
        {
            if (shop != null)
                return;

            if(tryAdmin)
            {
                if (passwordBox.Password == password)
                {
                    shop = new Shop(true, true);
                    NavigationService.Navigate(shop);
                    return;
                }
/*                else
                {
                    MessageBox.Show("Go to hell");
                    return;
                }*/
            }

            NavigationService.Navigate(new Shop());
        }
        private void TextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            _press = true;
            _timer.Start();
        }
        private void TextBlock_MouseUp(object sender, MouseButtonEventArgs e)
        {
            _press = false;
            _timer.Stop();
        }
        private void Timer_Tick(object? sender, EventArgs e)
        {
            if(_press)
            {
                ansverPassword.Visibility = Visibility;
                passwordBox.Visibility = Visibility;
                tryAdmin = true;
            }
        }

        private void passwordBox_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Enter)
            {
                ButtonDown(sender, null);
                return;
            }
        }
    }
}
