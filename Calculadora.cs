namespace Calculadora
{

   class Operacoes
   {
      
      public static decimal ObterValores()
      {
      repetir:
          Console.Write("Informe o valor: ");
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
        Console.WriteLine($"A soma dos valores é: {valor1 + valor2} ");
      }
   }

}