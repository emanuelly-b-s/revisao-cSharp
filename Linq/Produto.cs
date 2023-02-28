
public class Produto
{
    public string Nome { get; set; }
    public double Valor { get; set; }

    public DateTime DataValidade { get; set; }

    public Produto(string nome, double valor, DateTime validade)
    {
        Nome = nome;
        Valor = valor;
    }

    public override string ToString()
    {
        return Nome + " - R$ " + Valor;
    }
}