using System;
class Program{
    public static void Main(string[] args){
        int E,cont=0;
        E = int.Parse(Console.ReadLine());
        double A, G;
        for(int i = 0; i < E; i++){
            string entrada = (Console.ReadLine());
            string[] array = entrada.Split(' ');
            A = double.Parse(array[1]);
            G = double.Parse(array[2]);
            double temp = G * 0.7;
            if(A <= temp){
                Console.WriteLine(array[0]);
            }
            else{
                cont++;
            }
        }
        if(cont == E){
            Console.WriteLine("*");
        }
    }
}