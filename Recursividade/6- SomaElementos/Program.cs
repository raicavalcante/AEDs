using System;
class Program{
    public static void Main(string[] args){
        int percorre = 0;
        int resp = 0;
        // Entrada de dados do tamanho da lista(vetor)
        Console.Write("Digite o tamanho da lista: ");
        int tam = int.Parse(Console.ReadLine());
        int[] entradas = new int [tam];
        // Chamando função recursiva para preencher a lista(vetor)
        preencheRecursivo(entradas,percorre,tam);
        // Calculando os números da lista através de uma função recursiva e imprimindo o resultado
        Console.WriteLine(calculaRecursivo(entradas,percorre,tam,resp));
    }

    // Criando Função Recursiva que preenche o vetor
    static int[] preencheRecursivo(int[] entradas, int percorre, int tam){
        // Condição de parada
        if(percorre == tam){
            percorre = 0;
            return entradas;
        }
        // Entrada de dados + recursividade
        else{
            entradas[percorre] = int.Parse(Console.ReadLine());
            return preencheRecursivo(entradas,percorre+1,tam);
        }
    }

    // Criando função recursiva que calcula os números
    static int calculaRecursivo(int[] entradas, int percorre, int tam, int resp){ 
        // Condição de parada
        if(percorre == tam){
            return resp;
        }
        // Soma + Recursividade
        else{
            resp += entradas[percorre];
            return calculaRecursivo(entradas,percorre+1,tam,resp);
        }

    }
}