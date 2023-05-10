using System;
class Program{
    public static void Main(string[] args){
        /* Considere o algoritmos de ordenação por inserção. Reimplemente de forma
        que o laço externo, que define o índice do elemento a ser inserido, seja feito de
        forma recursiva. Obs. O laço interno pode ser feito de forma iterativa*/
        int[] array = new int[10];
        int x = 10;
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = x;
            x--;
            Console.Write(array[i] + " ");  
        }
        Insercao(array,1);
        Console.WriteLine();
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        
    }
    public static void Insercao(int[] array, int i){
        int tmp = array[i];
        int j = i - 1;
        if(i < array.Length){
            while ((j >= 0) && (array[j] > tmp)) {
                array[j + 1] = array[j];
                j--;
                Insercao(array,i++);
            }
        }
        else{
            array[j + 1] = tmp;
        }
    }
}
