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
using System.Windows.Threading;

namespace laba4
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Page
    {
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(tryAdmin)
            {
                if (passwordBox.Password == password)
                {
                    NavigationService.Navigate(new Shop(true, true));
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
    }
}
