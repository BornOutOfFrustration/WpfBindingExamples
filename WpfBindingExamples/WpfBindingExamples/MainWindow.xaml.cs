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

namespace WpfBindingExamples
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            DataContext = "heelo";
            InitializeComponent();
        }

        private void ButtonNoPath_Click(object sender, RoutedEventArgs e)
        {
            var window = new Window1();
            window.DataContext = "Hello, Datacontext is a string. {Binding} or {Binding Path=.} binds the first DataContext it can find.";
            window.Show();
        }

        private void ButtonAttachedProperty_Click(object sender, RoutedEventArgs e)
        {
            var window = new Window2();
            window.Show();
        }
    }
}
