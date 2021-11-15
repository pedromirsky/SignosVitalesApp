using GalaSoft.MvvmLight.Command;
using System.Windows.Input;
using MVP.Models;
using System.Threading.Tasks;



namespace MVP.ViewModels
{
    public class ResultadoViewModel : BaseViewModel
    {
        #region Attributes
        public bool isRefreshing = false;
        public object listViewSource;
        #endregion

        #region Properties

        public bool IsRefreshing
        {
            get { return isRefreshing; }
            set { SetValue(ref this.isRefreshing, value); }
        }

        public object ListViewSource
        {

            get { return this.listViewSource; }
            set
            {
                SetValue(ref this.listViewSource, value);
            }
        }
        #endregion

        #region Methods

        public async Task LoadData(string filtroResutlado)
        {
            //this.ListViewSource = await App.Database.GetResultadoModel();
            if (filtroResutlado == "Todos")
            {
                this.ListViewSource = await App.Database.GetResultadoModel();
            }
            else{
                this.ListViewSource = await App.Database.GetResultadoSignoVital(filtroResutlado);
            }
           

        }

        #endregion


        #region Constructor
        public ResultadoViewModel(string filtroResutlado )
        {
            LoadData(filtroResutlado);
        }
        #endregion
    }
}
