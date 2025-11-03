using System;
using System.Collections.Generic;
class Program
{   
    public static void Main()
    {
        List<Personagem> StarWars = new List<Personagem>();/*Lista que guarda os personagens*/
        Queue<Personagem> FilaPersonagens = new Queue<Personagem>();/*Fila que guarda os personagens*/
        Stack<Personagem> PilhaPersonagens = new Stack<Personagem>();/*Pilha que guarda os personagens*/
        int qtdpersonagens = int.Parse(Console.ReadLine());/*Começa com x número de personagens a serem adicionados na lista*/
        for (int p = 0; p < qtdpersonagens; p++)/*Adiciona na quantidade de personagens até chegar no limite que foi pedido*/
        {
            string talpersonagem = Console.ReadLine();/*Recebe personagem via linha*/
            string nomeandopersonagem = talpersonagem.Split(";")[0];/*Váriaveis de característica do personagem*/
            int informandoaltura; double informandopeso;
            if (talpersonagem.Split(";")[1].ToUpper() == "UNKNOWN") {informandoaltura = 0; }/*Evitar o problema que deu com int e double recebendo unknown na parte de altura e peso*/
            else { informandoaltura = int.Parse(talpersonagem.Split(";")[1]); }
            if (talpersonagem.Split(";")[2].ToUpper() == "UNKNOWN") { informandopeso = 0; }/*Evitar o problema que deu com int e double recebendo unknown na parte de altura e peso*/
            else { informandopeso = double.Parse(talpersonagem.Split(";")[2]); }
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
        int qtdcomandos = int.Parse(Console.ReadLine());/*Comandos*/
        for (int realicomandos = 0; realicomandos < qtdcomandos; realicomandos++)
        {
            string taiscomandos = Console.ReadLine();/*Recebe comando e valor de operação do comando*/
            string ocomando = taiscomandos.Split(";")[0].ToUpper();
            string fazcomando = taiscomandos.Split(";")[1];
            if (ocomando == "PESQBIN")/*Comando*/
            {
                Personagem basedepesquisabinaria = new Personagem(fazcomando, 0, 0, "", "", "", "", "", "");/*Personagem base para fazer a pesquisa binária*/
                int pesquisabinaria = StarWars.BinarySearch(basedepesquisabinaria);
                if (pesquisabinaria >= 0) { Console.WriteLine(fazcomando + " Ok"); }
                else { Console.WriteLine(fazcomando + " Nada"); }
            }
            else if (ocomando == "PUSH")/*Comando*/
            {
                foreach (Personagem empilhando in StarWars)
                {
                    if (empilhando.PegaLugarDeOrigem() == fazcomando)
                    {
                        PilhaPersonagens.Push(empilhando);
                    }
                }
            }
            else if (ocomando == "POP")/*Comando*/
            {
                if (fazcomando.ToUpper() == "ALL")
                {
                    int personagensxquantidade = PilhaPersonagens.Count;
                    for (int tantos = 0; tantos < personagensxquantidade; tantos++){ Console.WriteLine(PilhaPersonagens.Pop().PegaNome()); }
                }
                else {
                    int num = int.Parse(taiscomandos.Split(";")[1]); 
                    for (int aham = 0; aham < num; aham++) { Console.WriteLine(PilhaPersonagens.Pop().PegaNome()); }
                }
                
            }
            else if (ocomando == "ENQUEUE")/*Comando*/
            {

                foreach (Personagem enfileirando in StarWars)
                {
                    if (enfileirando.PegaLugarDeOrigem() == fazcomando)
                    {
                        FilaPersonagens.Enqueue(enfileirando);
                    }
                }
            }
            else if (ocomando == "DEQUEUE")/*Comando*/
            {   
                if (fazcomando.ToUpper() == "ALL")
                {
                    int personagensxquantidade = FilaPersonagens.Count;
                    for (int tantos = 0; tantos < personagensxquantidade; tantos++){ Console.WriteLine(FilaPersonagens.Dequeue().PegaNome()); }
                }
                else {
                    int num = int.Parse(taiscomandos.Split(";")[1]);
                    for (int aham = 0; aham < num; aham++) { Console.WriteLine(FilaPersonagens.Dequeue().PegaNome()); }
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
        return this.nome.CompareTo(tal.PegaNome());/*Filtra nome para usar na pesquisa binária*/
    }

}