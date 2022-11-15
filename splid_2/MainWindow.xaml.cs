using splid_2.code;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace splid_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private BindingList<SplidList> splidListData;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Splid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Splid_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }

        private void splidList_Loaded(object sender, RoutedEventArgs e)
        {
            splidListData = new BindingList<SplidList>()
            {
                new SplidList(){Description = "test"},
                new SplidList(){Description = "asdasd", Sum = 14},
                new SplidList(){Sum = 123}
            };

            splidList.ItemsSource = splidListData;
        }
    }
}
