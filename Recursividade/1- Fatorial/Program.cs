using System;
class Program{
    public static void Main(string[] args){
        // Entrada de dados
        int entrada;
        entrada = int.Parse(Console.ReadLine());
        // Declarando variável para condição de parada
        int parada = entrada - 1;
        // Imprimindo resultado
        Console.WriteLine(fatorialRecursivo(entrada,parada));
    }
    // Criando Função Recursiva
    static int fatorialRecursivo(int entrada,int parada){
        // Condição de parada da recursividade
        if(parada == 1){
            return entrada;
        }
        // Recursividade
        else{
            entrada *= parada;
            return fatorialRecursivo(entrada,parada-1);
        }
    }
}
