using Layout;

namespace Calculadora
{

   class Operacoes
   {
      
      public static decimal ObterValores()
      {
      repetir:
          Formatacao.Cor("Informe o valor: ", ConsoleColor.White);
          if (!decimal.TryParse(Console.ReadLine(), out decimal valor))
          
          {
            Console.WriteLine("Valor inválido! ");
            goto repetir;
          }
          else
          {
            return valor;
          }
      }
      public static void RealizarAdicao(decimal valor1, decimal valor2)
      {
        Formatacao.Cor($"A soma dos valores é: ", ConsoleColor.White);
        Formatacao.Cor($"{valor1 + valor2}", ConsoleColor.Red);
      }
   }

}