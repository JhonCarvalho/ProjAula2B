using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Escreva um algoritmo para ler o número total de eleitores de um município, o número de
             votos brancos, nulos e válidos. Calcular e escrever o percentual que cada um representa em
             relação ao total de eleitores.
            */

            int total_votos, branco, nulo, valido = 0;

            Console.WriteLine("Quantidade de votos Brancos: ");
            branco =Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Quantidade de votos Nulos: ");
            nulo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Quantidade de votos Válidos: ");
            valido = Convert.ToInt32(Console.ReadLine());

            total_votos = branco + nulo + valido;

            Console.WriteLine("\nTotal de votos " + total_votos);
            Console.WriteLine("\nBrancos: " + ((branco * 100) / total_votos)+"%");
            Console.WriteLine("Nulos: " + ((nulo * 100) / total_votos) + "%");
            Console.WriteLine("Válido: " + ((valido * 100) / total_votos) + "%");

            Console.ReadKey();


        }
    }
}
