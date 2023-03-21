using System;
class Program{
    public static void Main(string[] args){
        // Entrada de dados e variáveis
        string frase, contrario = "";
        frase = Console.ReadLine();
        int percorre = frase.Length-1;
        // Chamando a função recursiva e imprimindo resultado
        Console.WriteLine(inverteRecursivo(frase,contrario,percorre));
    }
    // Função Recursiva
    static string inverteRecursivo(string frase, string contrario, int percorre){
        // Condição de parada
        if(percorre < 0){
            return contrario;
        }
        // Operação + recursividade
        else{
            contrario += frase[percorre];
            return inverteRecursivo(frase,contrario,percorre-1);
        }
    }
}