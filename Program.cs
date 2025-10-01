using System;
using System.Collections.Generic;
class Program
{
    public static void Main()
    {
        Random r = new Random();
        List<int> Tetetetestando = new List<int>();
        Tetetetestando.Add(r.Next(0, 100)); Tetetetestando.Add(r.Next(0, 100)); Tetetetestando.Add(r.Next(0, 100));
        Tetetetestando.Add(r.Next(0, 100)); Tetetetestando.Add(r.Next(0, 100)); Tetetetestando.Add(r.Next(0, 100));
        Tetetetestando.Add(r.Next(0, 100)); Tetetetestando.Add(r.Next(0, 100)); Tetetetestando.Add(r.Next(0, 100));
        Console.WriteLine("Digite o início do apagar");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite a quantidade para apagar");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine(Tetetetestando.Count());
        foreach (int elemento in Tetetetestando){ Console.Write("| " + elemento); }
        Apagalist2(ref Tetetetestando, a, b);
        Console.WriteLine(" ");
        Console.WriteLine(Tetetetestando.Count());
        foreach (int elemento in Tetetetestando){ Console.Write("| " + elemento); }
       
    }
    public static void Apagalist2<T>(ref List<T> Recebe, int comeco, int qtd)
    {
        int calc = Recebe.Count() - comeco;
        if (qtd > calc)
        {
            int total = Recebe.Count();
            for (int z = comeco; z < total;z++)
            {
                Recebe.RemoveAt(comeco - 1);

            }
        }
        else {
            for (int z = qtd; z > 0; z--)
            {
                Recebe.RemoveAt(comeco - 1);
            }
        }
    }
}
