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
using System.Windows.Media.Imaging;

namespace Tele
{
    public partial class Dashboard : PhoneApplicationPage
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void hyperlinkButton1_Click(object sender, RoutedEventArgs e)
        {
            dashPivot.SelectedIndex = 3;
            //NavigationService.Navigate(new Uri("/Dashboard.xaml?PivotMain.SelectedIndex = 1", UriKind.Relative));
        }

        private void hyperlinkButton2_Click(object sender, RoutedEventArgs e)
        {
            dashPivot.SelectedIndex = 4;
        }

        private void hyperlinkButton3_Click(object sender, RoutedEventArgs e)
        {
            dashPivot.SelectedIndex = 5;
        }

        private void hyperlinkButton4_Click(object sender, RoutedEventArgs e)
        {
            dashPivot.SelectedIndex = 6;
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            DateTime today = DateTime.Now;
            string format = "MMM ddd d yyyy HH:mm";
            textBlock5.Text = today.ToString(format);
            dashPivot.Title = "Welcome " + Tele.GlobalVariables.user;
            if (Tele.GlobalVariables.user=="John")
            {
                //profile
                textBlock1.Text = "John Carter";
                textBlock2.Text = "Dehiwala, Colombo";
                textBlock4.Text = "011-2719043";
                textBlock56.Text = "+94 732 719 043";
                textBlock58.Text = "john@sltnet.com";
                //Tele
                textBlock7.Text = "Rs. 1024.00";
                BitmapImage imageTele = new BitmapImage(new Uri("/Tele;component/Images/callgraph.fw.png", UriKind.Relative));
                image1.Source = imageTele;
                callpacktext.Text = "Megaline Package";
                //Data
                BitmapImage imageData = new BitmapImage(new Uri("/Tele;component/Images/usagedistort.fw.png", UriKind.Relative));
                image2.Source = imageData;
                textBlock15.Text = "18 Gb of 25 Gb";
                progressBar1.Foreground = new SolidColorBrush(Color.FromArgb(255,0,127,255));
                progressBar1.Value = 72;
                textBlock16.Text = "1.5 Gb of 10 Gb";
                progressBar2.Foreground = new SolidColorBrush(Color.FromArgb(255, 0, 127, 255));
                progressBar2.Value = 15;
                textBlock17.Text = "19.6 Gb of 35 Gb";
                progressBar3.Foreground = new SolidColorBrush(Color.FromArgb(255, 0, 127, 255));
                progressBar3.Value = 56;
                textBlock18.Text = "Web Family";
                //bill
                textBlock30.Text = "Megaline Res SLT Phone Rental";
                textBlock41.Text = "345.00";
                textBlock42.Text = "1024.00";
                textBlock43.Text = "(400.00)";
                textBlock44.Text = "969.00";
                textBlock35.Text = "SLT BB Web Family Rental";
                textBlock45.Text = "1490.00";
                textBlock36.Text = "SLT Peo Entertainment Rental";
                textBlock46.Text = "1399.00";
                textBlock47.Text = "244.01";
                textBlock50.Text = "(600.00)";
                textBlock52.Text = "3691.42";
            }
            else if (Tele.GlobalVariables.user == "Tom")
            {
                //profile
                textBlock1.Text = "Tom Murphy";
                textBlock2.Text = "Ratmalan, Colombo";
                textBlock4.Text = "011-2712620";
                textBlock56.Text = "+94 733 564 895";
                textBlock58.Text = "tom@sltnet.com";
                //Tele
                textBlock7.Text = "Rs. 1635.00";
                BitmapImage imageTele = new BitmapImage(new Uri("/Tele;component/Images/callgraph2.fw.png", UriKind.Relative));
                image1.Source = imageTele;
                callpacktext.Text = "Citylink Package";
                //Data
                BitmapImage imageData = new BitmapImage(new Uri("/Tele;component/Images/usagedistor2t.fw.png", UriKind.Relative));
                image2.Source = imageData;
                textBlock15.Text = "7.4 Gb of 8 Gb";
                progressBar1.Foreground = new SolidColorBrush(Colors.Red);
                progressBar1.Value = 93;
                textBlock16.Text = "4.8 Gb of 5 Gb";
                progressBar2.Foreground = new SolidColorBrush(Colors.Red);
                progressBar2.Value = 96;
                textBlock17.Text = "12.2 Gb of 13 Gb";
                progressBar3.Foreground = new SolidColorBrush(Colors.Red);
                progressBar3.Value = 94;
                textBlock18.Text = "Web Pal";
                //TV
                textBlock20.Visibility = Visibility.Collapsed;
                textBlock21.Visibility = Visibility.Collapsed;
                textBlock27.Visibility = Visibility.Collapsed;
                textBlock28.Visibility = Visibility.Collapsed;
                button4.Visibility = Visibility.Collapsed;
                button5.Visibility = Visibility.Collapsed;
                button6.Visibility = Visibility.Collapsed;
                scrollViewer1.Visibility = Visibility.Collapsed;
                textBlock29.Visibility = Visibility.Visible;
                button7.Visibility = Visibility.Visible;
                //Bill
                textBlock30.Text = "Citylink Res SLT Phone Rental";
                textBlock41.Text = "165.00";
                textBlock42.Text = "1635.00";
                textBlock43.Text = "(400.00)";
                textBlock44.Text = "1400.00";
                textBlock35.Text = "SLT BB Web Pal Rental";
                textBlock45.Text = "990.00";
                textBlock36.Text = "Not Subscribed";
                textBlock46.Text = "0.00";
                textBlock47.Text = "396.76";
                textBlock50.Text = "155.00";
                textBlock52.Text = "3130.41";
            }
            if (Tele.GlobalVariables.extradata!="")
            {
                textBlock54.Text = Tele.GlobalVariables.extradata;
                progressBar4.Visibility = Visibility.Visible;
                textBlock53.Visibility = Visibility.Visible;
                textBlock54.Visibility = Visibility.Visible;
            }
            if (Tele.GlobalVariables.TvList != null)
            {
                listBox1.FontSize = 28;
                listBox1.Items.Add(Tele.GlobalVariables.TvList);
            }
            //mobile.dataplan
            if (Tele.GlobalVariables.plan != "" && Tele.GlobalVariables.data != "" && Tele.GlobalVariables.call != "" && Tele.GlobalVariables.sms != "")
            {
                textBlock83.Text = Tele.GlobalVariables.plan.ToString();
                textBlock79.Text = Tele.GlobalVariables.data.ToString();
                textBlock80.Text = Tele.GlobalVariables.call.ToString();
                textBlock82.Text = Tele.GlobalVariables.sms.ToString();
            }
            else
            {
                textBlock83.Text = "N/A";
                textBlock79.Text = "N/A";
                textBlock80.Text = "N/A";
                textBlock82.Text = "N/A";
            }
            //mobile.reload
            if (Tele.GlobalVariables.reload > 0)
            {
                int a = System.Convert.ToInt32(textBlock60.Text);
                int b = Tele.GlobalVariables.reload;
                int c = a + b;
                if (textBlock60.Text!="")
                {
                    textBlock60.Text = "";
                    textBlock60.Text = c.ToString();
                }
            }
        }

