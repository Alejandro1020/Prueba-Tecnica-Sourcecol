using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    internal class Program
    {

        static int NumeroSucesion()
        {


            int numero = 10;
            return numero;
        }
        static void Main(string[] args)
        {
            int cantidad = Program.NumeroSucesion();

            int tamaño = 10;
            int primerNumero = 0;
            int segundoNumero = 1;
            int siguiente = 0;
            int numeroNo = cantidad;
            

            for(int i = 1; i < tamaño; i++)
            {

                
            
                    if (i <= 1)
                    {
                    
                        siguiente = i;
                    
                    }
                    else
                    {

                        siguiente = primerNumero + segundoNumero;
                        primerNumero = segundoNumero;
                        segundoNumero = siguiente;

                    
                    }

                    Console.WriteLine(siguiente);

                    if (siguiente == cantidad)
                    {
                        Console.WriteLine("El numero " + cantidad + " esta en la sucesion fibonacci ");

                    }
                    else
                    {
                        
                    }
               




            }
           
            








        }
    }
}
