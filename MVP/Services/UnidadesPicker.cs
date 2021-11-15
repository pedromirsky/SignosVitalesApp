using MVP.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MVP.Services
{
    public class UnidadesPicker
    {
        public static List<Unidad> GetUnidadesPresion()
        {
            var unidades = new List<Unidad>()
            {
                new Unidad() {UnidadPresion = "mmHg"},
                new Unidad() {UnidadPresion = "Pa"}

            };
            return unidades;
        }

        public static List<Unidad> GetUnidadesTemperatura()
        {
            var unidades = new List<Unidad>()
            {
                new Unidad() {UnidadTemperatura = "°C"},
                new Unidad() {UnidadTemperatura = "F"}

            };
            return unidades;
        }

    }
}
