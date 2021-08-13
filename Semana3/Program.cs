using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA_3_15
{
    class Program

    {
        static void Main(string[] args)
        {   //Array de valores ingresados por el usuario
            int i = 0;
            int suma = 0;
            int[] numbers = new int[10];
            for (i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"Escriba el digito {i}");
                numbers[i] = Int32.Parse(Console.ReadLine());
                suma += numbers[i];
            }
            //Promedio de valores ingresados por el usuario
           
            Console.WriteLine($"El promedio es {suma / numbers.Length}");
            Console.ReadKey();

            

        }
    }
}