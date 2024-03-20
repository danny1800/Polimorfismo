using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    internal class carroseria:carro
    {
        //Atributos
        private double bace { get; set; }
        private double altura { get; set; }

        //Constructor
        public carroseria(string c, double b, double a)
        {
            color = c;
            this.bace = b;
            this.altura = a;
        }

        //Metodo
        public string MostrarArea()
        {
            string datos;
            double area1;
            area1 = bace * altura;
            datos = "El color de la carroceria es: " + color + Environment.NewLine;
            datos += "El area de la carroceria es: " + area1 + Environment.NewLine;
            return datos;
        }

    }
}
