namespace Homework5;

class Program
{
    static void Main(string[] args)
    {
        //Call Q1_method()
        Console.WriteLine(" ");
        methodQ1();
        //Call Q2_method()
        Console.WriteLine(" ");
        methodQ2();
        //Call Q3_method()
        Console.WriteLine(" ");
        createAccount();
    }
    //Q1 method
    static int largest(int a, int b)
    {
        if (a > b)
            return a;
        else
            return b;
    }
    static void methodQ1()
    {
        Console.Write("Enter your first number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter your second number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        int large = largest(num1, num2);
        Console.WriteLine("Largest number is: " + large);
    }

    //q2 method
    static void methodQ2()
    {
        Console.Write("Enter number for a: ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter number for b: ");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter number for c: ");
        int c = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter number for d: ");
        int d = Convert.ToInt32(Console.ReadLine());

        int max1 = largest(a, b);
        int max2 = largest(c, d);
        int final = largest(max1, max2);

        Console.WriteLine("THe largest number is: " + final);
    }

    //Q3
    static bool checkAge(int birth_year)
    {
        int currentYear = DateTime.Now.Year;
        int age = currentYear - birth_year;

        return age >= 18;
    }

    static void createAccount()
    {
        Console.Write("Enter your Username: ");
        string username = Console.ReadLine();

        Console.Write("Enter your Password: ");
        string password = Console.ReadLine();

        Console.Write("Enter your Password again: ");
        string password2 = Console.ReadLine();

        Console.Write("Enter your Birthyear: ");
        int birthyear = Convert.ToInt32(Console.ReadLine());

        if (checkAge(birthyear))
        {
            if (password == password2)
                Console.WriteLine("account is created successfully");
            else
                Console.WriteLine("Wrong Password");
        }
        else
        {
            Console.WriteLine("Could not create an account");
        }
    }
}
