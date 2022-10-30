using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_TPI.Entidades
{
    public class Servicios
    {
        private int Cod_servicio;
        private string Nombre;
        private string Descripcion;
        private int Costo_mensual;

        public Servicios() { }

        public Servicios(int cod_servicio,String nombre, string descripcion,int costo_mensual)
        {
            Cod_servicio = cod_servicio;
            String Nombre = nombre;
            Descripcion = descripcion;
            Costo_mensual = costo_mensual;
        }
        public int Codigo_servicio
        {
            get => Cod_servicio;
            set => Cod_servicio = value;
        }
        public string Nombre_servicio { get; set; }
        //public string Nombre_servicio
        /*{
            get => Nombre_servicio;
            set => Nombre_servicio = value;
        }*/
        public string Descripcion_servivio
        {
            get => Descripcion;
            set => Descripcion = value;
        }
        public int Costo_mensual_servicio
        {
            get => Costo_mensual;
            set => Costo_mensual = value;
        }

    }
}
