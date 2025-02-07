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

        public static void RealizarSubtracao(decimal valor1, decimal valor2)
        {
            Formatacao.Cor($"A subtração dos valores ", ConsoleColor.White);
            Formatacao.Cor($"{valor1} ", ConsoleColor.Cyan);
            Formatacao.Cor($"e ", ConsoleColor.White);
            Formatacao.Cor($"{valor2} ", ConsoleColor.Cyan);
            Formatacao.Cor($"é: ", ConsoleColor.White);
            Formatacao.Cor($"{valor1 - valor2}\n ", ConsoleColor.Cyan);
        }

        public static void RealizarMultiplicacao(decimal valor1, decimal valor2)
        {
            Formatacao.Cor($"A multiplicação dos valores ", ConsoleColor.White);
            Formatacao.Cor($"{valor1} ", ConsoleColor.Cyan);
            Formatacao.Cor($"e ", ConsoleColor.White);
            Formatacao.Cor($"{valor2} ", ConsoleColor.Cyan);
            Formatacao.Cor($"é: ", ConsoleColor.White);
            Formatacao.Cor($"{valor1 * valor2}\n ", ConsoleColor.Cyan);
        }

        public static void RealizarDivisao(decimal valor1, decimal valor2)
        {
            if (valor2 == 0)
            {
                Formatacao.Cor("Erro: Não é possível dividir por zero!\n", ConsoleColor.Red);
                return;
            }
            Formatacao.Cor($"A divisão dos valores ", ConsoleColor.White);
            Formatacao.Cor($"{valor1} ", ConsoleColor.Cyan);
            Formatacao.Cor($"e ", ConsoleColor.White);
            Formatacao.Cor($"{valor2} ", ConsoleColor.Cyan);
            Formatacao.Cor($"é: ", ConsoleColor.White);
            Formatacao.Cor($"{valor1 / valor2}\n ", ConsoleColor.Cyan);
        }

        public static void MostrarMenu()
        {
            Console.Clear();
            Formatacao.Cor("Escolha a operação desejada:\n", ConsoleColor.White);
            Formatacao.Cor("1 - Adição\n", ConsoleColor.Cyan);
            Formatacao.Cor("2 - Subtração\n", ConsoleColor.Cyan);
            Formatacao.Cor("3 - Multiplicação\n", ConsoleColor.Cyan);
            Formatacao.Cor("4 - Divisão\n", ConsoleColor.Cyan);
            Formatacao.Cor("5 - Sair\n", ConsoleColor.Cyan);
            Console.Write("Digite a opção desejada: ");
        }

        public static void ExecutarCalculadora()
        {
            bool continuar = true;

            while (continuar)
            {
                MostrarMenu();

                Console.ForegroundColor = ConsoleColor.Cyan;
                string opcao = Console.ReadLine();
                Console.ResetColor();

                decimal valor1, valor2;

                switch (opcao)
                {
                    case "1":
                        valor1 = ObterValores();
                        valor2 = ObterValores();
                        RealizarAdicao(valor1, valor2);
                        break;

                    case "2":
                        valor1 = ObterValores();
                        valor2 = ObterValores();
                        RealizarSubtracao(valor1, valor2);
                        break;

                    case "3":
                        valor1 = ObterValores();
                        valor2 = ObterValores();
                        RealizarMultiplicacao(valor1, valor2);
                        break;

                    case "4":
                        valor1 = ObterValores();
                        valor2 = ObterValores();
                        RealizarDivisao(valor1, valor2);
                        break;

                    case "5":
                        Formatacao.Cor("Saindo da calculadora. Até logo!", ConsoleColor.Green);
                        continuar = false;
                        break;

                    default:
                        Formatacao.Cor("Opção inválida! Tente novamente.\n", ConsoleColor.Red);
                        break;
                }

                if (continuar)
                {
                    Formatacao.Cor("\nPressione qualquer tecla para continuar...", ConsoleColor.White);
                    Console.ReadKey();
                }
            }
        }
    }
}
