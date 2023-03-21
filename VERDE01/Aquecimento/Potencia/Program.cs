using System;
class Program{
    public static void Main(string[] args){
        string entrada;
        int numero, potencia;
        int qnt = int.Parse(Console.ReadLine());
        for(int i = 0; i < qnt; i++){
            entrada = Console.ReadLine();

            numero = int.Parse(entrada[0].ToString());
            potencia = int.Parse(entrada[2].ToString());
            Console.WriteLine(calcula(numero,potencia));
        }

    }
    public static double calcula(int numero, int potencia){
        double resp;
        resp = Math.Pow(numero,potencia);
        return resp;
    }
}