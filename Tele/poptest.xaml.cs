using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace Tele
{
    public partial class poptest : PhoneApplicationPage
    {
        int temp;
        public poptest()
        {
            InitializeComponent();
        }

        private void checkBox1_Checked(object sender, RoutedEventArgs e)
        {
                temp = temp + 1;
                textBlock8.Text = temp.ToString();
                int a = temp * 40;
                textBox1.Text = a.ToString();
            
        }

        private void checkBox2_Checked(object sender, RoutedEventArgs e)
        {
                temp = temp + 1;
                textBlock8.Text = temp.ToString();
                int a = temp * 40;
                textBox1.Text = a.ToString();
                
        }

        private void checkBox1_Unchecked(object sender, RoutedEventArgs e)
        {
            temp = temp - 1;
            textBlock8.Text = temp.ToString();
            int a = temp * 40;
            textBox1.Text = a.ToString();
        }

        private void checkBox2_Unchecked(object sender, RoutedEventArgs e)
        {
            temp = temp - 1;
            textBlock8.Text = temp.ToString();
            int a = temp * 40;
            textBox1.Text = a.ToString();
        }

        private void checkBox3_Checked(object sender, RoutedEventArgs e)
        {
            temp = temp + 1;
            textBlock8.Text = temp.ToString();
            int a = temp * 40;
            textBox1.Text = a.ToString();
        }

        private void checkBox3_Unchecked(object sender, RoutedEventArgs e)
        {
            temp = temp - 1;
            textBlock8.Text = temp.ToString();
            int a = temp * 40;
            textBox1.Text = a.ToString();
        }

        private void checkBox4_Unchecked(object sender, RoutedEventArgs e)
        {
            temp = temp - 1;
            textBlock8.Text = temp.ToString();
            int a = temp * 40;
            textBox1.Text = a.ToString();
        }

        private void checkBox4_Checked(object sender, RoutedEventArgs e)
        {
            temp = temp + 1;
            textBlock8.Text = temp.ToString();
            int a = temp * 40;
            textBox1.Text = a.ToString();
        }

        private void textBox1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            int a;
            int b=0;
            for (int i = 0; i < 6; i++)
            {
                CheckBox chkBox = new CheckBox();
                if (i % 2 == 0)
                    chkBox.IsChecked = true;
                a = b + 1;
            }
        }
    }
}