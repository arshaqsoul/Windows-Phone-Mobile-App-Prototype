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
    public partial class Login : PhoneApplicationPage
    {
        public Login()
        {
            InitializeComponent();
            
        }

        private void loginbtn_Click(object sender, RoutedEventArgs e)
        {
            if (usrname.Text == "John" && passwrd.Password == "12345")
            {
                NavigationService.Navigate(new Uri("/Dashboard.xaml", UriKind.Relative));
                Tele.GlobalVariables.user = usrname.Text;
            }
            else if (usrname.Text == "Tom" && passwrd.Password == "54321")
            {
                NavigationService.Navigate(new Uri("/Dashboard.xaml", UriKind.Relative));
                Tele.GlobalVariables.user = usrname.Text;
            }
            else
            {
                MessageBoxResult result = MessageBox.Show("Invalid Username and Password", "", MessageBoxButton.OK);
            }
        }

        private void image1_ImageFailed(object sender, ExceptionRoutedEventArgs e)
        {

        }
    }
}