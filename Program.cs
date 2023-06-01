using System;

class FibonacciSeries
{
    static void Main()
    {
        Console.WriteLine("Enter the number of terms you want in the Fibonacci series:");
        int count = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Fibonacci series:");
        PrintFibonacciSeries(count);
    }

    static void PrintFibonacciSeries(int count)
    {
        int first = 0, second = 1;

        if (count >= 1)
        {
            Console.Write(first + " ");
        }
        if (count >= 2)
        {
            Console.Write(second + " ");
        }

        for (int i = 3; i <= count; i++)
        {
            int next = first + second;
            Console.Write(next + " ");

            first = second;
            second = next;
        }

        Console.WriteLine();
    }
}
