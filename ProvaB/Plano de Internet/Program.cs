using System;
class Program{
    public static void Main(string[] args){
        int cota,N,sobrou=0;
        cota = int.Parse(Console.ReadLine());
        N = int.Parse(Console.ReadLine());
        int usados;
        for(int i = 0; i < N; i++){
            usados = int.Parse(Console.ReadLine());
            sobrou += cota;
            sobrou -= usados;
        }
        Console.WriteLine(sobrou + cota);
    }
}
