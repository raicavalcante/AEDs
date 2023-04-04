using System;
class Program{
    public static void Main(string[] args){
        // Entrada de dados
        int entrada;
        entrada = int.Parse(Console.ReadLine());
        // Imprimindo resultado
        Console.WriteLine(somaRecursiva(entrada));
    }
    // Criando Função Recursiva
    static int somaRecursiva(int entrada){
        // Condição de parada da recursividade
        if(entrada == 0){
            return entrada;
        }
        // Recursividade
        else{
            return entrada + somaRecursiva(entrada-1);
        }
    }
}
