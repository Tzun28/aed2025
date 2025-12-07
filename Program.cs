using System;
using System.Collections;

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
    class RandomQueue<T>
    {
        private CCelula<T> Frente;
        private CCelula<T> Tras;
        private int Qtde = 0;
        RandomQueue()
        {
            Frente = new CCelula<T>();
            Tras = Frente;
        }
        void Enqueue(T item)
        {
            Tras.Prox = new CCelula<T>(item);
            Tras = Tras.Prox;
            Qtde++;
        }

        bool IsEmpty()
        {
            if  (Qtde <= 0)
                return true;
            else
                return false;
        }

    
        Object Dequeue()
        {
            if (IsEmpty()){ return default(T);};
            Random fila = new Random();
            int posicaoDaCelulaSorteada = fila.Next(1, Qtde);
            CCelula<T> aux = Frente.Prox;
            for (int i = 0; i < posicaoDaCelulaSorteada; i++)
            {
                aux = aux.Prox;
            }
            Frente.Prox = aux.Prox;
            return aux.Item;

        
        Object Sample()
            {
            if (IsEmpty()){ return default(T);};
            Random fila = new Random();
            int posicaoDaCelulaSorteada = fila.Next(1, Qtde);
            CCelula<T> aux = Frente.Prox;
            for (int i = 0; i < posicaoDaCelulaSorteada; i++)
            {
                aux = aux.Prox;
            }
            return aux.Item;
            }
            ;

    }
/*---------------------------------------------------------*/
    class Program
    {
        RandomQueue<int> RQ = new RandomQueue<int>();
    }
}