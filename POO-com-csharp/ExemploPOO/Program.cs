using System;
using System.Collections.Generic;
using System.IO;
using ExemploPOO.Helper;
using ExemploPOO.Interfaces;
using ExemploPOO.Models;

namespace ExemploPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            var caminho = "/home/rennerlopes/Documents/DIO/Programando com Orientação a Objeto com C#/POO/ExemploPOO/TrabalhandoComArquivos";
            var caminhoPathCombine = Path.Combine(caminho, "Pasta teste 1");
            var caminhoArquivo = Path.Combine(caminho, "arquivo-teste.txt");
            var caminhoArquivoTeste = Path.Combine(caminho, "arquivo-teste.txt");
            var caminhoArquivoTesteCopia = Path.Combine(caminho, "arquivo-teste-bkp.txt");
            var listaString = new List<string> { "Linha 1", "Linha 2", "Linha 3" };
            var listaStringContinuacao = new List<string> { "Linha 4", "Linha 5", "Linha 6" };
            var novoCaminhoArquivo = Path.Combine(caminho, "Pasta teste 2", "arquivo-teste.txt");


            FileHelper helper = new FileHelper();
            helper.ListarDiretorios(caminho);
            helper.ListarArquivosDiretorios(caminho);
            helper.CriarDiretorio(caminhoPathCombine);
            helper.ApagarDiretorio(caminhoPathCombine, true);
            helper.CriarArquivoTexto(caminhoArquivo, "Olá! Teste de escrita de arquivo");
            helper.CriarArquivoTextoStream(caminhoArquivo, listaString);
            helper.AdicionarTextoStream(caminhoArquivo, listaStringContinuacao);
            helper.AdicionarTexto(caminhoArquivo, "Linha 7");
            helper.LerArquivoStream(caminhoArquivo);
            helper.LerArquivo(caminhoArquivo);
            helper.MoverArquivos(caminhoArquivo, novoCaminhoArquivo, false);
            helper.CopiarArquivo(caminhoArquivoTeste, caminhoArquivoTesteCopia, false);
            helper.DeletarArquivo(caminhoArquivoTesteCopia);


            ICalculadora calc = new Calculadora();
            System.Console.WriteLine(calc.Somar(10, 20));

            Corrente c = new Corrente();
            c.Creditar(100);
            c.ExibirSaldo();

            Calculadora calc2 = new Calculadora();
            System.Console.WriteLine("Resultado da primeira soma: " + calc2.Somar(10, 10));
            System.Console.WriteLine("Resultado da primeira soma: " + calc2.Somar(10, 10, 10));

            Aluno p1 = new Aluno();
            p1.Nome = "Bob";
            p1.Idade = 20;
            p1.Documento = "123456";
            p1.Nota = 10;
            p1.Apresentar();

            Professor p2 = new Professor();
            p2.Nome = "Bob";
            p2.Idade = 20;
            p2.Documento = "123456";
            p2.Salario = 2000;
            p2.Apresentar();

            Retangulo r = new Retangulo();
            r.DefinirMedidas(30, 30);
            System.Console.WriteLine($"Área: {r.ObterArea()}");

            Retangulo r2 = new Retangulo();
            r2.DefinirMedidas(0, 30);
            System.Console.WriteLine($"Área: {r2.ObterArea()}");

            Pessoa p3 = new Pessoa(); //Após digital Pessoa, pressionamos CNTR + . e importamos a class para o projeto

            p3.Nome = "Bob";
            p3.Idade = 20;

            p3.Apresentar();
        }
    }
}
