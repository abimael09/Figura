using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Figura
{
    class Retangulo : Figura
    {
        // Atributos
        private double largura;
        private double altura;

        // Sets e Gets
        public void SetLargura(double largura)
        {
            this.largura = largura;
        }
        public double GetLargura()
        {
            return largura;
        }
        public void Setaltura(double altura)
        {
            this.altura = altura;
        }
        public double Getaltura()
        {
            return altura;
        }

        // Métodos
        public override void CalcularArea()
        {
            SetArea(largura * altura);
        }

        public override void CalcularPerimetro()
        {
            SetPerimetro(2 * (largura * altura));
        }
    }
}
