using System;
using System.Runtime.ConstrainedExecution;
class Program
{
    public static void Main()
    {
        int algo = 1;
        while (algo > 0)
        {
            algo = int.Parse(Console.ReadLine());
            int faz = algo / 2;
            bool q = false;
            bool s = false;
            List<int> lista = new List<int>();
            for (int a = 0; a < faz; a++)
            {
                string[] resp = Console.ReadLine().Split(" ");
                lista.Add(int.Parse(resp[2]));
            }
            for (int a = 0; a < faz; a++)
            {
                string[] resp = Console.ReadLine().Split(" ");
                if (int.Parse(resp[2]) == lista[a] && q == false){ q = false; }
                else{ q = true; }

            }
        }
    }
}