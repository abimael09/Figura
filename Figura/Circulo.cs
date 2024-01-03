using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Figura
{
    class Circulo : Figura
    {
        // Atributos
        private double raio;

        // Sets e Gets
        public void SetRaio(double raio)
        {
            this.raio = raio;
        }
        public double GetRaio()
        {
            return raio;
        }

        // Métodos
        public override void CalcularArea()
        {
            const double Pi = 3.14;
            SetArea(raio * Pi);
        }

        public override void CalcularPerimetro()
        {
            const double Pi = 3.14;
            SetPerimetro((Pi*2)*raio);
        }

    }
}
