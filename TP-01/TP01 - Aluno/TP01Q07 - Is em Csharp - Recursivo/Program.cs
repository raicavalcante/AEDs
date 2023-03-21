using System;

class program
{
    public static void Main(string[] args)
    {
        int tam = 0;
        string frase = Console.ReadLine();
        while (frase != "FIM")
        {
            int cont = 0;
            Console.Write(vogalRecursivo(frase,tam)?"SIM" : "NAO");
            Console.Write(" ");
            Console.Write(consoanteRecursivo(frase,tam)?"SIM" : "NAO");
            Console.Write(" ");
            Console.Write(inteiroRecursivo(frase,tam)?"SIM" : "NAO");
            Console.Write(" ");
            Console.WriteLine(realRecursivo(frase,tam,cont)?"SIM" : "NAO");
            frase = Console.ReadLine();
        }
    }

    public static bool vogalRecursivo(string frase, int tam)
    {

        if (tam == frase.Length)
        {
            return true;
        }
        if (frase[tam] != 'a' && frase[tam] != 'e' && frase[tam] != 'i' && frase[tam] != 'o' && frase[tam] != 'u')
        {
            return false;
        }
        return vogalRecursivo(frase, tam+1);

    }
    public static bool consoanteRecursivo(string frase, int tam)
    {
        if (tam == frase.Length)
        {
            return true;
        }
        if (char.IsLetter(frase[tam]) && !char.IsWhiteSpace(frase[tam]) && frase[tam] != 'a' && frase[tam] != 'e' && frase[tam] != 'i' && frase[tam] != 'o' && frase[tam] != 'u')
        {
            return consoanteRecursivo(frase, tam+1);
        }
        return false;
    }
    public static bool inteiroRecursivo(string frase, int tam)
    {
        if (tam >= frase.Length)
        {
            return true;
        }
        if (int.TryParse(frase, out int num) && num % 1 == 0)
        {
            return inteiroRecursivo(frase, tam+1);
        }
        else
        {
            return false;
        }
    }


    public static bool realRecursivo(string frase, int tam, int cont)
    {

        if (tam >= frase.Length)
        {
            return true;
        }
        if (frase[0] == '.')
        {
            return true;
        }
        if (Single.TryParse(frase, out float num))
        {
            if (frase[0] == '.' || frase[0] == ',')
            {
                return true;
            }
            if (frase[tam] == '.' || frase[tam] == ',')
            {
                cont++;
            }
            if (cont > 1)
            {
                return false;
            }
            else{
                return realRecursivo(frase,tam+1,cont);
            }
        }
        return false;
    }
}