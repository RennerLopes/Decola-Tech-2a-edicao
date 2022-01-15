using System;
using ExemploConstrutores.Models;

namespace ExemploConstrutores
{
    class Program
    {

        public delegate void Operacao(int x, int y);

        static void Main(string[] args)
        {
            // Exemplo do uso de Evento
            Matematica m = new Matematica(10, 20);
            m.Somar();

            // Exemplo do uso de Delegate
            Operacao op = new Operacao(Calculadora.Somar);
            //Operacao op = Calculadora.Somar; -> Pode ser chamado dessa outra forma
            op += Calculadora.Subtrair;

            op.Invoke(10, 10);
            op(10, 10);

            // Uso de constante
            const double pi = 3.14;
            // pi = 0 -> Não funciona, para isso podemos usar uma variável
            System.Console.WriteLine(pi);

            // Exemplos d Get e Set
            Data data = new Data();
            data.SetMes(20);

            data.Mes = 20;
            System.Console.WriteLine(data.Mes);

            data.Apresentar();

            // Uso do construtor na herança
            Aluno p2 = new Aluno("Lucas", "Freitas", "Matemática");
            p2.Apresentar();

            // Uso do construtor privado e padrão Singleton
            Log Log = Log.GetInstance();
            Log.PropriedadeLog = "Teste instancia";

            Log log2 = Log.GetInstance();
            System.Console.WriteLine(log2.PropriedadeLog);

            // Exemplo Construtor
            Pessoa p1 = new Pessoa();
            p1.Apresentar();
        }
    }
}
