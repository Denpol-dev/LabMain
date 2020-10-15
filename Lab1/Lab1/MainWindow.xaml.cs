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

namespace Lab1
{
    public class Circle
    {
        public double[] Circle_Create(double x, double y, double radius)
        {
            double x11, y11, x12, y12, x21, y21, x22, y22;

            x11 = x - (radius / 2);
            y11 = y + (radius / 2);
            x12 = x + (radius / 2);
            y12 = y + (radius / 2);
            x21 = x - (radius / 2);
            y21 = y - (radius / 2);
            x22 = x + (radius / 2);
            y22 = y - (radius / 2);

            double[] Circle_Arr = { x11, y11, x12, y12, x21, y21, x22, y22 };

            return Circle_Arr;
        }
    }

    public class Square
    {
        public double[] Square_Create(double x, double y, double a)
        {
            
            double x11, y11, x12, y12, x21, y21, x22, y22;

            x11 = x - (a / 2);
            y11 = y + (a / 2);
            x12 = x + (a / 2);
            y12 = y + (a / 2);
            x21 = x - (a / 2);
            y21 = y - (a / 2);
            x22 = x + (a / 2);
            y22 = y - (a / 2);

            double[] Square_Arr = { x11, y11, x12, y12, x21, y21, x22, y22};

            return Square_Arr;
        }
    }

    public class Rectangle
    {
        public double[] Rectangle_Create(double x, double y, double a, double b)
        {
            double x11, y11, x12, y12, x21, y21, x22, y22;

            x11 = x - (b / 2);
            y11 = y + (a / 2);
            x12 = x + (b / 2);
            y12 = y + (a / 2);
            x21 = x - (b / 2);
            y21 = y - (a / 2);
            x22 = x + (b / 2);
            y22 = y - (a / 2);

            double[] Square_Arr = { x11, y11, x12, y12, x21, y21, x22, y22 };

            return Square_Arr;
        }
    }

    public partial class MainWindow : Window
    {
        public double x = 0.0;
        public double y = 0.0;
        public double a = 0.0;
        public double b = 0.0;
        public double r = 0.0;
        public double xA = 0.0;
        public double yA = 0.0;
        public double aA = 0.0;
        public double bA = 0.0;
        public double rA = 0.0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Go_Click(object sender, RoutedEventArgs e)
        {
            if (Circle1.IsChecked == true)
            {
                if (Circle2.IsChecked == true)
                {
                    x = Convert.ToDouble(xQ1.Text);
                    y = Convert.ToDouble(yQ1.Text);
                    r = Convert.ToDouble(rQ1.Text);
                }
                Circle circle = new Circle();

                x = Convert.ToDouble(xQ1.Text);
                y = Convert.ToDouble(yQ1.Text);
                r = Convert.ToDouble(rQ1.Text);

                circle.Circle_Create(x, y, r);
            }
            else if (Rectangle1.IsChecked == true)
            {
                Square square = new Square();

                x = Convert.ToDouble(xQ1.Text);
                y = Convert.ToDouble(yQ1.Text);
                a = Convert.ToDouble(aQ1.Text);
                b = Convert.ToDouble(bQ1.Text);

                square.Square_Create(x, y, a);
            }
            else if (Square1.IsChecked == true)
            {
                x = Convert.ToDouble(xQ1.Text);
                y = Convert.ToDouble(yQ1.Text);
                a = Convert.ToDouble(aQ1.Text);
            }
        }

        private void Circle1_Checked(object sender, RoutedEventArgs e)
        {
            xQ1S.Visibility = Visibility.Visible;
            yQ1S.Visibility = Visibility.Visible;
            aQ1S.Visibility = Visibility.Collapsed;
            bQ1S.Visibility = Visibility.Collapsed;
            rQ1S.Visibility = Visibility.Visible;
        }

        private void Square1_Checked(object sender, RoutedEventArgs e)
        {
            xQ1S.Visibility = Visibility.Visible;
            yQ1S.Visibility = Visibility.Visible;
            aQ1S.Visibility = Visibility.Visible;
            bQ1S.Visibility = Visibility.Collapsed;
            rQ1S.Visibility = Visibility.Collapsed;
        }

        private void Rectangle1_Checked(object sender, RoutedEventArgs e)
        {
            xQ1S.Visibility = Visibility.Visible;
            yQ1S.Visibility = Visibility.Visible;
            aQ1S.Visibility = Visibility.Visible;
            bQ1S.Visibility = Visibility.Visible;
            rQ1S.Visibility = Visibility.Collapsed;
        }

        private void Circle2_Checked(object sender, RoutedEventArgs e)
        {
            xQ2S.Visibility = Visibility.Visible;
            yQ2S.Visibility = Visibility.Visible;
            aQ2S.Visibility = Visibility.Collapsed;
            bQ2S.Visibility = Visibility.Collapsed;
            rQ2S.Visibility = Visibility.Visible;
        }

        private void Square2_Checked(object sender, RoutedEventArgs e)
        {
            xQ2S.Visibility = Visibility.Visible;
            yQ2S.Visibility = Visibility.Visible;
            aQ2S.Visibility = Visibility.Visible;
            bQ2S.Visibility = Visibility.Collapsed;
            rQ2S.Visibility = Visibility.Collapsed;
        }

        private void Rectangle2_Checked(object sender, RoutedEventArgs e)
        {
            xQ2S.Visibility = Visibility.Visible;
            yQ2S.Visibility = Visibility.Visible;
            aQ2S.Visibility = Visibility.Visible;
            bQ2S.Visibility = Visibility.Visible;
            rQ2S.Visibility = Visibility.Collapsed;
        }
    }
}
