using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.CommunityToolkit.UI.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MVP
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PopUpSalir : Popup
    {
        public PopUpSalir()
        {
            InitializeComponent();
        }

      

        private void Button_Clicked_Cancelar(object sender, EventArgs e)
        {
            Dismiss(null);
        }

        private void Button_Clicked_Salir(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}