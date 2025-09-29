using System;
using System.Collections.Generic;
class Program{
    public static void Main(){
        Random r = new Random();
        Queue<int> Tetetetestando = new Queue<int>();
        Tetetetestando.Enqueue(r.Next(0, 100)); Tetetetestando.Enqueue(r.Next(0, 100)); Tetetetestando.Enqueue(r.Next(0, 100));
        List<int> Rei = new List<int>();
        Rei = Copiafilapralista(Tetetetestando);
        foreach(int a in Rei){ Console.WriteLine(a); }
    }
    public static List<t> Copiafilapralista<t>(Queue<t> Recebe){
    List<t> Nova = new List<t>();
    foreach (t elemento in Recebe)
    {
        Nova.Add(elemento);
    }
    return Nova;
    }
}
