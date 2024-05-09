using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorfismoQ22024
{
    public class Terreno : Inmueble
    {
        public Terreno() { }

        public Terreno(string TipoInmueble)
        {
            this.TipoInmueble = TipoInmueble;
        }

        public Terreno(string TipoInmueble, double Precio)
        {
            this.TipoInmueble = TipoInmueble;
            this.Precio = Precio;
        }

        public Terreno(string TipoInmueble, double Precio, string Ubicacion, double AreaTerreno)
        {
            this.TipoInmueble = TipoInmueble;
            this.Precio = Precio;
            this.Ubicacion = Ubicacion;
            this.AreaTerreno = AreaTerreno;
        }
    }
}
