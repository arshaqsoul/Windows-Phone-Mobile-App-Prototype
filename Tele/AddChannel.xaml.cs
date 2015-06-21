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
    public partial class AddChannel : PhoneApplicationPage
    {
        public AddChannel()
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

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            listBox1.Items.Add("ABC Channel");
            if (textBox1.Text == "")
            {
                textBox1.Text = "75";
                button1.IsEnabled = false;
            }
            else
            {
                Int32 a;
                Int32 b;
                a= System.Convert.ToInt32(textBox1.Text);
                b = a + 75;
                textBox1.Text = System.Convert.ToString(b);
                button1.IsEnabled = false;
            }
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            listBox1.Items.Add("Animal Planet");
            if (textBox1.Text == "")
            {
                textBox1.Text = "75";
                button2.IsEnabled = false;
            }
            else
            {
                Int32 a;
                Int32 b;
                a = System.Convert.ToInt32(textBox1.Text);
                b = a + 75;
                textBox1.Text = System.Convert.ToString(b);
                button2.IsEnabled = false;
            }
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            listBox1.Items.Add("BBC America");
            if (textBox1.Text == "")
            {
                textBox1.Text = "75";
                button3.IsEnabled = false;
            }
            else
            {
                Int32 a;
                Int32 b;
                a = System.Convert.ToInt32(textBox1.Text);
                b = a + 75;
                textBox1.Text = System.Convert.ToString(b);
                button3.IsEnabled = false;
            }
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            listBox1.Items.Add("Bloomberg");
            if (textBox1.Text == "")
            {
                textBox1.Text = "75";
                button4.IsEnabled = false;
            }
            else
            {
                Int32 a;
                Int32 b;
                a = System.Convert.ToInt32(textBox1.Text);
                b = a + 75;
                textBox1.Text = System.Convert.ToString(b);
                button4.IsEnabled = false;
            }
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            listBox1.Items.Add("Cartoon Network");
            if (textBox1.Text == "")
            {
                textBox1.Text = "75";
                button5.IsEnabled = false;
            }
            else
            {
                Int32 a;
                Int32 b;
                a = System.Convert.ToInt32(textBox1.Text);
                b = a + 75;
                textBox1.Text = System.Convert.ToString(b);
                button5.IsEnabled = false;
            }
        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            listBox1.Items.Add("CNBC Channel");
            if (textBox1.Text == "")
            {
                textBox1.Text = "75";
                button6.IsEnabled = false;
            }
            else
            {
                Int32 a;
                Int32 b;
                a = System.Convert.ToInt32(textBox1.Text);
                b = a + 75;
                textBox1.Text = System.Convert.ToString(b);
                button6.IsEnabled = false;
            }
        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            listBox1.Items.Add("CNN Channel");
            if (textBox1.Text == "")
            {
                textBox1.Text = "75";
                button7.IsEnabled = false;
            }
            else
            {
                Int32 a;
                Int32 b;
                a = System.Convert.ToInt32(textBox1.Text);
                b = a + 75;
                textBox1.Text = System.Convert.ToString(b);
                button7.IsEnabled = false;
            }
        }

        private void button8_Click(object sender, RoutedEventArgs e)
        {
            listBox1.Items.Add("CW Channel");
            if (textBox1.Text == "")
            {
                textBox1.Text = "75";
                button8.IsEnabled = false;
            }
            else
            {
                Int32 a;
                Int32 b;
                a = System.Convert.ToInt32(textBox1.Text);
                b = a + 75;
                textBox1.Text = System.Convert.ToString(b);
                button8.IsEnabled = false;
            }
        }

        private void button9_Click(object sender, RoutedEventArgs e)
        {
            listBox1.Items.Add("Discovery Channel");
            if (textBox1.Text == "")
            {
                textBox1.Text = "75";
                button9.IsEnabled = false;
            }
            else
            {
                Int32 a;
                Int32 b;
                a = System.Convert.ToInt32(textBox1.Text);
                b = a + 75;
                textBox1.Text = System.Convert.ToString(b);
                button9.IsEnabled = false;
            }
        }

        private void button10_Click(object sender, RoutedEventArgs e)
        {
            listBox1.Items.Add("Disney Channel");
            if (textBox1.Text == "")
            {
                textBox1.Text = "75";
                button10.IsEnabled = false;
            }
            else
            {
                Int32 a;
                Int32 b;
                a = System.Convert.ToInt32(textBox1.Text);
                b = a + 75;
                textBox1.Text = System.Convert.ToString(b);
                button10.IsEnabled = false;
            }
        }
        public string[] getChannelList()
        {
            Tele.GlobalVariables.TvList = new string[listBox1.Items.Count];
            int channelcount = listBox1.Items.Count;
            for (int i = 0; i < channelcount; i++)
            {
                Tele.GlobalVariables.TvList[i] = listBox1.Items[i].ToString() + Environment.NewLine;
            }
            return Tele.GlobalVariables.TvList;
        }

        private void button11_Click(object sender, RoutedEventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please select new channel(s)");
            }
            else
            {
                MessageBoxResult result = MessageBox.Show("You are about to pay Rs." + textBox1.Text + " for " + listBox1.Items.Count + " Channels. Are you sure to proceed with the transaction?", "", MessageBoxButton.OKCancel);
                if (result == MessageBoxResult.OK)
                {
                    getChannelList();
                    NavigationService.GoBack();
                }
                else if (result == MessageBoxResult.Cancel)
                {
                    listBox1.Items.Clear();
                    textBox1.Text = "";
                }
            }
        }

        private void button12_Click(object sender, RoutedEventArgs e)
        {
            listBox1.Items.Clear();
            textBox1.Text = "";
            NavigationService.GoBack();
        }
    }
}