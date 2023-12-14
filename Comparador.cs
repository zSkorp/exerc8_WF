using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX8WF
{
    internal class Comparador
    {
        private double valor1;
        private double valor2;

        public Comparador(double valor1, double valor2)
        {
            this.valor1 = valor1;
            this.valor2 = valor2;
        }

        public Comparador()
        {
            this.valor1 = 0;
            this.valor2 = 0;
        }

        public void SetV1(double v1)
        {
            this.valor1 = v1;
        }

        public void SetV2(double v2)
        {
            this.valor2 = v2;
        }

        public double GetV1()
        {
            return this.valor1;
        }

        public double GetV2()
        {
            return this.valor2;  
        }

        public string Comparar()
        {
            if (valor1 > valor2)
            {
               return "O primeiro valor é maior: ";
            }
            else if (valor2 > valor1)
            {
                return "O segundo valor é maior: ";
            }
            else
            {
                return "Os valores são iguais.";
            }
        }
    }
}
