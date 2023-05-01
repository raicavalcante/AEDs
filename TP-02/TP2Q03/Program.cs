using System;
class Program{
    public static void Main(string[] args){

        Jogadores[] j = new Jogadores[30];
        int cont = 0, achou = 0;
        string entrada = Console.ReadLine();
        while(entrada != "FIM"){
            j[cont] = new Jogadores();
            j[cont].ler(entrada);
            cont++;
            entrada = Console.ReadLine();
        }
        string entrada2 = Console.ReadLine();
        while(entrada2 != "FIM"){
            int inicio = 0;
            int fim = cont - 1;
            while(inicio <= fim){
                int metade = (inicio + fim) / 2;
                if(j[metade].nome.CompareTo(entrada2) == 0){
                    achou = 1;
                    inicio = fim + 1;
                }
                if(j[metade].nome.CompareTo(entrada2) > 0){
                    fim = metade - 1;
                }
                else{
                    inicio = metade + 1;
                }
            }
            if(achou == 1){
                Console.WriteLine("SIM");
            }
            else{
                Console.WriteLine("NAO");
            }
            achou = 0;
            entrada2 = Console.ReadLine();    
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

