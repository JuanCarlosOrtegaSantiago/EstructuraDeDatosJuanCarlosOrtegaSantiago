using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int H, M;
            try
            {
                Console.WriteLine("Ingresa El numero de hombres");
                H = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingresa el numero de mujeres");
                M = int.Parse(Console.ReadLine());
                if (M >= 0 && H >= 0)
                {
                    int TPersonas;
                    TPersonas = H + M;
                    double PHombres, PMujeres;
                    PHombres = H * 100 / TPersonas;
                    PMujeres = M * 100 / TPersonas;

                    Console.WriteLine("El porcentaje de Hombres es de %: {0}\nEl porcentaje de Mujeres es de %: {1}", PHombres, PMujeres);
                }
                else
                {
                    Console.WriteLine("Las cantidades no pueden ser negativas");
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
