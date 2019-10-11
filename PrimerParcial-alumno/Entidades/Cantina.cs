using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cantina
    {
        private List<Botella> botellas;
        private int espaciosTotales;
        static Cantina singleton;

        public Cantina(int espaciosTotales) //,Cantina singleton)
        {
            this.botellas = new List<Botella>(espaciosTotales);
            this.espaciosTotales = espaciosTotales;
            //this.singleton = singleton;
        }

        public List<Botella> Botellas { get { return this.botellas; } }

        public static Cantina GetCantina (int espacios ){
            if(Cantina.singleton == null)
            {
               return Cantina.singleton = new Cantina(espacios);
            }
            else
            {
                List <Botella> botellas = Cantina.singleton.Botellas;
                Cantina c1 = new Cantina(espacios);
                foreach (Botella b in botellas)
                {
                    if(!(c1 + b))
                    {
                        break;
                    }
                }
                return c1;
            }
        }

        public static bool operator + (Cantina c, Botella b)
        {
            if(c.espaciosTotales == c.Botellas.Count)
            {
                return false;
            }
            else
            {
                c.Botellas.Add(b);
                return true;
            }


        }
    }
}
