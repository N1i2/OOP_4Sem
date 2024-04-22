using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

namespace laba_8
{
    /// <summary>
    /// Interaction logic for AllInfo.xaml
    /// </summary>
    public partial class AllInfo : Page
    {
        public AllInfo(List<Class> classes)
        {
            InitializeComponent();

            foreach (var item in classes)
            {
                string checkSem = string.Empty;

                if (item.Semester == 1)
                {
                    checkSem = "1";
                }
                else if (item.Semester == 2)
                {
                    checkSem = "2";
                }
                else
                {
                    checkSem = "1,2";
                }

                string info = $"ID: {item.ID}, Name: {item.Name}, Semestr: {checkSem}, Yesr: {item.Years}, Labs: {item.CountOfLabs}, Lectrs: {item.CountOfLectrs}, Type: {((item.CheckType == 1) ? "Test" : "Exem")}";

                CreateElement(info);
            }
        }

        public void CreateElement(string text)
        {
            Grid grid = new Grid
            {
                Height = 100,
                Margin = new Thickness(0, 0, 0, 20),
                Background = new SolidColorBrush(Color.FromRgb(255, 204, 204))
            };

            Label label = new Label
            {
                Content = text,
                HorizontalAlignment = HorizontalAlignment.Center,
                VerticalAlignment = VerticalAlignment.Center,
                FontSize = 20
            };

            grid.Children.Add(label);
            ScrolArea.Children.Add(grid);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.GoBack();
        }
    }
}