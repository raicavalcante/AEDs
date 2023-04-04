using System;
class Program{
    public static void Main(string[] args){
        int sensor,capacidade,compara = 0,s,e;
        string entrada;
        string[] splitada;
        entrada = Console.ReadLine();
        splitada = entrada.Split(' ');
        sensor = int.Parse(splitada[0]);
        capacidade = int.Parse(splitada[1]);
        for(int i = 0; i < sensor; i++){
            entrada = Console.ReadLine();
            splitada = entrada.Split(' ');
            s = int.Parse(splitada[0]);
            e = int.Parse(splitada[1]);
            compara -= s;
            compara += e;
            if(compara > capacidade){
                Console.WriteLine("S");
                break;
            }
            else if(i == 4){
                Console.WriteLine("N");
            }
        }
    }
}