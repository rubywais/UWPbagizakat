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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace BagiWaris
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class AyahAda : Page
    {
        public AyahAda()
        {
            this.InitializeComponent();
        }

        private void AppBarButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
        }

        private void buttonHitungAyah_Click(object sender, RoutedEventArgs e)
        {
            double a = Convert.ToDouble(labelTotalHartaAyah.Text);
            labelTotalHartaAyah.Text = "";
            double b = a * 1 / 6;
            totalAyah.Text = ("Jumlah harta peninggalan ibu yang didapat ayah adalah " +"Rp. "+ b.ToString());
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}
