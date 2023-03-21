using System;
class Program{
    public static void Main(string[] args){
        // Declarando variáveis
        int numero, percorre = 0, resp = 1, proxNum = 0, numAnterior = 1 ;
        // Entrada de dados do n-ésimo numero
        numero = int.Parse(Console.ReadLine());
        // Chamando a função que calcula o número de fibonacci e imprime o resultado
        Console.WriteLine(fibonacciRecursivo(numero,percorre,resp,proxNum,numAnterior));
    }

    // Criando a função recursiva que calcula a sequência de fibonacci
    static int fibonacciRecursivo(int numero,int percorre,int resp,int proxNum,int numAnterior){
        // Condição de parada
        if(percorre == numero){
            return resp;
        }
        // Recursividade
        else{
            // Cálculos fibonacci
            resp = numAnterior + proxNum;
            numAnterior = proxNum;
            proxNum = resp;
            
            return fibonacciRecursivo(numero,percorre+1,resp,proxNum,numAnterior);
        }
    }
}