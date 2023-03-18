using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arreglos
{
    public class Program
    {
        static void Main(string[] args)
        {
           

            Console.WriteLine("Ingrese el tamaño del arreglo: ");
            int tam = int.Parse(Console.ReadLine());
            ArregloNumeros arr = new ArregloNumeros(tam);

            Console.WriteLine("Ingrese al menos 10 numeros enteros (entre -1500 y 3650)");

            bool entradaValida = false;

            while (!entradaValida)
            {
                string entrada = Console.ReadLine();
                string[] numerosStr = entrada.Split(' ');

                if (numerosStr.Length < 10)
                {
                    Console.WriteLine("Debe ingresar al menos 10 numeros, vuelva a intentar");
                    continue;
                }

                entradaValida= true;
                foreach (string str in numerosStr)
                {
                    int numero;
                    if (int.TryParse(str, out numero))
                    {
                        if (numero < -1500 || numero > 36500)
                        {
                            Console.WriteLine($"El numero {numero} esta fuera del rango permitido. Vuelva a intentar.");
                            entradaValida = false;
                            break;
                        }
                        else
                        {
                            arr.AgregarNumero(numero);
                        }
                    }
                    else
                    {
                        Console.WriteLine($"El valor {str} no es un numero entero valido. vuelva a intentar. ");
                        entradaValida = false;
                        break;
                    }
                }
            }

            int[] numerosPositivos;
            int[] numerosNegativos;
            arr.separaNumerosPositivosNegativos(out numerosPositivos, out numerosNegativos);

            Console.WriteLine("numeros positivos: " + string.Join(", ", numerosPositivos));
            Console.WriteLine("numeros negativos: " + string.Join(", ", numerosNegativos));
            Console.WriteLine($"Promedio: {arr.calcularPromedio()}");
            Console.WriteLine($"Media: {arr.CalcularMedia()}");
            Console.WriteLine($"Suma Total: {arr.calcularSuma()}");

            Console.ReadLine();

        }
    }
}
