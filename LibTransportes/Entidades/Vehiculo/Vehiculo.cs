using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibTransportes.Entidades
{
    public abstract class Vehiculo
    {
        protected Vehiculo(string marca, string modelo, string año)
        {
            Marca = marca;
            Modelo = modelo;
            Año = año;
        }

        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Año { get; set; }
        public abstract string Acelerar();
        public abstract string Frenar();        
    }
}
