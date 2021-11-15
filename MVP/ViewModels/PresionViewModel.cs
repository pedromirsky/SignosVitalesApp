using GalaSoft.MvvmLight.Command;
using System.Windows.Input;
using MVP.Models;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using MVP.Services;
using System.Linq;

namespace MVP.ViewModels
{
    public class PresionViewModel : BaseViewModel
    {
        #region Attributes

    public string presionDias;
    public string presionSis;
    public List<Unidad> ListUnidades { get; set; }
        #endregion

        #region UnidadesSeleccion

        public PresionViewModel()
        {
            ListUnidades = UnidadesPicker.GetUnidadesPresion().OrderBy(c => c.UnidadPresion).ToList(); ;
        }
        private Unidad _selectedUnidad;
        public Unidad SelectedUnidad
        {
            get
            {
                return _selectedUnidad;
            }
            set
            {
                SetProperty(ref _selectedUnidad, value);
                //put here your code  
                UnidadText = "Unidad : " + _selectedUnidad.UnidadPresion;
            }
        }
        private string _unidadText;
        public string UnidadText
        {
            get
            {
                return _unidadText;
            }
            set
            {
                SetProperty(ref _unidadText, value);
            }
        }
    

    #endregion

    #region Properties


    public string PresionDiasTxt
        {
            get { return this.presionDias; }
            set { SetValue(ref this.presionDias, value); }
        }

        public string PresionSisTxt // aca toma el valor del entry como variable de esta clase (como atributo)
        {
            get { return this.presionSis; }
            set { SetValue(ref this.presionSis, value); }
        }

        #endregion

        #region Commands
        public ICommand InsertCommand
        {
            get
            {
                return new RelayCommand(InsertMethod);
            }
        }
        #endregion

        #region Methods
        private async void InsertMethod()
        {
            DateTime now = DateTime.UtcNow;
            DateTime tempD = TimeZone.CurrentTimeZone.ToLocalTime(now);

            var resultado = new ResultadoModel
            {
                
                //Cargo valores para guardar en la base de datos
                PresionDias = presionDias,
                PresionSis = presionSis,
                Date = tempD,

                //Parte que también se muestre en el LV Resultados
                SignoVital = "Presión Arterial:",
                ValorMedido = (presionDias + " / " + presionSis),
                unidad = _selectedUnidad.UnidadPresion
                



        };

            await App.Database.SaveResultadoModelAsync(resultado);

        }

        #endregion

    }
}
