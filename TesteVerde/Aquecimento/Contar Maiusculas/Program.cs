using System;
class Program{
    public static void Main(string[] args){
        string frase;
        frase = Console.ReadLine();
        while(frase != "FIM"){
        Console.WriteLine(conta(frase));
        frase = Console.ReadLine();
        }
    }
    public static int conta(string frase){
        int cont=0;
        for(int i = 0; i < frase.Length; i++){
            if(char.IsUpper(frase[i])){
                cont++;
            }
        }
        return cont;
    }
}
