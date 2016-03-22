using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace clase2
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculadora.Calcular(2, 4, "+");
            Calculadora.Calcular(4, 2, "-");
            Calculadora.Calcular(3, 2, "*");
            Calculadora.Calcular(6, 2,"/");
            Calculadora.Mayor(2, 4); 
           

        }
    }
}
