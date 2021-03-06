﻿using System;
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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Demo9Task2
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private double course = 5.94573;

        public MainPage()
        {
            this.InitializeComponent();
        }

        private void MarkatButton_Click(object sender, RoutedEventArgs e)
        {
            double euro;
            bool result = double.TryParse(EurotBox.Text, out euro);
            if (result)
            {
                double markka = euro * course;
                MarkatBox.Text = markka.ToString("0.00");
            }
        }

        private void EurotButton_Click(object sender, RoutedEventArgs e)
        {
            double markka;
            bool result = double.TryParse(MarkatBox.Text, out markka);
            if (result)
            {
                double euro = markka / course;
                EurotBox.Text = euro.ToString("0.00" + "€");
            }
        }

    }
}
