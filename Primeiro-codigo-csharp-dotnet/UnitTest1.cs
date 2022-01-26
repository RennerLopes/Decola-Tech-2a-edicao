using NUnit.Framework;

namespace Primeiro_codigo_dotnet
{
  public class Tests
  {
    [Test]
    public void SomaTeste()
    {
      var a = 5;
      var b = 5;
      var esperado = 10;
      var contas = new contas();

      var result = contas.Soma(a, b);
      Assert.AreEqual(esperado, result);
    }

    [Test]
    public void SubtracaoTeste()
    {
      var a = 5;
      var b = 5;
      var esperado = 0;
      var contas = new contas();

      var result = contas.Subtracao(a, b);
      Assert.AreEqual(esperado, result);
    }

    [Test]
    public void DivisaoTeste()
    {
      var a = 5;
      var b = 5;
      var esperado = 1;
      var contas = new contas();

      var result = contas.Divisao(a, b);
      Assert.AreEqual(esperado, result);
    }

    [Test]
    public void MultiplicacaoTeste()
    {
      var a = 5;
      var b = 5;
      var esperado = 25;
      var contas = new contas();

      var result = contas.Multiplicacao(a, b);
      Assert.AreEqual(esperado, result);
    }
  }
}