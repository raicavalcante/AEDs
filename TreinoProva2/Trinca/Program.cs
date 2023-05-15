using System;
using System.Collections.Generic;
class Program{
    public static void Main(string[] args){
        int qntd = int.Parse(Console.ReadLine());
        List<int> list = new List<int>();
        for (int i = 0; i < qntd; i++)
        {
            int tam = int.Parse(Console.ReadLine());
            int[] array = new int[tam];
            for (int j = 0; j < tam; j++)
            {
                array[j] = int.Parse(Console.ReadLine());
                list.Add(array[j]);
            }
            list.Sort();
            int[] ordenado = list.ToArray();
            for (int k = 0; k < ordenado.Length; k++)
            {
                if(ordenado[k] == ordenado[k+1] && ordenado[k+1] == ordenado[k+2]){
                    Console.WriteLine(k);
                }
                else{
                    Console.WriteLine(-1);
                }
                
            }
        }
    }
}
