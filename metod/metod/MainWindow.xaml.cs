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

namespace metod
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    /// zadanie 1
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void a1_Click(object sender, RoutedEventArgs e)
        {
            double x = Convert.ToDouble(b1.Text);
            double y = Convert.ToDouble(b2.Text);
            c3.Content = x + y;
            c1.Content = " + ";
            c2.Content = " = ";
        }

        private void a2_Click(object sender, RoutedEventArgs e)
        {
            double x = Convert.ToDouble(b1.Text);
            double y = Convert.ToDouble(b2.Text);
            c3.Content = x - y;
            c1.Content = " - ";
            c2.Content = " = ";
        }

        private void a3_Click(object sender, RoutedEventArgs e)
        {
            double x = Convert.ToDouble(b1.Text);
            double y = Convert.ToDouble(b2.Text);
            c3.Content = x * y;
            c1.Content = " * ";
            c2.Content = " = ";
        }

        private void a4_Click(object sender, RoutedEventArgs e)
        {
            double x = Convert.ToDouble(b1.Text);
            double y = Convert.ToDouble(b2.Text);
            if (y == 0)
            {
                c3.Content = "На 0 делить нельзя";
                c1.Content = " / ";
                c2.Content = " = ";


            }
            else
            {
                c3.Content = x % y;
                c1.Content = " / ";
                c2.Content = " = ";

            }
        }
        //zadanie 2
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            {
                double x = Convert.ToDouble(d1.Text);
                double y = Convert.ToDouble(d2.Text);
                f1.Content = x * y;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            double x = Convert.ToDouble(g1.Text);
            if (x > 0)
            {
                h1.Content = "Положительное";
            }
            else if (x < 0)
            {
                h1.Content = "Отрицательное";
            }
            else if (x == 0)
            {
                h1.Content = "Ваше число равно 0";
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            double n = Convert.ToDouble(g1.Text);
            int r = 0;
            //25 1 5 25

            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    r = r + 1;
                }

            }
            if (r == 2)
            {
                h2.Content = "Простое";
            }
            else
            {
                h2.Content = "Сложное";
            }
        }
        private static long GetFactorial(int number)
        {
            if (number == 0)
            {
                return 1;
            }
            return number * GetFactorial(number - 1);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            {
                int m = Convert.ToInt32(i1.Text);
                long res = GetFactorial(m);
                k1.Content = res;
            }

        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            {
                double c = Convert.ToDouble(l1.Text);
                o1.Content = 700 - c;

            }
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            {
                double c = Convert.ToDouble(l1.Text);
                o2.Content = 700 * 10 / 100;
            }
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            {
                double c = Convert.ToDouble(l1.Text);
                if (700 - c > 0)
                {
                    o3.Content = "Долг есть";
                }
                else
                {
                    o3.Content = "Долга нет";
                }
            }
        }
    }
 }    

