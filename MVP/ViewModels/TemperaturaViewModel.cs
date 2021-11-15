using GalaSoft.MvvmLight.Command;
using System.Windows.Input;
using MVP.Models;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using MVP.Services;
using System.Linq;

namespace MVP.ViewModels
{
    public class TemperaturaViewModel : BaseViewModel
    {
        #region Attributes
        public string temp;


        #endregion
        public List<Unidad> ListUnidades { get; set; }

        #region UnidadesSeleccion

        public TemperaturaViewModel()
        {
            ListUnidades = UnidadesPicker.GetUnidadesTemperatura().OrderBy(c => c.UnidadTemperatura).ToList(); ;
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
                UnidadText = "Unidad : " + _selectedUnidad.UnidadTemperatura;
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
        public string TempTxt
        {
            get { return this.temp; }
            set { SetValue(ref this.temp, value); }
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
                Temperatura = temp,
                Date = tempD,
                SignoVital = "Temperatura:",
                ValorMedido = temp,
                unidad = _selectedUnidad.UnidadTemperatura



            };

            await App.Database.SaveResultadoModelAsync(resultado);

 
        }

        #endregion

    }
}
