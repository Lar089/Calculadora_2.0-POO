using System;
using System.Collections.Generic;
using System.Text;

namespace Calculadora_POO
{
    public class Calculadora
    {
        private double x;
        private double y;
        private double resultado;
        private string operacao;

        public Calculadora()
        {
        }

        public Calculadora(double x, double y, double resultado, string operacao)
        {
            this.x = x;
            this.y = y;
            this.resultado = resultado;
            this.operacao = operacao;
        }

        public double X
        {
            get { return x; }
            set { x = value; }
        }

        public double Y
        {
            get { return y; }
            set { y = value; }
        }

        public double Resultado
        {
            get { return resultado; }
            set { resultado = value; }
        }

        public string Operacao
        {
            get { return operacao; }
            set { operacao = value; }
        }

    }

}
