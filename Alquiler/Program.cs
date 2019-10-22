using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alquiler
{
    class Program
    {
        static void Main(string[] args)
        {
            TipoCancha dato = new TipoCancha();
            Console.WriteLine("Ingrese la cancha a alquilar\n" +
                "futbol \tfulbito \tbasquet \tindor: ");
            dato.Cancha = Console.ReadLine();
            Console.WriteLine("Ingrese numero de horas, no debe ser mayor a 3: ");
            dato.Horas = int.Parse(Console.ReadLine());
            Console.WriteLine("Que porcentaje descuento desea aplicar\n" +
                "0 \t10 \t20");
            dato.Descuento = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el Valor Abonado: ");
            dato.Pagado = float.Parse(Console.ReadLine());
            Console.WriteLine("\n\n\n\t\t\t *****Datos de la factura*****\n\n");
            dato.imprimir();
            Console.ReadKey();
        }
    }
}
