using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
class Program
{   
    public static void Main()
    {
    Dictionary<string, Personagem> Tal = new Dictionary<string, Personagem>();

        
        int qtdpersonagens = int.Parse(Console.ReadLine());
            List<Personagem> personagins = new List<Personagem>();
        for (int z = 0; z < qtdpersonagens; z++)
        {
            string talpersonagem = Console.ReadLine();
                string nome = talpersonagem.Split(";")[0];
                int altura = int.Parse(talpersonagem.Split(";")[1]);
                double peso = double.Parse(talpersonagem.Split(";")[2]);
                string corDoCabelo = talpersonagem.Split(";")[3];
                string corDaPele = talpersonagem.Split(";")[4];
                string corDosOlhos = talpersonagem.Split(";")[5];
                string anoNascimento = talpersonagem.Split(";")[6];
                string genero = talpersonagem.Split(";")[7];
                string homeworld = talpersonagem.Split(";")[8];
            Personagem tal = new Personagem
            {
                Nome = nome,
                altura = altura,
                peso = peso,
                corDoCabelo = corDoCabelo,
                corDaPele = corDaPele,
                corDosOlhos = corDosOlhos,
                anoNascimento = anoNascimento,
                genero = genero,
                homeworld = homeworld,

            };
        }
        

    }
}

class Personagem {
    private string nome{ get; set; }
    private int altura{ get; set; }
    private double peso{ get; set; }
    private string corDoCabelo{ get; set; }
    private string corDaPele{ get; set; }
    private string corDosOlhos{ get; set; }
    private string anoNascimento{ get; set; }
    private string genero{ get; set; }
    private string homeworld{ get; set; }

    public Personagem(string Nome, int Altura, double Peso, string CorDoCabelo, string CorDaPele,
        string CorDosOlhos, string AnoNascimento, string Genero, string Homeworld)
    {
        nome = Nome;
        altura = Altura;
        peso = Peso;
        corDoCabelo = CorDoCabelo;
        corDaPele = CorDaPele;
        corDosOlhos = CorDosOlhos;
        anoNascimento = AnoNascimento;
        genero = Genero;
        homeworld = Homeworld;
        
    }
        
    
}