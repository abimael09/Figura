using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Figura
{
    abstract class Figura
    {
        // Atributos
        private double area;
        private string cor;
        private double perimetro;

        // Sets e Gets
        public void SetArea(double area)
        {
            this.area = area;
        }
        public double GetArea()
        {
            return area;
        }
        public void SetCor(string cor)
        {
            this.cor = cor;
        }
        public string GetCor()
        {
            return cor;
        }
        public void SetPerimetro(double perimetro)
        {
            this.perimetro = perimetro;
        }
        public double GetPerimetro()
        {
            return perimetro;
        }

        // Construtores (vazio e cheio)
        public Figura() { }

        public Figura(double area, string cor, double perimetro)
        {
            this.area = area;
            this.cor = cor;
            this.perimetro = perimetro;
        }

        // Métodos
        public abstract void CalcularArea();

        public abstract void CalcularPerimetro();
        
    }
}
