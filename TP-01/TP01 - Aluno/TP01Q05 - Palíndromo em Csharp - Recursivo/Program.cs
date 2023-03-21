using System;
class Program{
    public static void Main(string[] args){
        string frase;
        frase = Console.ReadLine();
        while(frase != "FIM"){
            int tam = frase.Length;
            int ini = 0;
            int fim = tam-1;
            Console.WriteLine(recursivo(frase,ini,fim));
            frase = Console.ReadLine();
        }
    }

    public static string recursivo(string frase, int ini, int fim){
        if(ini >= fim){
            return "SIM";
        }
        else{
            if(frase[ini] == frase[fim]){
                return recursivo(frase,ini+1,fim-1);
            }
        }
        return "NAO";
    }

    /*public static string recursivoPA(string frase, int cont){
        string palindromo = "";
        string resp = "";
        if(cont >= 0){
            palindromo += frase[cont-1];
            palindromo = recursivoPA2(frase,palindromo,cont-2);
        }
        Console.WriteLine("fim + {0}" , palindromo);
        if(palindromo == frase){
            resp = "SIM";
            return resp;
        }
        else{
            resp = "NAO";
            return resp;
        }
    }
    static string recursivoPA2(string frase, string palindromo, int cont){
        if(cont >= 0){
            Console.WriteLine("1 - " + palindromo);
            palindromo += frase[cont];
            Console.WriteLine("2 - " + palindromo);
            recursivoPA2(frase,palindromo,cont-1);
        }
        Console.WriteLine(cont);
        Console.WriteLine("3 - " + palindromo);
        return palindromo;
    }*/
}