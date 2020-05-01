using System;

namespace Laboratorio06
{
    public class Parcial : Evaluacion
    {
        private int cantPreguntas = 0;

        public Parcial(int porcentaje, String nombre, int cantPreguntas) : base(porcentaje, nombre)
        {
            this.cantPreguntas = cantPreguntas;
        }

        public override string ToString()
        {
            return base.ToString() + "\n Preguntas:" + cantPreguntas;
        }
    }
}