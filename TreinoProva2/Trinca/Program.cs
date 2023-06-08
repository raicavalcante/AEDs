using System;
class Program{
    public static void Main(string[] args){
        int testes = int.Parse(Console.ReadLine());
        for (int i = 0; i < testes; i++)
        {
            int tam = int.Parse(Console.ReadLine());
            int[] array = new int[tam];
            string linha = Console.ReadLine();
            string[] splitada = linha.Split(' ');
            for (int j = 0; j < splitada.Length; j++)
            {
                array[j] = int.Parse(splitada[j]);
            }
            // Ordena
            for(int k = 0; k < tam-1; k++){
                int menor = k;
                for (int l = k + 1; l < tam; l++)
                {
                    if(array[menor] > array[l]){
                        menor = l;
                    }
                }
                int aux = array[menor];
                array[menor] = array[k];
                array[k] = aux;
            }
            int cont = 0;
            for (int x = tam-1; x != 0; x--)// 7 - 2 2 3 3 4 2 2
            {
                // 6
                int maior = x;
                // 6
                for (int y = x; y != 0; y--)
                {   
                    // 6
                    if(array[maior] == array[y-1]){
                        cont++;
                    }
                    
                }
                // Console.WriteLine("Cont" + cont);
                if(cont >= 3){
                        Console.WriteLine(array[maior]);
                        break;
                    }
                maior--;                
            }
            if(cont < 3){
                Console.WriteLine(-1);
            }
        }
    }
}