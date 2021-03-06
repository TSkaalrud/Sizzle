﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfMid_Prototype
{
    /// <summary>
    /// Interaction logic for HomePage.xaml
    /// </summary>
    public partial class HomePage : Page
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void Menu_Loaded(object sender, RoutedEventArgs e)
        {
            
        }

        private void popular_Click(object sender, RoutedEventArgs e)
        {
            
              
        }

        

        private void textB_MouseEnter(object sender, MouseEventArgs e)
        {
            if(textB.Text== "Enter Keywords for Recipes") {
                textB.Text = "";

                textB.Foreground = new SolidColorBrush(Color.FromRgb(0, 0, 0));
            }
        }

        private void textB_MouseLeave(object sender, MouseEventArgs e)
        {
            if (textB.Text == "")
            {
                textB.Text = "Enter Keywords for Recipes";

                textB.Foreground = new SolidColorBrush(Color.FromRgb(147, 139, 139));
            }
        }

        private void porkBelly_MouseEnter(object sender, MouseEventArgs e)
        {
            porkBelly.Background = new SolidColorBrush(Color.FromRgb(211, 208, 184));
        }

        private void porkBelly_MouseLeave(object sender, MouseEventArgs e)
        {
            porkBelly.Background = new SolidColorBrush(Color.FromRgb(236, 233, 210));
        }

        private void pasta_MouseEnter(object sender, MouseEventArgs e)
        {
            pasta.Background = new SolidColorBrush(Color.FromRgb(211, 208, 184));
        }

        private void pasta_MouseLeave(object sender, MouseEventArgs e)
        {
            pasta.Background = new SolidColorBrush(Color.FromRgb(236, 233, 210));
        }
        private void veggieTaco_MouseEnter(object sender, MouseEventArgs e)
        {
            veggieTaco.Background = new SolidColorBrush(Color.FromRgb(211,208,184));
        }

        private void veggieTaco_MouseLeave(object sender, MouseEventArgs e)
        {
            veggieTaco.Background = new SolidColorBrush(Color.FromRgb(236, 233, 210));
        }

        private void burger_MouseEnter(object sender, MouseEventArgs e)
        {
            burger.Background = new SolidColorBrush(Color.FromRgb(211, 208, 184));
        }

        private void burger_MouseLeave(object sender, MouseEventArgs e)
        {
            burger.Background = new SolidColorBrush(Color.FromRgb(236, 233, 210));
        }

        private void milkTea_MouseEnter(object sender, MouseEventArgs e)
        {
            milkTea.Background = new SolidColorBrush(Color.FromRgb(211, 208, 184));
        }

        private void milkTea_MouseLeave(object sender, MouseEventArgs e)
        {
            milkTea.Background = new SolidColorBrush(Color.FromRgb(236, 233, 210));
        }

        private void profile_highlight_MouseEnter(object sender, MouseEventArgs e)
        {
            ph.Visibility = Visibility.Visible;
        }

        private void profile_highlight_MouseLeave(object sender, MouseEventArgs e)
        {
            ph.Visibility = Visibility.Hidden;
        }

        private void profile_highlight_MouseDown(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Profile.xaml", UriKind.RelativeOrAbsolute));
        }

        private void textB_KeyDown(object sender, KeyEventArgs e)
        {
            homeRecipes.Visibility = Visibility.Hidden;
            result.Visibility = Visibility.Visible;
        }

        private void home_Click(object sender, RoutedEventArgs e)
        {
            homeRecipes.Visibility = Visibility.Visible;
            result.Visibility = Visibility.Hidden;
        }

        private void Button_VeggieTacos(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/ViewPage.xaml", UriKind.RelativeOrAbsolute));

        }
    }
}
