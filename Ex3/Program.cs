using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
               O custo de um carro novo ao consumidor é a soma do custo de fábrica com a porcentagem
               do distribuidor e dos impostos (aplicados ao custo de fábrica). Supondo que o percentual do
               distribuidor seja de 28% e os impostos de 45%, escrever um algoritmo para ler o custo de
               fábrica de um carro, calcular e escrever o custo final ao consumidor.
            */

            double custo_fabrica,distribuidor, imposto , custo_final;
            Console.WriteLine("Informe o valor do custo de fabrica do carro: R$");
            custo_fabrica =Convert.ToDouble(Console.ReadLine());

            distribuidor =0.28;
            imposto = 0.45;

            custo_final = custo_fabrica + (custo_fabrica * distribuidor) + (custo_fabrica * imposto);

            Console.WriteLine("O custo final do é : R$" + custo_final);
            Console.ReadKey();
                                    
        }
    }
}
