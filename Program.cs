using System;

namespace Homework_4
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter n:");
            int N = int.Parse(Console.ReadLine());

            int[] array = new int[N];
            Random numbers = new Random();

            for (int i = 0; i < N; i++)
            {
                array[i] = numbers.Next(0, N);
            }

            int numberToDivided = 0;

            foreach (int numberInArray in array)
            {
                if (numberInArray > 1)
                {
                    numberToDivided = numberInArray;
                    bool flagChoice = true;
                    for (int i = 2; i < numberToDivided; i++)
                    {
                        if (numberToDivided % i == 0)
                        {
                            flagChoice = false;
                            break;
                        }

                    }
                    if (flagChoice)
                    {
                        Console.WriteLine("Prime number: {0}", numberToDivided);
                    }
                }
            }
            Console.ReadLine();
            Console.ReadKey();
        }
    }
}
