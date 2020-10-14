using System;
using System.Windows;

namespace Lab2
{
    
    public class Complex
    {
        public double a1, b1, a2, b2, real, imaginary;
        public Complex(double a1 = 0, double b1 = 0, double a2 = 0, double b2 = 0)
        {
            this.a1 = a1;
            this.b1 = b1;
            this.a2 = a2;
            this.b2 = b2;
        }

        public static Complex operator +(Complex obj1, Complex obj2)
        {
            Complex complex = new Complex
            {
                real = obj1.a1 + obj2.a2,
                imaginary = obj1.b1 + obj2.b2
            };
            return complex;
        }

        public static Complex operator -(Complex obj1, Complex obj2)
        {
            Complex complex = new Complex
            {
                real = obj1.a1 - obj2.a2,
                imaginary = obj1.b1 - obj2.b2
            };
            return complex;
        }

        public static Complex operator *(Complex obj1, Complex obj2)
        {
            Complex complex = new Complex
            {
                real = (obj1.a1 * obj2.a2) - (obj1.b1 * obj2.b2),
                imaginary = (obj1.a1 * obj2.b2) + (obj1.b1 * obj2.a2)
            };
            return complex;
        }

        public static Complex operator /(Complex obj1, Complex obj2)
        {
            Complex complex = new Complex
            {
                real = ((obj1.a1 * obj2.a2) + (obj1.b1 * obj2.b2)) / ((obj2.a2 * obj2.a2) + (obj2.b2 * obj2.b2)),
                imaginary = ((obj2.a2 * obj1.b1) - (obj1.a1 * obj2.b2)) / ((obj2.a2 * obj2.a2) + (obj2.b2 * obj2.b2))
            };
            return complex;
        }
    }
    public partial class MainWindow : Window
    {
        public double a1 = 0.0;
        public double b1 = 0.0;
        public double a2 = 0.0;
        public double b2 = 0.0;
        public double z1 = 0.0;
        public double z2 = 0.0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Go_Click(object sender, RoutedEventArgs e)
        {
            if (C1.IsChecked == true)
            {               
                if (Input1_2.Text == "")
                {
                    b1 = 1.0;
                }
                else if (Input1_2.Text == "-")
                {
                    b1 = -1.0;
                }
                else
                    b1 = Convert.ToDouble(Input1_2.Text);

                if (Input2_2.Text == "")
                {
                    b2 = 1.0;
                }
                else if (Input2_2.Text == "-")
                {
                    b2 = -1.0;
                }
                else
                    b2 = Convert.ToDouble(Input2_2.Text);

                a1 = Convert.ToDouble(Input1_1.Text);
                a2 = Convert.ToDouble(Input2_1.Text);

                Complex Num1 = new Complex(a1, b1, a2, b2);
                Complex Num2 = new Complex(a1, b1, a2, b2);

                Complex Num3 = Num1 + Num2;

                Result1.Text = Convert.ToString(Num3.real);
                Result2.Text = Convert.ToString(Num3.imaginary);

                if (Num3.imaginary < 0)
                {
                    ZnakRes.Visibility = Visibility.Collapsed;
                }
                else
                {
                    ZnakRes.Visibility = Visibility.Visible;
                }
            }
            else if (C2.IsChecked == true)
            {
                if (Input1_2.Text == "")
                {
                    b1 = 1.0;
                }
                else if (Input1_2.Text == "-")
                {
                    b1 = -1.0;
                }
                else
                    b1 = Convert.ToDouble(Input1_2.Text);

                if (Input2_2.Text == "")
                {
                    b2 = 1.0;
                }
                else if (Input2_2.Text == "-")
                {
                    b2 = -1.0;
                }
                else
                    b2 = Convert.ToDouble(Input2_2.Text);

                a1 = Convert.ToDouble(Input1_1.Text);
                a2 = Convert.ToDouble(Input2_1.Text);

                Complex Num1 = new Complex(a1, b1, a2, b2);
                Complex Num2 = new Complex(a1, b1, a2, b2);

                Complex Num3 = Num1 - Num2;

                Result1.Text = Convert.ToString(Num3.real);
                Result2.Text = Convert.ToString(Num3.imaginary);

                if (Num3.imaginary < 0)
                {
                    ZnakRes.Visibility = Visibility.Collapsed;
                }
                else
                {
                    ZnakRes.Visibility = Visibility.Visible;
                }
            }
            else if (C3.IsChecked == true)
            {
                if (Input1_2.Text == "")
                {
                    b1 = 1.0;
                }
                else if (Input1_2.Text == "-")
                {
                    b1 = -1.0;
                }
                else
                    b1 = Convert.ToDouble(Input1_2.Text);

                if (Input2_2.Text == "")
                {
                    b2 = 1.0;
                }
                else if (Input2_2.Text == "-")
                {
                    b2 = -1.0;
                }
                else
                    b2 = Convert.ToDouble(Input2_2.Text);

                a1 = Convert.ToDouble(Input1_1.Text);
                a2 = Convert.ToDouble(Input2_1.Text);

                Complex Num1 = new Complex(a1, b1, a2, b2);
                Complex Num2 = new Complex(a1, b1, a2, b2);

                Complex Num3 = Num1 * Num2;

                Result1.Text = Convert.ToString(Num3.real);
                Result2.Text = Convert.ToString(Num3.imaginary);

                if (Num3.imaginary < 0)
                {
                    ZnakRes.Visibility = Visibility.Collapsed;
                }
                else
                {
                    ZnakRes.Visibility = Visibility.Visible;
                }
            }
            else if (C4.IsChecked == true)
            {
                if (Input1_2.Text == "")
                {
                    b1 = 1.0;
                }
                else if (Input1_2.Text == "-")
                {
                    b1 = -1.0;
                }
                else
                    b1 = Convert.ToDouble(Input1_2.Text);

                if (Input2_2.Text == "")
                {
                    b2 = 1.0;
                }
                else if (Input2_2.Text == "-")
                {
                    b2 = -1.0;
                }
                else
                    b2 = Convert.ToDouble(Input2_2.Text);

                a1 = Convert.ToDouble(Input1_1.Text);
                a2 = Convert.ToDouble(Input2_1.Text);

                Complex Num1 = new Complex(a1, b1, a2, b2);
                Complex Num2 = new Complex(a1, b1, a2, b2);

                Complex Num3 = Num1 / Num2;

                Result1.Text = Convert.ToString(Num3.real);
                Result2.Text = Convert.ToString(Num3.imaginary);

                if (Num3.imaginary < 0)
                {
                    ZnakRes.Visibility = Visibility.Collapsed;
                }
                else
                {
                    ZnakRes.Visibility = Visibility.Visible;
                }
            }
            else
                MessageBox.Show("Выберите действие", "Внимание!", MessageBoxButton.OK, MessageBoxImage.Exclamation);
        }

        private void C1_Checked(object sender, RoutedEventArgs e)
        {
            if (C1.IsChecked == true)
                Znak.Text = " + ";
        }

        private void C2_Checked(object sender, RoutedEventArgs e)
        {
            if (C2.IsChecked == true)
                Znak.Text = " - ";
        }

        private void C3_Checked(object sender, RoutedEventArgs e)
        {
            if (C3.IsChecked == true)
                Znak.Text = " * ";
        }

        private void C4_Checked(object sender, RoutedEventArgs e)
        {
            if (C4.IsChecked == true)
                Znak.Text = " / ";
        }
    }
}