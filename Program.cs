using System;
using System.Collections.Generic;
class Program
{
    public static void Main()
    {
        int soma = 0;
        List<int> numeros = new List<int>();
        for (int a = 1; a <= 100; a++)/*Também da para pular fazendo a+=2 que aí ia pegar só ímpar*/
        {
            if (a % 2 != 0) { numeros.Add(a); }
        }
        foreach (int elemento in numeros)
        {
            soma += elemento;
        }
        Console.WriteLine("A soma é " + soma);
    }
}