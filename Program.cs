using System;

class Program {
    public static void Main()
    {

        int n = int.Parse(Console.ReadLine());
        string va;
        string[] v = new string[2];
        double[] vdouble = new double[2];
        double valorperc, valorcxb;
        va = Console.ReadLine().Replace(".", ",");
        v = va.Split(" ");
        vdouble[0] = double.Parse(v[0]);
        vdouble[1] = double.Parse(v[1]);
        valorcxb = double.Parse(v[0])*2;
        for (int a = 1; a < n; a++)//N supermercados
        {
            v = Console.ReadLine().Split(" ");
            vdouble[0] = double.Parse(v[0]);
            Console.WriteLine(vdouble[0]);
            vdouble[1] = double.Parse(v[1]);
            if (vdouble[1] == 1000) { valorperc = vdouble[0]; }
            else { valorperc = vdouble[0] + (((1000 / 1000) - (vdouble[1] / 1000)) * vdouble[1]); }
            if (valorperc < valorcxb) { valorcxb = valorperc; }

        }
        Console.WriteLine(valorcxb*1.00);

        
    }
}