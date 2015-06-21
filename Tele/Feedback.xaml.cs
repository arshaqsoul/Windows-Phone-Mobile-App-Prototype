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
    public partial class Feedback : PhoneApplicationPage
    {
        public Feedback()
        {
            InitializeComponent();
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            DateTime today = DateTime.Now;
            string format = "MMM ddd d yyyy HH:mm";
            textBlock5.Text = today.ToString(format);
            ApplicationTitle.Text = "Welcome " + Tele.GlobalVariables.user;
            listPicker1.Items.Add("Complaint");
            listPicker1.Items.Add("Suggestion");
            listPicker1.Items.Add("General");
            listPicker1.Items.Add("Question");
        }

        private void hyperlinkButton1_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
           textBox1.Text = "";
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            if (textBox1.Text == "") { MessageBoxResult result = MessageBox.Show("Please Enter a description", "", MessageBoxButton.OK); }
            else
            {
                MessageBoxResult result = MessageBox.Show("Thank You For your valuable feedback. We look forward to do better in future.", "", MessageBoxButton.OK);
                NavigationService.GoBack();
            }
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}