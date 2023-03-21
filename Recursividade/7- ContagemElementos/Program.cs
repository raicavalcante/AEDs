using System;
class Program{
    public static void Main(string[] args){
        int tam;
        int percorre = 0;
        int cont = 0;
        // Entrada de dados com o tamanho do vetor
        Console.Write("Digite o tamanho da lista: ");
        tam = int.Parse(Console.ReadLine());
        int[] numeros = new int[tam];
        // Chamando função recursiva para preencher a lista(vetor)
        preencheRecursivo(numeros,percorre,tam);
        // Chamando função recursiva que verifica os numeros positivos e imprime a resposta
        Console.WriteLine(contagemRecursiva(numeros,percorre,tam,cont));
    }

    // Criando Função Recursiva que preenche o vetor
    static int[] preencheRecursivo(int[] numeros, int percorre, int tam){
        // Condição de parada
        if(percorre == tam){
            percorre = 0;
            return numeros;
        }
        // Entrada de dados + recursividade
        else{
            numeros[percorre] = int.Parse(Console.ReadLine());
            return preencheRecursivo(numeros,percorre+1,tam);
        }
    }

    // Criando Função Recursiva que verifica e faz a contagem de positivos
    static int contagemRecursiva(int[] numeros, int percorre, int tam, int cont){
        // Condição de parada
        if(percorre == tam){
            return cont;
        }
        // Recursividade
        else{
            // Verificando se é positivo
            if(numeros[percorre] >= 0){
                // Fazendo a contagem
                cont++;
            }
            return contagemRecursiva(numeros,percorre+1,tam,cont);
        }
    }
}
