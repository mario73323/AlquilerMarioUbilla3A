using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alquiler
{
    public class TipoCancha
    {
        private string cancha;
        public String Cancha
        {
            get { return cancha; }
            set { cancha = value; }
        }



        private float costo;
        public float Costo
        {
            get
            {
                if (this.Cancha == "futbol")
                    costo = 20;
                else
                {
                    if (this.Cancha == "fulbito")
                    {
                        costo = 15;
                    }
                    else
                        costo = 5;
                }
                return costo;
            }
        }


        private int horas;
        public int Horas
        {
            get
            {
                return horas;
            }

            set
            {
                if (value > 3)
                {
                    throw new Exception("No se puede alquilar una cancha por mas de 3 horas");
                }
                else
                    horas = value;
            }
        }
        private float subtotal;
        public float Subtotal
        {
            get
            {
                subtotal = Costo * Horas;
                return subtotal;
            }

        }
        private float descuento;
        public float Descuento
        {
            get { return descuento; }
            set { descuento = value; }
        }

        private float subtotal2;
        public float Subtotal2
        {
            get
            {
                return Subtotal - (Subtotal * Descuento / 100);
            }

        }
        private float iva;
        public float Iva
        {
            get
            {
                return (Subtotal2 * 12 / 100);
            }

        }

        private float final;
        public float Final
        {
            get
            {
                return final = Subtotal2 + Iva;
            }

        }
        private float pagado;
        public float Pagado
        {
            get
            {
                return pagado;
            }
            set
            {
                if (value < (Final * 0.5))
                    throw new Exception("Debe cancelar al menos el 50% del alquiler");
                else
                    pagado = value;
            }

        }

        private float pendiente;
        public float Pendiente
        {
            get
            {
                return pendiente = (Final - Pagado);
            }
        }
        private string estado;
        public string Estado
        {
            get
            {
                if (Pendiente >= 0)
                    estado = "Pendiente";
                else
                    estado = "Pagado";
                return estado;
            }

        }
        public void imprimir()
        {
            Console.WriteLine("Cancha: \t\t\t" + Cancha);
            Console.WriteLine("Costo: \t\t\t\t" + Costo);
            Console.WriteLine("Horas: \t\t\t\t" + Horas);
            Console.WriteLine("Subtotal: \t\t\t" + Subtotal);
            Console.WriteLine("Descuento: \t\t\t" + Descuento + "%");
            Console.WriteLine("Subtotal con descuento: \t" + Subtotal2);
            Console.WriteLine("Iva 12%: \t\t\t" + Iva);
            Console.WriteLine("Final: \t\t\t\t" + Final);
            Console.WriteLine("Pagado: \t\t\t" + Pagado);
            Console.WriteLine("Pendiente: \t\t\t" + Pendiente);
            Console.WriteLine("Estado: \t\t\t" + Estado);

        }
    }
}
