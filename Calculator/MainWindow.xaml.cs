using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
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

namespace Calculator
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            TxtBox.Text += "1";
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            TxtBox.Text += "2";
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            TxtBox.Text += "3";
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            TxtBox.Text += "4";
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            TxtBox.Text += "5";
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            TxtBox.Text += "6";
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            TxtBox.Text += "7";
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            TxtBox.Text += "8";
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            TxtBox.Text += "9";
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            TxtBox.Text += "0";
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            string x = TxtBox.Text;
            char[] y = x.ToArray();
            char[] z = new char[x.Length-1];
            for (int i = 0; i < x.Length - 1; i++)
            {
                z[i] = x[i];
            }
            string new_str = String.Concat<char>(z);
            TxtBox.Text = new_str;
        }

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            TxtBox.Text += "+";
        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            TxtBox.Text += "-";
        }

        private void Button_Click_14(object sender, RoutedEventArgs e)
        {
            TxtBox.Text += "*";
        }

        private void Button_Click_15(object sender, RoutedEventArgs e)
        {
            TxtBox.Text += "/";
        }

        private void Button_Click_16(object sender, RoutedEventArgs e)
        {
            string x = TxtBox.Text;
            float x1 = float.Parse(x);
            float newx = x1 * x1 * x1;
            string newx2 = newx.ToString();
            TxtBox.Text = newx2;
        }

        private void Button_Click_17(object sender, RoutedEventArgs e)
        {
            string x = TxtBox.Text;
            float x1 = float.Parse(x);
            float newx = x1 * x1;
            string newx2 = newx.ToString();
            TxtBox.Text = newx2;
        }

        private void Button_Click_18(object sender, RoutedEventArgs e)
        {
            string x = TxtBox.Text;
            float x1 = float.Parse(x);
            float newx = (float)Math.Sin(x1);
            string newx2 = newx.ToString();
            TxtBox.Text = newx2;
        }

        private void Button_Click_19(object sender, RoutedEventArgs e)
        {
            string x = TxtBox.Text;
            float x1 = float.Parse(x);
            float newx = (float)Math.Cos(x1);
            string newx2 = newx.ToString();
            TxtBox.Text = newx2;
        }

        private void Button_Click_20(object sender, RoutedEventArgs e)
        {
            string x = TxtBox.Text;
            float x1 = float.Parse(x);
            float newx = (float)Math.Tan(x1);
            string newx2 = newx.ToString();
            TxtBox.Text = newx2;
        }

        private void Button_Click_21(object sender, RoutedEventArgs e)
        {
            string x = TxtBox.Text;
            float x1 = float.Parse(x);
            float newx = (float)Math.Sqrt(x1);
            string newx2 = newx.ToString();
            TxtBox.Text = newx2;
        }

        private void Button_Click_22(object sender, RoutedEventArgs e)
        {
            string x = TxtBox.Text;
            float x1 = float.Parse(x);
            float newx = 1/((float)Math.Tan(x1));
            string newx2 = newx.ToString();
            TxtBox.Text = newx2;
        }

        private void Button_Click_23(object sender, RoutedEventArgs e)
        {
            TxtBox.Text += ".";
        }

        private void Button_Click_24(object sender, RoutedEventArgs e)
        {
            string str = TxtBox.Text;
            char[] x = str.ToArray();
            string[] y = new string[x.Length];
            List<string> lst = new List<string>();
            
            float rslt = 0;
            int i = 0;
            int j = 0;

            while (i <= x.Length - 1) {
                if (Char.IsDigit(x[i]))
                {
                    y[j] += x[i].ToString();
                }
                else {
                    j++;
                    y[j] += x[i].ToString();
                    j++;
                }  
                i++;
            }
            
            for (int a = 0; a <= y.Length -1; a++ )
            {
                if (y[a] != null)
                    lst.Add(y[a]);
                else
                    break;
            }
            string[] y2 = new string[lst.Count];

            for (int b = 0; b <= lst.Count - 1; b++)
            {
                y2[b] = lst[b];
            }

            int g = 1;
            

            while (g <= y2.Length - 1)
            {
                rslt = float.Parse(y2[g - 1]);
                if (y2[g] == "+")
                {
                    float x2 = float.Parse(y2[g + 1]);
                    rslt += x2;
                }
                else if (y2[g] == "-")
                {
                    float x2 = float.Parse(y2[g + 1]);
                    rslt -= x2;
                }
                else if (y2[g] == "*")
                {
                    float x2 = float.Parse(y2[g + 1]);
                    rslt *= x2;
                }
                else if (y2[g] == "/")
                {
                    float x2 = float.Parse(y2[g + 1]);
                    rslt /= x2;
                }
                g++;
            }

            TxtBox.Text = rslt.ToString();
        }
    }
}