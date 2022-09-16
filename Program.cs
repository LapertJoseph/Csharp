internal class Program
{
    private static void Main(string[] args)
    {
        //exo 1

        // int a = 12;
        // int b = 3;
        // int c;

        // c = a;  // c = 12
        // a = b;  // a = 3
        // b = c;  // b = 12

        // Console.WriteLine(a); // a = 3
        // Console.WriteLine(b); // b = 12

        //exo 2

        // int premiereValeur = 14;
        // int deuxiemeValeur = 2;


        // premiereValeur = premiereValeur + deuxiemeValeur;
        // deuxiemeValeur = premiereValeur - deuxiemeValeur;
        // premiereValeur = premiereValeur - deuxiemeValeur;

        // Console.WriteLine(premiereValeur);  //première Valeur = 2
        // Console.WriteLine(deuxiemeValeur);  //deuxième Valeur = 14

        //exo 3

        // int a = 2;
        // int b = -3;

        // if (a*b > 0)  {
        //     Console.WriteLine("même signe");  
        // }
        // else
        // {
        //     Console.WriteLine("pas le même signe");
        // }

        //exo 4

        // int n = 0;
        // double montant = 0.0;

        // if (n > 30)
        // {
        //     montant = 50 + n - 30;
        //     Console.WriteLine("\nFacture: ", montant);
        // }
        // else if (n > 10)
        // {
        //     montant = 20 + 1.5 * (n - 10);
        //     Console.WriteLine("\nFacture: ", montant);
        // }
        // else
        // {
        //     montant = 2 * n;
        //     Console.WriteLine("\nFacture: ", montant);
        // }


        //exo 5


        // int n = 5;
        // int res = n * (n+1) / 2;


        //exo 6

        // int nbre = 0;
        // int div = 0;
        // int somme = 0;

        // for (int i = 0; i < nbre; i++)
        // {
        //     div = nbre % i;
        //     if (div == 0){
        //         somme = somme + i;
        //     }
        // }
        // if (somme == (nbre + 1))
        // {
        //     Console.WriteLine("Votre nombre est premier !");
        // }
        // else if (somme != (nbre + 1))
        // {
        //     Console.WriteLine("Votre nombre n'est pas premier !");
        // }

        // exo 7
        
        string mot = "oiseau";
        string motReverse = "";
        

        Console.WriteLine("1) The length of '{0}' is {1}", mot, mot.Length);
        for (int i = mot.Length - 1; i >= 0; i--)
        {
            motReverse = motReverse + mot[i].ToString();            
        }

        if (mot == motReverse)
        {
            Console.WriteLine("Palindrome");
        } else {
            Console.WriteLine("Not Palindrome");
        }
    }
}