using System;
class Program{
    public static void Main(string[] args){
        // Declarando variáveis
        int numero, expoente, resp = 1;
        // Entrada de dados
        numero = int.Parse(Console.ReadLine());
        expoente = int.Parse(Console.ReadLine());
        // Chamando a função Recursiva
        Console.WriteLine(potenciaRecursivo(numero,expoente,resp));
    }

    // Declarando a função recursiva
    static int potenciaRecursivo(int numero, int expoente, int resp){
        // Condição de parada 
        if(expoente == 0){
            return resp;
        }
        // Fazendo a operação por Recursividade
        else{
            resp *= numero;
            return potenciaRecursivo(numero,expoente-1,resp);
        }
    }
}