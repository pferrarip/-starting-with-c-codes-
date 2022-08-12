using System;
class Program
{
    static void Main(string[] args)
    {
        string[] nome = new string[10];
        double[] preco = new double[10];



        nome = vemnome();
        preco = vempreco();
        double orcamento = vemorca();
        for (int i = 0; i < 10; i++)
        {
            if (preco[i] <= orcamento)
            {
                Console.WriteLine("o produto {0} custa {1} e cabe no seu orçamento de {2}", nome[i], preco[i], orcamento);
            }
        }
        static string[] vemnome()
        {
            string[] guardanome = new string[10];
            int n;

            for (n = 0; n < 10; n++)
            {
                Console.WriteLine("digite o nome do produto {0}", n + 1);
                guardanome[n] = Console.ReadLine();
            }
            return guardanome;
        }

        static double[] vempreco()
        {
            double[] guardapreco = new double[10];
            int p;

            for (p = 1; p < 10; p++)
            {
                Console.WriteLine("digite o valor do produto {0}", p);
                guardapreco[p] = double.Parse(Console.ReadLine());
            }
            return guardapreco;
        }
        static double vemorca()
        {
            double orcamento;
            Console.WriteLine("quanto voce tem de dinheiro");
            orcamento = double.Parse(Console.ReadLine());
            return orcamento;
        }
    }
}
