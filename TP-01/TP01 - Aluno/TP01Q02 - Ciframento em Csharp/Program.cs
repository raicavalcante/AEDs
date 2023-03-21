using System;
class Program{
    public static void Main(string[] args){
        string frase = Console.ReadLine();
        while(frase.ToUpper() != "FIM"){
            Console.WriteLine(ciframento(frase));
            frase = Console.ReadLine();
        }
    }
    public static string ciframento(string frase){
        string frasecesar = "";
        for(int i = 0; i < frase.Length; i++){
            frasecesar += (char)(Convert.ToInt32(frase[i]) + 3);
        }

        return frasecesar;
    }
}
