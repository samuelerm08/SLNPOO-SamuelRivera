using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LibTransportes.Entidades
{
    public class AutoElectrico : Vehiculo
    {
        public AutoElectrico(string marca, string modelo, string año, int porcentajeBateria, int autonomia) : base(marca, modelo, año)
        {
            PorcentajeBateria = porcentajeBateria;
            Autonomia = autonomia;
        }

        public int PorcentajeBateria { get; set; }     
        public int Autonomia { get; set; }

        public override string Acelerar()
        {
            return "Acelerando Electricamente";
        }

        public override string Frenar()
        {
            return "Frenando con los frenos especiales de disco";
        }

        public override string ToString()
        {
            return $"Marca: {Marca}\n" +
                   $"Modelo: {Modelo}\n" +
                   $"Año: {Año}\n" +
                   $"Porcentaje de Bateria: {PorcentajeBateria}\n" +
                   $"Autonomia: {Autonomia}";
        }
    }
}
