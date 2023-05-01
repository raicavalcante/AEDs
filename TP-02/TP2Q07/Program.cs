using System;
using System.Collections.Generic;
class Program{
    public static void Main(string[] args){
        Jogadores[] j = new Jogadores[30];
        List<Jogadores> AL = new List<Jogadores>(20);
        int cont = 0;
        string entrada = Console.ReadLine();
        while(entrada != "FIM"){
            j[cont] = new Jogadores();
            j[cont].ler(entrada);
            AL.Add(j[cont]);
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
                AL.Insert(0,j[cont]);
            }
            else if(split[0] == "I*"){
                pos = int.Parse(split[1]);
                j[cont] = new Jogadores();
                j[cont].ler(entrada3);
                AL.Insert(pos,j[cont]);
            }
            else if(split[0] == "R*"){
                pos = int.Parse(split[1]);
                AL.RemoveAt(pos);
            }
            else if(split[0] == "IF"){
                j[cont] = new Jogadores();
                j[cont].ler(entrada3);
                AL.Add(j[cont]);
            }
            else if(split[0] == "RF"){
                AL.RemoveAt(AL.Count-1);
            }
            else if(split[0] == "RI"){
                AL.RemoveAt(0);
            }
        }
        foreach (Jogadores item in AL)
        {
            item.imprimir();
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