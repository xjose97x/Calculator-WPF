using System;
using System.Windows;
using System.Windows.Controls;

namespace calculatorlive
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int first, second, final;
        private string operationMethod;
        public MainWindow()
        {
            InitializeComponent();
            result.Text = "0";
        }

        private void numClick(object sender, RoutedEventArgs e)
        {
            if (result.Text == "0" || final > 0)
            {
                result.Text = "";
            }
            result.Text += (sender as Button).Content;
        }

        private void clear_Click(object sender, RoutedEventArgs e)
        {
            result.Text = "0";
            first = 0;
            second = 0;
            final = 0;
        }

        private void operation(object sender, RoutedEventArgs e)
        {
            operationMethod = (sender as Button).Name;
            first = Int32.Parse(result.Text);
            result.Text = "0";
        }

        private void equal_Click(object sender, RoutedEventArgs e)
        {
            second = Int32.Parse(result.Text);

            switch(operationMethod)
            {
                case "add":
                    final = first + second;
                    break;
                case "minus":
                    final = first - second;
                    break;
                case "multiply":
                    final = first * second;
                    break;
                case "division":
                    final = first / second;
                    break;        
            }
            result.Text = final.ToString();
        }
    }
}
