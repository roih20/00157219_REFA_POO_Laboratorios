using System;

namespace Laboratorio06
{
    public class Tarea : Evaluacion
    {
        private DateTime fechaEntrega;

        public DateTime FechaEntrega => fechaEntrega;


        public Tarea(int porcentaje, String nombre, DateTime fechaEntrega) : base(porcentaje, nombre)
        {
            this.fechaEntrega = fechaEntrega;
        }

        public override string ToString()
        {
            return base.ToString()+ " \n Fecha de entrega: " + FechaEntrega ;
        }
    } 
}