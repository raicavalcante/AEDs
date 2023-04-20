using System;
using System.Collections;
class Program{
    public static void Main(string[] args){
        // 1. Crie o ArrayList AL1 sem definir a capacidade inicial
            ArrayList AL1 = new ArrayList();
        // 2. Imprima a capacidade e a quantidade de elementos.
            Console.WriteLine("Capacidade: {0} Quantidade: {1}", AL1.Capacity, AL1.Count);
        // 3. Adicione os números 19, 7 e 11.
            AL1.Add(19); AL1.Add(7); AL1.Add(11);
        // 4. Imprima a capacidade e a quantidade de elementos.
            Console.WriteLine("Capacidade: {0} Quantidade: {1}", AL1.Capacity, AL1.Count);
        // 5. Adicione os números 5, 7 e 17.
            AL1.Add(5); AL1.Add(7); AL1.Add(17);
        // 6. Imprima a capacidade e a quantidade de elementos.
            Console.WriteLine("Capacidade: {0} Quantidade: {1}", AL1.Capacity, AL1.Count);
        // 7. Imprima os elementos do ArrayList usando o comando foreach.
            foreach(int num in AL1){
                Console.Write(num + " ");
            }Console.WriteLine();
        // 8. Adicione o número 5 nas posições 0, 2 e 10. Ocorreu algum problema? Se sim, anote qual foi o motivo e resolva esse problema.
            AL1[0] = 5; AL1[2] = 5; AL1[5] = 5; /* O ultimo elemento estava na posição 5 , e não tem como ultrapassar*/
        // 9. Imprima os elementos do ArrayList usando o comando for.
            for(int i = 0; i < AL1.Count; i++){
                Console.Write(AL1[i] + " ");
            } Console.WriteLine();
        // 10. Imprima a primeira e a última posição que contém o número 7.
            Console.WriteLine("Primeira posição: " + AL1.IndexOf(7));
            Console.WriteLine("Última posição: " + AL1.LastIndexOf(7));
        // 11. Imprima todas as posições que contém o número 5.
            Console.Write("posições: ");
            for(int i = 0; i < AL1.Count; i++){
                if(AL1[i].Equals(5)){
                    Console.Write(i + " ");
                }
            }
        // 12. Adicione os números 5, 23, 47, 5 e 5.
            AL1.Add(5); AL1.Add(23); AL1.Add(47); AL1.Add(5); AL1.Add(5);
            Console.WriteLine();
        // 13. Imprima os elementos do ArrayList usando o comando while
            int j = 0;
            while(AL1.Count > j){
                Console.Write(AL1[j] + " ");
                j++;
            }Console.WriteLine();
        // 14. Imprima as posições do número 5 retornada pelos métodos: BinarySeach(), IndexOf() e LastIndexOf()
            Console.Write("Binary: " + AL1.BinarySearch(5) + " / "); 
            Console.Write("IndexOf: " + AL1.IndexOf(5) + " / "); 
            Console.Write("LastIndexOf: " + AL1.LastIndexOf(5));
        // 15. Ordene os elementos do ArrayList.
            AL1.Sort(); Console.WriteLine();
        // 16. Imprima os elementos do ArrayList (use o comando que você desejar).
            foreach(int num in AL1){
                Console.Write(num + " ");
            }Console.WriteLine();
        // 17. Remova o número 23.
            AL1.Remove(23);
        // 18. Imprima os elementos do ArrayList (use o comando que você desejar).
            foreach(int num in AL1){
                Console.Write(num + " ");
            }Console.WriteLine();
        // 19. Remova o elemento da posição 7.
            AL1.RemoveAt(7);
        // 20. Imprima os elementos do ArrayList (use o comando que você desejar).
            foreach(int num in AL1){
                Console.Write(num + " ");
            }Console.WriteLine();
        // 21. Remova os elementos das posições 2, 3 e 4.
            AL1.RemoveRange(2,3);
        // 22. Imprima os elementos do ArrayList (use o comando que você desejar).
            foreach(int num in AL1){
                Console.Write(num + " ");
            }Console.WriteLine();
        // 23. Inverta os elementos do ArrayList.
            AL1.Reverse();
        // 24. Imprima os elementos do ArrayList (use o comando que você desejar).
            foreach(int num in AL1){
                Console.Write(num + " ");
            }Console.WriteLine();
        // 25. Remova todos os elementos do ArrayList.
            AL1.Clear();
        // 26. Imprima os elementos do ArrayList (use o comando que você desejar).
            foreach(int num in AL1){
                Console.Write(num + " ");
            }
        // 27. Imprima a capacidade e a quantidade de elemento
            Console.WriteLine("Capacidade: {0} Quantidade: {1}", AL1.Capacity, AL1.Count);
    }
}