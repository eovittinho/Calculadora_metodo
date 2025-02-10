using Layout;

class Calculadora
{
    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Calculadora Simples");
            Console.WriteLine("Selecione a operação:");
            Console.WriteLine("1 - Adição");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("5 - Sair");
            Console.Write("Opção: ");

            string opcao = Console.ReadLine();

            if (opcao == "5")
            {
                break;
            }

            Console.Write("Digite o primeiro número: ");
            if (!double.TryParse(Console.ReadLine(), out double num1))
            {
                Console.WriteLine("Entrada inválida. Pressione qualquer tecla para tentar novamente.");
                Console.ReadKey();
                continue;
            }

            Console.Write("Digite o segundo número: ");
            if (!double.TryParse(Console.ReadLine(), out double num2))
            {
                Console.WriteLine("Entrada inválida. Pressione qualquer tecla para tentar novamente.");
                Console.ReadKey();
                continue;
            }

            double resultado = 0;
            bool operacaoValida = true;

            switch (opcao)
            {
                case "1":
                    resultado = Adicao(num1, num2);
                    break;
                case "2":
                    resultado = Subtracao(num1, num2);
                    break;
                case "3":
                    resultado = Multiplicacao(num1, num2);
                    break;
                case "4":
                    if (num2 != 0)
                    {
                        resultado = Divisao(num1, num2);
                    }
                    else
                    {
                        Console.WriteLine("Erro: Divisão por zero não é permitida.");
                        operacaoValida = false;
                    }
                    break;
                default:
                    Console.WriteLine("Operação inválida.");
                    operacaoValida = false;
                    break;
            }

            if (operacaoValida)
            {
                Console.WriteLine($"Resultado: {resultado}");
            }

            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
        }
    }

    static double Adicao(double a, double b)
    {
        return a + b;
    }

    static double Subtracao(double a, double b)
    {
        return a - b;
    }

    static double Multiplicacao(double a, double b)
    {
        return a * b;
    }

    static double Divisao(double a, double b)
    {
        return a / b;
    }
}