using System;

namespace ejercicio_03
{
    internal class Program 
    {
        int aux = 1;
        public static void Main(string[] args)
        {
            Console.WriteLine("ingresa n: "); ;
            Program secuencia = new Program();
            secuencia.imprimir(x: Convert.ToInt32(Console.ReadLine()));   


        }

        public void imprimir(int x)
        {

            if (aux < x)
            {
                Console.WriteLine(aux);
                aux++;
                imprimir(x);
                
            }
            else if (x == 0)
            {
                return;
            }else if (aux == x || aux > x)
            {
                Console.WriteLine(x);
                x--;
                imprimir(x);
            }
        }
    }
}