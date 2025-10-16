using System.Collections.Generic;
class Program
{
    public static void Main()
    {
        int qtdpersonagens = int.Parse(Console.ReadLine());
        for (int z = 0; z < qtdpersonagens; z++)
        {
            string taldopersonagem = Console.ReadLine();
            List<string> personagins = new List<string>();
            foreach (string caracteristica in taldopersonagem.Split(";"))
            {
                personagins.Add(caracteristica);
            }


            Personagem Dart = new Personagem()
            {

            };
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
}