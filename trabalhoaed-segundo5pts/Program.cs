using System;
using System.Collections.Generic;
#region codigo
class Program
{   
    public static void Main()
    {
        List<Personagem> StarWars = new List<Personagem>();/*Lista que guarda os personagens*/
        List<Personagem> StarSemBaderna = new List<Personagem>();
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
        
        for (int contagem = 0; contagem < qtdpersonagens; contagem++){
            foreach (Personagem autobot in StarWars){
                if (autobot.PegaNome() < StarSemBaderna[qtdpersonagens-1].PegaNome()){    
                }
                else {  
                    
                }

            }
        }
        string megachar = 'a', supachar = 'b';
        if (megachar > supachar)Console.WriteLine("Supremo");
        else Console.WriteLine("Dominador");

    }
}
#endregion
#region ccelula
public class CCelula<T>
	{
		public T Item;
		public CCelula<T> Prox;

		public CCelula()
		{
			Item = default(T);
			Prox = null;
		}

		public CCelula(T valorItem)
		{
			Item = valorItem;
			Prox = null;
		}

		public CCelula(T valorItem, CCelula<T> proxCelula)
		{
			Item = valorItem;
			Prox = proxCelula;
		}
	}
    public class CLista<T> : IEnumerable<T>
	{
		private CCelula<T> Primeira;
		private CCelula<T> Ultima;
		private int Qtde = 0;

		public CLista()
		{
			Primeira = new CCelula<T>();
			Ultima = Primeira;
		}

		public bool Vazia() => Primeira == Ultima;

		public void InsereFim(T valorItem)
		{
			Ultima.Prox = new CCelula<T>(valorItem);
			Ultima = Ultima.Prox;
			Qtde++;
		}

		public void InsereComeco(T valorItem)
		{
			Primeira.Prox = new CCelula<T>(valorItem, Primeira.Prox);
			if (Primeira.Prox.Prox == null)
				Ultima = Primeira.Prox;
			Qtde++;
		}

		public bool InsereIndice(T valorItem, int posicao)
		{
			if (posicao < 1 || posicao > Qtde + 1) return false;

			CCelula<T> aux = Primeira;
			for (int i = 0; i < posicao - 1; i++)
				aux = aux.Prox;

			aux.Prox = new CCelula<T>(valorItem, aux.Prox);
			if (aux.Prox.Prox == null)
				Ultima = aux.Prox;
			Qtde++;
			return true;
		}

		public bool Contem(T valorItem)
		{
			for (var aux = Primeira.Prox; aux != null; aux = aux.Prox)
				if (EqualityComparer<T>.Default.Equals(aux.Item, valorItem))
					return true;
			return false;
		}

		public T RetornaIndice(int posicao)
		{
			if (posicao < 1 || posicao > Qtde) return default(T);

			var aux = Primeira.Prox;
			for (int i = 1; i < posicao; i++)
				aux = aux.Prox;
			return aux.Item;
		}

		

		

		

		public int Quantidade() => Qtde;
	}
#endregion
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

}