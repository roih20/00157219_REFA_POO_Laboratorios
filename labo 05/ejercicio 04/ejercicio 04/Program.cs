using System;

namespace ejercicio_04
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string cadena = " ";
            Console.WriteLine("Digitie una cadena: ");
            cadena = Console.ReadLine();
            Console.WriteLine("Original string: {0}", cadena);
            Console.WriteLine("Replace string : {0} ", cadena.Replace('a', 'b'));


        }
        
    }
}