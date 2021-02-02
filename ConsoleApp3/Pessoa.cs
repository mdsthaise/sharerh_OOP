using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    public abstract class Pessoa
    {
        private readonly int codigo;
        private DateTime dataNascimento;
        public DateTime DataNascimento
        {
            get { return dataNascimento; }
            set 
            {
                if (dataNascimento.Year > 2003)
                    throw new Exception("Data menor que a esperada.");
                dataNascimento = value; 
            }
        }

        protected string Nome { get; set; }
        //public DateTime DataNascimento { get; set; }
        public decimal Altura { get; set; }
        public string Genero { get; set; }

        //public Pessoa(DateTime dataNascimento)
        //{
        //    DataNascimento = dataNascimento;
        //}

        public int RetornarIdade()
        {
            return DateTime.Now.AddYears(-DataNascimento.Year).Year;
        }

        public virtual string Comer()
        {
            return "Peguei os meus talheres e iniciei minha refeição.";
        }

        public virtual string Andar()
        {
            return "Fiquei em pé e caminhei.";
        }

        public string Respirar()
        {
            return "Inspira e respira.";
        }
    }
}
