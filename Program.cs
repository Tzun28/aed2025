using System;
using System.Collections.Generic;
namespace AED
{
    #region Classe CCelula - Esse tal de region aparentemente é para ocultar essa parte do código mais fácil
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
    #region CFila
    public class CFila<T> : IEnumerable<T>
    {
        private CCelula<T> Frente;
        private CCelula<T> Tras;
        private int Qtde = 0;
        public CFila()
        {
            Frente = new CCelula<T>();
            Tras = Frente;
        }
        public bool EstaVazia() => Frente == Tras;
        public void Enfileira(T valorItem)
        {
            Tras.Prox = new CCelula<T>(valorItem);
            Tras = Tras.Prox;
            Qtde++;
        }
        public T Desenfileira()
        {
            if (Frente != Tras)
            {
                Frente = Frente.Prox;
                T item = Frente.Item;
                Qtde--;
                return item;
            }
            return default(T);
        }
        public T Peek() => Frente != Tras ? Frente.Prox.Item : default(T);
        public bool Contem(T valorItem)
        {
            for (CCelula<T> aux = Frente.Prox; aux != null; aux = aux.Prox)
                if (EqualityComparer<T>.Default.Equals(aux.Item,
                valorItem))
                    return true;
            return false;
        }
        public int Quantidade() => Qtde;
        public IEnumerator<T> GetEnumerator()
        {
            for (var aux = Frente.Prox; aux != null; aux = aux.Prox)
                yield return aux.Item;
        }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() => GetEnumerator();
    
        public static CFila<T> ConcatenaFila(CFila<T> F1, CFila<T> F2){
            CFila<T> aux = new CFila<T>();
            for (CCelula<T> x = F1.Tras; x.Prox != null; x = x.Prox)
            {
                aux.Inserir(x.Prox.Item);
            }
            for (CCelula<T> x = L2.Primeira; x.Prox != null; x = x.Prox)
            {
                aux.Inserir(x.Prox.Item);
            }
            return aux;
        }
    }
        #endregion
    class Program
    {
        public static void Main()
        {
            
        }
    }
}