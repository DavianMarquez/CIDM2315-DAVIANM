using System.Security.Permissions;

namespace Homework4;

class Program
{
    static void Main(string[] args)
    {
        int a = 3;
        int b = 5;                      //code for q1
        int largest = Largest(a, b);

        Console.WriteLine("a = " + a + "; b=" +b);
        Console.WriteLine("The largest number is: " + largest);
        
        Console.WriteLine();

        //code for q2
        PrintTriangle(5, "left");
        Console.WriteLine();
        PrintTriangle(5, "right");
    }
    //code for q1
    static int Largest(int x, int y)
    {
        if (x > y)
            return x;
        else
            return y;
    }

    //code for q2
    static void PrintTriangle(int n, string shape)
    {
        Console.WriteLine("N is: " + n + "; shape is " + shape);
        if(shape.ToLower() == "left")
        {
            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine(new string('*', i));
            }
        }
        else if(shape.ToLower() == "right")
        {
            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine(new string(' ', n - i) + new string('*', i));
            }
        }
    }
}
