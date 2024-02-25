using System.Reflection;

int menu()
{
    Console.WriteLine("\t\nCALCULADORA");
    Console.WriteLine("Escolha uma opção:");
    Console.WriteLine("1 - Somar");
    Console.WriteLine("2 - Subtrair");
    Console.WriteLine("3 - Multiplicar");
    Console.WriteLine("4 - Dividir");
    Console.WriteLine("5 - Resto da divisão");
    Console.WriteLine("6 - Potência");
    Console.WriteLine("0 - Sair");
    Console.WriteLine("");
    int opcao = Convert.ToInt32(Console.ReadLine());
    return opcao;
}

void somar()
{
    Console.Write("\nPor favor, digite o primeiro número: ");
    int n1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Segundo número: ");
    int n2 = Convert.ToInt32(Console.ReadLine());

    int soma = n1 + n2;

    Console.WriteLine($"Soma: {n1} + {n2} = {soma}");
}

void subtrair()
{
    Console.Write("\nPor favor, digite o primeiro número inteiro: ");
    int n1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Segundo número inteiro: ");
    int n2 = Convert.ToInt32(Console.ReadLine());

    int subtracao = n1 - n2;

    Console.WriteLine($"Subtração: {n1} - {n2} = {subtracao}");

}

void multiplicar()
{
    Console.Write("\nPor favor, digite o primeiro número: ");
    double n1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Segundo número: ");
    double n2 = Convert.ToInt32(Console.ReadLine());

    double multiplicacao = n1 * n2;

    Console.WriteLine($"Multiplicação: {n1} * {n2} = {multiplicacao}");
}

void dividir()
{
    Console.Write("\nPor favor, digite o primeiro número: ");
    double n1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Segundo número: ");
    double n2 = Convert.ToInt32(Console.ReadLine());

    if (n2 == 0)
    {
        Console.WriteLine("\nNão é possível dividir por 0");
    }

    double divisao = n1 / n2;

    Console.WriteLine($"Divisão: {n1} / {n2} = {divisao}");
}

void resto()
{
    Console.Write("\nPor favor, digite o primeiro número: ");
    double n1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Segundo número: ");
    double n2 = Convert.ToInt32(Console.ReadLine());

    if (n2 == 0)
    {
        Console.WriteLine("\nNão é possível dividir por 0");
    }

    double resto = n1 % n2;

    Console.WriteLine($"Resto de {n1} / {n2} = {resto}");
}

void potencia()
{
    Console.Write("\nPor favor, digite o primeiro número (base): ");
    double n1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Segundo número (expoente): ");
    double n2 = Convert.ToInt32(Console.ReadLine());

    double potenciacao = Math.Pow(n1, n2);

    Console.WriteLine($"Potenciação: {n1} elevado a {n2} = {potenciacao}");
}

int opcao;

while (true)
{
    opcao = menu();

    switch (opcao)
    {
        case 1:
            somar();
            break;
        case 2:
            subtrair();
            break;
        case 3:
            multiplicar();
            break;
        case 4:
            dividir();
            break;
        case 5:
            resto();
            break;
        case 6:
            potencia();
            break;
        default:
            return;
    }
}


