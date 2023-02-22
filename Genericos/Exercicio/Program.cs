using System.Collections.Generic;

Stack<int> teste = new Stack<int>();

teste.Push(1);
teste.Push(2);



public class Stack<T>
{
    private T[] pilha = new T[10];
    private int topo = -1;

    public void Push(T item)
    {
        topo++;
        pilha[topo] = item;
    }

    public void Pop()
    {
        if (topo < 0)
            return;
        pilha[topo] = default(T);
        topo--;
    }

    public bool isEmpty()
    {
        return topo < 0;
    }

    public int Size()
    {
        return topo + 1;
    }

    void Clear()
    {
        for (int i = 0; i < pilha.Count(); i++)
        {
            pilha[i] = default(T);
        }
        topo = -1;
    }

    public override string ToString()
    {
        string result = "";
        for (int i = topo; i < 0; i--)
        {
            result += $"{i}" + $"{pilha[i]}";
        }
        return result;
    }
}
