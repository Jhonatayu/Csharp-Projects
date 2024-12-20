namespace HelloWorld
{
    class Program
    {

        enum Menu { Soma = 1, Subtracao, Multiplicacao, Divisao, Impar, Potenciacao, RaizQuadrada, Sair }

        static void Main(string[] args)
        {
            string enter = "\nPressione ENTER para retornar ao Menu.";

            bool escolheuSair = false;
            while (!escolheuSair)
            {
                Console.WriteLine("\nSelecione uma Opção\n");
                Console.WriteLine("1- Soma\n2- Subtração\n3- Multiplicação\n4- Divisão\n5- Impar\n6- Potênciação\n7- Raiz Quadrada\n8- Sair\n");
                Menu opcao = (Menu)int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case Menu.Soma:
                        Console.WriteLine($"\n\tO resultado da SOMA é: {Soma()}");
                        Console.WriteLine($"\n{enter}");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case Menu.Subtracao:
                        Console.WriteLine($"\n\tO resultado da SUBTRAÇÃO é: {Subtracao()}");
                        Console.WriteLine($"\n{enter}");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case Menu.Multiplicacao:
                        Console.WriteLine($"\n\tO resultado da MULTIPLICAÇÃO é: {Multiplicacao()}");
                        Console.WriteLine($"\n{enter}");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case Menu.Divisao:

                        if (Divisao() == 0)
                            Console.WriteLine("\nNão é possível dividir um número por 0.");
                        else
                            Console.WriteLine($"\n\tO resultado da DIVISÃO é: {Divisao()}");

                        Console.WriteLine($"\n{enter}");
                        Console.ReadLine();
                        Console.Clear();
                        break;

                    case Menu.Impar:
                        Impar();
                        Console.WriteLine(enter);
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case Menu.Potenciacao:
                        Console.WriteLine($"O resultado da Potência é: {Potenciacao()}");
                        Console.WriteLine($"\n{enter}");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case Menu.RaizQuadrada:
                        RaizQuadrada();
                        Console.WriteLine(enter);
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case Menu.Sair:
                        escolheuSair = true;
                        break;
                    default:
                        Console.WriteLine("\nPor favor selecione uma opção válida.");
                        Console.WriteLine(enter);
                        Console.ReadLine();
                        Console.Clear();
                        break;
                }
            }


        }

        static decimal Soma()
        {
            Console.Clear();
            Console.Write("\nDigite o primeiro número: ");
            decimal number1 = decimal.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            decimal number2 = decimal.Parse(Console.ReadLine());

            return number1 + number2;
        }

        static decimal Subtracao()
        {
            Console.Clear();
            Console.Write("\nDigite o primeiro número: ");
            decimal number1 = decimal.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            decimal number2 = decimal.Parse(Console.ReadLine());

            return number1 - number2;
        }

        static decimal Multiplicacao()
        {
            Console.Clear();
            Console.Write("\nDigite o primeiro número: ");
            decimal number1 = decimal.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            decimal number2 = decimal.Parse(Console.ReadLine());

            return number1 * number2;
        }

        static decimal Divisao()
        {
            Console.Clear();
            Console.Write("\nDigite o primeiro número: ");
            decimal number1 = decimal.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            decimal number2 = decimal.Parse(Console.ReadLine());

            if (number1 == 0 || number2 == 0)
                return 0;
            else
                return number1 / number2;
        }

        static decimal Impar()
        {
            Console.Clear();
            Console.Write("\nDigite um número: ");
            decimal number = decimal.Parse(Console.ReadLine());

            if (number % 2 == 0)
                Console.WriteLine("\nO número é PAR.");
            else
                Console.WriteLine("\nO número é IMPAR.");
            return 0;
        }

        static decimal Potenciacao()
        {
            Console.Clear();
            Console.Write("\nDigite o número que deseja realizar a potênciação: ");
            decimal number1 = decimal.Parse(Console.ReadLine());

            // Variável necessária para armazenar o valor original do número, para dessa forma realizar a potenciação da forma correta.
            decimal number1Copy = number1;

            Console.Write("Digite qual o nível da potência: ");
            decimal number2 = decimal.Parse(Console.ReadLine());

            int i = 1;
            while (i < number2)
            {
                i++;
                number1 = number1 * number1Copy;
            }
            return number1;
        }

        static double RaizQuadrada()
        {
            Console.Clear();
            Console.Write("\nDigite o número que deseja realizar a raiz quadrada: ");
            double number = double.Parse(Console.ReadLine());

            double raiz = Math.Sqrt(number);
            Console.WriteLine($"\nA raiz quadrada de {number} é: {raiz}");
            return raiz;
        }
    }
}