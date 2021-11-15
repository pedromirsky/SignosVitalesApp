using Java.Util;
using MVP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.CommunityToolkit.Extensions;
using Xamarin.CommunityToolkit.PlatformConfiguration.iOSSpecific;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace MVP.Vistas
{
    //[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Principal : ContentPage
    {
        public Principal()
        {
            InitializeComponent();
        }

        private async void btn1_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MenuSV());
        }

        private async void btn2_Clicked(object sender, EventArgs e)
        {
            //Task<List<Results>> results = App.Database.GetResults();
            //await Navigation.PushAsync(new Resultados((await results)[1].ToString()));
            await Navigation.PushAsync(new Resultados("Todos"));



        }

        private void btnSalir_Clicked(object sender, EventArgs e)
        {
            Navigation.ShowPopup(new PopUpSalir());
        }
    }
}