using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace ltdaTercerNivel.clases
{
    public class Factura
    {

        private double subtotal;

        public double Subtotal
        {
            get { return subtotal; }
            set { subtotal = value; }
        }

        private double iva;

        public double Iva
        {
            get {
                Iva = Subtotal * 0.12;
                return iva; }
            set { iva = value; }
        }

        private double total;

        public double Total
        {
            get {
                Total = Subtotal + Iva;
                return total; }
            set { total = value; }
        }

        private Cliente cliente;

        public Cliente Cliente
        {
            get { return cliente; }
            set { cliente = value; }
        }

        private Gasolina gasolina;

        public Factura(double subtotal, double iva, double total, Cliente cliente, Gasolina gasolina)
        {
            Subtotal = subtotal;
            Iva = iva;
            Total = total;
            Cliente = cliente;
            Gasolina = gasolina;
        }

        public Factura()
        {
        }

        public Gasolina Gasolina
        {
            get { return gasolina; }
            set { gasolina = value; }
        }




    }
}
