using System;
class Program{
    public static void Main(string[] args){
        Jogadores[] j = new Jogadores[30];
        Geracao G = new Geracao(30);
        int cont = 0;
        int[] ordenados = new int[30];
        string entrada = Console.ReadLine();
        while(entrada != "FIM"){
            j[cont] = new Jogadores();
            j[cont].ler(entrada);
            ordenados[cont] = j[cont].id;
            cont++;
            entrada = Console.ReadLine();
        }
        G.Entrada(ordenados);
        G.Sort();
        int aux = 0;
        for(int k = 0; k < j.Length; k++){
            for (int i = 0; i < cont; i++){
                // Console.WriteLine(G.GetArray()[aux]);
                // Console.WriteLine(j[i].id);
                // Console.WriteLine("Contador:" + i);
                // Console.WriteLine("---");
                if (G.GetArray()[aux] == j[i].id)
                {
                    j[i].imprimir();
                }
            }
            aux++;
        }
    }
}
class Jogadores{

    public string nome;
    public string foto;
    public string nascimento;
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
        nascimento = splitada[3];
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
        Console.Write(nascimento);
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

    public void Sort()
    {
        for (int i = 1; i < n; i++) {
			int tmp = array[i];
            int j = i - 1;

            while ((j >= 0) && (array[j] > tmp)) {
                array[j + 1] = array[j];
                j--;
            }
            array[j + 1] = tmp;
        }
    }
}
