using System;
class Program{
    public static void Main(string[] args){
        // Declarando variáveis
        int numero;
        // Entrada de dados do n-ésimo numero
        numero = int.Parse(Console.ReadLine());
        // Chamando a função que calcula o número de fibonacci e imprime o resultado
        Console.WriteLine(fibonacciRecursivo(numero));
    }

    // Criando a função recursiva que calcula a sequência de fibonacci
    static int fibonacciRecursivo(int numero){
        // Condição de parada
        if(numero < 2){
            return numero;
        }
        // Recursividade
        else{
            return fibonacciRecursivo(numero - 1) + fibonacciRecursivo (numero - 2);
        }
    }
}