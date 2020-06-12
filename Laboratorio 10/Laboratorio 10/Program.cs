using System;
using System.Collections.Generic;

namespace Laboratorio_10
{
    internal class Program
    {

        private  delegate void MyDelegate(List<CuentaBancaria> A);
        private static MyDelegate AccountPeople;
        
        
        public static void Main(string[] args)
        {
            var Account =  new List<CuentaBancaria>();
            int  opcion = 0;
            bool continuar = true;

            do
            {
                Console.WriteLine(Menu());
                opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                    
                        string name = "";
                        Console.WriteLine("Nombre de la cuenta:");
                        name = Console.ReadLine();

                        double salario = 0;
                        Console.WriteLine("Ingresos: ");
                        salario = Convert.ToDouble(Console.ReadLine());
                   
                        Account.Add(new CuentaBancaria(name, salario));
                        break;
                
                    case 2:
                        AccountPeople = VerCuentas;
                        AccountPeople.Invoke(Account);
                        break;
                
                    case 3:
                        AccountPeople = VerCuentas;
                        AccountPeople += VerSalario;
                        AccountPeople.Invoke(Account);
                        break;
                    case 4:

                        Action<List<CuentaBancaria>> myAction = (A) =>
                        {
                            A.ForEach((element) =>
                            {
                                Console.WriteLine($"Nombre: {element.name}, Ingresos: ${element.salary} ");
                            });
                        };
                        myAction += (AA) => { 
                            double SALARIO = 0;
                            AA.ForEach(element =>
                            {
                                SALARIO += element.salary;
                            });
                            Console.WriteLine($"Suma de salarios: ${SALARIO}");
                            
                        };

                        myAction += (AAA) =>
                        {
                            int i = 1;
                            foreach (CuentaBancaria cuentaBancaria  in Account)
                            {
                                if (cuentaBancaria.name[0].Equals('A')||
                                    cuentaBancaria.name[0].Equals('E')||
                                    cuentaBancaria.name[0].Equals('I')||
                                    cuentaBancaria.name[0].Equals('O')||
                                    cuentaBancaria.name[0].Equals('U'))
                                {
                                    Console.WriteLine("Nombre:" + cuentaBancaria.name);
                                    Console.WriteLine("Ingresos: $" + cuentaBancaria.salary);
                                    double Salario = 0;
                                    Salario += cuentaBancaria.salary;
                                    Console.WriteLine($"Suma de salarios: ${Salario}");
                                    i++;
                                }
                                
                            }
                            
                        };
                        
                        myAction.Invoke(Account);
                        break;
                    case 5: 
                        
                        Console.WriteLine("SALIENDO DEL MENU....");
                        continuar = false;
                        break;
                        
                    default: Console.WriteLine("Opcion erronea");
                        break;
                }

            } while (continuar);
            
           


        }


        public static void VerCuentas(List<CuentaBancaria> A)
        {
            A.ForEach((element) =>
                {
                    Console.WriteLine($"Nombre: {element.name}, Ingresos: ${element.salary} ");
                });
        }

        public static void VerSalario(List<CuentaBancaria> AA)
        {

            double SALARIO = 0;
            AA.ForEach(element => { SALARIO += element.salary; });
            Console.WriteLine($"Suma de salarios: ${SALARIO}");
        }
        private static string Menu()
        {
            return " \n 1) Agregar cuenta " +
                   " \n 2) Ver cuentas almacenadas" +
                   " \n 3) Ver cuentas almacenadas y total de las cuentas" +
                   " \n 4) Ver cuentas" +
                   " \n 5) Salir";
        }
    }
}