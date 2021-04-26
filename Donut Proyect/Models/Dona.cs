using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Donut_Proyect.Models
{
    class Dona
    {
        
        public RadioButton TipoDona { get; set; }
        public RadioButton TipoRelleno { get; set; }
        public RadioButton TipoCubierta { get; set; }
        public double Precio { get; set; }
    }
}
