using System;

namespace Laboratorio06
{
    public class Laboratorio : Evaluacion
    {
        private String tipo;

     

        public Laboratorio(int porcentaje, String nombre, String tipo ) : base(porcentaje, nombre)
        {
            this.tipo = tipo;
        }

        public override string ToString()
        {
            return base.ToString() + "\n Tipo:" + tipo ;
        }
    }
}