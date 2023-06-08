using System;
class Program{
    public static void Main(string[] args){
        Jogadores[] j = new Jogadores[30]; 
        Geracao G = new Geracao(30); 
        int[] date = new int[30];
        int cont = 0;
        int[] ordenados = new int[30];
        string entrada = Console.ReadLine();
        while(entrada != "FIM"){
            j[cont] = new Jogadores();
            j[cont].ler(entrada);
            DateTime data1, data2;
            data1 = DateTime.Parse("28/05/2023");
            data2 = j[cont].nascimento;
            TimeSpan result = new TimeSpan();
            result = data1 - data2;
            int diferenca = result.Days;
            date[cont] = diferenca;
            ordenados[cont] = diferenca;
            cont++;
            entrada = Console.ReadLine();
        }
        G.Entrada(ordenados);
        G.Sort();
        // int datef = cont-1; // 13
        // int ordenadosf = ordenados.Length - cont; // 16
        // for (int i = 0; i < date.Length; i++)
        // {
        //     Console.WriteLine(date[i]);
        // }
        // Console.WriteLine(cont);
        int aux = ordenados.Length-1;
        for(int k = 0; k < cont; k++){
            for (int i = 0; i < cont; i++){
                if (date[i] == G.GetArray()[aux])
                {
                    j[i].imprimir();
                }
            }
            aux--;
        }
    }
}
class Jogadores{

    public string nome;
    public string foto;
    public DateTime nascimento;
    public int id;
    public int[] times;
    
    public void ler(string entrada){
        int conttimes = 6;
        string exclui = entrada.Replace('"' , '$');
        string exclui0 = exclui.Replace("[" , "$");
        string exclui1 = exclui0.Replace("]" , "$");
        string exclui2 = exclui1.Replace("$", "");
        entrada = exclui2;
        string[] splitada = entrada.Split(',');
        
        id = int.Parse(splitada[5]);
        nome = splitada[1];
        foto = splitada[2];
        nascimento = DateTime.Parse(splitada[3]);
        if(splitada.Length <= 7){
            times = new int[1];
            times[0] = int.Parse(splitada[6]); 
        }
        else{
            times = new int[splitada.Length-6]; 

            for(int i = 0; i < times.Length; i++){
                times[i] = int.Parse(splitada[conttimes]);
                conttimes++;
            }
        }
    }
    public void imprimir(){
        Console.Write(id);
        Console.Write(" ");
        Console.Write(nome);
        Console.Write(" ");
        Console.Write(nascimento.ToString("d/MM/yyyy"));
        Console.Write(" ");
        Console.Write(foto);
        Console.Write(" ");
        Console.Write("(");
        for(int i = 0; i < times.Length; i++){
            if(times.Length == 1){
                Console.Write(times[i]);
            }
            else{
                Console.Write(times[i]);
                if(i == times.Length-1){
                    break;
                }
                else{
                    Console.Write(", ");
                }
            }
        }
        Console.Write(")");
        Console.WriteLine();
    }
}
class Geracao : Jogadores{
    protected int[] array;
    protected int n;

    public Geracao()
    {
        array = new int[100];
        n = array.Length;
    }

    public Geracao(int tamanho)
    {
        array = new int[tamanho];
        n = array.Length;
    }
    public int[] GetArray()
    {
        return array;
    }

    public void EntradaPadrao()
    {
        n = Convert.ToInt32(Console.ReadLine());
        array = new int[n];

        for (int i = 0; i < n; i++)
        {
            array[i] = Convert.ToInt32(Console.ReadLine());
        }
    }

    public void Entrada(int[] vet)
    {
        n = vet.Length;
        array = new int[n];
        for (int i = 0; i < n; i++)
        {
            array[i] = vet[i];
        }
    }
    public bool IsOrdenado()
    {
        bool resp = true;
        for (int i = 1; i < n; i++)
        {
            if (array[i] < array[i - 1])
            {
                i = n;
                resp = false;
            }
        }
        return resp;
    }
    public void Swap(int i, int j)
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }

    public void Sort() {
      SortMergesort(0, n-1);
   }

   private void SortMergesort(int esq, int dir) {
      if (esq < dir){
         int meio = (esq + dir) / 2;
         SortMergesort(esq, meio);
         SortMergesort(meio + 1, dir);
         Intercalar(esq, meio, dir);
      }
   }

   public void Intercalar(int esq, int meio, int dir){
      int n1, n2, i, j, k;

      //Definir tamanho dos dois subarrays
      n1 = meio-esq+1;
      n2 = dir - meio;

      int[] a1 = new int[n1+1];
      int[] a2 = new int[n2+1];

      //Inicializar primeiro subarray
      for(i = 0; i < n1; i++){
         a1[i] = array[esq+i];
      }

      //Inicializar segundo subarray
      for(j = 0; j < n2; j++){
         a2[j] = array[meio+j+1];
      }

      //Sentinela no final dos dois arrays
      a1[i] = a2[j] = 0x7FFFFFFF;

      //Intercalacao propriamente dita
      for(i = j = 0, k = esq; k <= dir; k++){
         array[k] = (a1[i] <= a2[j]) ? a1[i++] : a2[j++];
      }
   }
}
