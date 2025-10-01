using System;
using System.Collections.Generic;
class Program
{
    public static void Main()
    {
        Dictionary<string, List<string>> Montadoras = new Dictionary<string, List<string>> {
            ["Fiat"] = new List<string>
                {
                "Fiorino", "Argo","Pulse","Cronos","Fastback","Strada","Mobi","Toro","Titano"
                }
            ,["Volkswagen"] = new List<string>
                {
                    "Taos", "Voyage","Polo","Tera","Amarok","Nivus","Golf","Jetta","Tiguan"
                }
            ,
            ["Hyundai"] = new List<string>
                {
                    "Creta","HB20","HB20S","Kona","Tucson"
                }
            ,
            ["GM"] = new List<string>
                {
                    "Onix", "Tracker","S10","Spin","Montana"
                }
        };
        Console.WriteLine("Digite o nome da montadora para descobrir quantidade e nomes de carro");
        string marca = Console.ReadLine();
        Console.WriteLine("Quantidade de modelos: " + Montadoras[marca].Count());
        foreach (string a in Montadoras[marca]) {
            Console.Write(a + " | ");
        }
    }
}