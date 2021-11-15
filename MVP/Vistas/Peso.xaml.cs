using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MVP.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Peso : ContentPage
    {
        public Peso()
        {
            InitializeComponent();
            unidadPeso.Items.Add("kg");
            unidadPeso.Items.Add("lb");
            unidadPeso.SelectedIndex = 0;
        }

        private void unidadPeso_SelectedIndexChanged(object sender, EventArgs e)
        {
            String unidad = unidadPeso.SelectedItem.ToString();
        }

        private async void guardarPeso_Clicked(object sender, EventArgs e)
        {
            String unidad = unidadPeso.SelectedItem.ToString();

            await Navigation.PushAsync(new Resultados("Peso: "));
        }
    }
}