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
    public sealed partial class UnosPosade : Page
    {
        /*public static string ime = "Dino";
        public static string prezime = "Zivojevic";
        public static string ID = "5"; */
        public UnosPosade()
        {
            this.InitializeComponent();
        }

        private async void button_Click(System.Object sender, RoutedEventArgs e)
        {

            if (comboBox.SelectedItem == null)
            {
                var d = new MessageDialog("Morate odabrati polozaj");
                await d.ShowAsync();
            }

            else if (Official.ViewModels.ProvjeritiKorisnika.PostojiLi(textBox.Text, textBox1.Text, textBox2.Text, (comboBox.SelectedItem as ComboBoxItem).Content.ToString()))
            {
            



            if ((comboBox.SelectedItem as ComboBoxItem).Content.ToString() == "Pilot")
                this.Frame.Navigate(typeof(UnosParametara));

            else if ((comboBox.SelectedItem as ComboBoxItem).Content.ToString() == "Stjuardesa")
                this.Frame.Navigate(typeof(PrikazParametara));
    
            }

            else {
                var d = new MessageDialog("Uneseni su neispravni parametri, pokusajte ponovo ili izvrsite registraciju");
                await d.ShowAsync();
            }
            
        }

        private void textBox_TextChanged(System.Object sender, TextChangedEventArgs e)
        {

        }

        private void passwordBox_PasswordChanged(System.Object sender, RoutedEventArgs e)
        {

        }

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Help));
        }

        private void textBox1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(BlankPage1));
        }
    }
}
