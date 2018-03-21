using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 0;
            double y = 0;
            double v = 0;

            Console.WriteLine("Ingresar la distancia recorrida en kilometros...");
            x = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingresar la el tiempo transcurrido...");
            y = double.Parse(Console.ReadLine());

            if (y == 0)
            {
                Console.WriteLine("Te has teletransportado!! No existe velocidad alguna!");
                Console.ReadLine();
            }
            else
            {
                v = x / y;
                Console.WriteLine("Tu velocidad es de: " + v +" Km/Hr");
                Console.ReadLine();
            }
        }
    }
}
