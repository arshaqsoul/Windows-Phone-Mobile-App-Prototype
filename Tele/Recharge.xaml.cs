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
    public partial class Recharge : PhoneApplicationPage
    {
        public Recharge()
        {
            InitializeComponent();
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            DateTime today = DateTime.Now;
            string format = "MMM ddd d yyyy HH:mm";
            textBlock5.Text = today.ToString(format);
            ApplicationTitle.Text = "Welcome " + Tele.GlobalVariables.user;
            listPicker1.Items.Add(0);
            listPicker1.Items.Add(25);
            listPicker1.Items.Add(50);
            listPicker1.Items.Add(100);
            listPicker1.Items.Add(150);
            listPicker1.Items.Add(200);

        }

        private void hyperlinkButton1_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            scrollViewer1.Visibility = Visibility.Visible;
            textBlock3.Visibility = Visibility.Visible;
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("You are about to reload Rs. " +listPicker1.SelectedItem.ToString()+ " are you sure to confirm the transaction?", "", MessageBoxButton.OKCancel);
            if (result == MessageBoxResult.OK)
            {
            Tele.GlobalVariables.reload = System.Convert.ToInt32(listPicker1.SelectedItem);
            }

        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            if (Tele.GlobalVariables.plan != "" && Tele.GlobalVariables.data != "" && Tele.GlobalVariables.call != "" && Tele.GlobalVariables.sms != "")
            {
                Tele.GlobalVariables.plan = "";
                Tele.GlobalVariables.data = "";
                Tele.GlobalVariables.call = "";
                Tele.GlobalVariables.sms = "";
            }
            else 
            {
                MessageBoxResult result = MessageBox.Show("You have selected the " + textBlock6.Text + " Package which costs " + textBlock4.Text + " . Do you want to confirm?", "", MessageBoxButton.OKCancel);
                if (result == MessageBoxResult.OK)
                {
                    Tele.GlobalVariables.plan = textBlock6.Text;
                    Tele.GlobalVariables.data = textBlock7.Text;
                    Tele.GlobalVariables.call = textBlock8.Text;
                    Tele.GlobalVariables.sms = textBlock9.Text;
                    NavigationService.GoBack();
                }
            }
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            if (Tele.GlobalVariables.plan != "" && Tele.GlobalVariables.data != "" && Tele.GlobalVariables.call != "" && Tele.GlobalVariables.sms != "")
            {
                Tele.GlobalVariables.plan = "";
                Tele.GlobalVariables.data = "";
                Tele.GlobalVariables.call = "";
                Tele.GlobalVariables.sms = "";
            }
            else
            {
                 MessageBoxResult result = MessageBox.Show("You have selected the " + textBlock11.Text + " Package which costs " + textBlock10.Text + " . Do you want to confirm?", "", MessageBoxButton.OKCancel);
                 if (result == MessageBoxResult.OK)
                 {
                     Tele.GlobalVariables.plan = textBlock11.Text;
                     Tele.GlobalVariables.data = textBlock12.Text;
                     Tele.GlobalVariables.call = textBlock13.Text;
                     Tele.GlobalVariables.sms = textBlock14.Text;
                     NavigationService.GoBack();
                 }
            }
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            if (Tele.GlobalVariables.plan != "" && Tele.GlobalVariables.data != "" && Tele.GlobalVariables.call != "" && Tele.GlobalVariables.sms != "")
            {
                Tele.GlobalVariables.plan = "";
                Tele.GlobalVariables.data = "";
                Tele.GlobalVariables.call = "";
                Tele.GlobalVariables.sms = "";
            }
            else
            {
                 MessageBoxResult result = MessageBox.Show("You have selected the " + textBlock16.Text + " Package which costs " + textBlock15.Text + " . Do you want to confirm?", "", MessageBoxButton.OKCancel);
                 if (result == MessageBoxResult.OK)
                 {
                     Tele.GlobalVariables.plan = textBlock16.Text;
                     Tele.GlobalVariables.data = textBlock17.Text;
                     Tele.GlobalVariables.call = textBlock18.Text;
                     Tele.GlobalVariables.sms = textBlock19.Text;
                     NavigationService.GoBack();
                 }
            }
        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            if (Tele.GlobalVariables.plan != "" && Tele.GlobalVariables.data != "" && Tele.GlobalVariables.call != "" && Tele.GlobalVariables.sms != "")
            {
                Tele.GlobalVariables.plan = "";
                Tele.GlobalVariables.data = "";
                Tele.GlobalVariables.call = "";
                Tele.GlobalVariables.sms = "";
            }
            else
            {
                MessageBoxResult result = MessageBox.Show("You have selected the " + textBlock21.Text + " Package which costs " + textBlock20.Text + " . Do you want to confirm?", "", MessageBoxButton.OKCancel);
                if (result == MessageBoxResult.OK)
                {
                    Tele.GlobalVariables.plan = textBlock21.Text;
                    Tele.GlobalVariables.data = textBlock22.Text;
                    Tele.GlobalVariables.call = textBlock23.Text;
                    Tele.GlobalVariables.sms = textBlock24.Text;
                    NavigationService.GoBack();
                }
            }
        }
    }
}