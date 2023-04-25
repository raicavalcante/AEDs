using System;
using System.Collections;
class Program{
    public static void Main(string[] args){

        // 1 - Crie um ArrayList e adicione 10 valores inteiros digitados pelo usuário. Ao final, imprima todos os elementos.
        int respInt;
        ArrayList AL = new ArrayList();
        for(int i = 0; i < 10; i++){
            respInt = int.Parse(Console.ReadLine());
            AL.Add(respInt);
        }
        for(int i = 0; i < AL.Count; i++){
            Console.Write(AL[i] + " ");
        }Console.WriteLine();

        // 2 - Crie um ArrayList e adicione 10 strings digitados pelo usuário. Ao final, imprima todos os elementos
        LimpaArray(AL);
        string respString;
        for(int i = 0; i < 10; i++){
            respString = Console.ReadLine();
            AL.Add(respString);
        }
        for(int i = 0; i < AL.Count; i++){
            Console.Write(AL[i] + " ");
        }Console.WriteLine();

        // 3 - Crie um ArrayList e adicione os números ímpares no intervalo entre 1 a 100. Calcule a soma dos números usando o comando for.
        LimpaArray(AL);
        int respFor = 0, somaFor = 0 ;
        for(int i = 0; i < 100; i++){
            respFor += 1 ;
            if(respFor % 2 != 0){
                AL.Add(respFor);
                somaFor += respFor;
            }
        }
        Console.WriteLine("Soma ímpares com for: " + somaFor);

        // 4 - Crie um ArrayList e adicione os números pares no intervalo entre 1 a 100. Calcule a soma dos números usando o comando while.
        LimpaArray(AL);
        int respWhile = 0, somaWhile = 0 ;
        while(respWhile <= 100){
            respWhile += 1 ;
            if(respWhile % 2 == 0){
                AL.Add(respWhile);
                somaWhile += respWhile;
            }
        }
        Console.WriteLine("Soma pares com While: " + somaWhile);

        
        // 5 - Crie um ArrayList e adicione os números no intervalo entre 1 a 100. Calcule a soma dos números usando o comando do while.
        LimpaArray(AL);
        int respDo = 0, somaDo = 0 ;
        do{
            respDo += 1 ;
            AL.Add(respDo);
            somaDo += respDo;            
        }while(respDo < 100);
        Console.WriteLine("Soma numeros com DoWhile: " + somaDo);

        // 6 - Crie um ArrayList e adicione os números pares no intervalo entre 1 a 100. Calcule a soma dos números usando o comando foreach.
        LimpaArray(AL);
        int somaForeach = 0;
        for (int i = 1; i <= 100; i++){
            if(i % 2 == 0){
                 AL.Add(i);
            }
        }
        foreach(int numero in AL){
            somaForeach += numero;
        }
        Console.WriteLine("Soma pares com foreach: " + somaForeach);


        // 7 - Crie um ArrayList contendo os seguintes elementos (5, 13, 19, 31, 3, 7, 11, 5, 57, 13, 5). Faça uma função que apague TODAS as ocorrências de um determinado elemento. Use essa função para apagar todas as ocorrências do número 5 e 13.
        LimpaArray(AL);
        AL = new ArrayList(){5, 13, 19, 31, 3, 7, 11, 5, 57, 13, 5};
        int num = 5;
        ApagaNumInArrayList(num,AL);
        int num2 = 13;
        ApagaNumInArrayList(num2,AL);
        Console.Write("ArrayList: ");
        for (int i = 0; i < AL.Count; i++)
        {
            Console.Write(AL[i] + " ");   
        }
        Console.WriteLine();

        // 8 – Faça um programa que leia n números inteiros e os armazene em um ArrayList. Calcule a soma e a média aritmética (use o comando FOR e depois o FOREACH).
        LimpaArray(AL);
        double qnt = 0, soma = 0, mediaAritmética = 0;
        string n = Console.ReadLine();
        while(n != "FIM"){
            AL.Add(int.Parse(n));
            qnt++;
            n = Console.ReadLine();
        }
        foreach(int numero in AL){
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
        LimpaArray(AL);
        AL = new ArrayList(){1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25};
        int metade = AL.Count/2;
        // For
        Console.WriteLine("-For-");
        Console.Write("Elementos: ");
        for(int i = 0; i < AL.Count; i++){
            Console.Write(AL[i] + " ");
        }
        Console.WriteLine();
        Console.Write("Elementos invertidos: ");
        AL.Reverse();
        for(int i = 0; i < AL.Count; i++){
            Console.Write(AL[i] + " ");
        }
        AL.Reverse();
        Console.WriteLine();
        Console.Write("Elementos posições ímpares: ");
        for(int i = 0; i < AL.Count; i++){
            if(i % 2 != 0){
                Console.Write(AL[i] + " ");
            }
        }
        Console.WriteLine();
        Console.Write("Elementos ímpares: ");
        for(int i = 0; i < AL.Count; i++){
            if((int)AL[i] % 2 != 0){
                Console.Write(AL[i] + " ");
            }
        }
        Console.WriteLine();
        Console.Write("Elementos primeira metade: ");
        for(int i = 0; i <= metade; i++){
            Console.Write(AL[i] + " ");
        }
        Console.WriteLine();
        // foreach
        Console.WriteLine("-Foreach-");
        Console.Write("Elementos: ");
        foreach (var item in AL)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
        Console.Write("Elementos invertidos: ");
        AL.Reverse();
        foreach (var item in AL)
        {
            Console.Write(item + " ");
        }
        AL.Reverse();
        Console.WriteLine();
        Console.Write("Elementos posições ímpares: ");
        int per = 0;
        foreach (var item in AL)
        {
            if(per % 2 != 0){
                Console.Write(item + " ");
            }
            per++;
        }
        Console.WriteLine();
        Console.Write("Elementos ímpares: ");
        foreach (var item in AL)
        {
            if((int)item % 2 != 0){
                Console.Write(item + " ");
            }
        }
        Console.WriteLine();
        Console.Write("Elementos primeira metade: ");
        int cont = 0; 
        foreach (var item in AL)
        {
            if(cont <= metade){
                Console.Write(item + " ");
            }
            cont++;
        }

        // 13 - Faça um programa que gere uma coleção com n números inteiros aleatórios (o valor de n deve ser informado pelo usuário no início da execução do programa. Imprima os elementos da coleção.
        int quantidade = int.Parse(Console.ReadLine());
        Random R = new Random();
        for(int i = 0; i < quantidade; i++){
            AL.Add(R.Next(0,500));
        }
        Console.Write("ArrayList: ");
        for (int i = 0; i < AL.Count; i++)
        {
            Console.Write(AL[i] + " ");   
        }
        Console.WriteLine();

    }    
    public static void LimpaArray(ArrayList AL){
        AL.Clear();
    }
    public static ArrayList ApagaNumInArrayList(int num, ArrayList AL){
        for(int i = 0; i < AL.Count; i++){
            if(AL.Contains(num)){
                AL.Remove(num);
            }
        }
        return AL;
    }
    // 14 – Crie uma função para inverter os dados da coleção recebida como parâmetro. Obs1: use qualquer outra estrutura que julgar necessária. Obs2: não utilize o método reverse da classe ArrayList.
    public static void InverteArrayList(ArrayList collection){
        int i = 0, j = collection.Count-1;
        while(i < j){
            object temp = collection[i];
            collection[i] = collection[j];
            collection[j] = temp;
            i++;
            j--; 
        }
    }
    // 15 – Crie uma função que receba a coleção como parâmetro e retorne a soma de seus elementos. Obs: considere que todos seus dados são do tipo int.
    public static int SomaElementos(ArrayList collection){
        int soma = 0;
        foreach(int numero in collection){
            soma += numero;
        }
        return soma;
    }
    // 16 – Crie uma função que calcule o número de elementos positivos de uma coleção passada como parâmetro.
    public static int CalculaPositivos(ArrayList collection){
        int positivos = 0;
        foreach(int numero in collection){
            if(numero > 0){
                positivos++;
            }
        }
        return positivos;
    }
    // 17 – Crie uma função que calcule o número de ocorrências em uma coleção de um elemento passado como parâmetro.
    public static int ContaOcorrencias(ArrayList collection, int busca){
        int ocorrências = 0, i = 0;
        foreach(int numero in collection){
            if((int)collection[i] == busca){
                ocorrências++;
            }
            i++;
        }
        return ocorrências;
    }
}
