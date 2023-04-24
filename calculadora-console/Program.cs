Menu();

static void Menu()
{
    bool terminou = false;

    Console.Clear();

    Console.WriteLine("Digite uma operação:");
    Console.WriteLine("1 - Soma");
    Console.WriteLine("2 - Subtração");
    Console.WriteLine("3 - Multiplicação");
    Console.WriteLine("4 - Divisão");
    Console.WriteLine("5 - Sair");

    Console.WriteLine("----------");
    short opcao = short.Parse(Console.ReadLine());

    do
    {

        switch (opcao)
        {
            case 1: Soma(); break;
            case 2: Subtracao(); break;
            case 3: Multiplicacao(); break;
            case 4: Divisao(); break;
            case 5: Console.WriteLine("O programa se encerrou!"); System.Environment.Exit(0); break;
            default: Menu(); break;

        }

        Console.WriteLine("\n" + "Fazer outra operação? (y/n)");
        char reniciar = char.Parse(Console.ReadLine());

        if (reniciar == 'y')
        {
            Menu();
            terminou = false;
        }
        else
        {
            terminou = true;
            Console.Clear();
            Console.WriteLine("O programa se encerrou!");
        }
    } while (!terminou);
}

static void Soma()
{
    Console.Clear();

    Console.WriteLine("Digite o primeiro valor");
    int numero1 = int.Parse(Console.ReadLine());

    Console.WriteLine("Digite o segundo valor");
    int numero2 = int.Parse(Console.ReadLine());

    int resultado = numero1 + numero2;
    Console.WriteLine($"O resultado da soma de {numero1} mais {numero2} é {resultado}");
}

static void Subtracao()
{
    Console.Clear();

    Console.WriteLine("Digite o primeiro valor");
    int numero1 = int.Parse(Console.ReadLine());

    Console.WriteLine("Digite o segundo valor");
    int numero2 = int.Parse(Console.ReadLine());

    int resultado = numero1 - numero2;
    Console.WriteLine($"O resultado da subtração de {numero1} menos {numero2} é {resultado}");
}

static void Multiplicacao()
{
    Console.Clear();

    Console.WriteLine("Digite o primeiro valor");
    int numero1 = int.Parse(Console.ReadLine());

    Console.WriteLine("Digite o segundo valor");
    int numero2 = int.Parse(Console.ReadLine());

    int resultado = numero1 * numero2;
    Console.WriteLine($"O resultado da multiplicação de {numero1} vezes {numero2} é {resultado}");
}

static void Divisao()
{
    Console.Clear();

    Console.WriteLine("Digite o primeiro valor");
    int numero1 = int.Parse(Console.ReadLine());

    Console.WriteLine("Digite o segundo valor");
    int numero2 = int.Parse(Console.ReadLine());

    int resultado = numero1 / numero2;
    Console.WriteLine($"O resultado da divisão de {numero1} divido por {numero2} é {resultado}");
}
