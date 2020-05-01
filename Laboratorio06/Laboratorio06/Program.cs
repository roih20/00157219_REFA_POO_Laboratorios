using System;
using System.Collections.Generic;

namespace Laboratorio06
{
    internal class Program
    {
        public static List<Evaluacion> ev = new List<Evaluacion>();
        public static void Main(string[] args)
        {   
            
            bool continuar = true;
            bool error;
            do
            {
                try
                {
                    error = false;
                    do
                    {
                        Console.WriteLine(
                            "1)Agregar evaluacion\n 2)Mostrar evaluaciones \n 3) Eliminar evaluacion\n 4)Terminar programa");
                        int opcion = Convert.ToInt32(Console.ReadLine());

                        switch (opcion)
                        {
                            case 1:
                                AgregarEvaluacion();
                                break;

                            case 2:
                                MostrarEvaluaciones();
                                break;

                            case 3:
                                EliminarEvaluacion();
                                break;
                            case 4:
                                TerminarPrograma();
                                continuar = false;
                                break;
                            default:
                                Console.WriteLine("Opcion erronea");
                                break;

                        }

                    } while (continuar);
                }
                catch (FormatException e)
                {
                    error = true;
                    Console.WriteLine("No puede ingresar letras");
                }

            } while (error);
        }
       private static void AgregarEvaluacion()
        {
            Console.WriteLine("1)Laboratorio\n 2)Parcial\n 3)Tarea");
            int opcion = Convert.ToInt32(Console.ReadLine());
            bool Error2;
            do
            {
                try
                {
                    Error2 = false;
                    switch (opcion) { 
                        
                        case 1 :
                   
                    String nombre = "";
                    Console.WriteLine("Nombre del laboratorio: ");
                    nombre = Console.ReadLine();
                    int porcentaje = 0;
                    bool continuando;
                    do
                    {
                        try
                        {
                            continuando = false;
                            Console.WriteLine("Porcentaje del laboratorio: ");
                            porcentaje = Convert.ToInt32(Console.ReadLine());
                        }
                        catch (FormatException e)
                        {
                            Console.WriteLine("Debe ingresar un valor entero:");
                            continuando = true;
                            
                        }
                    } while (continuando);

                    while (porcentaje > 100)
                    {
                        try
                        {
                            Console.WriteLine("Procentaje del laboratorio: ");
                            porcentaje = Convert.ToInt32(Console.ReadLine());
                        }
                        
                        catch (ArithmeticException e)
                        {
                            Console.WriteLine("No puede poner un valor mayor de 100");
                            
                        }
                    }

                    while (porcentaje < 0)
                    {
                        try
                        {
                            Console.WriteLine("Procentaje del laboratorio: ");
                            porcentaje = Convert.ToInt32(Console.ReadLine());
                        }
                        catch (ArithmeticException e)
                        {
                            Console.WriteLine("No puede ingresar valores negativos");
                        }
                    }
                    

                    String tipo = "";
                    Console.WriteLine("tipo: ");
                    tipo = Console.ReadLine();
                    ev.Add(new Laboratorio(porcentaje, nombre, tipo));
                    
                    break;
                
                case 2:
                    Console.WriteLine("Nombre del parcial: ");
                    nombre = Console.ReadLine();
                    int porcentaje2 = 0;
                    bool reset;
                    do
                    {
                        try
                        {
                            reset = false;
                            Console.WriteLine("Porcentaje del parcial:");
                            porcentaje2 = Convert.ToInt32(Console.ReadLine());

                        }
                        catch (FormatException e)
                        {
                            Console.WriteLine("Debe ingresar un valor");
                            reset = true;
                        }
                        
                    } while (reset);

                    while (porcentaje2 > 100)
                    {
                        try
                        {
                            Console.WriteLine("Porcentaje del parcial:");
                            porcentaje2 = Convert.ToInt32(Console.ReadLine()); 
                        }
                        catch (ArithmeticException e)
                        {
                            Console.WriteLine("No puede ser un valor mayor de 100");
                        }
                    }

                    while (porcentaje2 < 0)
                    {
                        try
                        {
                            Console.WriteLine("Porcentaje del parcial:");
                            porcentaje2 = Convert.ToInt32(Console.ReadLine()); 
                        }
                        catch (ArithmeticException e)
                        {
                            Console.WriteLine(e);
                            
                        }
                    }
                    int cantPreguntas = 0;
                    bool reset2;
                    do
                    {
                        try
                        {
                            reset2 = false;
                            Console.WriteLine("Cantidad de preguntas: ");
                            cantPreguntas = Convert.ToInt32(Console.ReadLine());
                        }
                        catch (FormatException e)
                        {
                            Console.WriteLine("Debe ingresar un valor");
                            reset2 = true;
                        }

                    } while (reset2);

                    while (cantPreguntas < 0)
                    {
                        try
                        {
                            Console.WriteLine("Cantidad de preguntas: ");
                            cantPreguntas = Convert.ToInt32(Console.ReadLine());
                        }
                        catch (ArithmeticException e)
                        {
                            Console.WriteLine(e);
                        }
                    }
                    ev.Add(new Parcial(porcentaje2, nombre, cantPreguntas));
                    break;
                
                case 3:
                    Console.WriteLine("Nombre de la tarea: ");
                    nombre = Console.ReadLine();
                    int porcentaje3 = 0;
                    bool reset3;
                    do
                    {
                        try
                        {
                            reset3 = false;
                            Console.WriteLine("Porcentaje de la tarea: ");
                            porcentaje3 = Convert.ToInt32(Console.ReadLine());
                        }
                        catch (FormatException e)
                        {
                            Console.WriteLine("Debe ingresar un valor");
                            reset3 = true;
                        }
                    } while (reset3);

                    while (porcentaje3 > 100)
                    {
                        try
                        {
                                Console.WriteLine("Porcentaje de la tarea:");
                                porcentaje3 = Convert.ToInt32(Console.ReadLine());
                        }
                        catch (ArithmeticException e)
                        {
                            Console.WriteLine("No debe de pasar de 100 el porcentaje");
                        }
                    }
                    DateTime fechaEntrega = DateTime.MaxValue;
                    bool fecha;
                    do
                    {
                        try
                        {
                            fecha = false;
                            Console.WriteLine("Fecha de entrega: ");
                            fechaEntrega = Convert.ToDateTime(Console.ReadLine());
                        }
                        catch (FormatException e)
                        {
                            fecha = true;
                            Console.WriteLine("Ingrese la fecha correctamente");
                        }
                        
                    } while (fecha);
                    
                    ev.Add(new Tarea(porcentaje3, nombre, fechaEntrega));
                    break;
                default: Console.WriteLine("Opcion erronea");
                    break;
            }
                }
                catch (FormatException e)
                {
                    Error2 = true;
                    Console.WriteLine("No puede ingresar letras");
                }

            } while (Error2);
            
        }

