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
    public sealed partial class PrikazParametara : Page
    {
        public PrikazParametara()
        {
            this.InitializeComponent();
        }

        private void PrikazVisine_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void PrikazKursa_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void PrikazUgaoKrila_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void PrikazTemperatura_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void PrikazPritiska_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void PrikazBrzine_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ProgressBar_ValueChanged(object sender, RangeBaseValueChangedEventArgs e)
        {
                  
        }

        private void ProgressBar_ValueChanged_1(object sender, RangeBaseValueChangedEventArgs e)
        {

        }

        private void ProgressBar_ValueChanged_2(object sender, RangeBaseValueChangedEventArgs e)
        {

        }

        private void ProgressBar_ValueChanged_3(object sender, RangeBaseValueChangedEventArgs e)
        {

        }

        private void ProgressBar_ValueChanged_4(object sender, RangeBaseValueChangedEventArgs e)
        {

        }

        private void ProgressBar_ValueChanged_5(object sender, RangeBaseValueChangedEventArgs e)
        {

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Help));
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(UnosPosade));
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            //Official.ViewModels.Arduino kontrola = new ViewModels.Arduino();
            Official.ViewModels.UnosParametaraViewModel var = new ViewModels.UnosParametaraViewModel();
            PrikazBrzine.Text = Official.ViewModels.UnosParametaraViewModel.DajBrzinu().ToString();
            PrikazVisine.Text = Official.ViewModels.UnosParametaraViewModel.DajVisinu().ToString();
            PrikazKursa.Text = Official.ViewModels.UnosParametaraViewModel.DajKurs().ToString();
            PrikazUgaoKrila.Text = Official.ViewModels.UnosParametaraViewModel.DajUgaoKrila().ToString();
            PrikazTemperatura.Text = Official.ViewModels.UnosParametaraViewModel.DajTemperaturu().ToString();
            PrikazPritiska.Text = Official.ViewModels.UnosParametaraViewModel.DajPritisak().ToString();

        }
    }
}
