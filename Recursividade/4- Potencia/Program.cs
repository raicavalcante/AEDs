using System;
class Program{
    public static void Main(string[] args){
        // Declarando variáveis
        int numero, expoente;
        // Entrada de dados
        numero = int.Parse(Console.ReadLine());
        expoente = int.Parse(Console.ReadLine());
        // Chamando a função Recursiva
        Console.WriteLine(potenciaRecursivo(numero,expoente));
    }

    // Declarando a função recursiva
    static int potenciaRecursivo(int numero, int expoente){
        // Condição de parada 
        if(expoente == 1){
            return numero;
        }
        // Fazendo a operação por Recursividade
        else{
            return numero * potenciaRecursivo(numero,expoente-1);
        }
    }
}