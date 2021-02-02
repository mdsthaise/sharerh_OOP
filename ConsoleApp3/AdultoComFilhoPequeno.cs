using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    public class AdultoComFilhoPequeno : Adulto
    {
        public string ComprarFralda()
        {
            return "Putz! Que fralda cara!";
        }

        public override string Trabalhar()
        {
            return base.Trabalhar() + " A não ser que seja meu filho.";
        }

        //Overload = Sobrecarga um método
        public string Respirar(bool fundo)
        {
            return "Tem que respirar mais fundo pra ter paciência.";
        }

        //Mudar o tipo de retorno utilizando o mesmo nome de método e parâmetro
        public new int Respirar()
        {
            return 0;
        }
    }
}
