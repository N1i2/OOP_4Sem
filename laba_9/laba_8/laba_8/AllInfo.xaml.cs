using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        public ObservableCollection<Class> Classes
        {
            get; set;
        }

        public AllInfo(List<Class> classes)
        {
            InitializeComponent();

            Classes = new ObservableCollection<Class>(classes);
            AllList.ItemsSource = Classes;
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.GoBack();
        }
    }
}