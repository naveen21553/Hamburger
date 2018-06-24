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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Hamburger
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            BackButton.Visibility = Visibility.Collapsed;
            MyFrame.Navigate(typeof(Home));
        }

        private void HamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            mySplitView.IsPaneOpen = !mySplitView.IsPaneOpen;
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            if (MyFrame.CanGoBack)
            {
                MyFrame.Navigate(typeof(Home));
                HomeListBox.IsSelected = true;                
            }
        }

        private void MyListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (HomeListBox.IsSelected)
            {
                MyFrame.Navigate(typeof(Home));
                BackButton.Visibility = Visibility.Collapsed;
                Title.Text = "Home";
            }

            else if (FinanceListBox.IsSelected)
            {
                MyFrame.Navigate(typeof(Finance));
                BackButton.Visibility = Visibility.Visible;
                Title.Text = "Finance";
            }

            else if (FoodListBox.IsSelected)
            {
                MyFrame.Navigate(typeof(Food));
                BackButton.Visibility = Visibility.Visible;
                Title.Text = "Food";
            }

            else if (TravelListBox.IsSelected)
            {
                MyFrame.Navigate(typeof(Travel));
                BackButton.Visibility = Visibility.Visible;
                Title.Text = "Travel";
            }
        }
    }
}
