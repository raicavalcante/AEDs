using System;
class Program{
    public static void Main(string[] args){
        int qntfigurinhas = int.Parse(Console.ReadLine());
        int diferentes = 0, repetidas = 0;
        int[] figurinhas = new int[qntfigurinhas];
        
        for (int i = 0; i < qntfigurinhas; i++)
        {
            figurinhas[i] = int.Parse(Console.ReadLine());
            diferentes++;
        }
        for(int i = 0; i < qntfigurinhas-1; i++){
            int menor = i;
            for(int j = i + 1; j < qntfigurinhas; j++){
                if(figurinhas[menor] > figurinhas[j]){
                    menor = j;
                }
            }
            int temp = figurinhas[menor];
            figurinhas[menor] = figurinhas[i];
            figurinhas[i] = temp;
        }
        for (int i = 0; i < qntfigurinhas; i++)
        {   
            if(i < qntfigurinhas-1){
                if(figurinhas[i] == figurinhas[i+1]){
                    diferentes--;
                    repetidas++;
                }
            }
            else{

            }
        }
        Console.WriteLine(diferentes);
        Console.WriteLine(repetidas);
    }
}
