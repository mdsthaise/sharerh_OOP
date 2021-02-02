using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------------ADULTO------------------------------------");
            Adulto adulto = new Adulto();
            var idade = adulto.RetornarIdade();
            Console.WriteLine(adulto.Respirar());
            Console.WriteLine(adulto.Andar());
            Console.WriteLine(adulto.Comer());
            Console.WriteLine(adulto.Trabalhar());
            Console.WriteLine("----------------------------------------------------------");

            Console.WriteLine("----------------------BEBÊ------------------------------------");
            Bebe bebe = new Bebe();
            Console.WriteLine(bebe.Respirar());
            Console.WriteLine(bebe.Andar());
            Console.WriteLine(bebe.Comer());
            Console.WriteLine("----------------------------------------------------------");

            Console.WriteLine("---------------CRIANÇA-------------------------------------------");
            Crianca crianca = new Crianca();
            Console.WriteLine(crianca.Brincar());
            Console.WriteLine(crianca.Respirar());
            Console.WriteLine(crianca.Andar());
            Console.WriteLine(crianca.Comer());
            Console.WriteLine("----------------------------------------------------------");

            Console.WriteLine("---------------ADULTO COM FILHO-------------------------------------------");
            AdultoComFilhoPequeno adultoComFilho = new AdultoComFilhoPequeno();
            Console.WriteLine(adultoComFilho.ComprarFralda());
            Console.WriteLine(adultoComFilho.Respirar(true));
            Console.WriteLine(adultoComFilho.Andar());
            Console.WriteLine(adultoComFilho.Comer());
            Console.WriteLine(adultoComFilho.Trabalhar());
        }
    }
}
