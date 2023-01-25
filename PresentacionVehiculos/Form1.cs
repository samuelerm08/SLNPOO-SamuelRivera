using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibTransportes.Entidades;

namespace PresentacionVehiculos
{
    public partial class PresentacionVehiculos : Form
    {
        public PresentacionVehiculos()
        {
            InitializeComponent();
        }
        private void MostrarCamion(object sender, EventArgs e)
        {
            var r = new Remolque() { Estado = "Conectado" };
            var c = new Camion("Ford", "350", 1970, "Arena", 1000)
            {
                Remolque = r
            };

            //Metodo para quitar remolque
            //c.QuitarRemolque();
            //MessageBox.Show(c.QuitarRemolque());

            MessageBox.Show($"{c}");
        }
    }
}
