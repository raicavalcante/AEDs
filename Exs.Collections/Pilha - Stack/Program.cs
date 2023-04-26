using System;
using System.Collections;
class Program{
    public static void Main(string[] args){        
        // 1 - Crie um ArrayList e adicione 10 valores inteiros digitados pelo usuário. Ao final, imprima todos os elementos.
        int respInt;
        Stack S = new Stack();
        for (int i = 0; i < 10; i++)
        {
            respInt = int.Parse(Console.ReadLine());
            S.Push(respInt);
        }
        for (int i = 0; i < 10; i++)
        {
            Console.Write(S.Pop() + " ");
        }Console.WriteLine();

        // 2 - Crie um ArrayList e adicione 10 strings digitados pelo usuário. Ao final, imprima todos os elementos
        LimpaPilha(S);
        string respString;
        for (int i = 0; i < 10; i++)
        {
            respString = Console.ReadLine();
            S.Push(respString);
        }
        for (int i = 0; i < 10; i++)
        {
            Console.Write(S.Pop() + " ");
        }Console.WriteLine();

        // 3 - Crie um ArrayList e adicione os números ímpares no intervalo entre 1 a 100. Calcule a soma dos números usando o comando for.
        LimpaPilha(S);
        int respFor = 0, somaFor = 0 ;
        for (int i = 0; i < 100; i++)
        {
            respFor += 1;
            if(respFor % 2 != 0){
                S.Push(respFor);
                somaFor += respFor;
            }
        }
        Console.WriteLine("Soma ímpares com for: " + somaFor);

        // 4 - Crie um ArrayList e adicione os números pares no intervalo entre 1 a 100. Calcule a soma dos números usando o comando while.
        LimpaPilha(S);
        int respWhile = 0, somaWhile = 0 ;
        while(respWhile <= 100){
            respWhile += 1 ;
            if(respWhile % 2 == 0){
                S.Push(respWhile);
                somaWhile += respWhile;
            }
        }
        Console.WriteLine("Soma pares com While: " + somaWhile);

        // 5 - Crie um ArrayList e adicione os números no intervalo entre 1 a 100. Calcule a soma dos números usando o comando do while.
        LimpaPilha(S);
        int respDo = 0, somaDo = 0 ;
        do{
            respDo += 1 ;
            S.Push(respDo);
            somaDo += respDo;            
        }while(respDo < 100);
        Console.WriteLine("Soma numeros com DoWhile: " + somaDo);

        // 6 - Crie um ArrayList e adicione os números pares no intervalo entre 1 a 100. Calcule a soma dos números usando o comando foreach.
        LimpaPilha(S);
        int somaForeach = 0;
        for (int i = 1; i <= 100; i++){
            if(i % 2 == 0){
                S.Push(i);
            }
        }
        foreach(int numero in S){
            somaForeach += numero;
        }
        Console.WriteLine("Soma pares com foreach: " + somaForeach);

        // 7 - Crie um ArrayList contendo os seguintes elementos (5, 13, 19, 31, 3, 7, 11, 5, 57, 13, 5). Faça uma função que apague TODAS as ocorrências de um determinado elemento. Use essa função para apagar todas as ocorrências do número 5 e 13.
        S = new Stack();
        int num = 5, num2 = 13;
        S.Push(5); S.Push(13); S.Push(19); S.Push(31); S.Push(3); S.Push(7); S.Push(11); S.Push(5); S.Push(57); S.Push(13); S.Push(5);
        ApagaNumInStack(num,ref S);
        ApagaNumInStack(num2,ref S);
        Console.Write("Stack: ");
        foreach (var item in S)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();

        // 10 – Faça um programa que leia n números inteiros e os armazene em um Stack. Calcule a soma e a média aritmética (use o comando FOREACH para iterar sobre os elementos).
        LimpaPilha(S);
        double qnt = 0, soma = 0, mediaAritmética = 0;
        string n = Console.ReadLine();
        while(n != "FIM"){
            S.Push(int.Parse(n));
            qnt++;
            n = Console.ReadLine();
        }
        foreach(int numero in S){
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
        LimpaPilha(S);
        int preencher = 1;
        for(int i = 0; i < 25; i++){
            S.Push(preencher);
            preencher++;
        }
        int metade = 25/2;
        Console.WriteLine("-Foreach-");
        Console.Write("Elementos: ");
        foreach (var item in S)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
        Console.Write("Elementos invertidos: ");
        int[] elementos = S.Cast<int>().ToArray();;
        Array.Reverse(elementos);
        foreach (int numero in elementos) {
            Console.Write(numero + " ");
        }
        Console.WriteLine();
        Console.Write("Elementos posições ímpares: ");
        int per = 0;
        foreach (var item in S)
        {
            if(per % 2 != 0){
                Console.Write(item + " ");
            }
            per++;
        }
        Console.WriteLine();
        Console.Write("Elementos ímpares: ");
        foreach (var item in S)
        {
            if((int)item % 2 != 0){
                Console.Write(item + " ");
            }
        }
        Console.WriteLine();
        Console.Write("Elementos primeira metade: ");
        int cont = 0; 
        foreach (var item in S)
        {
            if(cont <= metade){
                Console.Write(item + " ");
            }
            cont++;
        } Console.WriteLine();

        // 13 - Faça um programa que gere uma coleção com n números inteiros aleatórios (o valor de n deve ser informado pelo usuário no início da execução do programa. Imprima os elementos da coleção
        LimpaPilha(S);
        int quantidade = int.Parse(Console.ReadLine());
        Random R = new Random();
        for(int i = 0; i < quantidade; i++){
            S.Push(R.Next());
        }
        Console.Write("ArrayList: ");
        foreach (var item in S)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
    public static void LimpaPilha(Stack S){
        S.Clear();
    }
    public static void ApagaNumInStack(int num, ref Stack S){
        Stack temp = new Stack();
        foreach (var item in S)
        {
            if(num != (int)item){
                temp.Push(item);
            }
            
        }
        S = temp;
    }
    // 14 – Crie uma função para inverter os dados da coleção recebida como parâmetro. Obs1: use qualquer outra estrutura que julgar necessária. Obs2: não utilize o método reverse da classe ArrayList.
    public static void InvertePilha(ref Stack collection){
        int[] elementos = collection.Cast<int>().ToArray();
        Array.Reverse(elementos);
        foreach (int numero in elementos) {
            Console.Write(numero + " ");
        }
    }
    // 15 – Crie uma função que receba a coleção como parâmetro e retorne a soma de seus elementos. Obs: considere que todos seus dados são do tipo int.
    public static int SomaElementos(ref Stack collection){
        int soma = 0;
        foreach(int num in collection){
            soma += num;
        }
        return soma;
    }
    // 16 – Crie uma função que calcule o número de elementos positivos de uma coleção passada como parâmetro.
    public static int CalculaPositivos(ref Stack collection){
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
    public static int ContaOcorrencias(ref Stack collection, int busca){
        int ocorrências = 0;
        foreach(int num in collection){
            if((int)collection.Pop() == busca){
                ocorrências++;
            }
        }
        return ocorrências;
    }
}
