using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diccionario
{
    class Program
    {
        static void Main(string[] args)
        {
            //Diccionario de Nombres y Edades
            Dictionary<String, String> NyE = new Dictionary<string, String>();

            NyE.Add("Eliezer Diaz", "18");
            NyE.Add("Joel Diaz", "20");
            NyE.Add("Lalo Diaz", "7");
            NyE.Add("Julio Diaz", "47");

            foreach (KeyValuePair<String, String> E in NyE)
            {
                Console.WriteLine("clave: {0}, valor: {1}", E.Key, E.Value);
            }

            Console.ReadKey();
        }
    }
}
