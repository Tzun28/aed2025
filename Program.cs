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
            Tal<talpersonagem, = new Personagem();
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

}