using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest1
{
    public static class ProcesadorMatematico
    {
        public static int Sumar(int primerNumero, int segundoNumero)
        {
            return primerNumero + segundoNumero;
        }

        public static int Resta(int primerNumero, int segundoNumero)
        {
            return primerNumero - segundoNumero;
        }

        public static int Multiplicacion(int primerNumero, int segundoNumero)
        {
            return primerNumero * segundoNumero;
        }

        public static int Division(int dividendo, int divisor)
        {
            return dividendo / divisor;
        }

        public static int Potencia(int numeroBase, int exponente)
        {
            return (int)Math.Pow(numeroBase, exponente);
        }

        public static int Raiz(int numeroBase, int exponente)
        {
            return (int)Math.Pow(numeroBase, 1 / exponente);
        }

    }
}
