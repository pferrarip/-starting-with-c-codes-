using System;

class Program{
    static void Main(string[] args){
        int positions;
        int[] numbers = new int[15];

        numbers = goback();

        for (positions=0; positions<15; positions++)
        {
            if (positions % 2 == 0)
            {
                Console.WriteLine("{0} é {1}", positions, numbers[positions]);
            }
        }
        Console.ReadKey();
    }

    static int[] goback()
    {
        int x;
        int[] numbers = new int[15];
        for (x = 0; x<15; x++)
        {
            Console.WriteLine("Digite {0} numeros: ", x+1);
            numbers[x] = int.Parse(Console.ReadLine());
        }
        return numbers;
    }
}