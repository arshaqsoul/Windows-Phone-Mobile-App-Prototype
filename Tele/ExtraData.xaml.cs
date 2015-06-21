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
    public partial class ExtraData : PhoneApplicationPage
    {
        public ExtraData()
        {
            InitializeComponent();
        }

        private void hyperlinkButton1_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            DateTime today = DateTime.Now;
            string format = "MMM ddd d yyyy HH:mm";
            textBlock5.Text = today.ToString(format);
            ApplicationTitle.Text = "Welcome " + Tele.GlobalVariables.user;
        }

        private void slider1_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            int a = System.Convert.ToInt32(slider1.Value);
            textBlock2.Text = a.ToString() + " GB";
            int b;
            b = a * 250;
            textBox1.Text = b.ToString();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            slider1.Value = 0;
            textBox1.Text = "";
            NavigationService.GoBack();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            if (textBox1.Text == "Cost in Rs." || textBox1.Text == "")
            {
                MessageBox.Show("Please select an extension using the slider");
            }
            else
            {
                MessageBoxResult result = MessageBox.Show("You are about to pay Rs." + textBox1.Text + " for an extension of " + textBlock2.Text + ". Are you sure to proceed with transaction?", "", MessageBoxButton.OKCancel);
                if (result == MessageBoxResult.OK)
                {
                    Tele.GlobalVariables.extradata = "0 Gb of " + textBlock2.Text;
                    NavigationService.GoBack();
                }
                else if (result == MessageBoxResult.Cancel)
                {
                    slider1.Value = 0;
                    textBox1.Text = "";
                }
            }
        }
    }
}