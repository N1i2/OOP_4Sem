using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace test
{
    public partial class MainWindow : Window
    {
        public static readonly RoutedEvent MyCustomEvent = EventManager.RegisterRoutedEvent(
                    "MyCustomEvent",
                    RoutingStrategy.Bubble,
                    typeof(RoutedEventHandler),
                    typeof(MainWindow));
        public event RoutedEventHandler MyCustomEventHandler
        {
            add { AddHandler(MyCustomEvent, value); }
            remove { RemoveHandler(MyCustomEvent, value); }
        }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Direct_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Direct Routing");
        }

        // Bubbling Routing event handler
        private void Bubbling_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Bubbling Routing");
        }
    }
    public static class TunnelingHandler
    {
        public static readonly RoutedEvent ClickEvent = EventManager.RegisterRoutedEvent(
            "Click", RoutingStrategy.Tunnel, typeof(RoutedEventHandler), typeof(TunnelingHandler));

        public static void AddClickHandler(DependencyObject d, RoutedEventHandler handler)
        {
            if (d is UIElement element)
            {
                element.AddHandler(ClickEvent, handler);
            }
        }

        public static void RemoveClickHandler(DependencyObject d, RoutedEventHandler handler)
        {
            if (d is UIElement element)
            {
                element.RemoveHandler(ClickEvent, handler);
            }
        }
    }

    public static class TunnelingExtensions
    {
        public static void AddTunnelingClickHandler(this UIElement element, RoutedEventHandler handler)
        {
            TunnelingHandler.AddClickHandler(element, handler);
        }

        public static void RemoveTunnelingClickHandler(this UIElement element, RoutedEventHandler handler)
        {
            TunnelingHandler.RemoveClickHandler(element, handler);
        }
    }
}