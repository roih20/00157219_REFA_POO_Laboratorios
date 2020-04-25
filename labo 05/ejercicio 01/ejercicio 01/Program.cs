using System;

namespace ejercicio_01
{
  internal class Program
  {
    public static void Main(string[] args)
            {
    
                int a, b, limit, i, auxliar; 
                Console.WriteLine("Ingrese un numero: ");
                limit = int.Parse(Console.ReadLine());
                a = 0;
                b = 1;
                for (i = 0; i < limit; i++)
                {
                    auxliar = a;
                    a = b;
                    b = auxliar + a;
                    Console.WriteLine(a);
                }
    
                Console.ReadKey();
            }
  }
}