using System;
using System.Collections;
class Program{
    public static void Main(string[] args){
        /* Considere a class Qualquer que possui um atributo numeros que é um
        ArrayList de inteiros. Considere também que este atributo já está preenchido
        com vários números. Faça o método void ImprimeDivisiveis() que mostra na
        tela todos número que são divisíveis por 3 ou 7*/
        Lista lista = new Lista(10);
        int x = 10;
        for (int i = 0; i < lista.n; i++)
        {
            lista.numeros.Add(x);
            Console.Write(lista.numeros[i] + " ");
            x--;
        }
        Console.WriteLine();
        ImprimeDivisiveis(lista.numeros);
        
    }
    public static void ImprimeDivisiveis(ArrayList array){
        for (int i = 0; i < 10; i++)
        {
            if((int)array[i] % 3 == 0 || (int)array[i] % 7 == 0){
                Console.Write(array[i] + " ");
            }
        }
    }
}

class Lista{
    public ArrayList numeros;
    public int n;

    public Lista(int tamanho){
        ArrayList numeros = new ArrayList(tamanho);
        n = tamanho;
    }
}