        private static void MostrarEvaluaciones()
        {

            foreach (var evaluacion in ev)
            {
                Console.WriteLine(evaluacion.ToString());

            }
        }

        private static void EliminarEvaluacion()
        {
            Console.WriteLine("1)Laboratorio\n 2)Parcial\n 3)Tarea\n ");
            int opcion = Convert.ToInt32(Console.ReadLine());
            String remove = "";
            String remove1 = "";
            String remove2 = "";
            bool Error;
            do
            {
                try
                {
                    Error = false;
                    switch (opcion){
                
                        case 1:

                            foreach (var buscar in ev)
                            {
                                remove = buscar.Nombre;
                       
                            }

                            ev.RemoveAll(s => s.Nombre.Equals(remove));
                            break;
                
                        case 2:
                            foreach (var buscar in ev)
                            {
                                remove1=   buscar.Nombre;
                            }

                            ev.RemoveAll(s => s.Nombre.Equals(remove1));
                            break;
                
                        case 3:
                            foreach (var buscar in ev)
                            {
                                remove2 = buscar.Nombre;
                            }

                            ev.RemoveAll(s => s.Nombre.Equals(remove2));
                            break;
                        default: Console.WriteLine("Opcion erronea");
                            break;
                    }
                }
                catch (FormatException e)
                {
                    Error = true;
                    Console.WriteLine("No puede ingresar letras");
                }
            } while (Error);
        }

         private static void TerminarPrograma()
        {
            Console.Write(CalcularNota.Calcular(ev));
        }
    }
}