        private Image uri(string p, UriKind uriKind)
        {
            throw new NotImplementedException();
        }

        private void callDetailsBtn_Click(object sender, RoutedEventArgs e)
        {
            if (callpacktext.Text == "Megaline Package")
            {
                pophead.Text = "Megaline Package";
                popdesc.Text = "Mega Home Plan (Peak Hours)";
                popplan.Text = "SLT to SLT Peak Hours Rs.1.50   SLT to Others Peak Hours Rs.2.50";
                popdesc1.Text = "Mega Home Plan (Off Peak Hours)";
                popplan1.Text = "SLT to SLT Off Peak Hours Rs.1.00 SLT to Others Off Peak Hours Rs.2.00";
            }
            else if (callpacktext.Text == "Citylink Package")
            {
                pophead.Text = "Citylink Package";
                popdesc.Text = "City from 1st to 5th min";
                popplan.Text = "SLT to SLT 1st to 5th Rs.1.25   SLT to Others 1st to 5th Rs.2.25";
                popdesc1.Text = "City after 5th min";
                popplan1.Text = "SLT to SLT after 5th Rs.1.00 SLT to Others after 5th Rs.2.00";
            }
            popup1.IsOpen = true;
        }

        private void closedetailpopbtn_Click(object sender, RoutedEventArgs e)
        {
        }

