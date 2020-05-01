using System;
using System.Collections.Generic;

namespace Laboratorio06
{
    public static class CalcularNota
    {
        public static double Calcular(List<Evaluacion> ev)
        {
            double Promedio = 0;
            foreach (var VARIABLE in ev)
            {
                double nota = 0;
                bool cont;
                do
                {
                    try
                    {
                        cont = false;
                        Console.WriteLine("Introducir nota: ");
                        nota = Convert.ToDouble(Console.ReadLine());
                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine("Debe ingresar un valor");
                        cont = true;
                    }

                } while (cont);

                while (nota > 10)
                {
                    try
                    {
                        Console.WriteLine("Introducir nota: ");
                        nota = Convert.ToDouble(Console.ReadLine());
                    }
                    catch (ArithmeticException e)
                    {
                        Console.WriteLine("No debe de pasar de 10 ");
                    }
                }

                while (nota < 0)
                {
                    try
                    {
                        Console.WriteLine("Introducir nota: ");
                        nota = Convert.ToDouble(Console.ReadLine());
                    }
                    catch (ArithmeticException e)
                    {
                        Console.WriteLine("No puede ingresar valores negativos");
                    }
                }
                
                Promedio += (nota * VARIABLE.Porcentaje) / 100;
            }

            return Promedio;
        }
    }
}