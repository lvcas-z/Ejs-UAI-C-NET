using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPizzeria
{
    internal class Program
    {
        int buscarPrecioPizza(int pizzaSeleccionada, int[] pizzas)
        {

            int pizzaPrecio;


            if (pizzaSeleccionada >= 0 && pizzaSeleccionada < pizzas.Length)
            {
                pizzaPrecio = pizzas[pizzaSeleccionada];
                return pizzaPrecio;
            }
            else
            {
                Console.WriteLine("La pizza seleccionada no existe");
            }

            return -1;

        }

        int obtenerPrecioPedido(int cantidades, int pizzaSeleccionada, int[]pizzas)
        {
            int precioPizza;
            precioPizza = buscarPrecioPizza(pizzaSeleccionada, pizzas);
            int precioTotal = precioPizza * cantidades;

            return precioTotal;
        }

        int buscarMoto(int motoBuscada, string[] motos)
        {

            string pizzaPrecio;


            if (pizzaSeleccionada >= 0 && pizzaSeleccionada < pizzas.Length)
            {
                pizzaPrecio = pizzas[pizzaSeleccionada];
                return pizzaPrecio;
            }
            else
            {
                Console.WriteLine("La pizza seleccionada no existe");
            }

            return -1;

        }


        static void Main(string[] args)
        {
            int[] preciosPizzas = { 12, 15, 20, 25, 32 };

            string[] motos = { "Fran Zanella", "Axel Gilera", "Luciano Harley", "Lucas Bmw", "Liu Suzuki" };

            int[] kilometros = new int[motos.Length];

            List<int> pedidos;

            int iniciarSistema,codPizza, cantidad, nroMoto, monto, distancia,nroPedido;
            codPizza = 0;
            cantidad = 0;
            nroMoto = 0;
            monto = 0;


            


            Console.WriteLine("🍕 Pedidos Pizerria 🍕");

            Console.WriteLine("Si desea ingresar un pedido ingrese 1 sino 0 para salir del sistema");
            while (true)
            {
                Console.Write("Numero:");
                iniciarSistema = int.Parse(Console.ReadLine());
                    if (iniciarSistema == 1)
                    {
                        Console.WriteLine("----  Bievenido al sistema de Pedidos 🍕 -----");
                        Console.WriteLine("");

                        Console.WriteLine("Ingrese el numero de Pedido 📃📃 :");
                        Console.Write("Numero:");
                        nroPedido = int.Parse(Console.ReadLine());
                        Console.WriteLine("");

                        Console.WriteLine("Ingrese el numero de Pizza a selecionar:");
                        Console.WriteLine("");
                        Console.WriteLine("--  0) Muzzarella Grande");
                        Console.WriteLine("--  1) Napolitana Grande");
                        Console.WriteLine("--  2) Anchoas Grande");
                        Console.WriteLine("--  3) Jamon y Morrones Grande");
                        Console.WriteLine("--  4) Fugazzetta Grande");
                        Console.WriteLine("");
                        Console.Write("Numero:");
                        codPizza = int.Parse(Console.ReadLine());
                        Console.WriteLine("");

                        Console.WriteLine("Ingrese la cantidad de Pizzas:");
                        Console.Write("Cantidad:");
                        cantidad = int.Parse(Console.ReadLine());
                        Console.WriteLine("");

                        Console.WriteLine("Ingrese el numero de moto que repartira el pedido:");
                        Console.Write("Numero:");
                        nroMoto = int.Parse(Console.ReadLine());
                        Console.WriteLine("");

                        Console.WriteLine("Ingrese los km que hara el delivery: ");
                        Console.Write("Kilometros:");
                        distancia = int.Parse(Console.ReadLine());
                        Console.WriteLine("");

                    }
                    else if(iniciarSistema <=0 || iniciarSistema>1 )
                    {
                        Console.WriteLine("Error solo se puede ingresar 1 o 0 🙃🙃 ...");
                }
                else
                {
                    Console.WriteLine("Saliendo del sistema 👋👋👋 ....");
                    break;
                }

            }
        }
    }
}
