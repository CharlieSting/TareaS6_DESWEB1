using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Schema;

namespace CalculadoraS6.Models
{
    public class Expresion
    {
        // (num1 y num2) y los métodos (Sumar, Restar, Multiplicar, Dividir)
        public double Num1 { get; set; }
        public double Num2 { get; set; }

        public  double Sumar()
        {
            double total;
            total= Num1 + Num2;
            return total;
        }
        public double Restar()
        {
            double total;
            total = Num1 - Num2;
            return total;
        }

        public double Multiplicar()
        {
                double total;
                total = Num1 * Num2;
                return total;
        }
        public double Dividir() {
            double total;
            total = Num1 / Num2;
            return total;

        }

        public override string ToString()
        {
            return $"Resultado: ";
        }


    }
}
