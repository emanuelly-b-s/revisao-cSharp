PilhaGenerica<int> pilha = new PilhaGenerica<int>();

pilha.Empilhar(32);
pilha.Empilhar(20);
pilha.Empilhar(17);
pilha.Empilhar(5);
pilha.Empilhar(23);
pilha.Empilhar(340);
pilha.Empilhar(74);
pilha.Empilhar(7);

// Imprime o tamanho da pilha
Console.WriteLine("Tamanho da pilha: " + pilha.Tamanho());

// Imprime o item no topo da pilha
Console.WriteLine("Item no topo da pilha: " + pilha.Topo());

// Desempilha um item e o imprime
int itemDesempilhado = pilha.Desempilhar();
Console.WriteLine("Item desempilhado: " + itemDesempilhado);

// Imprime o tamanho da pilha novamente
Console.WriteLine("Tamanho da pilha: " + pilha.Tamanho());

// Limpa a pilha e verifica se está vazia
pilha.Limpar();
Console.WriteLine("A pilha está vazia? " + pilha.Vazia());

public class PilhaGenerica<T>
{
    private List<T> itens;

    public PilhaGenerica()
    {
        itens = new List<T>();
    }

    public void Empilhar(T item)
    {
        itens.Add(item);
    }

    public T Desempilhar()
    {
        if (itens.Count == 0)
        {
            throw new InvalidOperationException("A pilha está vazia.");
        }

        T item = itens[itens.Count - 1];
        itens.RemoveAt(itens.Count - 1);
        return item;
    }

    public T Topo()
    {
        if (itens.Count == 0)
        {
            throw new InvalidOperationException("A pilha está vazia.");
        }

        return itens[itens.Count - 1];
    }

    public int Tamanho()
    {
        return itens.Count;
    }

    public void Limpar()
    {
        itens.Clear();
    }

    public bool Vazia()
    {
        return itens.Count == 0;
    }
}