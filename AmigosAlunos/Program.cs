using System;
class Program{
    public static void Main(string[] args){
        Lista lista = new Lista();
        string lista1 = Console.ReadLine();
        string[] splitada = lista1.Split(' ');
        for (int i = 0; i < splitada.Length; i++)
        {
            lista.inserirFim(splitada[i]);
        }
        string lista2 = Console.ReadLine();
        string[] splitada2 = lista2.Split(' ');
        string quest = Console.ReadLine();
        if(quest == "nao"){
            for (int i = 0; i < splitada2.Length; i++)
            {
                lista.inserirFim(splitada2[i]);
            }
        }
        else{
            int pos = lista.pesquisar(quest);
            for (int i = 0; i < splitada2.Length; i++)
            {
                lista.inserir(splitada2[i],pos);
                pos++;
            }
        }
        lista.mostrar();
    }
}

class Celula {
	public string elemento; // Elemento inserido na celula.
	public Celula prox; // Aponta a celula prox.

	// public Celula() {
    //     string x = "";
	// 	Celula(x);
	// }

	public Celula(string elemento) {
      this.elemento = elemento;
      this.prox = null;
	}
}

class Lista {
	private Celula primeiro;
	private Celula ultimo;

	public Lista() {
        string x = "";
		primeiro = new Celula(x);
		ultimo = primeiro;
	}

	public void inserirInicio(string x) {
		Celula tmp = new Celula(x);
        tmp.prox = primeiro.prox;
		primeiro.prox = tmp;
		if (primeiro == ultimo) {                 
			ultimo = tmp;
		}
      tmp = null;
	}

	public void inserirFim(string x) {
		ultimo.prox = new Celula(x);
		ultimo = ultimo.prox;
	}

	public string removerInicio(){
		if (primeiro == ultimo) {
			throw new Exception("Erro ao remover (vazia)!");
		}

        Celula tmp = primeiro;
		primeiro = primeiro.prox;
		string resp = primeiro.elemento;
        tmp.prox = null;
        tmp = null;
		return resp;
	}

	public string removerFim(){
		if (primeiro == ultimo) {
			throw new Exception("Erro ao remover (vazia)!");
		} 

		// Caminhar ate a penultima celula:
        Celula i;
        for(i = primeiro; i.prox != ultimo; i = i.prox);

        string resp = ultimo.elemento; 
        ultimo = i; 
        i = ultimo.prox = null;
      
		return resp;
	}
   public void inserir(string x, int pos){

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
	public string remover(int pos){
        string resp;
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
	
	public int pesquisar(string x) {
		int resp = 0;
        int cont = 0;
		for (Celula i = primeiro.prox; i != null; i = i.prox) {
         if(i.elemento == x){
            resp = cont;
            i = ultimo;
         }
         cont++;
		}
		return resp;
	}
   public int Tamanho() {
      int tamanho = 0; 
      for(Celula i = primeiro; i != ultimo; i = i.prox, tamanho++);
      return tamanho;
   }

   public void mostrar() {
		for (Celula i = primeiro.prox; i != null; i = i.prox){
			Console.Write(i.elemento + " ");
		}
	}
}