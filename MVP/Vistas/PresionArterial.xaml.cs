using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MVP.ViewModels;

namespace MVP
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PresionArterial : ContentPage
    {
        public PresionArterial()
        {
            
            
            InitializeComponent();
            BindingContext = new PresionViewModel();
            pkrPA.SelectedIndex = 0;


        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Resultados("Presión Arterial:"));
        }

       
    }
}