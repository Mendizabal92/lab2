using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace clase2
{
    class Calculadora
    {//xml es,un texto plano,= a html.
        
      /// <summary>
      /// 
      /// </summary>
      /// <param name="nro1"></param>
      /// <param name="nro2"></param>
        private static void sumar(double nro1,double nro2)
        {
            
            //Console.WriteLine("estoy sumando");//metodos estaticos:/*como me doy cuenta qe es un metodo estatico?*/
            /*metodos estaticos despues del punto(.)los qe me aparecen son metodos de la clase(osea estaticos)*/
            Console.WriteLine("suma {0}",nro1+nro2);
        }
        /// <summary>
        /// 
        /// </summary>
        private static void restar(double nro1, double nro2)//publico lo puede ver todos, y el private solo la clase.
        {
           
            //Console.WriteLine("estoy restando");
            Console.WriteLine("resta {0}",nro1-nro2);
        }

        private static void multiplicar(double nro1, double nro2)
        {
            //Console.WriteLine("estoy multiplicando");
            
            Console.WriteLine("multiplicacion {0}",nro1*nro2);
        }

        private static void dividir(double nro1, double nro2)
        {
            //Console.WriteLine("estoy dividiendo");
            
            if (Calculadora.Validar(nro2)==true)
            {
                Console.WriteLine("division {0}", nro1 / nro2);
            }
            else
            {
                Console.WriteLine("no se puede dividir por 0!");
            }
            
        }
        /// <summary>
        /// Validar si es distinto a 0
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        private static bool Validar(double x)//metodos, el comportamiento.
        {
            if (x!=0) 
                return true;
                    return false;
            //solo lo limito para qe lo vea dentro de la clase,private
        
        }

        public static void Calcular(double numero1,double numero2,string operacion)
        {
            switch (operacion)
            {
                case "+":

                    sumar(numero1, numero2);
                    break;

                case "-":

                    restar(numero1, numero2);
                    break;
                
                case "*":

                    multiplicar(numero1, numero2);
                    break;
                        
                case "/":

                    dividir(numero1, numero2);
                    break;
            }
        
           
        }

        public static double Mayor(double minimo, double maximo)
        {
            double n=0;

            if (n < minimo)
            {
                minimo = n;
            }
            else
            {
                maximo = n;
            }
            return n;
        }
    }
}