        private void callchngBtn_Click(object sender, RoutedEventArgs e)
        {
            pack.Text = callpacktext.Text;
            popup2.IsOpen = true;
        }

        private void hyperlinkButton5_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void hyperlinkButton5_Click_1(object sender, RoutedEventArgs e)
        {
            dashPivot.SelectedIndex = 0;
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/ExtraData.xaml", UriKind.Relative));
        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/AddChannel.xaml", UriKind.Relative));
        }

        private void detailpop_Opened(object sender, EventArgs e)
        {

        }

        private void logoutbtn_Click(object sender, RoutedEventArgs e)
        {
            Tele.GlobalVariables.user = "";
            NavigationService.Navigate(new Uri("/Login.xaml", UriKind.Relative));
        }

        private void popok_Click(object sender, RoutedEventArgs e)
        {
            this.popup1.IsOpen = false;
        }

        private void packok_Click(object sender, RoutedEventArgs e)
        {
            if (callpacktext.Text == "")
            {
                MessageBoxResult result = MessageBox.Show("You are about to change your current package to " +list1.SelectedItem.ToString()+ " The change will take place within 24 hours. The service charge for the package change costs Rs.300. Do you want to confirm the change and the transaction?", "", MessageBoxButton.OKCancel);
                if (result==MessageBoxResult.OK)
                {
                callpacktext.Text = list1.SelectedItem.ToString();
                this.popup2.IsOpen = false;
                }
            }
            else
            {
                MessageBoxResult result = MessageBox.Show("You are about to change your current package to " + list1.SelectedItem.ToString() + " The change will take place within 24 hours. The service charge for the package change costs Rs.300. Do you want to confirm the change and the transaction?", "", MessageBoxButton.OKCancel);
                if (result == MessageBoxResult.OK)
                {
                    callpacktext.Text = "";
                    callpacktext.Text = list1.SelectedItem.ToString();
                    this.popup2.IsOpen = false;
                }
            }
            
        }

        private void packclose_Click(object sender, RoutedEventArgs e)
        {
            this.popup2.IsOpen = false;
        }

        private void popup2_Loaded(object sender, RoutedEventArgs e)
        {
            list1.Items.Add("Megaline Package");
            list1.Items.Add("Citylink Package");
            list1.Items.Add("Fibre Package");
        }

        private void hyperlinkButton6_Click(object sender, RoutedEventArgs e)
        {
            dashPivot.SelectedIndex = 1;
        }

        private void hyperlinkButton7_Click(object sender, RoutedEventArgs e)
        {
            dashPivot.SelectedIndex = 2;
        }

        private void hyperlinkButton8_Click(object sender, RoutedEventArgs e)
        {
            Tele.GlobalVariables.user = "";
            NavigationService.Navigate(new Uri("/Login.xaml", UriKind.Relative));
        }

        private void button8_Click(object sender, RoutedEventArgs e)
        {
            amt.Text = textBlock52.Text;
            popup3.IsOpen = true;
        }

        private void popup3_Opened(object sender, EventArgs e)
        {
            list2.Items.Add("Credit Card");
            list2.Items.Add("Direct Transfer");

        }

        private void payclose_Click(object sender, RoutedEventArgs e)
        {
            this.popup3.IsOpen = false;
        }

