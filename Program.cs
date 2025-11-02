using System;
using System.Collections.Generic;
class Program
{   
    public static void Main()
    {
        List<Personagem> StarWars = new List<Personagem>();/*Lista que guarda os personagens*/
        Queue<Personagem> FilaPersonagens = new Queue<Personagem>();
        Stack<Personagem> PilhaPersonagens = new Stack<Personagem>();
        int qtdpersonagens = int.Parse(Console.ReadLine());/*Começa com x número de personagens a serem adicionados na lista*/
        for (int p = 0; p < qtdpersonagens; p++)/*Adiciona na quantidade de personagens até chegar no limite que foi pedido*/
        {
            string talpersonagem = Console.ReadLine();
            string nomeandopersonagem = talpersonagem.Split(";")[0];
            int informandoaltura = int.Parse(talpersonagem.Split(";")[1]);
            double informandopeso = double.Parse(talpersonagem.Split(";")[2]);
            string informandoCorDoCabelo = talpersonagem.Split(";")[3];
            string informandoCorDaPele = talpersonagem.Split(";")[4];
            string informandoCorDosOlhos = talpersonagem.Split(";")[5];
            string informandoAnoNascimento = talpersonagem.Split(";")[6];
            string informandoGenero = talpersonagem.Split(";")[7];
            string informandoHomeworld = talpersonagem.Split(";")[8];
            Personagem Atual = new Personagem(nomeandopersonagem, informandoaltura, informandopeso, informandoCorDoCabelo, informandoCorDaPele, informandoCorDosOlhos,
            informandoAnoNascimento, informandoGenero, informandoHomeworld);/*Depois de juntar dados, cria o personagem*/
        StarWars.Add(Atual);/*Adiciona o personagem na lista*/
        }
        foreach (Personagem x in StarWars)
        {
            Console.WriteLine(x);
        }
        int qtdcomandos = int.Parse(Console.ReadLine());
        for (int realicomandos = 0; realicomandos < qtdcomandos; realicomandos++)
        {
            string taiscomandos = Console.ReadLine();
            string ocomando = taiscomandos.Split(";")[0].ToUpper();
            string fazcomando = taiscomandos.Split(";")[1].ToUpper();
            if (ocomando == "PESQBIN")
            {
                int pesquisabinaria = List<Personagem>.BinarySearch(StarWars.PegaNome(), fazcomando);
                else if (ocomando == "PUSH")
                {

                }
                else if (ocomando == "POP")
                {

                }
                else if (ocomando == "ENQUEUE")
                {

                }
                else if (ocomando == "DEQUEUE")
                {

                }
            }
        }
    

    }
    
}


class Personagem : IComparable<Personagem> {
    private string nome;
    private int altura;
    private double peso;
    private string corDoCabelo;
    private string corDaPele;
    private string corDosOlhos;
    private string anoNascimento;
    private string genero;
    private string homeworld;

    public Personagem(string GuardaNome, int GuardaAltura, double GuardaPeso, string GuardaCorDoCabelo, string GuardaCorDaPele,
        string GuardaCorDosOlhos, string GuardaAnoNascimento, string GuardaGenero, string GuardaHomeworld)
    {
        nome = GuardaNome;
        altura = GuardaAltura;
        peso = GuardaPeso;
        corDoCabelo = GuardaCorDoCabelo;
        corDaPele = GuardaCorDaPele;
        corDosOlhos = GuardaCorDosOlhos;
        anoNascimento = GuardaAnoNascimento;
        genero = GuardaGenero;
        homeworld = GuardaHomeworld;
    }
    public string PegaNome()
    {
        return this.nome;
    }
    public int PegaAltura()
    {
        return this.altura;
    }
    public double PegaPeso()
    {
        return this.peso;
    }
    public string PegaCorCabelo()
    {
        return this.corDoCabelo;
    }
    public string PegaCorPele()
    {
        return this.corDaPele;
    }
    public string PegaCorOlhos()
    {
        return this.corDosOlhos;
    }
    public string PegaNascimento()
    {
        return this.anoNascimento;
    }
    public string PegaGenero()
    {
        return this.genero;
    }
    public string PegaLugarDeOrigem()
    {
        return this.homeworld;
    }

    public int CompareTo(Personagem tal)
    {
        return this.nome.CompareTo(tal.PegaNome());
    }

}