using System;
using System.Collections.Generic;
class Program{
    public static void Main(string[] args){
        int qntfigurinhas = int.Parse(Console.ReadLine());
        int diferentes = 0, repetidas =0;
        List<int> figurinhas = new List<int>();
        for (int i = 0; i < qntfigurinhas; i++)
        {
            figurinhas.Add(int.Parse(Console.ReadLine()));
        }
        figurinhas.Sort();
        int[] compara = figurinhas.ToArray();

        for (int i = 0; i < qntfigurinhas; i++)
        {
            if(compara[i] == compara[i+1]){ // 12 , 65 , 65
                repetidas++; // 1
            }
            else{
                diferentes++; //1
            }
            if(compara[i] == compara[i-1]){
                
            }
        }
        Console.WriteLine(diferentes);
        Console.WriteLine(repetidas);
    }
}
