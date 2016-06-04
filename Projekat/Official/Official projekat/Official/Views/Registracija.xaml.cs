using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
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
    public sealed partial class BlankPage1 : Page
    {
        public BlankPage1()
        {
            this.InitializeComponent();
        }

        private async void button_Click(object sender, RoutedEventArgs e)
        {
            if (Official.ViewModels.ProvjeritiKorisnika.PostojiLi(RegistrujIme.Text, RegistrujPrezime.Text, RegistrujID.Text))
            {
                var d = new MessageDialog("Vec postoji korisnik sa zadanim podacima");
                await d.ShowAsync();
            }

            else
            {
                Official.ViewModels.ProvjeritiKorisnika.Dodaj(RegistrujIme.Text, RegistrujPrezime.Text, RegistrujID.Text);
                var d = new MessageDialog("Uspjesno ste registrovani");
                await d.ShowAsync();
            }

        }

        private void RegistrujIme_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void RegistrujPrezime_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void RegistrujID_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(UnosPosade));
        }
    }
}
