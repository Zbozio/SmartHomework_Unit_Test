using System;

public class PrimeN
{
  public static bool IsPrime(int number)
    {
        if (number < 2) return false;
        if (number == 2) return true;
        if (number % 2 == 0) return false;
        for (int i = 3; i <= Math.Sqrt(number); i += 2)
        {
            if (number % i == 0) return false;
        }
        return true;
    }

    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        string input = Console.ReadLine();
        int number = int.Parse(input);
        if (IsPrime(number))
        {
            Console.WriteLine("{0} is a prime number.", number);
        }
        else
        {
            Console.WriteLine("{0} is not a prime number.", number);
        }
    }
}
