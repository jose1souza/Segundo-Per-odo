﻿using biblioteca;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca
{
    public class Calculadora
    {
        public static double soma(double n1, double n2)
        {
            return n1 + n2;
            // retornando a soma de dois números
        } // fim da função soma
        public static double sub(double n1, double n2)
        {
            return n1 - n2;
            // retornando a subtração de dois números
        } // fim da função subtrair
        public static double div(double n1, double n2)
        {
            if (n2 == 0)
            {
                return 0;
            }
            else
            {
                return n1 / n2;
                // retornando a divisão de dois números
            } // fim da função dividir
        }
        public static double multi(double n1, double n2)
        {
            return n1 * n2;
            // retornando a multiplicação de dois números
        } // fim da função multiplicar

    }
}