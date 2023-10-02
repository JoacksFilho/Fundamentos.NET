using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace FundamentosNET.Models
{
    public class Pessoa
    {
        public string? Nome { get; set; }
        public int Idade { get; set; }
        public string? Documento { get; set; }

        public void Apresentar()
        {
            // Console.WriteLine($"Olá, meu nome é " + 
            // $"{Nome}, e tenho {Idade} anos");

            System.Console.WriteLine($"Olá, meu nome é {Nome} \n e tenho {Idade} anos");
        }
    }
}