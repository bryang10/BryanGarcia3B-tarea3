using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using ltdaTercerNivel.clases;


namespace ltdaTercerNivel
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente();
            Factura factura = new Factura();
            Console.WriteLine("Ingrsese completos sus Nombres y Apellidos: ");
            cliente.Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese  CI: Cedula de Identidad: ");
            cliente.Cedula = Console.ReadLine();
            Console.WriteLine("Ingrese la direccion: ");
            cliente.Direccion = Console.ReadLine();

            Gasolina gasolina = new Gasolina();
            Program.Gasolina();
            int option = Convert.ToInt16(Console.ReadLine());

            //switch para menu 

            switch (option)
            {
                case 1:
                    gasolina.Tipo = "Diesel";
                    gasolina.Precio = 1.03;
                    break;
                case 2:
                    gasolina.Tipo = "Super";
                    gasolina.Precio = 2.48;
                    break;

                case 3:
                    gasolina.Tipo = "Extra";
                    gasolina.Precio = 1.48;
                    break;
                default:
                    Console.WriteLine("Ingrese un numero valido");
                    break;
            }
            Console.WriteLine("Ingrese la cantidad en galones que desea comprar");
            gasolina.Cantidadg = Convert.ToInt16(Console.ReadLine());
            factura.Subtotal = gasolina.Precio * gasolina.Cantidadg;


            Console.WriteLine(":::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::");
            Console.WriteLine(":::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::");
            Console.WriteLine("___________________________________BIENVENIDO________________________________");
            Console.WriteLine("                                    FACTURA                                  ");
            Console.WriteLine("Nombre: {0}" , cliente.Nombre);
            Console.WriteLine("Cedula {0}", cliente.Cedula);
            Console.WriteLine("Direccion {0}", cliente.Direccion);
            Console.WriteLine("                                                                             ");
            Console.WriteLine("                                                                             ");
            Console.WriteLine("                                                                             ");
            Console.WriteLine("COMPRA:");
            Console.WriteLine("                                                                             ");
            Console.WriteLine("TIPO:                    "+gasolina.Tipo);

            Console.WriteLine("Cantidad de Galones:     "+ gasolina.Cantidadg);
            
            Console.WriteLine("Precio por GALON:        "+ gasolina.Precio);
            
            Console.WriteLine("_____________________________________________________________________________");
            Console.WriteLine("                                                             Subtotal:  {0} ", gasolina.Precio * gasolina.Cantidadg);
            Console.WriteLine("                                                                  IVA: {0}", factura.Iva);
            Console.WriteLine("                                                                TOTAL: {0} ", factura.Total);


            Console.WriteLine("                              GRACIAS POR COMPRAR                            ");

            Console.WriteLine(":::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::");
            Console.WriteLine(":::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::");
            Console.ReadKey();
        }

        private  static void Gasolina()
        {
            Console.WriteLine("______________________________________________________________________________");
            Console.WriteLine("              ELEGIR EL TIPO DE GASOLINA QUE DESEA COMPRAR                    ");
            Console.WriteLine("  1.- DIESEL........................................................$1.03     ");
            Console.WriteLine("  2.- SUPER ........................................................$2.48     ");
            Console.WriteLine("  3.- EXTRA ........................................................$1.48     ");
            Console.WriteLine("______________________________________________________________________________");
        }
    }
}
