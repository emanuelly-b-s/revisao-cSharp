
using System.Collections.Generic;
using System.Linq;
public class Estoque
{
    public IEnumerable<Produto> ListaProdutos {get; set;}= new List<Produto>()
    {
        new Produto("Arroz", 10.0, new DateTime(2023, 12, 31)),
        new Produto("Feijão", 8.0, new DateTime(2023, 6, 30)),
        new Produto("Azeite", 20.0, new DateTime(2025, 2, 28)),
        new Produto("Sal", 2.0, new DateTime(2024, 10, 31)),
        new Produto("Açúcar", 5.0, new DateTime(2023, 8, 31)),
        new Produto("Café", 7.5, new DateTime(2022, 12, 31)),
        new Produto("Leite", 3.5, new DateTime(2023, 4, 30)),
        new Produto("Pão", 4.0, new DateTime(2022, 11, 30)),
        new Produto("Queijo", 15.0, new DateTime(2022, 10, 31)),
        new Produto("Presunto", 12.0, new DateTime(2022, 11, 30)),
        new Produto("Manteiga", 8.5, new DateTime(2023, 1, 31)),
        new Produto("Achocolatado", 6.0, new DateTime(2024, 5, 31)),
        new Produto("Refrigerante", 4.5, new DateTime(2023, 7, 31)),
        new Produto("Suco", 3.5, new DateTime(2023, 3, 31)),
        new Produto("Água", 2.0, new DateTime(2024, 2, 29)),
        new Produto("Carne", 25.0, new DateTime(2023, 2, 28)),
        new Produto("Frango", 15.0, new DateTime(2023, 1, 31)),
        new Produto("Peixe", 20.0, new DateTime(2022, 12, 31)),
        new Produto("Batata", 2.5, new DateTime(2022, 10, 31)),
        new Produto("Cebola", 3.0, new DateTime(2023, 3, 31)),
        new Produto("Alho", 2.0, new DateTime(2022, 11, 30)),
        new Produto("Tomate", 3.5, new DateTime(2023, 1, 28)),
        new Produto("Cenoura", 2.5, new DateTime(2023, 1, 31)),
        new Produto("Abóbora", 4.0, new DateTime(2024, 4, 30)),
        new Produto("Beterraba", 2.5, new DateTime(2023, 2, 19))
    };
}