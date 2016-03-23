using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassEjercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 5";/*cual era la instruccion que dentro del for no lo tenga qe esta pasando uno por uno*/
                                              

            int numero;
            int acumulador = 0;
            int acumuladorj = 0;

            Console.WriteLine("Ingrese un numero: ");
            numero = int.Parse(Console.ReadLine());

            for (int i = 1; i < numero; i++)
            {
                acumulador += i;   
            }
            for (int j = numero+1; j < 999 ; j--)
            {
                if (acumulador==acumuladorj)
                {
                    Console.WriteLine("{0}",j);
                    break;
                }
                else
                {
                    acumuladorj += j;
                }
            }
            
            Console.ReadLine();
        }
    }
}
