using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            double M1, M2, D;
            try
            {
                Console.WriteLine("Ingresa la primer masa");
                M1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Ingresa la segunda masa");
                M2 = double.Parse(Console.ReadLine());
                Console.WriteLine("Ingresa ladistancia");
                D = double.Parse(Console.ReadLine());
                if (M1 > 0 && M2 > 2 && D > 0)
                {
                    double F;
                    F = (0.00000006673 * M1 * M2) / D*D;
                    Console.WriteLine("La fuerza gravitacional es de: {0}", F);
                }
                else
                {
                    Console.WriteLine("Los datos ingresados no son correctos, por favor verifica.");
                }
                Console.ReadLine();
            }
            catch (Exception ex)
            {

                Console.WriteLine("Error:\n{0}", ex);
            }
        }
    }
}
