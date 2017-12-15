using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Calculator
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private double total1 = 0;
        private double total2 = 0;
        bool plusButtonClicked = false;
        bool minusButtonClicked = false;
        bool multiplyButtonClicked = false;
        bool divideButtonClicked = false;

        public MainPage()
        {
            this.InitializeComponent();
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
           result.Text += "7";
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            result.Text += "8";
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            result.Text += "9";
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            result.Text += "4";
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            result.Text += "5";
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            result.Text += "6";
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            result.Text += "2";
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            result.Text += "1";
        }


        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            result.Text = "";
        }


        private void btn0_Click(object sender, RoutedEventArgs e)
        {
            result.Text += "0";
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            result.Text += "3";
        }

 

        private void btnDecimalPoint_Click(object sender, RoutedEventArgs e)
        {
            result.Text += ".";
        }

        private void btnDiv_Click(object sender, RoutedEventArgs e)
        {
            total1 = total1 + double.Parse(result.Text);
            result.Text = "";

            plusButtonClicked = false;
            minusButtonClicked = false;
            multiplyButtonClicked = false;
            divideButtonClicked = true;
        }

        private void btnTimes_Click(object sender, RoutedEventArgs e)
        {
            total1 = total1 + double.Parse(result.Text);
            result.Text = "";

            plusButtonClicked = false;
            minusButtonClicked = false;
            multiplyButtonClicked = true;
            divideButtonClicked = false;
        }

        private void btnMinus_Click(object sender, RoutedEventArgs e)
        {
            total1 = total1 + double.Parse(result.Text);
            result.Text = "";

            plusButtonClicked = false;
            minusButtonClicked = true;
            multiplyButtonClicked = false;
            divideButtonClicked = false;
        }

        private void btnEqual_Click(object sender, RoutedEventArgs e)
        {
            if (plusButtonClicked == true)
            {
                total2 = total1 + double.Parse(result.Text);
                result.Text = total2.ToString();
                total1 = 0;
            }
            else if (minusButtonClicked == true)
            {
                total2 = total1 - double.Parse(result.Text);
                result.Text = total2.ToString();
                total1 = 0;
            }
            else if (multiplyButtonClicked == true)
            {
                total2 = total1 * double.Parse(result.Text);
                result.Text = total2.ToString();
                total1 = 0;
            }
            else if (divideButtonClicked == true)
            {
                total2 = total1 / double.Parse(result.Text);
                result.Text = total2.ToString();
                total1 = 0;
            }
        }

        private void btnPlus_Click(object sender, RoutedEventArgs e)
        {
            total1 = total1 += double.Parse(result.Text);
            result.Text = "";

            plusButtonClicked = true;
            minusButtonClicked = false;
            multiplyButtonClicked = false;
            divideButtonClicked = false;
        }
    }
}
