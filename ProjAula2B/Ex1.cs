using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjAula2B
{
    class Ex1
    {
        static void Main(string[] args)
        {
            /*
             1. Faça um algoritmo que leia a idade de uma pessoa expressa em anos, meses e dias e escreva
                a idade dessa pessoa expressa apenas em dias. Considerar ano com 365 dias e mês com 30
                dias.
             */

            string dtNascimento = "";

            System.Console.WriteLine("Informe a data de nascimento : ");
            dtNascimento = Console.ReadLine();

            DateTime dtNasc = DateTime.Parse(dtNascimento);
            DateTime dtAtual = DateTime.Now;
            TimeSpan date = dtAtual - dtNasc;
            System.Console.WriteLine("Data Nascimento :"+dtNasc+"   Data atual: "+dtAtual+  "  Você tem "+ date.Days+" dias vividos");

            Console.ReadKey();






        }
    }
}
