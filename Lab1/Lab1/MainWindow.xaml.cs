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

            double[] Rectangle_Arr1 = { x11, y11, x12, y12, x21, y21, x22, y22 };

            return Rectangle_Arr1;
        }
    }

    public class Intersections
    {
        public bool Rectangle_Rectangle(double[] Rectangle1_Arr, double[] Rectangle2_Arr)
        {
            bool res = true;
            double x1 = 0, x2 = 0, x3 = 0, x4 = 0, y1 = 0, y2 = 0, y3 = 0, y4 = 0, k1 = 0, k2 = 0, b1 = 0, b2 = 0, x = 0, y = 0;

            for (int i = 0; i < Rectangle1_Arr.Length; i += 2)
            {
                if (i >= 6)
                {
                    x1 = Rectangle1_Arr[i];
                    y1 = Rectangle1_Arr[i + 1];
                    x2 = Rectangle1_Arr[i - 6];
                    y2 = Rectangle1_Arr[i - 5];
                    x3 = Rectangle2_Arr[i];
                    y3 = Rectangle2_Arr[i + 1];
                    x4 = Rectangle2_Arr[i - 6];
                    y4 = Rectangle2_Arr[i - 5];
                }
                else
                {
                    x1 = Rectangle1_Arr[i];
                    y1 = Rectangle1_Arr[i + 1];
                    x2 = Rectangle1_Arr[i + 2];
                    y2 = Rectangle1_Arr[i + 3];
                    x3 = Rectangle2_Arr[i];
                    y3 = Rectangle2_Arr[i + 1];
                    x4 = Rectangle2_Arr[i + 2];
                    y4 = Rectangle2_Arr[i + 3];
                }

                if (x1 >= x2)
                {
                    if (i >= 6)
                    {
                        x2 = Rectangle1_Arr[i];
                        y2 = Rectangle1_Arr[i + 1];
                        x1 = Rectangle1_Arr[i - 6];
                        y1 = Rectangle1_Arr[i - 5];
                    }
                    else
                    {
                        x2 = Rectangle1_Arr[i];
                        y2 = Rectangle1_Arr[i + 1];
                        x1 = Rectangle1_Arr[i + 2];
                        y1 = Rectangle1_Arr[i + 3];
                    }
                }
                else
                {
                    if (i >= 6)
                    {
                        x1 = Rectangle1_Arr[i];
                        y1 = Rectangle1_Arr[i + 1];
                        x2 = Rectangle1_Arr[i - 6];
                        y2 = Rectangle1_Arr[i - 5];
                    }
                    else
                    {
                        x1 = Rectangle1_Arr[i];
                        y1 = Rectangle1_Arr[i + 1];
                        x2 = Rectangle1_Arr[i + 2];
                        y2 = Rectangle1_Arr[i + 3];
                    }
                }

                if (x3 >= x4)
                {
                    if (i >= 6)
                    {
                        x4 = Rectangle2_Arr[i];
                        y4 = Rectangle2_Arr[i + 1];
                        x3 = Rectangle2_Arr[i - 6];
                        y3 = Rectangle2_Arr[i - 5];
                    }
                    else
                    {
                        x4 = Rectangle2_Arr[i];
                        y4 = Rectangle2_Arr[i + 1];
                        x3 = Rectangle2_Arr[i + 2];
                        y3 = Rectangle2_Arr[i + 3];
                    }
                }
                else
                {
                    if (i >= 6)
                    {
                        x3 = Rectangle2_Arr[i];
                        y3 = Rectangle2_Arr[i + 1];
                        x4 = Rectangle2_Arr[i - 6];
                        y4 = Rectangle2_Arr[i - 5];
                    }
                    else
                    {
                        x3 = Rectangle2_Arr[i];
                        y3 = Rectangle2_Arr[i + 1];
                        x4 = Rectangle2_Arr[i + 2];
                        y4 = Rectangle2_Arr[i + 3];
                    }
                }

                if (y1 == y2)
                {
                    k1 = 0;
                }
                else
                {
                    k1 = (y2 - y1) / (x2 - x1);
                }

                if (y3 == y4)
                {
                    k2 = 0;
                }
                else
                {
                    k2 = (y4 - y3) / (x4 - x3);
                }

                if (k1 == k2)
                {
                    res = false;
                }

                else
                {
                    b1 = y1 - (k1 * x1);
                    b2 = y3 - (k2 * x3);

                    x = (b2 - b1) / (k1 - k2);
                    y = (k1 * x) + b1;

                    if (((x1 <= x4) && (x4 <= x2)) || ((x1 <= x3) && (x3 <= x2)))
                    {
                        res = true;
                    }
                }
            }
            return res;
        }

        public bool Rectangle_Square(double[] Rectangle1_Arr, double[] Square2_Arr)
        {
            bool res = false;
            double x1, x2, x3, x4, y1, y2, y3, y4, k1, k2, b1, b2, x, y;

            for (int i = 0; i < Rectangle1_Arr.Length; i += 2)
            {
                if (i >= 6)
                {
                    x1 = Rectangle1_Arr[i];
                    y1 = Rectangle1_Arr[i + 1];
                    x2 = Rectangle1_Arr[i - 6];
                    y2 = Rectangle1_Arr[i - 5];
                    x3 = Square2_Arr[i];
                    y3 = Square2_Arr[i + 1];
                    x4 = Square2_Arr[i - 6];
                    y4 = Square2_Arr[i - 5];
                }
                else
                {
                    x1 = Rectangle1_Arr[i];
                    y1 = Rectangle1_Arr[i + 1];
                    x2 = Rectangle1_Arr[i + 2];
                    y2 = Rectangle1_Arr[i + 3];
                    x3 = Square2_Arr[i];
                    y3 = Square2_Arr[i + 1];
                    x4 = Square2_Arr[i + 2];
                    y4 = Square2_Arr[i + 3];
                }

                if (x1 >= x2)
                {
                    if (i >= 6)
                    {
                        x2 = Rectangle1_Arr[i];
                        y2 = Rectangle1_Arr[i + 1];
                        x1 = Rectangle1_Arr[i - 6];
                        y1 = Rectangle1_Arr[i - 5];
                    }
                    else
                    {
                        x2 = Rectangle1_Arr[i];
                        y2 = Rectangle1_Arr[i + 1];
                        x1 = Rectangle1_Arr[i + 2];
                        y1 = Rectangle1_Arr[i + 3];
                    }
                }
                else
                {
                    if (i >= 6)
                    {
                        x1 = Rectangle1_Arr[i];
                        y1 = Rectangle1_Arr[i + 1];
                        x2 = Rectangle1_Arr[i - 6];
                        y2 = Rectangle1_Arr[i - 5];
                    }
                    else
                    {
                        x1 = Rectangle1_Arr[i];
                        y1 = Rectangle1_Arr[i + 1];
                        x2 = Rectangle1_Arr[i + 2];
                        y2 = Rectangle1_Arr[i + 3];
                    }
                }

                if (x3 >= x4)
                {
                    if (i >= 6)
                    {
                        x4 = Square2_Arr[i];
                        y4 = Square2_Arr[i + 1];
                        x3 = Square2_Arr[i - 6];
                        y3 = Square2_Arr[i - 5];
                    }
                    else
                    {
                        x4 = Square2_Arr[i];
                        y4 = Square2_Arr[i + 1];
                        x3 = Square2_Arr[i + 2];
                        y3 = Square2_Arr[i + 3];
                    }
                }
                else
                {
                    if (i >= 6)
                    {
                        x3 = Square2_Arr[i];
                        y3 = Square2_Arr[i + 1];
                        x4 = Square2_Arr[i - 6];
                        y4 = Square2_Arr[i - 5];
                    }
                    else
                    {
                        x3 = Square2_Arr[i];
                        y3 = Square2_Arr[i + 1];
                        x4 = Square2_Arr[i + 2];
                        y4 = Square2_Arr[i + 3];
                    }
                }

                if (y1 == y2)
                {
                    k1 = 0;
                }
                else
                {
                    k1 = (y2 - y1) / (x2 - x1);
                }

                if (y3 == y4)
                {
                    k2 = 0;
                }
                else
                {
                    k2 = (y4 - y3) / (x4 - x3);
                }

                if (k1 == k2)
                {
                    res = false;
                }
                else
                {
                    b1 = y1 - (k1 * x1);
                    b2 = y3 - (k2 * x3);

                    x = (b2 - b1) / (k1 - k2);
                    y = (k1 * x) + b1;

                    if (((x1 <= x4) && (x4 <= x2)) || ((x1 <= x3) && (x3 <= x2)))
                    {
                        res = true;
                    }
                }
            }
            return res;
        }

        public bool Rectangle_Circle()
        {
            return false;
        }

        public bool Circle_Square()
        {
            return false;
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
            Rectangle rectangle = new Rectangle();
            Square square = new Square();
            Intersections intersections = new Intersections();

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
                double[] Rectangle1_Arr = rectangle.Rectangle_Create(x, y, a, b);

                if (Rectangle2.IsChecked == true)
                {
                    x = Convert.ToDouble(xQ2.Text);
                    y = Convert.ToDouble(yQ2.Text);
                    a = Convert.ToDouble(aQ2.Text);
                    b = Convert.ToDouble(bQ2.Text);

                    double[] Rectangle2_Arr = rectangle.Rectangle_Create(x, y, a, b);

                    bool res = intersections.Rectangle_Rectangle(Rectangle1_Arr, Rectangle2_Arr);

                    if (res == true)
                        Answer.Text = Convert.ToString("Ответ: Пересекаются");
                    else
                        Answer.Text = Convert.ToString("Ответ: Не пересекаются");
                }
                else if (Square2.IsChecked == true)
                {
                    x = Convert.ToDouble(xQ2.Text);
                    y = Convert.ToDouble(yQ2.Text);
                    a = Convert.ToDouble(aQ2.Text);

                    double[] Square2_Arr = square.Square_Create(x, y, a);

                    bool res = intersections.Rectangle_Square(Rectangle1_Arr, Square2_Arr);

                    if (res == true)
                        Answer.Text = Convert.ToString("Ответ: Пересекаются");
                    else
                        Answer.Text = Convert.ToString("Ответ: Не пересекаются");
                }
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
