using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] matriz = numeros();
        Console.WriteLine("A linha 1 é = {0}", (matriz[0, 0] + matriz[0, 1] + matriz[0, 2] + matriz[0, 3] + matriz[0, 4]));
        Console.ReadKey();
        Console.WriteLine("A linha 2 é = {0}", (matriz[1, 0] + matriz[1, 1] + matriz[1, 2] + matriz[1, 3] + matriz[1, 4]));
        Console.ReadKey();
        Console.WriteLine("A linha 3 é = {0}", (matriz[2, 0] + matriz[2, 1] + matriz[2, 2] + matriz[2, 3] + matriz[2, 4]));
	Console.ReadKey();


    }
    static int[,] numeros()
    {
        int l, c;
        int[,] res = new int[3, 5];
        for ( l = 0; l < 3; l++)
        {
            for ( c = 0; c < 5; c++)
            {
                Console.WriteLine("digte o numero para linha {0}  e coluna {1} ", l+1, c+1);
                res[l, c] = int.Parse(Console.ReadLine());
            }
        }
        return res;

    }



}