using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arreglos
{
    public class ArregloNumeros
    {
        private int[] numeros;
        private int cantidadNumeros;


        public ArregloNumeros(int tamMaximo)
        {
            numeros = new int[tamMaximo];
            cantidadNumeros = 0;
        }

        public void AgregarNumero(int numero)
        {
            if (cantidadNumeros < numeros.Length)
            {
                numeros[cantidadNumeros] = numero;
                cantidadNumeros++;
            }
            else
            {
                Console.WriteLine("El arreglo esta lleno, no se pueden agregar mas numeros ");
            }
        }

        public double calcularPromedio()
        {
            if (cantidadNumeros > 0)
            {
                int suma = calcularSumaRecursiva(0);
                return (double)suma / cantidadNumeros;
            }
            else
            {
                Console.WriteLine("El arreglo esta vacio, no se puede calcular el promedio");
                return 0;
            }
        }

        public int calcularSuma()
        {
            if (cantidadNumeros > 0)
            {
                return calcularSumaRecursiva(0);
            }
            else
            {
                Console.WriteLine("El arreglo esta vacio, no se puede calcular el promedio");
                return 0;
            }
        }

        public int calcularSumaRecursiva(int indice)
        {
            if (indice == cantidadNumeros -1)
            {
                return numeros[indice];
            }
            else
            {
                return numeros[indice] + calcularSumaRecursiva(indice + 1);
            }
        }

        public double CalcularMedia()
        {
            if (cantidadNumeros > 0)
            {
                Array.Sort(numeros, 0, cantidadNumeros);
                if (cantidadNumeros % 2 == 0)
                {
                    int indiceMedio1 = cantidadNumeros / 2 - 1;
                    int indiceMedio2 = cantidadNumeros / 2;
                    return (double)(numeros[indiceMedio1] + numeros[indiceMedio2]) / 2;
                }
                else
                {
                    int indiceMedio = cantidadNumeros / 2;
                    return numeros[indiceMedio];
                }
            }
            else
            {
                Console.WriteLine("El arreglo esta vacio, no se puede calcular el promedio");
                return 0;
            }
        }

        public void separaNumerosPositivosNegativos(out int[] numerosPositivos, out int[] numerosNegativos)
        {
            int cantidadPositivos = 0;
            int cantidadNegativos = 0;

            for (int i = 0; i < cantidadNumeros; i++)
            {
                if (numeros[i] >= 0)
                {
                    cantidadPositivos++;
                }
                else
                {
                    cantidadNegativos++;
                }
            }

            numerosPositivos = new int[cantidadNumeros];
            numerosNegativos = new int[cantidadNegativos];

            int indicePositivos = 0;
            int indiceNegativos = 0;

            for (int i = 0; i < cantidadNumeros; i++)
            {
                if (numeros[i] >= 0)
                {
                    numerosPositivos[indicePositivos] = numeros[i];
                    indicePositivos++;
                }
            }
        }


    }
}
