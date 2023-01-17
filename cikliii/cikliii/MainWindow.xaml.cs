using System;
using System.Collections;
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

namespace cikliii
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        // zadanie 1
        private void itog_Click(object sender, RoutedEventArgs e)
        {
            int a = Convert.ToInt32(Ab.Text);
            int b = Convert.ToInt16(Bb.Text);
            int summ = 0;
            for (int i = a + 1; i < b; i++)
            {
                summ += i;
            }
            summamej.Content = summ;
            for (int i = a + 1; i < b; i++)
            {
                if (i % 2 == 1)
                {
                    nechet.Content += $"{i} : ";
                }
            }
        }

        // zadanie 2
        private void a1_Click_1(object sender, RoutedEventArgs e)
        {
            int x = Convert.ToInt32(c1.Text);
            int result = 1;
            do
            {
                result *= x;
                x -= 1;
            } while (x > 0);
            d1.Content = "Кол-во вариантов доставки = 0";
        }
        // zadanie 4
        private void a2_Click_1(object sender, RoutedEventArgs e)
        {
            int n = Convert.ToInt32(c2.Text);
            int a = 0;
            for (int i = 0; i < n; i++)
            {
                a += i;
                d2.Content = a;
            }
        }
        // zadanie 6
        private void a3_Click_1(object sender, RoutedEventArgs e)
        {
            int n = 1;
            int r = 1;
            n = Convert.ToInt32(c3.Text);
            for (int i = 1; i <= n; i++)
            {
                r = r * i;
            }
            d3.Content = r;
        }
        // zadanie 5
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            {

                {
                    try
                    {
                        switch (choice.SelectedIndex)
                        {
                            case 0:
                                double x = Convert.ToDouble(payment.Text);
                                g1.Content = x * 10 % 100;
                                break;
                            case 1:
                                double y = Convert.ToDouble(payment.Text);
                                g1.Content = y * 15 % 100;
                                break;
                            case 2:
                                double z = Convert.ToDouble(payment.Text);
                                g1.Content = z * 25 % 100;
                                break;
                            case 3:
                                double h = Convert.ToDouble(payment.Text);
                                g1.Content = h * 35 % 100;
                                break;
                            case 4:
                                double v = Convert.ToDouble(payment.Text);
                                g1.Content = v * 45 % 100;
                                break;
                            case 5:
                                double m = Convert.ToDouble(payment.Text);
                                g1.Content = m * 50 % 100;
                                break;


                        }
                    }
                    catch
                    {
                        g2.Content = "";
                    }
                }
            }
        }

        private void b1_Click(object sender, RoutedEventArgs e)
        {
            {
                for (int i = 10; i <= 20; i++)
                {
                    d4.Content += $"{Math.Pow(i, 2)}";
                }
            }
        }
    }
}
