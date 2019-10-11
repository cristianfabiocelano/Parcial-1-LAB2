using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cerveza:Botella
    {
        private const int MEDIDA = 330;
        private Tipo tipo;

        public Cerveza(string marca, int capacidadML, int contenidoML) : this(marca, capacidadML,Tipo.Vidrio, contenidoML)
        {}
        public Cerveza(string marca, int capacidadML,Tipo tipo, int contenidoML) : base(marca, capacidadML, contenidoML)
        {this.tipo = tipo;}

        public override int ServirMedida()
        {
            int valorAGastar=((Cerveza.MEDIDA * 80) / 100);

            if (valorAGastar <= this.Contenido)
            {this.Contenido = this.Contenido - valorAGastar;}
            else
            {this.Contenido = this.Contenido - this.Contenido; }//  contenido = 0
            return this.Contenido;
        }

        private string GenerarInforme()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(this.marca + " - " + this.contenidoML + "/" + this.capacidadML + " - " +this.tipo);
            return sb.ToString();
        }

        public static implicit operator Botella.Tipo(Cerveza cerveza)
        {
            return cerveza.tipo;
        }
    }
}
