using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_TPI.Entidades
{
    public class Cliente
    {
        private string NroCLiente;
        private string Nombre;
        private string NroCalle;
        private string Calle;
        private string Barrio;
        private string Localidad;

        public Cliente() { }

        public Cliente(string nroCliente, string nombre, string nroCalle, string calle, string barrio, string localidad, bool activo)
        {
            NroCLiente = nroCliente;
            Nombre = nombre;
            NroCalle = nroCalle;
            Calle = calle;
            Barrio = barrio;
            Localidad = localidad;
            Activo = activo;
        }
        public Cliente(string nroCliente, string nombre)
        {
            NroCLiente = nroCliente;
            Nombre = nombre;
        }

    

    public string NumeroCliente
        {
            get => NroCLiente;
            set => NroCLiente = value;
        }

        public string NombreCliente
        {
            get => Nombre;
            set => Nombre = value;
        }

        public string nroCalle
        {
            get => NroCalle;
            set => NroCalle = value;
        }

        public string calle
        {
            get => Calle;
            set => Calle = value;
        }
        public string barrio
        {
            get => Barrio;
            set => Barrio = value;
        }

        public string localidad
        {
            get => Localidad;
            set => Localidad = value;
        }

        public bool Activo { get; set; }


    }
}
