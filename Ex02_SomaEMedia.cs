using System;
using System.Collections.Generic;


Console.WriteLine("Digite a quantidade de numeros a serem calculados: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n < 3 || n > 10)
{
    Console.WriteLine("Por favor, digite uma quantidade entre 3 e 10");
    return;
}

List<double> lista = new List<double>();

for (int i = 0; i < n; i++)
{
    Console.Write($"Numero {i + 1}: ");
    double numero = Convert.ToDouble(Console.ReadLine());
    lista.Add(numero);
}

double calculo(int n, List<double> lista)
{

    double soma = 0;
    double media = 0;

    foreach (double numero in lista)
    {
        soma += numero;
    }

    media = soma / n;

    return media;
}

double resultado = calculo(n, lista);
Console.WriteLine($"Media = {resultado:F3}");
