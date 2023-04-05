using System;
class Program{
    public static void Main(string[] args){
        string frase;
        Console.WriteLine("valores: m e d");
        frase = Console.ReadLine();
        while(frase != "FIM"){
            Console.WriteLine(sorteia(frase));
            frase = Console.ReadLine();
        }
    }
    public static string sorteia(string frase){
        string resp = "";
        Random gerador = new Random(4);
        char aleatorio = (char)('a' + (Math.Abs(gerador.Next()) % 26));
        char aleatorio2 = (char)('a' + (Math.Abs(gerador.Next()) % 26));
        for(int i = 0; i < frase.Length ; i++){
            if(frase[i] == aleatorio){
                resp += aleatorio2;
            }
            else{
                resp += frase[i];
            }
        }
        return resp;
    }
}