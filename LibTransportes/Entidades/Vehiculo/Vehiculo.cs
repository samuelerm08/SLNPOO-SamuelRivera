using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibTransportes.Entidades
{
    public abstract class Vehiculo
    {
        protected Vehiculo(string marca, string modelo, int año)
        {
            Marca = marca;
            Modelo = modelo;
            Año = año;
        }

        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Año { get; set; }
        public abstract string Acelerar();
        public abstract string Frenar();      
        
        public virtual string Imprimir()
        {
            return $"Marca: {Marca}\n" +
                   $"Modelo: {Modelo}\n" +
                   $"Año: {Año}";
        }
    }
}
