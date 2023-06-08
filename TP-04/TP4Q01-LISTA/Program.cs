using System;
class Program{
    public static void Main(string[] args){
        Lista lista = new Lista();
        string entrada = Console.ReadLine();
        while(entrada != "FIM"){
            Jogadores Tmp = new Jogadores();
            Tmp.ler(entrada);
            lista.inserirFim(Tmp);
            entrada = Console.ReadLine();
        }
        int entrada2 = int.Parse(Console.ReadLine());
        int pos;
        for(int i = 0; i < entrada2 ; i++){
            string entrada3 = Console.ReadLine();
            string[] split = entrada3.Split(' ');
            if(split[0] == "II"){
                Jogadores Tmp = new Jogadores();
                Tmp.ler(entrada3);
                lista.inserirInicio(Tmp);
            }
            else if(split[0] == "I*"){
                pos = int.Parse(split[1]);
                Jogadores Tmp = new Jogadores();
                Tmp.ler(entrada3);
                lista.inserir(Tmp,pos);
            }
            else if(split[0] == "R*"){
                pos = int.Parse(split[1]);
                lista.remover(pos);
            }
            else if(split[0] == "IF"){
                Jogadores Tmp = new Jogadores();
                Tmp.ler(entrada3);
                lista.inserirFim(Tmp);
            }
            else if(split[0] == "RF"){
                lista.removerFim();
            }
            else if(split[0] == "RI"){
                lista.removerInicio();
            }
        }
        lista.mostrar();
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
class Lista {
	private Celula primeiro;
	private Celula ultimo;

	public Lista() {
        Jogadores Rai = new Jogadores();
		primeiro = new Celula(Rai);
		ultimo = primeiro;
	}

	public void inserirInicio(Jogadores x) {
		Celula tmp = new Celula(x);
        tmp.prox = primeiro.prox;
		primeiro.prox = tmp;
		if (primeiro == ultimo) {                 
			ultimo = tmp;
		}
        tmp = null;
	}

	public void inserirFim(Jogadores x) {
		ultimo.prox = new Celula(x);
		ultimo = ultimo.prox;
	}

	public Jogadores removerInicio(){
		if (primeiro == ultimo) {
			throw new Exception("Erro ao remover (vazia)!");
		}

        Celula tmp = primeiro;
		primeiro = primeiro.prox;
		Jogadores resp = primeiro.elemento;
        tmp.prox = null;
        tmp = null;
		return resp;
	}

	public Jogadores removerFim(){
		if (primeiro == ultimo) {
			throw new Exception("Erro ao remover (vazia)!");
		} 

		// Caminhar ate a penultima celula:
        Celula i;
        for(i = primeiro; i.prox != ultimo; i = i.prox);

        Jogadores resp = ultimo.elemento; 
        ultimo = i; 
        i = ultimo.prox = null;
      
		return resp;
	}

   public void inserir(Jogadores x, int pos){

        int tamanho = Tamanho();

        if(pos < 0 || pos > tamanho){
                throw new Exception("Erro ao inserir posicao (" + pos + " / tamanho = " + tamanho + ") invalida!");
        } else if (pos == 0){
            inserirInicio(x);
        } else if (pos == tamanho){
            inserirFim(x);
        } else {
            // Caminhar ate a posicao anterior a insercao
            Celula i = primeiro;
            for(int j = 0; j < pos; j++, i = i.prox);
            
            Celula tmp = new Celula(x);
            tmp.prox = i.prox;
            i.prox = tmp;
            tmp = i = null;
      }
   }

	public Jogadores remover(int pos){
        Jogadores resp;
        int tamanho = Tamanho();

		if (primeiro == ultimo){
			throw new Exception("Erro ao remover (vazia)!");

        } else if(pos < 0 || pos >= tamanho){
                throw new Exception("Erro ao remover (posicao " + pos + " / " + tamanho + " invalida!");
        } else if (pos == 0){
            resp = removerInicio();
        } else if (pos == tamanho - 1){
            resp = removerFim();
        } else {
            // Caminhar ate a posicao anterior a insercao
            Celula i = primeiro;
            for(int j = 0; j < pos; j++, i = i.prox);
            
            Celula tmp = i.prox;
            resp = tmp.elemento;
            i.prox = tmp.prox;
            tmp.prox = null;
            i = tmp = null;
        }

		return resp;
	}

	public void mostrar() {
		for (Celula i = primeiro.prox; i != null; i = i.prox) {
			i.elemento.imprimir();
		}
	}
	
	public bool pesquisar(Jogadores x) {
		bool resp = false;
		for (Celula i = primeiro.prox; i != null; i = i.prox) {
         if(i.elemento == x){
            resp = true;
            i = ultimo;
         }
		}
		return resp;
	}

   public int Tamanho() {
      int tamanho = 0; 
      for(Celula i = primeiro; i != ultimo; i = i.prox, tamanho++);
      return tamanho;
   }
}