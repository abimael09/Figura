using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Figura
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instanciando classe e criando objeto RET
            Retangulo ret = new Retangulo();
            ret.SetCor("Green");
            ret.SetLargura(10);
            ret.Setaltura(5);
            ret.SetArea(50.0);
            ret.SetPerimetro(15.0);
            ret.CalcularArea();
            ret.CalcularPerimetro();

            // Instanciando classe e criando objeto QUADR
            Quadrado quadr = new Quadrado();
            quadr.SetCor("Red");
            quadr.SetLado(10.0);
            quadr.CalcularArea();
            quadr.CalcularPerimetro();

            // Instanciando classe e criando objeto CIRC
            Circulo circ = new Circulo();
            circ.SetCor("Blue");
            circ.SetRaio(4.0);
            circ.CalcularArea();
            circ.CalcularPerimetro();

            // Criando Vetor Figuras e guardando dados em três posições
            Figura[] figuras = new Figura[3];

            figuras[0] = ret;
            figuras[1] = quadr;
            figuras[2] = circ;

            
                Console.WriteLine("Mostrando Dados do Retângulo: \n\n" + ret);
                Console.WriteLine("Mostrando Dados do Quadrado: \n\n" + figuras[1]);
                Console.WriteLine("Mostrando Dados do Círculo: \n\n" + figuras[2]); 
   
            
                Console.ReadKey();
        }
    }
}
