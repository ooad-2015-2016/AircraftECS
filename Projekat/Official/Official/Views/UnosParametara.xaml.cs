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

namespace Official.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class UnosParametara : Page
    {
        public UnosParametara()
        {
            this.InitializeComponent();
        }

        private void Pokretanje_Click(object sender, RoutedEventArgs e)
        {
            //Ovdje je potrebno ubaciti uslov tipa ako su uneseni svi parametri da ide na narednu komandu
            this.Frame.Navigate(typeof(PrikazParametara));
        }

        private void UnosVisine_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void UnosBrzine_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void UnosKursa_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void UnosUgaoKrila_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void UnosTemperatura_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void UnosPritisak_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Help));
        }
    }
}
