using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
              Uma revendedora de carros usados paga a seus funcionários vendedores um salário fixo por
              mês, mais uma comissão também fixa para cada carro vendido e mais 5% do valor das
              vendas por ele efetuadas. Escrever um algoritmo que leia o número de carros por ele
              vendidos, o valor total de suas vendas, o salário fixo e o valor que ele recebe por carro
              vendido. Calcule e escreva o salário final do vendedor.*/

            int qtd_carro;
            double salario_fixo,por_carro,valor_venda, salario_final;

            Console.WriteLine("Informe a quantidade de carros vendidos: ");
            qtd_carro =Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o valor total da venda: ");
            valor_venda =Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe o valor do salário fixo: ");
            salario_fixo = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe o valor que o funcionario reberá por carro vendido : ");
            por_carro = Convert.ToDouble(Console.ReadLine());

            salario_final = salario_fixo + (qtd_carro * por_carro) + (valor_venda * 0.05);

            Console.WriteLine("O salario final do vendedor é de : R$" + salario_final);

            Console.ReadKey();

        }
    }
}
