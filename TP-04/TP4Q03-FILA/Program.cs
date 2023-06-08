using System;
class Program{
    public static void Main(string[] args){
        Fila fila = new Fila();
        string entrada = Console.ReadLine();
        while(entrada != "FIM"){
            Jogadores Tmp = new Jogadores();
            Tmp.ler(entrada);
            fila.inserir(Tmp);
            entrada = Console.ReadLine();
        }
        int entrada2 = int.Parse(Console.ReadLine());
        for(int i = 0; i < entrada2 ; i++){
            string entrada3 = Console.ReadLine();
            string[] split = entrada3.Split(' ');
            if(split[0] == "I"){
                Jogadores Tmp = new Jogadores();
                Tmp.ler(entrada3);
                fila.inserir(Tmp);
            }
            else if(split[0] == "R"){
                fila.remover();
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

class Celula {
	public Jogadores elemento; // Elemento inserido na celula.
	public Celula prox; // Aponta a celula prox.

	// public Celula() {
	// 	this(0);
	// }

	public Celula(Jogadores elemento) {
      this.elemento = elemento;
      this.prox = null;
	}
}
class Fila {
	private Celula primeiro;
	private Celula ultimo;
	public Fila() {
        Jogadores Rai = new Jogadores(); // Café com leite
		primeiro = new Celula(Rai);
		ultimo = primeiro;
	}
	public void inserir(Jogadores x) {
		ultimo.prox = new Celula(x);
		ultimo = ultimo.prox;
	}
	public Jogadores remover(){
		if (primeiro == ultimo) {
			throw new Exception("Erro ao remover!");
		}

        Celula tmp = primeiro;
        primeiro = primeiro.prox;
        Jogadores resp = primeiro.elemento;
        tmp.prox = null;
        tmp = null;
		return resp;
	}

	public void mostrar() {
		for(Celula i = primeiro.prox; i != null; i = i.prox) {
			i.elemento.imprimir();
		}
	}
}