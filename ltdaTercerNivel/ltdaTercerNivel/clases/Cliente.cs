using System;
using System.Collections.Generic;
using System.Text;

namespace ltdaTercerNivel.clases
{
    public class Cliente
    {

        private String  nombre;

        public String  Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }


        private String cedula;

        public String Cedula
        {
            get { return cedula; }
            set { cedula = value; }
        }


        private String direccion;

        public Cliente(string nombre, string cedula, string direccion)
        {
            Nombre = nombre;
            Cedula = cedula;
            Direccion = direccion;
        }

        public Cliente()
        {
        }

        public String Direccion 
        {
            get { return direccion; }
            set { direccion = value; }
        }


        private Factura factura;

        public Factura Factura
        {
            get { return factura; }
            set { factura = value; }
        }


    }
}
