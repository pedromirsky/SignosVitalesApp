
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MVP.ViewModels;

namespace MVP
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Resultados : ContentPage
    {
        public Resultados(string filtroResultados)
        {
            InitializeComponent(); 
            BindingContext = new ResultadoViewModel(filtroResultados);
        }

    }
}