

using System;

namespace ejercicio_02
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string palabra = " ", palabra2 = "";
            string nuevapalabra = "";
            Console.WriteLine("Digite una palabra: ");
             palabra =Console.ReadLine();

            for (int i = palabra.Length - 1; i >= 0; i--)
            {
                nuevapalabra = palabra.Substring(i, 1);
                palabra2 = palabra2 + nuevapalabra;
            }
                Console.Write("\nPalabra invertida: "+ palabra2);
            if (palabra.Equals(palabra2))
            {
                Console.WriteLine("\nLa palabra es palindrome");
                 
            }
            else
            {
                Console.WriteLine("\nLa palabra no es palindrome ");
            }
        }
    }
}