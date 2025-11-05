using System;
using System.Collections.Generic;
namespace AED{
    #region Classe CCelula - Esse tal de region aparentemente é para ocultar essa parte do código mais fácil
    #region Tentando fazer uma Cclasse Lista
    public class CLista<T>
    {
        private CCelula<T> Primeira;
        private CCelula<T> Ultima;
        public CLista()
        {
            Primeira = new CCelula<T>();
            Ultima = Primeira;
        }
        public void InserirAntesDe( T valorainserir, T valoratual)
        {
            for (CCelula<T> x = Primeira.Prox; x != null; x = x.Prox)
            {
                if (x() == x(valoratual))
                {
                    
                }
            }
            
        }
        
    }
    #endregion
    public class CCelula<T>//Declaração de classe ccelula com dado genérico
    {
        public T Item;
        public CCelula<T> Prox;
        public CCelula()
        {
            Item = default(T);
            Prox = null;
        }
        public CCelula(T valordoItem)
        {
            Item = valordoItem;
            Prox = null;
        }
        public CCelula(T valordoItem, CCelula<T> proxCelula)
        {
            Item = valordoItem;
            Prox = proxCelula;
        }
        
    }
    #endregion
    class Program
    {
        public static void Main()
        {
            List<string> Raio = new List<string>() { "Raio", "Trovão", "Barulho" };
            Console.WriteLine(Raio[0]);
            Raio[0] = Raio[1];
            Console.WriteLine(Raio[0]);

            List<CCelula<string>> Clista = new List<CCelula<string>>();



        }
        
    }
}