using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class ClaseCalculadora
    {
        int numero1 = 0;

        public int numero1Publico
        {
            get { return numero1; }
            set { numero1 = value; }
        }
        int numero2 = 0;

        public int numero2Publico
        {
            get { return numero2; }
            set { numero2 = value; }
        }

        int resultado = 0;

        public int resultadoPublica
        {
            get { return resultado; }
            set { resultado = value; }
        }
        char operacion = 'N';

        public char OperacionPublica
        {
            get { return operacion; }
            set { operacion = value; }
        }
        public ClaseCalculadora(int cNumero1, int cNumero2, int cResultado, char cOperacion)
        {
            numero1 = cNumero1;
            numero2 = cNumero2;
            resultado = cResultado;
            operacion = cOperacion;
        }
        public int Sumar()
        {
            resultado = numero1 + numero2;
            return resultado; 
        }
        public int Restar()
        {
            resultado = numero1 - numero2;
            return resultado;
        }
        public int Multiplicar()
        {
            resultado = numero1 * numero2;
            return resultado;
        }
        public int Dividir()
        {
            resultado = numero1 / numero2;
            return resultado;
        }
        public int Porcentaje()
        {
            resultado = (numero1 * numero2)/100;
            return resultado;
        }
        public int Raiz()
        {
            double numeroendouble = 0;
            numeroendouble = Convert.ToDouble(numero1.ToString());
            resultado = Convert.ToInt32(Math.Sqrt(numeroendouble));
            return resultado;
        }
    }
}
