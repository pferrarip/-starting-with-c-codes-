using System;

 class Program
    {
        static void Main(string[] args)
        {
            int[,] vt = new int[5, 5];
            int l, c;
         

            vt = Pedir();
                for( l = 0; l < 5; l++)
            {
                for(c = 0; c<5; c++)
                {
                    if(l == c || l+c == 4)
                    {
                        Console.Write(" {0} ",vt[l, c]);
                    }
                    else
                    {
                        Console.Write("   ");
                    }
                }
                Console.WriteLine();
            }
         Console.ReadKey();
        }  

        static int[,] Pedir()
        {
            int l, c;
            int[,] res = new int[5, 5];

            for (l = 0; l < 5; l++)
            {
                for (c = 0; c < 5; c++)
                {
                    Console.WriteLine("digite um numero para linha {0} e para coluna {1}", l + 1, c + 1);
                    res[l, c] = int.Parse(Console.ReadLine());
                }
            }
            return res;

        }
    }
}