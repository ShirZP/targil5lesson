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

namespace targil5lesson
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void redLight_Click(object sender, RoutedEventArgs e)
        {
            if (slowImage.IsVisible)
            {
                slowImage.Visibility = Visibility.Hidden;
            }
            MessageBox.Show("!!!!!!BRAKES!!!!!!");

        }
        public int i = 0;

        private void yellow_Light1_Click(object sender, RoutedEventArgs e)
        {
            i = i + 5;
            carImage.Margin = new Thickness(650 - i, 200, 0, 0);
            slowImage.Visibility = Visibility.Visible;
        }

        private void greenLight_Click(object sender, RoutedEventArgs e)
        {
            i = i + 15;
            carImage.Margin = new Thickness(650 - i, 200, 0, 0);
        }
    }
}