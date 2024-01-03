using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Figura
{
    class Quadrado : Figura
    {
        // Atributos
        private double lado;

        // Sets e Gets
        public void SetLado(double lado)
        {
            this.lado = lado;
        }
        public double GetLado()
        {
            return lado;
        }

        // Métodos
        public override void CalcularArea()
        {
            SetArea(lado * lado);
        }

        public override void CalcularPerimetro()
        {
            SetPerimetro(lado * 4);
        }
    }
}
