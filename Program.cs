using System.Collections.Generic;
class Program
{
    public static void Main()
    {
        int qtdpersonagens = int.Parse(Console.ReadLine());
            List<Personagem> personagins = new List<Personagem>();
        for (int z = 0; z < qtdpersonagens; z++)
        {
            string taldopersonagem = Console.ReadLine();
            string nomedigitado = taldopersonagem.Split(";")[0];
            Personagem tal = new Personagem()
            {
                
            };
            personagins.Add(tal);
        }
    }
}

class Personagem {
    private string nome;
    private int altura;
    private double peso;
    private string corDoCabelo;
    private string corDaPele;
    private string corDosOlhos;
    private string anoNascimento;
    private string genero;
    private string homeworld;

    public void Adiciona(string oque)
    {
        nome = nomedigitado;
    }
}