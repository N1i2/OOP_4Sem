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
    /// Interaction logic for SecondPage.xaml
    /// </summary>
    public partial class SecondPage : Page
    {
        public static readonly RoutedEvent DirectEvent;

        static SecondPage()
        {
            DirectEvent = EventManager.RegisterRoutedEvent(
                "DClick",
                RoutingStrategy.Bubble,
                typeof(RoutedEventHandler),
                typeof(SecondPage));
        }

        public event RoutedEventHandler DClick
        {
            add
            {
                base.AddHandler(SecondPage.DirectEvent, value);
            }
            remove
            {
                base.RemoveHandler(SecondPage.DirectEvent, value);
            }
        }

        public SecondPage()
        {
            InitializeComponent();
        }

        public void bottomClickYellow(object sender, MouseButtonEventArgs e)
        {
            ShowYellow();
        }
        public void bottomClickOrange(object sender, MouseButtonEventArgs e)
        {
            ShowOrange();
        }

        public void topClickYellow(object sender, MouseButtonEventArgs e)
        {
            ShowYellow();
        }
        public void topClickOrange(object sender, MouseButtonEventArgs e)
        {
            ShowOrange();
        }

        public void ShowYellow()
        {
            MessageBox.Show("Yellow click");
        }
        public void ShowOrange()
        {
            MessageBox.Show("Orange click");
        }
        private void MyCustomExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("Hello");
        }
        public void ClickFone(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Fone");
        }
    }
}
