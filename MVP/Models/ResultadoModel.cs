using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace MVP.Models
{
    public class ResultadoModel
    {
        [PrimaryKey, AutoIncrement]
        public int ResultadoID { get; set; }
        public string Temperatura { get; set; }
        public string PresionDias { get; set; }
        public string PresionSis { get;  set; }
        public string Peso { get; set; }
        public DateTime Date { get; set; }
        public string SignoVital { get; set; }
        public string ValorMedido { get; set; }
        public string unidad { get; set; } // es un string !! no una Unidad como la de la clase creada

    }
}
