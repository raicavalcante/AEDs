using System;
class Program{
    public static void Main(string[] args){
        Jogadores[] j = new Jogadores[30];
        Fila fila = new Fila(5);
        int cont = 0;
        string entrada = Console.ReadLine();
        while(entrada != "FIM"){
            j[cont] = new Jogadores();
            j[cont].ler(entrada);
            fila.inserir(j[cont]);
            cont++;
            entrada = Console.ReadLine();
        }
        int entrada2 = int.Parse(Console.ReadLine());
        for(int i = 0; i < entrada2; i++){
            string entrada3 = Console.ReadLine();
            string[] split = entrada3.Split(' ');

            if(split[0] == "R"){
                fila.remover();
                cont--;

            }
            else if(split[0] == "I"){
                j[cont] = new Jogadores();
                j[cont].ler(entrada3);
                if(cont < 5){
                    fila.inserir(j[cont]);
                    cont++;
                }
                else if(cont == 5){
                    fila.remover();
                    fila.inserir(j[cont]);
                    cont--;
                } 
            }
        }
        fila.mostrar();
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

class Fila {
   private Jogadores[] array;
   private int primeiro; // Remove do indice "primeiro".
   private int ultimo; // Insere no indice "ultimo".

   public Fila (int tamanho){
      array = new Jogadores[tamanho+1];
      primeiro = ultimo = 0;
   }
   public void inserir(Jogadores x){
      if (((ultimo + 1) % array.Length) == primeiro) {
        throw new InvalidOperationException("Erro");
      }

      array[ultimo] = x;
      ultimo = (ultimo + 1) % array.Length;
   }
   public Jogadores remover() {
      if (primeiro == ultimo) {
         throw new InvalidOperationException("Erro");
      }

      Jogadores resp = array[primeiro];
      primeiro = (primeiro + 1) % array.Length;
      return resp;
   }
   public bool isCheio() {
      return (primeiro == ultimo + 1); 
   }
   public void mostrar (){
      for(int i = primeiro; i != ultimo; i = (i + 1) % array.Length) {
        array[i].imprimir();
      }
   }
}



