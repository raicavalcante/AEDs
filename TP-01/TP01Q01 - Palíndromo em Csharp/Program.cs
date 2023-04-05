using System;
class Program{
    public static void Main(string[] args){
        string frase;
        frase = Console.ReadLine();
        while(frase != "FIM"){
        Console.WriteLine(verifica(frase));
        frase = Console.ReadLine();
        }

    }
    public static string verifica(string frase){
        string palindromo = "";
        string resp;
        for(int i = frase.Length-1; i >= 0; i--){
            palindromo += frase[i];
        }
        if(palindromo == frase){
            resp = "SIM";
            return resp;
        }
        else{
            resp = "NAO";
            return resp;
        }

    }
}