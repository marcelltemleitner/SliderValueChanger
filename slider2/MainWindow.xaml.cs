using System.Windows;
using System.Windows.Media;


namespace slider2
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

        private void ColorSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Color color = Color.FromRgb((byte)redColor.Value, (byte)greenColor.Value, (byte)blueColor.Value);
            this.Background = new SolidColorBrush(color);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            redColor.Value = redColor.Value - 1;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            redColor.Value = redColor.Value + 1;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            greenColor.Value = greenColor.Value - 1;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            greenColor.Value = greenColor.Value + 1;
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            blueColor.Value = blueColor.Value - 1;
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            blueColor.Value = blueColor.Value + 1;
        }

    }
}

