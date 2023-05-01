using System;
class Program{
    public static void Main(string[] args){
        Jogadores[] j = new Jogadores[30];
        Lista lista = new Lista(20);
        int cont = 0;
        string entrada = Console.ReadLine();
        while(entrada != "FIM"){
            j[cont] = new Jogadores();
            j[cont].ler(entrada);
            lista.inserirFim(j[cont]);
            cont++;
            entrada = Console.ReadLine();
        }
        int entrada2 = int.Parse(Console.ReadLine());
        int pos;
        for(int i = 0; i < entrada2 ; i++){
            string entrada3 = Console.ReadLine();
            string[] split = entrada3.Split(' ');
            if(split[0] == "II"){
                j[cont] = new Jogadores();
                j[cont].ler(entrada3);
                lista.inserirInicio(j[cont]);
            }
            else if(split[0] == "I*"){
                pos = int.Parse(split[1]);
                j[cont] = new Jogadores();
                j[cont].ler(entrada3);
                lista.inserir(j[cont],pos);
            }
            else if(split[0] == "R*"){
                pos = int.Parse(split[1]);
                lista.remover(pos);
            }
            else if(split[0] == "IF"){
                j[cont] = new Jogadores();
                j[cont].ler(entrada3);
                lista.inserirFim(j[cont]);
            }
            else if(split[0] == "RF"){
                lista.removerFim();
            }
            else if(split[0] == "RI"){
                lista.removerInicio();
            }
        }
        lista.imprimirLista();
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

class Lista{
   private Jogadores[] array;
   private int n;
   public Lista (int tamanho){
      array = new Jogadores[tamanho];
      n = 0;
   }
   public void inserirInicio(Jogadores x) {
      if(n >= array.Length){
         throw new Exception("Erro ao inserir!");
      } 
      for(int i = n; i > 0; i--){
         array[i] = array[i-1];
      }

      array[0] = x;
      n++;
   }
   public void inserirFim(Jogadores x){
      if(n >= array.Length){
         throw new Exception("Erro ao inserir!");
      }
      array[n] = x;
      n++;
   }
   public void inserir(Jogadores x, int pos){
      if(n >= array.Length || pos < 0 || pos > n){
         throw new Exception("Erro ao inserir!");
      }
      for(int i = n; i > pos; i--){
         array[i] = array[i-1];
      }
      array[pos] = x;
      n++;
   }
   public Jogadores removerInicio(){
      if (n == 0) {
         throw new Exception("Erro ao remover!");
      }

      Jogadores resp = array[0];
      n--;

      for(int i = 0; i < n; i++){
         array[i] = array[i+1];
      }

      return resp;
   }
   public Jogadores removerFim(){
      if (n == 0) {
         throw new Exception("Erro ao remover!");
      }

      return array[--n];
   }
   public Jogadores remover(int pos){
      if (n == 0 || pos < 0 || pos >= n) {
         throw new Exception("Erro ao remover!");
      }

      Jogadores resp = array[pos];
      n--;

      for(int i = pos; i < n; i++){
         array[i] = array[i+1];
      }

      return resp;
   }
   public void mostrar (){
      Console.Write("[ ");
      for(int i = 0; i < n; i++){
         Console.Write(array[i] + " ");
      }
      Console.WriteLine("]");
   }
   public bool pesquisar(Jogadores x){
      bool retorno = false;
      for (int i = 0; i < n && retorno == false; i++) {
        retorno = (array[i] == x);
      }
      return retorno;
   }

   public void imprimirLista(){
        for (int i = 0; i < n; i++)
        {
            array[i].imprimir();  
        }
   }
}

