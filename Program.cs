using System;
using System.Collections.Generic;
namespace AED{
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
    class Program
    {
        public static void Main()
        {

        }
    }
}