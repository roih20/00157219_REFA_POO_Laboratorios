using System;
using System.Collections.Generic;

namespace ejercicio_05
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<string> letras = new List<string>();
            string letra;
            int n = 1;
            do
            {
                Console.WriteLine("Ingrese letraS: ");
                letra = Console.ReadLine();
                if (letra.Length > 1)
                {
                    Console.WriteLine("Ingrese solo una letra: ");
                }
                else
                {
                    if (letra.Equals("a") || letra.Equals("e") || letra.Equals("i") || letra.Equals("o") || letra.Equals("u") ||
                        letra.Equals("A") || letra.Equals("E") || letra.Equals("I") || letra.Equals("O") || letra.Equals("U")   )
                    {
                     letras.Add(letra);   
                    }
                }
                Console.WriteLine(" 1 para continuar y 0 para salir");
                n = Convert.ToInt32(Console.ReadLine());
            } while (n != 0);

            Console.WriteLine("vocales de la lista: \n");
            foreach (var it in letras)
            {
                Console.WriteLine(it);
            }

        }
    }
}