//Dado n numeros, encontre os valores mínimo e máximo que podem ser calculados somando a quantidade elementos do array - 1. 
//Depois escreva os valores mínimo e máximo e mostre todos os números primos entre esses dois números


using System;
using System.Globalization;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int n, soma = 0;
            int[] vet1;
            
            
            

            Console.WriteLine("Digite o tamanho do seu array ");
            n = int.Parse(Console.ReadLine());
            vet1 = new int[n];
            


            //Numeros aleatorios
            for (int i = 0; i < vet1.Length; i++)
            {
                Console.WriteLine("Digite um numero: ");
                vet1[i] = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                
            }

            for (int i = n - 1; i >= 1; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (vet1[j] > vet1[j + 1])
                    {
                        int trocaNumero = vet1[j];
                        vet1[j] = vet1[j + 1];
                        vet1[j + 1] = trocaNumero;
                    }
                }
            }

            Console.WriteLine("----- ORDEM CRESCENTE----");
            for (int i = 0; i < n; i++)
            {
                Console.Write(vet1[i] + " ");
            }

            //valor minimo array-1
            int soma1 = 0;
            for (int i = 0; i < n - 1; i++)
            {
                soma1 += vet1[i];
            }
            Console.WriteLine("\n\n" + soma1);

            //valor maximo array-1
            int soma2 = 0;
            for (int i = 1; i < n; i++)
            {
                soma2 += vet1[i];
            }
            Console.WriteLine("\n\n" + soma2);
          

        }
        }
    }

