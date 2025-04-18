using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPizzeria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] preciosPizzas = { 12, 15, 20, 25, 32 };
            int[] moto = { 1, 2, 3, 4, 5 };


            int iniciarSistema,codPizza, cantidad, nroMoto, monto, montoTotal;
            codPizza = 0;
            cantidad = 0;
            nroMoto = 0;
            monto = 0;
            montoTotal = 0;


            int buscarPizza(int pizzaSeleccionada, int[] Pizzas  ){

                for (int i = 0; int i < Pizzas.Length; int i++)
                {
                    
                }


            }

            Console.WriteLine("🍕 Pedidos Pizerria 🍕");

            Console.WriteLine("Si desea ingresar un pedido ingrese 1 sino 0 para salir del sistemas");
            iniciarSistema = int.Parse(Console.ReadLine());
            if (iniciarSistema == 1)
            {
                Console.WriteLine("----  Bievenido al sistema de Pedidos 🍕 -----");
                Console.WriteLine("Por favor ingrese el numero de Pizza que desea elegir:");
                Console.WriteLine("");
                Console.WriteLine("--  0) Muzzarella Grande");
                Console.WriteLine("--  1) Napolitana Grande");
                Console.WriteLine("--  2) Anchoas Grande");
                Console.WriteLine("--  3) Jamon y Morrones Grande");
                Console.WriteLine("--  4) Fugazzetta Grande");
                Console.WriteLine("");
                codPizza = int.Parse(Console.ReadLine());


            }
            else
            {
                Console.WriteLine("Saliendo del sistema...");
            }
        }
    }
}
