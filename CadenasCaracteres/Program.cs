using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadenasCaracteres
{
    internal class Program
    {

      
        
        static void Main(string[] args)
        {

           String nombre= Program.Caracteres();

            int contador = 0;
            
            for (int i = 0; i <=20; i++)
            {
                contador++;
                if (nombre.Length < 20) {
                    Console.WriteLine(nombre[i] + "...");
                }
                else
                {
                    Console.WriteLine(nombre[i]);
                }

                
            }
            


        }
        static  String Caracteres()
        {
            String nombre = "juanandresZapataggfb";
            return (nombre);
            

           
        }


    }
}
