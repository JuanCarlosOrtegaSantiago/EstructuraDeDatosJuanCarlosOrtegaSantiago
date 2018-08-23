using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int km, dias;
            try
            {
                Console.WriteLine("Ingresa los kilometros a recorrrer");
                km = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingresa los dias de estancia");
                dias = int.Parse(Console.ReadLine());
                double pago;
                pago = (km * 9.25) * 2;
                if (dias > 7 && km > 1000)
                {
                    double descuento, TPago;
                    descuento = (pago * 30) / 100;
                    TPago = pago - descuento;
                    Console.WriteLine("El total a pagar es de: {0}", TPago);
                }
                else
                {
                    Console.WriteLine("El total a pagar es de: ${0}", pago);
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
