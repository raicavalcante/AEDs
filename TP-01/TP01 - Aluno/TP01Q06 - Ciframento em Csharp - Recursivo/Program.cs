using System;
class Program{
    public static void Main(string[] args){
        string frase = Console.ReadLine();
        string frasecesar = "";
        while(frase != "FIM"){
            int tam = 0;
            Console.WriteLine(recursivo(frase,tam,frasecesar));
            frase = Console.ReadLine();
        }
    }
    public static string recursivo(string frase, int tam, string frasecesar){
        if(tam == frase.Length){
            return frasecesar;
        }
        else{
            frasecesar += (char)(Convert.ToInt32(frase[tam]) + 3);
            frasecesar = recursivo(frase,tam+1,frasecesar);
        }
        return frasecesar;
    }
}