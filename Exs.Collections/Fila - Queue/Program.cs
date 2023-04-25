using System;
using System.Collections;
class Program{
    public static void Main(string[] args){
        // 1 - Crie um ArrayList e adicione 10 valores inteiros digitados pelo usuário. Ao final, imprima todos os elementos.
        Queue Q = new Queue();
        int respInt;
        for(int i = 0; i < 10; i++){
            respInt = int.Parse(Console.ReadLine());
            Q.Enqueue(respInt);
        }
        for(int i = 0; i < 10; i++){
            Console.Write(Q.Dequeue() + " ");
        }Console.WriteLine();

        // 2 - Crie um ArrayList e adicione 10 strings digitados pelo usuário. Ao final, imprima todos os elementos
        LimpaFila(Q);
        string respString;
        for(int i = 0; i < 10; i++){
            respString = Console.ReadLine();
            Q.Enqueue(respString);
        }
        for(int i = 0; i < 10; i++){
            Console.Write(Q.Dequeue() + " ");
        }Console.WriteLine();

        // 3 - Crie um ArrayList e adicione os números ímpares no intervalo entre 1 a 100. Calcule a soma dos números usando o comando for.
        LimpaFila(Q);
        int somaFor = 0, respFor = 0;
        for (int i = 0; i < 100; i++)
        {
            respFor += 1;
            if(respFor % 2 != 0){
                Q.Enqueue(respFor);
                somaFor += respFor;  
            } 
        }
        Console.WriteLine("Soma ímpares com for: " + somaFor);

        // 4 - Crie um ArrayList e adicione os números pares no intervalo entre 1 a 100. Calcule a soma dos números usando o comando while.
        LimpaFila(Q);
        int respWhile = 0, somaWhile = 0;
        while(respWhile <= 100){
            respWhile += 1 ;
            if(respWhile % 2 == 0){
                Q.Enqueue(respWhile);
                somaWhile += respWhile;
            }
        }
        Console.WriteLine("Soma pares com While: " + somaWhile);

        // 5 - Crie um ArrayList e adicione os números no intervalo entre 1 a 100. Calcule a soma dos números usando o comando do while.
        LimpaFila(Q);
        int respDo = 0, somaDo = 0;
        do{
            respDo += 1 ;
            Q.Enqueue(respDo);
            somaDo += respDo;            
        }while(respDo < 100);
        Console.WriteLine("Soma numeros com DoWhile: " + somaDo);

        // 6 - Crie um ArrayList e adicione os números pares no intervalo entre 1 a 100. Calcule a soma dos números usando o comando foreach.
        LimpaFila(Q);
        int somaForeach = 0;
        for (int i = 1; i <= 100; i++){
            if(i % 2 == 0){
                Q.Enqueue(i);
            }
        }
        foreach(int numero in Q){
            somaForeach += numero;
        }
        Console.WriteLine("Soma pares com foreach: " + somaForeach);

        // 7 - Crie um ArrayList contendo os seguintes elementos (5, 13, 19, 31, 3, 7, 11, 5, 57, 13, 5). Faça uma função que apague TODAS as ocorrências de um determinado elemento. Use essa função para apagar todas as ocorrências do número 5 e 13.
        Q = new Queue();
        int num = 5, num2 = 13;
        Q.Enqueue(5); Q.Enqueue(13); Q.Enqueue(19); Q.Enqueue(31); Q.Enqueue(3); Q.Enqueue(7); Q.Enqueue(11); Q.Enqueue(5); Q.Enqueue(57); Q.Enqueue(13); Q.Enqueue(5);
        ApagaNumInQueue(num,Q);
        ApagaNumInQueue(num2,Q);
        Console.Write("Queue: ");
        for (int i = 0; i < 11; i++)
        {
            Console.Write(Q.Dequeue() + " ");   
        }
        Console.WriteLine();

        // 9 – Faça um programa que leia n números inteiros e os armazene em um Queue. Calcule a soma e a média aritmética (use o comando FOREACH para iterar sobre os elementos).
        LimpaFila(Q);
        double qnt = 0, soma = 0, mediaAritmética = 0;
        string n = Console.ReadLine();
        while(n != "FIM"){
            Q.Enqueue(int.Parse(n));
            qnt++;
            n = Console.ReadLine();
        }
        foreach(int numero in Q){
            soma += numero;
        }
        mediaAritmética = soma/qnt;
        Console.WriteLine("A soma dos elementos é: {0} e a média Aritmética é: {1}" , soma , mediaAritmética);

        // 11 – Faça um programa que preencha um ArrayList com elementos de diferentes tipos (int, double, float, boolean, String). Tente calcular a soma dos elementos. Evidentemente, isso irá provocar uma mensagem de erro. Que mensagem o Visual Studio retorna?
        // AL = new ArrayList(){ 1, 2, "AED", new Queue(), "teste", 3.14 };
        // foreach (var item in AL){
        //     soma += item;
        // }
        // O operador "+=" não pode ser aplicado a operandos dos tipos "double" e "object" [ArrayList]

        // 12 – Faça um programa que preencha um ArrayList com os números entre 1 e 25. Pede-se:
        // ● Imprima todos os elementos
        // ● Imprima todos os elementos em ordem invertida
        // ● Imprima todos os elementos em posições ímpares (os elementos da posição 1, 3, 5, ...)
        // ● Imprima todos os elementos ímpares
        // ● Imprima apenas os elementos da primeira metade do vetor (posição 0 a 12).
        // OBS: você deve fazer esse programa 2 vezes. Primeiro usando o comando FOR e depois usando o comando FOREACH.
        LimpaFila(Q);
        int preencher = 1;
        for(int i = 0; i < 25; i++){
            Q.Enqueue(preencher);
            preencher++;
        }
        int metade = 25/2;
        Console.WriteLine("-Foreach-");
        Console.Write("Elementos: ");
        foreach (var item in Q)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
        Console.Write("Elementos invertidos: ");
        int[] elementos = Q.Cast<int>().ToArray();;
        Array.Reverse(elementos);
        foreach (int numero in elementos) {
            Console.Write(numero + " ");
        }
        Console.WriteLine();
        Console.Write("Elementos posições ímpares: ");
        int per = 0;
        foreach (var item in Q)
        {
            if(per % 2 != 0){
                Console.Write(item + " ");
            }
            per++;
        }
        Console.WriteLine();
        Console.Write("Elementos ímpares: ");
        foreach (var item in Q)
        {
            if((int)item % 2 != 0){
                Console.Write(item + " ");
            }
        }
        Console.WriteLine();
        Console.Write("Elementos primeira metade: ");
        int cont = 0; 
        foreach (var item in Q)
        {
            if(cont <= metade){
                Console.Write(item + " ");
            }
            cont++;
        } Console.WriteLine();

        // 13 - Faça um programa que gere uma coleção com n números inteiros aleatórios (o valor de n deve ser informado pelo usuário no início da execução do programa. Imprima os elementos da coleção
        LimpaFila(Q);
        int quantidade = int.Parse(Console.ReadLine());
        Random R = new Random();
        for(int i = 0; i < quantidade; i++){
            Q.Enqueue(R.Next());
        }
        Console.Write("ArrayList: ");
        foreach (var item in Q)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine(); 
    }
    public static void LimpaFila(Queue Q){
        Q.Clear();
    }
    public static void ApagaNumInQueue(int num, Queue Q){
        Queue temp = new Queue();
        foreach (var item in Q)
        {
            if(num != (int)item){
                temp.Enqueue(item);
            }
            
        }
        Q = temp;
    }
    // 14 – Crie uma função para inverter os dados da coleção recebida como parâmetro. Obs1: use qualquer outra estrutura que julgar necessária. Obs2: não utilize o método reverse da classe ArrayList.
    public static void InverteFila(Queue collection){
        int[] elementos = collection.Cast<int>().ToArray();
        Array.Reverse(elementos);
        foreach (int numero in elementos) {
            Console.Write(numero + " ");
        }
    }
    // 15 – Crie uma função que receba a coleção como parâmetro e retorne a soma de seus elementos. Obs: considere que todos seus dados são do tipo int.
    public static int SomaElementos(Queue collection){
        int soma = 0;
        foreach(int num in collection){
            soma += num;
        }
        return soma;
    }
    // 16 – Crie uma função que calcule o número de elementos positivos de uma coleção passada como parâmetro.
    public static int CalculaPositivos(Queue collection){
        int positivos = 0;
        foreach(int numero in collection){
            Console.WriteLine(numero);
            if(numero > 0){
                positivos++;
            }
        }
        return positivos;
    }
    // 17 – Crie uma função que calcule o número de ocorrências em uma coleção de um elemento passado como parâmetro.
    public static int ContaOcorrencias(Queue collection, int busca){
        int ocorrências = 0;
        foreach(int num in collection){
            if((int)collection.Dequeue() == busca){
                ocorrências++;
            }
        }
        return ocorrências;
    }
}
