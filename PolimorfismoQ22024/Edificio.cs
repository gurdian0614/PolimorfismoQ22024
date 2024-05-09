using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorfismoQ22024
{
    public class Edificio
    {
        public string Tipo {  get; set; }

        public double Precio { get; set; }

        /// <summary>
        /// Método que muestra el mensaje de venta
        /// </summary>
        public void Vender()
        {
            Console.WriteLine($"{Tipo} vendida por el precio de L{Precio}");
        }
    }
}
