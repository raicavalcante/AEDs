using System;
class Program{
    public static void Main(string[] args){
        Pilha pilha = new Pilha();
        string entrada = Console.ReadLine();
        while(entrada != "FIM"){
            Jogadores Tmp = new Jogadores();
            Tmp.ler(entrada);
            pilha.inserir(Tmp);
            entrada = Console.ReadLine();
        }
        int entrada2 = int.Parse(Console.ReadLine());
        for(int i = 0; i < entrada2 ; i++){
            string entrada3 = Console.ReadLine();
            string[] split = entrada3.Split(' ');
            if(split[0] == "I"){
                Jogadores Tmp = new Jogadores();
                Tmp.ler(entrada3);
                pilha.inserir(Tmp);
            }
            else if(split[0] == "R"){
                pilha.remover();
            }
        }
        pilha.mostraPilha();
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
class Pilha {
	private Celula topo;

	public Pilha() {
		topo = null;
	}

	public void inserir(Jogadores x) {
		Celula tmp = new Celula(x);
		tmp.prox = topo;
		topo = tmp;
		tmp = null;
	}

	public Jogadores remover(){
		if (topo == null) {
			throw new Exception("Erro ao remover!");
		}
		Jogadores resp = topo.elemento;
		Celula tmp = topo;
		topo = topo.prox;
		tmp.prox = null;
		tmp = null;
		return resp;
	}

	public void mostraPilha() {
		mostraPilha(topo);
	}

	private void mostraPilha(Celula i) {
		if (i != null) {
			mostraPilha(i.prox);
			i.elemento.imprimir();
		}
	}
}