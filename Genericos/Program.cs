using System;

Lista<string> listaString = new Lista<string>();

listaString.Add("teste1");
listaString.Add("teste2");
listaString.Add("teste3");

foreach (var i in listaString.lista)
{
    Console.WriteLine(i);
}

public class Lista<T>
{
    public T[] lista  = new T[];
    private int index { get; set; } = 0;

    public void Add(T item)
    {
        lista[index] = item;
        index++;
    }
}



