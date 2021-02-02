using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    public class Adulto : Pessoa
    {
        public virtual string Trabalhar()
        {
            return @"Olá! Estou codando! Não me perturbe! \o";
        }
    }
}
