using System;

namespace Aula01
{
  class Program
  {
    static void Main(string[] args)
    {
      int valor1;
      int valor2;
      int total;
      System.Console.WriteLine("Digite o primeiro valor");
      valor1 = int.Parse(Console.ReadLine());
      System.Console.WriteLine("O primeiro valor é: " + valor1);
      System.Console.WriteLine("Digite o segundo valor");
      valor2 = int.Parse(Console.ReadLine());
      System.Console.WriteLine("O segundo valor é: " + valor2);

      total = valor1 + valor2;
      System.Console.WriteLine("A soma dos valores é: " + total);
    }
  }
}
