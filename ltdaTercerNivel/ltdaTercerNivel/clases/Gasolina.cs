using System;
using System.Collections.Generic;
using System.Text;

namespace ltdaTercerNivel.clases
{
    public class Gasolina
    {

        private String tipo;

        public String Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        private double cantidadg;

        public double Cantidadg
        {
            get { return cantidadg; }
            set { cantidadg = value; }
        }

        private double precio;

        public Gasolina(string tipo, double cantidadg, double precio)
        {
            Tipo = tipo;
            Cantidadg = cantidadg;
            Precio = precio;
        }

        public Gasolina()
        {
        }

        public double Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        private Factura factura;

        public Factura Factura
        {
            get { return factura; }
            set { factura = value; }
        }



    }
}
