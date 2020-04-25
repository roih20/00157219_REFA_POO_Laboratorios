using System;
using System.Collections.Generic;
using System.Security.Principal;

namespace meet
{
    internal class Program
    {
        public static void Main(string[] args)
        {
          var p = new List<Persona>();
          
          p.Add(new Persona("Rodrigo", "Figueroa",
              19));
          p.Add(new Persona("Walter", edad: 20));
          p.Add(new Persona(edad: 25));
          p.Add(new Persona(apellido: "Aguirre"));

          String buscar = "Rodrigo";
          buscar = Console.ReadLine();
          p.ForEach(it =>
          {

              if (buscar.Equals(it.Nombre))
              {
                  Console.WriteLine("Nombre");
                  it.Nombre = Console.ReadLine();
                  Console.WriteLine(it.ToString());
              }
                  
          });
          
          
    }
    }
}