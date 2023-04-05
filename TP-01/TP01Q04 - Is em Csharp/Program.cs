using System;
class Program{
    public static void Main(string[] args){
        string frase;
        frase = Console.ReadLine();
        while(frase != "FIM"){
            Console.Write(verificavogais(frase)?"SIM" : "NAO");
            Console.Write(" ");
            Console.Write(verificaconsoantes(frase)?"SIM" : "NAO");
            Console.Write(" ");
            Console.Write(verificainteiros(frase)?"SIM" : "NAO");
            Console.Write(" ");
            Console.WriteLine(verificareal(frase)?"SIM" : "NAO");
            frase = Console.ReadLine();
        }
    }
    public static bool verificavogais(string frase){
        int cont = 0;
        bool resp = false;
        for(int i = 0; i < frase.Length; i++){
            if(frase[i] == 'a' || frase[i] == 'e' || frase[i] == 'i' || frase[i] == 'o' || frase[i] == 'u'){
                cont++;
            }
        }
        if(cont == frase.Length){
            resp = true;
        }
        return resp;
    }

    public static bool verificaconsoantes(string frase){
        int cont = 0;
        bool resp = false;
        for(int i = 0; i < frase.Length; i++){
            if(frase[i] == 'a' || frase[i] == 'e' || frase[i] == 'i' || frase[i] == 'o' || frase[i] == 'u'){
                cont++;
            }
            if(frase[i] >= 0){
                resp = false;
                return resp;
            }
        }
        if(cont == 0){
            resp = true;
        }
        return resp;
    }

    public static bool verificainteiros(string frase){
        bool resp = false;
        if(int.TryParse(frase, out int teste)){
            resp = true;
        }
        return resp;
    }

    public static bool verificareal(string frase){
        bool resp = false;
        int cont = 0;
        for(int i = 0; i < frase.Length; i++){
            if(frase[i] == '.' || frase[i] == ','){
                cont++;
            }
        }
        for(int i = 0; i < frase.Length; i++){
            if(frase[i] != '1' && frase[i] != '2' && frase[i] != '3' && frase[i] != '4' && frase[i] != '5' && frase[i] != '6' && frase[i] != '7' && frase[i] != '8' && frase[i] != '9' && frase[i] != '0' && frase[i] != '.' && frase[i] != ',' && frase[i] != '-'){
                resp = false;
                return resp;
            }
        }
        if(cont <= 1){
            resp = true;
        }
        return resp;
    }
}