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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace BagiWaris
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class IbuAda : Page
    {
        public IbuAda()
        {
            this.InitializeComponent();
        }
        private void AppBarButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {

        }
        private void buttonHitungIbu_Click(object sender, RoutedEventArgs e)
        {
            double d = Convert.ToDouble(labelTotalHartaIbu.Text);
            labelTotalHartaIbu.Text = "";
            double f = d * 1 / 6;
            totalIbu.Text = ("Jumlah harta peninggalan ibu yang didapat ayah adalah " +"Rp. "+ f.ToString());
        }
    }
}
