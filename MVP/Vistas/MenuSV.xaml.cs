using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MVP.Vistas;

namespace MVP.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuSV : ContentPage
    {
        public MenuSV()
        {
            InitializeComponent();
        }

        private async void presionArterial_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PresionArterial());
        }

        private async void temperatura_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Temperatura());
        }

        private async void peso_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Peso());
        }

        private async void glucemia_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Glucemia());
        }

        private async void saturacionOxigeno_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SaturacionOxigeno());
        }
    }
}