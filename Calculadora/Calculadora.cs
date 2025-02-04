namespace Calculadora
{
    class Operacoes
    {
     public static void RealizarAdicao(
        decimal valor1,
        decimal valor2
        )
        {
         decimal soma = valor1 + valor2;
         Console.WriteLine($"A soma dos valores {valor1} e {valor2} é: {soma}");
        }

    }
}