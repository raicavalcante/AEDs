using System;
class Program{
    public static void Main(string[] args){
        // Entrada de dados
        int entrada;
        entrada = int.Parse(Console.ReadLine());
        // Declarando variável para condição de parada
        int parada = entrada - 1;
        // Imprimindo resultado
        Console.WriteLine(somaRecursiva(entrada,parada));
    }
    // Criando Função Recursiva
    static int somaRecursiva(int entrada,int parada){
        // Condição de parada da recursividade
        if(parada == 0){
            return entrada;
        }
        // Recursividade
        else{
            entrada += parada;
            return somaRecursiva(entrada,parada-1);
        }
    }
}
