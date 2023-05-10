using System;
class Program{
    public static void Main(string[] args){
        /* Uma desvantagem do algoritmo de Inserção é que quando ele insere um novo
        elemento na parte ordenada, ele efetua uma pesquisa sequencial para
        encontrar a posição do novo elemento. Explique e apresente uma proposta de
        melhoria para o algoritmo. Implemente e apresente a complexidade de sua solução. */

        int[] array = new int[10];
        int cont = 0;
        Random R = new Random();
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = R.Next(0,20);
            Console.Write(array[i] + " ");

        }

        for (int i = 1; i < array.Length; i++) {
			int tmp = array[i];
            int j = i - 1;
            int indice = BinarySearch(array,tmp,0,j);

            while (j >= indice) {
                array[j + 1] = array[j];
                j--;
                cont++;
            }
            array[j + 1] = tmp;
        }
        Console.WriteLine();
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
        Console.WriteLine("Contador: " + cont);
        
        /* Uma forma de melhorar esse algoritmo é implementar um BinarySearch na hora de comparar os elementos.
          Logo a complexidade das comparações que seria N, torna-se lg(N)*/
        
        
    }
    public static int BinarySearch(int[] arr, int target, int left , int right)
    {
        while (left <= right)
        {
            int mid = left + (right - left)  / 2;

            if (arr[mid] == target)
            {
                return mid;
            }
            else if (arr[mid] < target)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }

        return left;
    }

}