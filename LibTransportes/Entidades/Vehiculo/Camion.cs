using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace LibTransportes.Entidades
{
    public class Camion : Vehiculo
    {
        public Camion(string marca, string modelo, string año, string tipoCarga, float capacidad) : base(marca, modelo, año)
        {
            TipoCarga = tipoCarga;
            Capacidad = capacidad;
        }

        public string TipoCarga { get; set; }
        public float Capacidad { get; set; }
        public Remolque Remolque { get; set; }

        public override string Acelerar()
        {
            return $"Camion Acelerando con motor a nafta";
        }

        public override string Frenar()
        {
            return $"Camion Frenando con potencia";
        }

        public string QuitarRemolque()
        {
            Remolque = null;
            return "Remolque suelto";
        }

        public override string ToString()
        {
            return $"Marca: {Marca}\n" +
                   $"Modelo: {Modelo}\n" +
                   $"Año: {Año}\n" +
                   $"Tipo de Carga: {TipoCarga}\n" +
                   $"Capacidad: {Capacidad}\n";
        }
    }
}
