 class Program
    {
    static void Main(string[] args)
        {
            string[] nome = new string[10];
            double[,] notas = new double[10, 3];
            double[] media = new double[10];
            nome = nomes();
            notas = vemnota(nome);
            media = vemmedia(notas, nome);



            Console.WriteLine("Aluno\t\t Nota 1\t\t Nota 2\t\t Nota3\t\t Media\t\t Situação");
            for (int i = 0; i < 10; i++)
            {
                if (media[i] >= 7)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("{0}\t\t {1}\t\t{2}\t\t {3}\t\t {4}\t\t foi aprovado", nome[i], notas[i, 0], notas[i, 1], notas[i, 2], media[i]);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("{0}\t\t {1}\t\t {2}\t\t {3}\t\t {4}\t\t\foi reprovado", nome[i], notas[i, 0], notas[i, 1], notas[i, 2], media[i]);

                }
            }
            Console.ReadKey();



        }
        static string[] nomes()
        {
            string[] guardanome = new string[10];
            int n;
            for (n = 0; n < 10; n++)
            {
                Console.WriteLine("digite o nome do aluno  {0}", n + 1);
                guardanome[n] = Console.ReadLine();
            }
            return guardanome;
        }
        static double[,] vemnota(string[] x)
        {

            int l, c;
            double[,] res = new double[10, 3];

            for (l = 0; l < 10; l++)
            {
                for (c = 0; c < 3; c++)
                {
                    Console.WriteLine("digite a nota para o aluno {0} e para sua {1}° nota ", x[l], c + 1);
                    res[l, c] = double.Parse(Console.ReadLine());

                }

            }
            return res;
        }
        static double[] vemmedia(double[,] Notas, string[] Nome)
        {
            string[] nome = new string[10];
            double[,] notas = new double[10, 3];
            double[] media = new double[10];

            for (int l = 0; l < 10; l++)
            {

                double somar = Notas[l, 0] + Notas[l, 1] + Notas[l, 2];
                media[l] = somar / 3;
                Console.WriteLine("A nota do aluno {0} é = {1}", nome[l], media[l]);



            }
            return media;
        }

    }
}