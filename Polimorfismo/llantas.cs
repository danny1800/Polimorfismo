using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polimorfismo
{
    internal class llantas
    {
        protected string color {  get; set; }
        private double radio {  get; set; }
        
        public llantas(string c, double r)
        {
            color = c;
            this.radio = r;
        }

        public string MostrarDiametro()
        {
            string datos;
            double diam;
            diam = Math.Round (Math.PI * Math.Pow (radio, 2));
            datos = "El color de la llanta es: " + color + Environment.NewLine;
            datos += "El diametros de las llantas es: " + diam + Environment.NewLine;
            return datos;
        }
    }
}
