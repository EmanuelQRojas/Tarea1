﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class funciones
    {
        static double cuenta = 0;
        static public void depositar() {
            double deposito = 0;
            Console.WriteLine("Ingrese la cantidad a depositar: ");
            deposito = Convert.ToDouble(Console.ReadLine());
            cuenta += deposito;
        }
        static public double calcular_retirodinero(double retiro) {
            if (retiro < cuenta)
            {
                double cantidad = retiro;
                double veinte = 0, diez = 0, cinco = 0, dos = 0, uno = 0;
                double resto = 0, sobrante = 0;
                resto = cantidad;

                while (resto > 0)
                {
                    if (resto >= 20000) { veinte++; resto -= 20000; }
                    if (resto >= 10000) { diez++; resto -= 10000; }
                    if (resto < 10000 && resto >= 5000) { cinco++; resto -= 5000; }
                    if (resto < 5000 && resto >= 2000) { dos++; resto -= 2000; }
                    //if (resto < 2000 && resto >= 1000) { uno++; resto -= 1000; }
                    if (resto < 2000) { sobrante = resto; break; }
                }
                Console.WriteLine("Cantidad retirada: " + cantidad
                    + "\n Billetes de 20 000: " + veinte
                    + "\n Billetes de 10 000: " + diez
                    + "\n Billetes de 5 000: " + cinco
                    + "\n Billetes de 2 000: " + dos
                    + "\n Billetes de 1 000: " + uno
                    + "\n Cantidad muy pequeña para retirar: " + sobrante);

                cuenta -= retiro;
                cuenta += sobrante;

            }
            else {
                Console.WriteLine("Fondos insuficientes.");
            }
            return retiro;
             }
        static public void calcular_recibomonedas() {
            if (cuenta >= 0)
            {
                int cont = 50;
                int opcionm = 0;
                int total = 0, c1 = 0, c2 = 0, c3 = 0, c4 = 0, c5 = 0, c6 = 0;
                do
                {
                    Console.WriteLine("Menu de Monedas"
                    + "\n 1.¢5."
                    + "\n 2.¢10."
                    + "\n 3.¢25."
                    + "\n 4.¢50."
                    + "\n 5.¢100."
                    + "\n 6.¢500."
                    + "\n 7.Salir.");
                    opcionm = Convert.ToInt16(Console.ReadLine());
                    if (opcionm == 1) { c1++; }
                    if (opcionm == 2) { c2++; }
                    if (opcionm == 3) { c3++; }
                    if (opcionm == 4) { c4++; }
                    if (opcionm == 5) { c5++; }
                    if (opcionm == 6) { c6++; }
                    total = c1 * 5 + c2 * 10 + c3 * 25 + c4 * 50 + c5 * 100 + c6 * 500;
                    cont--;
                } while (opcionm != 7 || cont < 0);
                Console.WriteLine("Total de monedas:\n"
                    + c1 + " monedas de ¢5.\n"
                    + c2 + " monedas de ¢10.\n"
                    + c3 + " monedas de ¢25.\n"
                    + c4 + " monedas de ¢50.\n"
                    + c5 + " monedas de ¢100.\n"
                    + c6 + " monedas de ¢500.\n"
                    + "Total recivido: " + total);
                cuenta += total;
            }
            else { Console.WriteLine("Debe tener dinero en su cuenta para depositar monedas."); }
        }
        static public void calcular_tipodecambio()
        {

            double cd = 0.002, dc = 531.00;//valor al 20/05/16
            int opcionc = 0;
            double val1 = 0;
            double cambio = 0;
            Console.WriteLine("Menu de Conversion"
            + "\n 1.Convertir Colones a Dolares."
            + "\n 2.Convertir Dolares a Colones."
            + "\n 3.Salir.");
            opcionc = Convert.ToInt16(Console.ReadLine());
            switch (opcionc)
            {
                case 1:
                    Console.WriteLine("Ingrese la cantidad de colones: ");
                    val1 = Convert.ToDouble(Console.ReadLine());
                    cambio = val1 * cd;
                    Console.WriteLine(val1 + " Colones equivale a " + cambio + " Dolares.");
                    break;
                case 2:
                    Console.WriteLine("Ingrese la cantidad de Dolares: ");
                    val1 = Convert.ToDouble(Console.ReadLine());
                    cambio = val1 * dc;
                    Console.WriteLine(val1 + " Dolares equivale a " + cambio + " Colones.");
                    break;
                case 3:
                    break;
                default:
                    Console.WriteLine("Opcion Invalida.");
                    break;
            }
        }


        static void Main(string[] args)
        {
            int opcion = 0;
            do
            {
                Console.WriteLine("Menu Pricipal"
                    + "\n 1.Deposito de efectivo."
                    + "\n 2.Retiro de Dinero."
                    + "\n 3.Recibo de Monedas."
                    + "\n 4.Consulta de tipo de Cambio."
                    + "\n 5.Salir.");
                opcion = Convert.ToInt16(Console.ReadLine());
                switch (opcion) {
                case 1:
                        depositar();
                        break;
                case 2:
                    int cantidad = 0;
                    Console.WriteLine("Ingrese la cantidad que desea retirar: ");
                    cantidad = Convert.ToInt32(Console.ReadLine());
                    calcular_retirodinero(cantidad);
                    break;

                case 3:
                    calcular_recibomonedas();
                    break;

                case 4:
                    calcular_tipodecambio();
                    break;
                default:
                    Console.WriteLine("Ingrese una opcion valida.");
                    break;

                }
            } while (opcion != 5);

        }
    }
}
