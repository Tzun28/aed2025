using System;
using System.Collections;
namespace AED
{
    public class CCelulaDup<T>
    {
        public T Item;
        public CCelulaDup<T> Ant;
        public CCelulaDup<T> Prox;
        public CCelulaDup()
        {
            Item = default(T);
            Ant = null;
            Prox = null;
        }
        public CCelulaDup(T valorItem)
        {
            Item = valorItem;
            Ant = null;
            Prox = null;
        }
        public CCelulaDup(T valorItem, CCelulaDup<T> celulaAnt, CCelulaDup<T> proxCelula)
        {
            Item = valorItem;
            Ant = celulaAnt;
            Prox = proxCelula;
        }
    }
    public class Deque<T>
    {
        private CCelulaDup<T> Primeira;
        private CCelulaDup<T> Ultima;
        private int Qtde = 0;
        public Deque()
        {
            Primeira = new CCelulaDup<T>();
            Ultima = new CCelulaDup<T>(default(T),null,Primeira);
            Primeira.Ant = Ultima;
        }
        
        public bool isEmpty()
        {
            if (Qtde <= 0){return true;}
            else return false;
        }
        public int ssize()
        {
            return Qtde;
        }
        public void pushLeft(T item)
        {   
            Ultima.Item = item;
            Ultima.Ant = new CCelulaDup<T>(default(T), null, Ultima);
            Ultima = Ultima.Ant;
            Qtde++;
        }
        public void pushRight(T item)
        {
            Primeira.Item = item;
            Primeira.Prox = new CCelulaDup<T>(default(T),Primeira,null);
            Primeira = Primeira.Prox;
            Qtde++;
        }
        public T popLeft()
        {
            if (Qtde == 0){  Console.WriteLine("Não há ccélulas dentro da Deque"); return default(T);}
            T aux = Ultima.Prox.Item;
            Ultima = Ultima.Prox;
            Ultima.Ant = null;
            Qtde--;
            return aux;
        }
        public T popRight()
        {
            if (Qtde == 0){  Console.WriteLine("Não há ccélulas dentro da Deque"); return default(T);}
            T aux = Primeira.Ant.Item;
            Primeira = Primeira.Ant;
            Primeira.Prox = null;
            Primeira.Item = default(T);
            Qtde--;
            return aux;
        }
    }
    class Program{
        public static void Main(){
            Deque<int> Aeddois = new Deque<int>();
            Aeddois.pushRight(15);
            Aeddois.pushRight(30);
            Aeddois.pushRight(60);
            Aeddois.pushLeft(10);
            Aeddois.pushLeft(5);
            Aeddois.pushLeft(2);
            Console.WriteLine("Valor mais a esquerda "+ Aeddois.popLeft());
            Console.WriteLine("Valor mais a direita {0}", Aeddois.popRight());
            Console.WriteLine("Valor mais a esquerda "+ Aeddois.popLeft());
            Console.WriteLine("Valor mais a esquerda "+ Aeddois.popLeft());
            Console.WriteLine("Valor mais a esquerda "+ Aeddois.popLeft());
            Console.WriteLine("Valor mais a direita {0}", Aeddois.popRight());
            Aeddois.popRight();
        }
    }
}