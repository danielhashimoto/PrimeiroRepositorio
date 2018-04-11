using System;

namespace NewGit
{
    class Program
    {
        static void Main(string[] args)
        {
        
        int dia;
        int mes;
        int ano;


         Console.Clear();

        Console.WriteLine("Insira o dia utilizando 2 dígitos");
        dia = int.Parse(Console.ReadLine());

        Console.WriteLine("Insira o mês utilizando 2 dígitos");
        mes = int.Parse(Console.ReadLine());

        Console.WriteLine("Insira o ano utilizando 4 dígitos");
        ano = int.Parse(Console.ReadLine());

       
        if(dia>=1 & dia<=31 & mes>=1 & mes<=12 & ano>=1 )
        Console.WriteLine("A data em questão é: "+dia.ToString("D2") +"/"+mes.ToString("D2")+"/"+ano.ToString("D4"));

        else 
        Console.WriteLine("Insira números inteiros positivos com o número de dígitos solicitados no enunciado");





        }
    }
}
