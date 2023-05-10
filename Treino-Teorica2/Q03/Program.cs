using System;
class Program{
    public static void Main(string[] args){
        /* Considere uma fila circular vista em aula. Implemente o algoritmo de seleção nesta fila.
        Considere que a classe fila circular possua os atributos
        int array[];
        int inicio, fim;
        Considere que também já estejam implementados os métodos de inserção, remoção e mostrar vistos em aula.
        Implemente o método void ordenarPorSelecao(); */
        Fila fila = new Fila(10);
        int x = 10;
        for (int i = 0; i < fila.tamanho; i++)
        {
            fila.inserir(x);
            x--;
        }
        fila.mostrar();
        fila.remover();
        fila.remover();
        fila.mostrar();
        fila.ordenarPorSeleção();
        fila.mostrar();
        
    }

}
class Fila {
   private int[] array;
   private int inicio; // Remove do indice "inicio".
   private int fim; // Insere no indice "fim".

   public int tamanho = 10;

   public Fila (int tamanho){
      array = new int[tamanho+1];
      inicio = fim = 0;
   }

   public void inserir(int x){

      //validar insercao
      if (((fim + 1) % array.Length) == inicio) {
         throw new InvalidOperationException("Erro");
      }

      array[fim] = x;
      fim = (fim + 1) % array.Length;
   }

   public int remover() {

      //validar remocao
      if (inicio == fim) {
         throw new InvalidOperationException("Erro");
      }

      int resp = array[inicio];
      inicio = (inicio + 1) % array.Length;
      return resp;
   }

   public void mostrar (){
      Console.Write("[ ");

      for(int i = inicio; i != fim; i = ((i + 1) % array.Length)) {
         Console.Write(array[i] + " ");
      }

      Console.WriteLine("]");
   }
   
   public void ordenarPorSeleção(){
    for (int i = inicio; i != fim; i = ((i + 1) % array.Length)) {
         int menor = i;
         for (int j = (i + 1); j < fim; j++){
            if (array[menor] > array[j]){
               menor = j;
            }
         }
         Swap(menor, i);
      }
    }

    public void Swap(int i, int j) {
      int temp = array[i];
      array[i] = array[j];
      array[j] = temp;
   }
}