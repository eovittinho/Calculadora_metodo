using Layout;

namespace Calculadora
{
   class Operacoes
   {  
      public static decimal ObterValores()
      {
      repetir:
          Formatacao.Cor("Informe o valor: ", ConsoleColor.White);
          Console.ForegroundColor = ConsoleColor.Cyan;
          string input = Console.ReadLine();
          Console.ResetColor(); 

          if (!decimal.TryParse(input, out decimal valor))
          {
            Formatacao.Cor("Valor inválido! ", ConsoleColor.Red);
            goto repetir;
          }
            return valor;
      }
      public static void RealizarAdicao(decimal valor1, decimal valor2)
      {
        Formatacao.Cor($"A soma dos valores ", ConsoleColor.White);
        Formatacao.Cor($"{valor1} ", ConsoleColor.Cyan);
        Formatacao.Cor($"e ", ConsoleColor.White);
        Formatacao.Cor($"{valor2} ", ConsoleColor.Cyan);
        Formatacao.Cor($"é: ", ConsoleColor.White);
        Formatacao.Cor($"{valor1 + valor2}\n ", ConsoleColor.Cyan);
      }
   }
}