        private void payok_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("You are about to pay Rs." +pamt.Text+ " as a payment for the bill total of Rs. " + amt.Text + " for this month using " + list2.SelectedItem, "", MessageBoxButton.OKCancel);
            if (result == MessageBoxResult.OK)
            {
                decimal a = System.Convert.ToDecimal(pamt.Text);
                decimal b = System.Convert.ToDecimal(amt.Text);
                decimal c = b - a;
                textBlock52.Text = c.ToString();
                this.popup3.IsOpen = false;
            }

        }

        private void feedbtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Feedback.xaml", UriKind.Relative));
        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("To receive a PEO TV connection it will cost Rs. 500 as a service charge and Rs. 8000 for equipment totalling to Rs.8500. Do you want to request for a PEO TV subscription", "", MessageBoxButton.OKCancel);
            if (result==MessageBoxResult.OK)
            {
                textBlock29.Text = "You have sent a request. Please stay patiently until a call center representative gets in touch within a few hours. Thank You";
                this.button7.IsEnabled = false;
            }
            //textBlock20.Visibility = Visibility.Visible;
            //textBlock21.Visibility = Visibility.Visible;
            //textBlock27.Visibility = Visibility.Visible;
            //textBlock28.Visibility = Visibility.Visible;
            //button4.Visibility = Visibility.Visible;
            //button5.Visibility = Visibility.Visible;
            //button6.Visibility = Visibility.Visible;
            //scrollViewer1.Visibility = Visibility.Visible;
            //textBlock29.Visibility = Visibility.Collapsed;
            //button7.Visibility = Visibility.Collapsed;
        }

        private void button9_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Recharge.xaml", UriKind.Relative));
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            intpack.Text = textBlock18.Text;
            popup4.IsOpen = true;
        }

        private void popup4_Loaded(object sender, RoutedEventArgs e)
        {
            list3.Items.Add("Web Pal");
            list3.Items.Add("Web Surfer");
            list3.Items.Add("Web Familly");
            list3.Items.Add("Web Pro");
        }

        private void intpackok_Click(object sender, RoutedEventArgs e)
        {
            if (textBlock18.Text == "")
            {
                MessageBoxResult result = MessageBox.Show("You are about to change your current package to " +list3.SelectedItem.ToString()+ " The change will take place within 24 hours. The service charge for the package change costs Rs.300. Do you want to confirm the change and the transaction?", "", MessageBoxButton.OKCancel);
                if (result == MessageBoxResult.OK)
                {
                    textBlock18.Text = list3.SelectedItem.ToString();
                    this.popup4.IsOpen = false;
                }
            }
            else
            {
                MessageBoxResult result = MessageBox.Show("You are about to change your current package to " +list3.SelectedItem.ToString()+ " The change will take place within 24 hours. The service charge for the package change costs Rs.300. Do you want to confirm the change and the transaction?", "", MessageBoxButton.OKCancel);
                if (result == MessageBoxResult.OK)
                {
                    textBlock18.Text = "";
                    textBlock18.Text = list3.SelectedItem.ToString();
                    this.popup4.IsOpen = false;
                }
            }
        }

        private void intpackclose_Click(object sender, RoutedEventArgs e)
        {
            this.popup4.IsOpen = false;
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            if (textBlock18.Text == "Web Pal")
            {
                inthd.Text = "Web Pal";
                intdes.Text = "Web Pal Plan";
                intplan.Text = "Totally 10 GB free available every month. Download speed at 8 mbps. When limit exceeded Speed slows down";
                
            }
            else if (textBlock18.Text == "Web Surfer")
            {
                inthd.Text = "Web Surfer";
                intdes.Text = "Web Surfer Plan";
                intplan.Text = "Totally 15 GB free available every month. Download speed at 8 mbps. When limit exceeded Speed slows down";
            }
            popup7.IsOpen = true;
        }

        private void intok_Click(object sender, RoutedEventArgs e)
        {
            this.popup7.IsOpen = false;
        }

        private void popup6_Loaded(object sender, RoutedEventArgs e)
        {
            list4.Items.Add("Peo Titanium");
            list4.Items.Add("Peo Platinum");
            list4.Items.Add("Peo Gold");
            list4.Items.Add("Peo Entertainment");
        }

        private void tvpackok_Click(object sender, RoutedEventArgs e)
        {
            if (textBlock27.Text == "")
            {
                MessageBoxResult result = MessageBox.Show("You are about to change your current package to " + list4.SelectedItem.ToString() + " The change will take place within 24 hours. The service charge for the package change costs Rs.300. Do you want to confirm the change and the transaction?", "", MessageBoxButton.OKCancel);
                if (result == MessageBoxResult.OK)
                {
                    textBlock27.Text = list4.SelectedItem.ToString();
                    this.popup6.IsOpen = false;
                }
            }
            else
            {
                MessageBoxResult result = MessageBox.Show("You are about to change your current package to " + list4.SelectedItem.ToString() + " The change will take place within 24 hours. The service charge for the package change costs Rs.300. Do you want to confirm the change and the transaction?", "", MessageBoxButton.OKCancel);
                if (result == MessageBoxResult.OK)
                {
                    textBlock27.Text = "";
                    textBlock27.Text = list4.SelectedItem.ToString();
                    this.popup6.IsOpen = false;
                }
            }
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            tvcurpack.Text = textBlock27.Text;
            popup6.IsOpen = true;
        }
        
    }
}