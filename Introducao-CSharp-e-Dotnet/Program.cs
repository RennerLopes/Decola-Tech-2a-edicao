using System;
using Primeiro;
using CSharp;
using Interface;
using Enum;

namespace Introducao_ao_C__e_.NET
{
  class Program
  {
    static void Main(string[] args)
    {
      // Duas formas de referenciar uma classe
      // Não é recomendado criar duas classes com o mesmo nome, é apenas como exemplo
      var classe = new Classe();
      var classe2 = new Segundo.Classe();

      // Instanciando a classe Pessoa
      Pessoa person = new Pessoa();

      person.Nome = "Thiago";
      person.Idade = 20;
      person.Estado = "RJ";

      var person2 = new Pessoa();

      person2.Nome = "Livia";
      person2.Idade = 22;
      person2.Estado = "SP";

      // Instanciando a classe Animal que está usando a interface IAnimal
      Animal animal = new Animal();

      animal.Nome = "Zeus";
      animal.NomeDono = "Gabriel";
      animal.Especie = "Cachorro";

      // Chamando o Enum de pessoas e declarando na variável
      var pessoa = (Pessoas)0;
      Pessoas pessoa2 = Pessoas.João;
      Pessoas pessoa3 = (Pessoas)4;

      Console.WriteLine(pessoa3);
    }
  }
}
