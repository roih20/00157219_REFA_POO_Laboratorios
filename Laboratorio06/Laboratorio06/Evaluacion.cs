using System;

namespace Laboratorio06
{
    public class Evaluacion
    {
        protected String nombre = "";
        protected int porcentaje = 0;

        public int Porcentaje => porcentaje;

        public String Nombre  => nombre;

        public Evaluacion(int porcentaje, String nombre)
        {
            this.nombre = nombre;
            this.porcentaje = porcentaje;
        }

        public override string ToString()
        {
            return base.ToString()+  "\n Nombre: " + Nombre +"\n Porcentaje:" + Porcentaje ;
        }
    }
}