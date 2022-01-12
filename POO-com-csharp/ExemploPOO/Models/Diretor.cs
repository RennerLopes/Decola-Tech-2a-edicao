using System;

namespace ExemploPOO.Models
{
    public class Diretor : Professor
    {
        public override void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e sou um professor, e ganho {Salario}");
        }
    }
}