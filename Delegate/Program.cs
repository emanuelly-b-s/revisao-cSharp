 using System.Collections.Generic;
 using System.Lnq;

delegate int formataInt(int input);

int duplica(int input) => input * 2;

List<int> lista = new List<int> {2, 3, 5, 6};

List<int> Duplica(List<int> lista, formataInt minhaFuncao)
{
    var novaLista = new List<int>();

    foreach (var item in lista)
    {
        novaLista.Add(minhaFuncao(i));
    }

    return novaLista;
}