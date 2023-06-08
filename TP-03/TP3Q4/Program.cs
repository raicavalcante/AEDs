using System;
class Program{
    public static void Main(string[] args){
        Geracao G = new Geracao(); 
        string entrada = Console.ReadLine();
        G.lerJogadores(entrada);
        G.Sort();
        G.imp();    
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
    protected Jogadores[] array;
    protected int n;

    public Geracao()
    {
        array = new Jogadores[100];
        n = 0;
    }

    public Geracao(int tamanho)
    {
        array = new Jogadores[tamanho];
        n = 0;
    }
    public Jogadores[] GetArray()
    {
        return array;
    }

    public void lerJogadores(string entrada){
        while(entrada != "FIM"){
            array[n] = new Jogadores();
            array[n].ler(entrada);
            n++;
            entrada = Console.ReadLine();
        }
    }
    public void Swap(int i, int j)
    {
        Jogadores temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }

    public void Sort() {
      SortQuicksort(0, n-1);
    }

    private void SortQuicksort(int esq, int dir) {
        int i = esq, j = dir;
        Jogadores pivo = array[(dir+esq)/2];
        while (i <= j) {
            while (String.Compare(array[i].nome , pivo.nome) < 0) i++;
            while (String.Compare(array[j].nome , pivo.nome) > 0) j--;
            if (i <= j) {
                Swap(i, j);
                i++;
                j--;
            }
        }
        if (esq < j)  SortQuicksort(esq, j);
        if (i < dir)  SortQuicksort(i, dir);
    }

    public void imp(){
        for (int i = 0; i < n; i++)
        {
            array[i].imprimir();
        }
    }
}
