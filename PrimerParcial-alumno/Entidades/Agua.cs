using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Agua:Botella
    {
        public const int MEDIDA = 400;

        public Agua(string marca, int capacidadML, int contenidoML) :base(marca,capacidadML,contenidoML)
        {}

        public override int ServirMedida()
        {
            return this.ServirMedida(Agua.MEDIDA);
        }
        public int ServirMedida(int otraMedida)
        {
            if (otraMedida <= this.Contenido)
            {
                this.Contenido = this.Contenido - otraMedida;
            }
            else
            {
                this.Contenido = this.Contenido - this.Contenido;//  contenido = 0
            }

            return this.Contenido;
        }
        private string GenerarInforme()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(this.marca + " - " + this.contenidoML + "/" + this.capacidadML);
            return sb.ToString();
        }


    }
}
