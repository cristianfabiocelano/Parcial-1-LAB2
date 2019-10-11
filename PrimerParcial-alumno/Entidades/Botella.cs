using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   
    public abstract class Botella
    {
        protected int capacidadML;
        protected int contenidoML;
        protected string marca;

        public Botella(string marca, int capacidadML, int contenidoML)
        {
            if (capacidadML < contenidoML)
                capacidadML = contenidoML; 
            this.capacidadML = capacidadML;
            this.contenidoML = contenidoML;
            this.marca = marca;
        }

        public int CapacidadLitros { get { return (this.capacidadML / 1000); } }
        public int Contenido { get { return this.contenidoML; } set { this.contenidoML = value; } }
        public int PorcentajeCotenido {
            get {
                return ((this.capacidadML * this.contenidoML) / 100);
            }
        }
        public abstract int ServirMedida();
        private string GenerarInforme()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(this.marca + " - " +this.contenidoML+"/"+ this.capacidadML);
            return sb.ToString();
        }
        public override string ToString()
        {
            return this.GenerarInforme();
        }

        public enum Tipo
        {
            Plastico,
            Vidrio
        }
    }
        
}
