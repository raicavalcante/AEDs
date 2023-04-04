using System;
class Program{
    public static void Main(string[] args){
        // Entrada de dados
        int entrada;
        entrada = int.Parse(Console.ReadLine());
        // Imprimindo resultado
        Console.WriteLine(fatorialRecursivo(entrada));
    }
    // Criando Função Recursiva
    static int fatorialRecursivo(int entrada){
        // Condição de parada da recursividade
        if(entrada == 1){
            return entrada;
        }
        // Recursividade
        else{
            return entrada * fatorialRecursivo(entrada-1);
        }
    }
}
