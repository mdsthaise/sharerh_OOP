using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    public class Bebe : Pessoa
    {
        public override string Andar()
        {
            return "Só ando no colinho.";
        }

        public override string Comer()
        {
            return "Tetê da mamãe.";
        }
    }
}
