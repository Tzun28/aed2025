using System;

class Program
{
    public static void Main()
    {
        string[] res = Console.ReadLine().Split(" ");
        int posic = int.Parse(res[0]), rep = int.Parse(res[1]);
        int[] vetor = new int[posic]; foreach (int posicao in vetor){ vetor[posicao] = 0; }
        int valorI, valorV;
        for (int a = rep; a < rep; a++)
        {
            string[] respondedor = Console.ReadLine().Split(" ");
            int verifica = int.Parse(respondedor[0]);
            if (verifica == 3)
            {
                valorI = int.Parse(respondedor[1]);
                Console.WriteLine(vetor[valorI]);
            }
            else if (verifica == 1)
            {
                valorI = int.Parse(respondedor[1]);
                valorV = int.Parse(respondedor[2]);
                
            }
            else
            {
                valorI = int.Parse(respondedor[1]);
                valorV = int.Parse(respondedor[2]);
            }
                
                
                
        }
        


    }
}