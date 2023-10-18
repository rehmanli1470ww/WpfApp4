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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp4
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

        

        private void Mouse_RightButtonDown1(object sender, MouseButtonEventArgs e)
        {
            gr.Children.Remove(Click1);
        }

       

        private void Mouse_RightButtonDown2(object sender, MouseButtonEventArgs e)
        {
            gr.Children.Remove(Click2);
        }

       

        private void Mouse_RightButtonDown3(object sender, MouseButtonEventArgs e)
        {
            gr.Children.Remove(Click3);
        }

       

        private void Mouse_RightButtonDown4(object sender, MouseButtonEventArgs e)
        {
            gr.Children.Remove(Click4);
        }

       

        private void Mouse_RightButtonDown5(object sender, MouseButtonEventArgs e)
        {
            gr.Children.Remove(Click5);
        }

       
        private void Mouse_RightButtonDown6(object sender, MouseButtonEventArgs e)
        {
            gr.Children.Remove(Click6);
        }

        

        private void Left1(object sender, RoutedEventArgs e)
        {
            
            Random rnd = new Random();
            int r = rnd.Next(0,255);
            int g=rnd.Next(0,255);
            int b=rnd.Next(0,255);

            MessageBox.Show($"Name :"+Click1.Name+ "\nPath : " + Click1+ "\nEni : " +Click1.Height + "\nUzunu : " + Click1.Width);
            Click1.Background = new SolidColorBrush(Color.FromRgb((byte)r, (byte)g, (byte)b));
            gr.Background= new SolidColorBrush(Color.FromRgb((byte)g, (byte)r, (byte)b));
        }

        private void Left2(object sender, RoutedEventArgs e)
        {

            Random rnd = new Random();
            int r = rnd.Next(0, 255);
            int g = rnd.Next(0, 255);
            int b = rnd.Next(0, 255);

            MessageBox.Show($"Name :" + Click2.Name + "\nPath : " + Click2 + "\nEni : " + Click2.Height + "\nUzunu : " + Click2.Width);
            Click2.Background = new SolidColorBrush(Color.FromRgb((byte)r, (byte)g, (byte)b));
            gr.Background = new SolidColorBrush(Color.FromRgb((byte)g, (byte)r, (byte)b));
        }

        private void Left3(object sender, RoutedEventArgs e)
        {

            Random rnd = new Random();
            int r = rnd.Next(0, 255);
            int g = rnd.Next(0, 255);
            int b = rnd.Next(0, 255);

            MessageBox.Show($"Name :" + Click3.Name + "\nPath : " + Click3 + "\nEni : " + Click3.Height + "\nUzunu : " + Click3.Width);
            Click3.Background = new SolidColorBrush(Color.FromRgb((byte)r, (byte)g, (byte)b));
            gr.Background = new SolidColorBrush(Color.FromRgb((byte)g, (byte)r, (byte)b));
        }

        private void Left4(object sender, RoutedEventArgs e)
        {

            Random rnd = new Random();
            int r = rnd.Next(0, 255);
            int g = rnd.Next(0, 255);
            int b = rnd.Next(0, 255);

            MessageBox.Show($"Name :" + Click4.Name + "\nPath : " + Click4 + "\nEni : " + Click4.Height + "\nUzunu : " + Click4.Width);
            Click4.Background = new SolidColorBrush(Color.FromRgb((byte)r, (byte)g, (byte)b));
            gr.Background = new SolidColorBrush(Color.FromRgb((byte)g, (byte)r, (byte)b));
        }

        private void Left5(object sender, RoutedEventArgs e)
        {

            Random rnd = new Random();
            int r = rnd.Next(0, 255);
            int g = rnd.Next(0, 255);
            int b = rnd.Next(0, 255);

            MessageBox.Show($"Name :" + Click5.Name + "\nPath : " + Click5 + "\nEni : " + Click5.Height + "\nUzunu : " + Click5.Width);
            Click5.Background = new SolidColorBrush(Color.FromRgb((byte)r, (byte)g, (byte)b));
            gr.Background = new SolidColorBrush(Color.FromRgb((byte)g, (byte)r, (byte)b));
        }

        private void Left6(object sender, RoutedEventArgs e)
        {

            Random rnd = new Random();
            int r = rnd.Next(0, 255);
            int g = rnd.Next(0, 255);
            int b = rnd.Next(0, 255);

            MessageBox.Show($"Name :" + Click6.Name + "\nPath : " + Click6 + "\nEni : " + Click6.Height + "\nUzunu : " + Click6.Width);
            Click6.Background = new SolidColorBrush(Color.FromRgb((byte)r, (byte)g, (byte)b));
            gr.Background = new SolidColorBrush(Color.FromRgb((byte)g, (byte)r, (byte)b));
        }
    }
}
