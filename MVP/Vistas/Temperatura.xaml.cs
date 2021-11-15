using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MVP.ViewModels;

namespace MVP
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Temperatura : ContentPage
    {
        public Temperatura()
        {
            InitializeComponent();
            BindingContext = new TemperaturaViewModel();
            pkrTemp.SelectedIndex = 0;
            
        }

        
        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Resultados("Temperatura:")); // ojo que este Resultados es el .xaml , no el Model
        }
    }
}