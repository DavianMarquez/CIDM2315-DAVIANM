namespace Homework3;

class Program
{
    static void Main(string[] args)
    {
        //Code for Q1

    Console.WriteLine("Input a integer: ");
    int num = Convert.ToInt16(Console.ReadLine());

    bool isPrime = true;
    if (num <= 1)
        {
            isPrime = false;
        }
        else
        {
            for (int i = 2; i <= num - 1; i++)
            {
                if (num % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
        }
        if (isPrime)
            Console.WriteLine($"{num} is prime");
        else
            Console.WriteLine($"{num} is non-prime");


        // Code for Q2
    
    Console.WriteLine("Assign an int value to N: ");
    int num2 = Convert.ToInt32(Console.ReadLine());

    for (int row = 1; row <= num2; row++)
        {
            for (int a = 2; a <= num2; a++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }

        // code for Q3
    Console.WriteLine("Assign an int value to N: ");
    int num3 = Convert.ToInt32(Console.ReadLine());

    for (int row = 1; row <= num3; row++)
    {
        for (int b = 1; b <= row; b++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
    }

         // Code for bonus
        Console.WriteLine("Assign an int value to N: ");
        int num4 = Convert.ToInt32(Console.ReadLine());

         for (int row = 1; row <= num4; row++)
        {
            for (int space = 1; space <= num4 - row; space++)
            {
                Console.Write(" ");
            }
            for (int c = 1; c <= row; c++)
            {
                Console.Write(row);
            }
            Console.WriteLine();
        }
    }
}
