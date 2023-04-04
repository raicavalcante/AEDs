using System;
class Program{
    public static void Main(string[] args){
        int qnt,cont0 = 0, cont1 = 0;
        string entrada;
        string[] resp;
        qnt = int.Parse(Console.ReadLine());
        entrada = Console.ReadLine();
        resp = entrada.Split(' ');

        for(int i=0; i < qnt; i++){
            if(int.Parse(resp[i]) == 0){
                cont0++;
            }
            if(int.Parse(resp[i]) == 1){
                cont1++;
            }
        }
        if(cont0 > cont1){
            Console.Write("Y");
        }
        else{
            Console.Write("N");
        }
        
    }
}