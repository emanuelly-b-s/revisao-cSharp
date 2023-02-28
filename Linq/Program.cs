using System.Collections.Generic;
using System;
using System.Linq;
using static System.Console;

Estoque estoque = new Estoque();

Pesquisa.ValoresOrdenados(estoque);
WriteLine();
Pesquisa.NomesOrdenados(estoque);
WriteLine();
public class Pesquisa
{

    // 1 -Liste todos os produtos do estoque, do mais barato ao mais caro.
    public static void ValoresOrdenados(Estoque listP)
    {
        Console.WriteLine("Produtos ordenados pelo valor\n");
        var listOrd = listP.ListaProdutos.OrderBy(p => p.Valor).ToList();

        foreach (var item in listOrd)
        {
            Console.WriteLine(item);
        }
    }

    // 2 - Liste os produtos por ordem alfabética.
    public static void NomesOrdenados(Estoque listP)
    {
        Console.WriteLine("Produtos ordenados por ordem alfabetica\n");
        var listOrd = listP.ListaProdutos.OrderBy(p => p.Nome).ToList();

        foreach (var item in listOrd)
        {
            Console.WriteLine(item);
        }
    }
}





// 3 - Encontre a média de preço dos produtos, mostre a média, e todos os produtos com o preço acima dela


// 4 - Liste os produtos vencidos


// 5 - Implemente uma função que receba a lista de estoque e uma data utilizando o tipo DateTime, 
// esta função deve retornar uma lista que contendo todos os produtos que irão expirar até esta data
// Ex: WillExpirate(List<estoque> estoque, DateTime dataDesejada) { }


// 6 - Implemente uma função chamada valorMínimo, que tenha como parâmetro a lista de estoque e o valor mínimo
// que a lista deve filtrar, utilize o LINQ para retornar todos os valores acima do valorMínimo
// Ex: getByMinValue(List<estoque> estoque, double minValue)


// 7 - Assim como no exercício 6, implemente agora uma função que pegue todos os valores menores que o valor máximo
// Ex: getByMaxValue(List<estoque> estoque, double maxValue)
