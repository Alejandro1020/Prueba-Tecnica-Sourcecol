using System;
using System.Collections.Generic;
using System.Linq;



namespace ListasDeAutos
{
    internal class Program
    {

        public class Autos
        
        {
            public String Brand  { get; set;}
            public int model { get; set;}

            public String color { get; set; }
        }
        static void Main(string[] args)
        {
            Autos autos = new Autos();


           
            autos.Brand = "chevrolet";
            autos.model = 2018;
            autos.color = "rojo";
            String marca = autos.Brand;
            int modelo=autos.model;
            string color=autos.color;
            Console.WriteLine(marca+"  "+modelo+"  "+color); 
           
          
            
            
            int[] numeros = new int[] { 2017, 2009, 2023, 2018, 2015, 2016, 2019 };
            

            


           

            IEnumerable<int> numerosPares = from numero in numeros where numero > 2017 select numero;

            foreach(int i in numerosPares)
            {
                Console.WriteLine(i);
            }
        }
    }
}
