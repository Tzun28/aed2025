using System;
using System.Collections.Generic;
class Program{
    public static void Main(){
        Random r = new Random();
        List<int> Tetetetestando = new List<int>();
        Tetetetestando.Add(r.Next(0, 100));Tetetetestando.Add(r.Next(0, 100));Tetetetestando.Add(r.Next(0, 100));
        Tetetetestando.Add(r.Next(0, 100));Tetetetestando.Add(r.Next(0, 100));Tetetetestando.Add(r.Next(0, 100));
        Tetetetestando.Add(r.Next(0, 100));Tetetetestando.Add(r.Next(0, 100));Tetetetestando.Add(r.Next(0, 100));
        Console.WriteLine("Digite o início da lista");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o fim da lista");
        int b = int.Parse(Console.ReadLine());
        List<int> Rei = Copiapartelista(Tetetetestando, a ,b);
        Console.WriteLine(Rei.Count() + "," + Tetetetestando.Count());
        foreach (int delta in Rei) { Console.WriteLine(delta); }
    }
    public static List<T> Copiapartelista<T>(List<T> Recebe, int inicio, int fim ){
        List<T> Nvlista = new List<T>();

        if (inicio > Recebe.Count()){ Console.WriteLine("a"); return Nvlista;}
        else if (inicio > fim){
            if (inicio == 0){ inicio = 1; }   
            for (int z = fim; z <= inicio; z++)
            {
                Nvlista.Add(Recebe[z-1]);
            }
            Console.WriteLine("b");
            return Nvlista;
        }
        else if (fim > Recebe.Count()){
            if (inicio == 0) { inicio = 1; }
            for (int z = inicio; z <= Recebe.Count(); z++)
            {
                Nvlista.Add(Recebe[z-1]);
            }
            Console.WriteLine("c");
            return Nvlista;
        }
        else {   
            if (inicio == 0){ inicio = 1; }
            for (int z = inicio; z <= fim; z++)
            {
                Nvlista.Add(Recebe[z - 1]);
            }
            Console.WriteLine("d");
            return Nvlista;
        }
    }
}
