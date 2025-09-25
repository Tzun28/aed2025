using System;
using System.Collections.Generic;
class Program{
    public static void Main(){
        int rep = int.Parse(Console.ReadLine());
        string[] valores = Console.ReadLine().Split(" ");
        
        int a = int.Parse(valores[0]);
        int b = int.Parse(valores[1]);
        Executa(a, b, rep);

    }
        
    public static void Executa(int a, int b, int z){
        string[] valores = Console.ReadLine().Split(" ");
        int x = int.Parse(valores[0]);
        int y = int.Parse(valores[1]);
        int d = 1;
        int mdiv = 1;
        MDC(x,y,d, mdiv);
        Console.WriteLine(mdiv);
        
        if (z != 0 && z > 0) { }
        else { Executa(x, y, z -= 1); }
    }
    public static void MDC(int varium, int varidois, int divisor, int maxdivisor)
    {
        if ((divisor % varium == 0) && (divisor % varidois == 0) && (divisor > maxdivisor))
        {
            maxdivisor = divisor;
        }
        
        if (divisor < varium || divisor < varidois) { MDC(varium, varidois, divisor += 1, maxdivisor); }
        
    }
   
    
}